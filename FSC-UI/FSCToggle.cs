using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSC_UI
{
    public partial class FSCToggle : UserControl
    {
        public FSCToggle()
        {
            InitializeComponent();
            background = FSCToggleBackPanel.BackColor;
            toggle = FSCTogglePanel.BackColor;
            toggleHover = Color.Silver;
            //this.MinimumSize = new Size(35, 17);
            //this.MaximumSize = new Size(35, 17);
        }

        private Color background;
        private Color toggle;
        private Color toggleHover;
        private State currentState = State.Left;
        private bool allowCenter = false;

        [Category("FSC Settings")]
        public Color Background
        {
            get { return background; }
            set
            {
                background = value;
                FSCToggleBackPanel.BackColor = background;

                this.Invalidate();
            }
        }

        [Category("FSC Settings")]
        public Color Toggle
        {
            get { return toggle; }
            set
            {
                toggle = value;
                FSCTogglePanel.BackColor = toggle;

                this.Invalidate();
            }
        }

        [Category("FSC Settings")]
        public Color ToggleHover
        {
            get { return toggleHover; }
            set
            {
                toggleHover = value;

                this.Invalidate();
            }
        }

        [Category("FSC Settings")]
        public State CurrentState
        {
            get { return currentState; }
            set
            {
                currentState = value;
                ToggleAction();

                this.Invalidate();
            }
        }

        [Category("FSC Settings")]
        public bool AllowCenter
        {
            get { return allowCenter; }
            set
            {
                allowCenter = value;

                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle rectSurface = FSCToggleBackPanel.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, 0, 0);
            int smoothSize = 2;

            using (GraphicsPath pathSurface = ControlsGraphic.GetFigurePath(rectSurface, FSCToggleBackPanel.Height / 2))
            using (GraphicsPath pathBorder = ControlsGraphic.GetFigurePath(rectBorder, FSCToggleBackPanel.Height / 2 - 0))
            using (Pen penSurface = new Pen(this.BackColor, smoothSize))
            using (Pen penBorder = new Pen(this.BackColor, 0))
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                FSCToggleBackPanel.Region = new Region(pathSurface);
                pevent.Graphics.DrawPath(penSurface, pathSurface);
            }
            
            rectSurface = FSCTogglePanel.ClientRectangle;

            using (GraphicsPath pathSurface = ControlsGraphic.GetFigurePath(rectSurface, FSCTogglePanel.Height / 2))
            using (GraphicsPath pathBorder = ControlsGraphic.GetFigurePath(rectBorder, FSCTogglePanel.Height / 2 - 0))
            using (Pen penSurface = new Pen(this.BackColor, smoothSize))
            using (Pen penBorder = new Pen(this.BackColor, 0))
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                FSCTogglePanel.Region = new Region(pathSurface);
                pevent.Graphics.DrawPath(penSurface, pathSurface);
            }
        }

        public enum State
        {
            Left,
            Center,
            Right
        }

        public bool GetBool()
        {
            if (currentState == State.Left)
            {
                return false;
            }

            return true;
        }

        private void FSCToggle_Click(object sender, EventArgs e)
        {
            if (currentState == State.Left)
            {
                currentState = allowCenter ? State.Center : State.Right;
            }
            else if (currentState == State.Center)
            {
                currentState = State.Right;
            }
            else if (currentState == State.Right)
            {
                currentState = State.Left;
            }

            ToggleAction();
        }

        private void FSCToggle_MouseEnter(object sender, EventArgs e)
        {
            FSCTogglePanel.BackColor = toggleHover;
        }

        private void FSCToggle_MouseLeave(object sender, EventArgs e)
        {
            FSCTogglePanel.BackColor = toggle;
        }

        private void ToggleAction()
        {
            if (currentState == State.Left)
            {
                FSCTogglePanel.Left = 0;
            }
            else if (currentState == State.Center)
            {
                FSCTogglePanel.Left = FSCToggleBackPanel.Left + FSCToggleBackPanel.Width / 2 - FSCTogglePanel.Width / 2;
            }
            else if (currentState == State.Right)
            {
                FSCTogglePanel.Left = FSCToggleBackPanel.Left + FSCToggleBackPanel.Width - FSCTogglePanel.Width + 4;
            }
        }

        private void FSCToggle_Paint(object sender, PaintEventArgs e)
        {
            FSCToggleBackPanel.BackColor = background;
            FSCTogglePanel.BackColor = toggle;
        }
    }
}
