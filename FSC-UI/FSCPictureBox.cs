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
using FSC_UI;

namespace FSC_UI.Controls
{
    public partial class FSCPictureBox : PictureBox
    {
        public FSCPictureBox()
        {
            InitializeComponent();

            this.Resize += new EventHandler(PictureBox_Resize);
        }

        private int[] radius = new int[] { 7, 7, 7, 7 };

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

        private void PictureBox_Resize(object sender, EventArgs e)
        {
            if (radius[0] > this.Height)
                radius[0] = this.Height;
            if (radius[1] > this.Height)
                radius[1] = this.Height;
            if (radius[2] > this.Height)
                radius[2] = this.Height;
            if (radius[3] > this.Height)
                radius[3] = this.Height;
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
    }
}
