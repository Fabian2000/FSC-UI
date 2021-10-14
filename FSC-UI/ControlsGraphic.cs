using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSC_UI
{
    class ControlsGraphic
    {
        internal static GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        internal static GraphicsPath GetFigurePath(Rectangle rect, float radiusTopLeft, float radiusTopRight, float radiusBottomRight, float radiusBottomLeft)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize1 = radiusTopLeft * 2F;
            float curveSize2 = radiusTopRight * 2F;
            float curveSize3 = radiusBottomRight * 2F;
            float curveSize4 = radiusBottomLeft * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize1, curveSize1, 180, 90);
            path.AddArc(rect.Right - curveSize2, rect.Y, curveSize2, curveSize2, 270, 90);
            path.AddArc(rect.Right - curveSize3, rect.Bottom - curveSize3, curveSize3, curveSize3, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize4, curveSize4, curveSize4, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
