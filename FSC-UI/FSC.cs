using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSC_UI
{
    public partial class FSC : Form
    {
        public FSC()
        {
            InitializeComponent();

            FSCTopMostBTN.Text = "\uD83D\uDCCC";
            FSCMinimizeBTN.Text = "\uD83D\uDDD5";
            if (isMaximized)
            {
                FSCMaximizeBTN.Text = "\uD83D\uDDD7";
            }
            else
            {
                FSCMaximizeBTN.Text = "\uD83D\uDDD6";
            }
            FSCCloseBTN.Text = "\u2715";

            if (this.TopMost)
            {
                this.TopMost = false;
                FSCTopMostBTN.BackColor = ThemeLoader.CurrentTheme.ClickItem_BackColor;
            }

            FSCMinimizeBTN.Enabled = this.MinimizeBox;
            FSCMaximizeBTN.Enabled = this.MaximizeBox;

            FSCTopMostBTN.MouseUp += LooseFocusButtonEvent;
            FSCMinimizeBTN.MouseUp += LooseFocusButtonEvent;
            FSCMaximizeBTN.MouseUp += LooseFocusButtonEvent;
            FSCCloseBTN.MouseUp += LooseFocusButtonEvent;
            FSCTopMostBTN.MouseLeave += LooseFocusButtonEvent;
            FSCMinimizeBTN.MouseLeave += LooseFocusButtonEvent;
            FSCMaximizeBTN.MouseLeave += LooseFocusButtonEvent;
            FSCCloseBTN.MouseLeave += LooseFocusButtonEvent;

            // Resize Grip
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        internal bool TopMostBTNVisible = true;

        private void LooseFocusButtonEvent(object sender, EventArgs e)
        {
            FSCTitleBarPanel.Focus();
        }

        private int[] radius = new int[] { 7, 7, 7, 7 };
        private bool isMaximized = false;
        private bool enableCustomTitlebar = true;
        private Point oldNormalCoords;
        private Size oldNormalSize;
        private int[] oldNormalRadius = new int[4];

        [Category("FSC Settings")]
        public bool EnableCustomTitleBar
        {
            get { return enableCustomTitlebar; }
            set
            {
                enableCustomTitlebar = value;

                FSCTitleBarPanel.Visible = enableCustomTitlebar;
            }
        }

        [Category("FSC Settings")]
        public int RadiusTopLeft
        {
            get { return radius[0]; }
            set
            {
                if (value > 0)
                {
                    radius[0] = value;
                }
                else
                {
                    radius[0] = 1;
                }

                this.Invalidate();
            }
        }

        [Category("FSC Settings")]
        public int RadiusTopRight
        {
            get { return radius[1]; }
            set
            {
                if (value > 0)
                {
                    radius[1] = value;
                }
                else
                {
                    radius[1] = 1;
                }

                this.Invalidate();
            }
        }

        [Category("FSC Settings")]
        public int RadiusBottomRight
        {
            get { return radius[2]; }
            set
            {
                if (value > 0)
                {
                    radius[2] = value;
                }
                else
                {
                    radius[2] = 1;
                }

                this.Invalidate();
            }
        }

        [Category("FSC Settings")]
        public int RadiusBottomLeft
        {
            get { return radius[3]; }
            set
            {
                if (value > 0)
                {
                    radius[3] = value;
                }
                else
                {
                    radius[3] = 1;
                }

                this.Invalidate();
            }
        }

        [Category("FSC Settings")]
        public bool IsMaximized
        {
            get { return isMaximized; }
            set
            {
                isMaximized = value;

                if (isMaximized)
                {
                    this.WindowState = FormWindowState.Normal;
                    oldNormalRadius = radius;
                    oldNormalCoords = this.Location;
                    oldNormalSize = new Size(this.Width, this.Height);

                    /*RadiusBottomLeft = 0;
                    RadiusBottomRight = 0;
                    RadiusTopLeft = 0;
                    RadiusTopRight = 0;*/
                    radius = new int[] { 0, 0, 0, 0 };

                    this.Width = Screen.FromHandle(this.Handle).WorkingArea.Width;
                    this.Height = Screen.FromHandle(this.Handle).WorkingArea.Height;
                    this.Location = new Point(0, 0);

                    FSCMaximizeBTN.Text = "\uD83D\uDDD7";
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                    this.Width = oldNormalSize.Width;
                    this.Height = oldNormalSize.Height;
                    this.Location = oldNormalCoords;

                    RadiusBottomLeft = oldNormalRadius[0];
                    RadiusBottomRight = oldNormalRadius[1];
                    RadiusTopLeft = oldNormalRadius[2];
                    RadiusTopRight = oldNormalRadius[3];

                    FSCMaximizeBTN.Text = "\uD83D\uDDD6";
                }

                this.Invalidate();
            }
        }

        private void FSC_Resize(object sender, EventArgs e)
        {
            if (radius[0] > this.Height)
                radius[0]  = this.Height;
            if (radius[1] > this.Height)
                radius[1]  = this.Height;
            if (radius[2] > this.Height)
                radius[2]  = this.Height;
            if (radius[3] > this.Height)
                radius[3]  = this.Height;

            if (this.Width <= (this.Width - FSCTopMostBTN.Left + FSCTitleLabel.Width + FSCTitleLabel.Left) - 3)
            {
                FSCTitleLabel.Visible = false;
            }
            else
            {
                FSCTitleLabel.Visible = true;
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, 0, 0);
            int smoothSize = 2;
            if (radius[0] > 0 || radius[1] > 0 || radius[2] > 0 || radius[3] > 0)
            {
                using (GraphicsPath pathSurface = ControlsGraphic.GetFigurePath(rectSurface, radius[0], radius[1], radius[2], radius[3]))
                using (GraphicsPath pathBorder = ControlsGraphic.GetFigurePath(rectBorder, radius[0] - 0, radius[1] - 0, radius[2] - 0, radius[3] - 0))
                using (Pen penSurface = new Pen(this.BackColor, smoothSize))
                using (Pen penBorder = new Pen(this.BackColor, 0))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                }
            }
            else
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                this.Region = new Region(rectSurface);
            }
        }

        private void FSC_TextChanged(object sender, EventArgs e)
        {
            FSCTitleLabel.Text = this.Text;
        }

        private void FSCCloseBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FSCMaximizeBTN_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                IsMaximized = false;
            }
            else
            {

                IsMaximized = true;
            }
        }

        private void FSCMinimizeBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FSCTopMostBTN_Click(object sender, EventArgs e)
        {
            if (this.TopMost)
            {
                this.TopMost = false;
                FSCTopMostBTN.BackColor = ThemeLoader.CurrentTheme.ClickItem_BackColor;
            }
            else
            {
                this.TopMost = true;
                FSCTopMostBTN.BackColor = ThemeLoader.CurrentTheme.ClickItem_ActiveColor;
            }
        }

        Stopwatch doubleClickWatch; // Own double Click, normal double click is not working with moveWindow, because MoveWindows steals mouse control
        private void FSCTitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            if (doubleClickWatch == null)
            {
                doubleClickWatch = new Stopwatch();
            }

            if (!doubleClickWatch.IsRunning)
            {
                doubleClickWatch.Reset();
                doubleClickWatch.Start();
            }
            else
            {
                if (doubleClickWatch.Elapsed.Milliseconds < 200 && FSCMaximizeBTN.Enabled)
                {
                    doubleClickWatch.Stop();
                    if (isMaximized)
                    {
                        IsMaximized = false;
                    }
                    else
                    {
                        IsMaximized = true;
                    }
                }
                else
                {
                    doubleClickWatch.Restart();
                }
            }

            if (!isMaximized)
            {
                this.MoveWindow();
            }
        }

        // Resize
        private const int cGrip = 16;
        private const int cCaption = 32;
        protected override void WndProc(ref Message m)
        {
            if (FSCMaximizeBTN.Enabled)
            { 
                if (m.Msg == 0x84)
                {
                    Point pos = new Point(m.LParam.ToInt32());
                    pos = this.PointToClient(pos);
                    if (pos.Y < cCaption)
                    {
                        m.Result = (IntPtr)2;
                        return;
                    }
                    if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                    {
                        m.Result = (IntPtr)17;
                        return;
                    }
                }
            }
            base.WndProc(ref m);
        }

        private void FSC_Shown(object sender, EventArgs e)
        {
            FSCMinimizeBTN.Enabled = this.MinimizeBox;
            FSCMaximizeBTN.Enabled = this.MaximizeBox;

            FSCTopMostBTN.Visible = TopMostBTNVisible;
        }
    }
}
