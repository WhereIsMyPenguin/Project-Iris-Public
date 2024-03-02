using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Project_Iris
{
    public partial class RoundPanel : Panel
    {
        int a = 20, c = 2; float b = 45;
        Color cl3 = Color.Black;

        [Category("Gradients")]
        public RoundPanel()
        {
            DoubleBuffered = true;
        }
        [Category("Gradients")]
        public int BorderCurve
        {
            get { return a; }
            set { a = value; Invalidate(); }
        }
        [Category("Gradients")]
        public int BorderSize
        {
            get { return c; }
            set { c = value; Invalidate(); }
        }
        [Category("Gradients")]
        public float Angle
        {
            get { return b; }
            set { b = value; Invalidate(); }
        }
        [Category("Gradients")]
        public Color BorderColor
        {
            get { return cl3; }
            set { cl3 = value; Invalidate(); }
        }
        private GraphicsPath GetDrawPath(Rectangle re, int radius)
        {
            GraphicsPath paths = new GraphicsPath();
            float curveSize = radius * 2F;
            paths.StartFigure();
            paths.AddArc(re.X, re.Y, curveSize, curveSize, 180, 90);
            paths.AddArc(re.Right - curveSize, re.Y, curveSize, curveSize, -90, 90);
            paths.AddArc(re.Right - curveSize, re.Bottom - curveSize, curveSize, curveSize, 0, 90);
            paths.AddArc(re.X, re.Bottom - curveSize, curveSize, curveSize, 90, 90);
            paths.CloseFigure();
            return paths;
        }
        private GraphicsPath ShadowPaint()
        {
            GraphicsPath paths = new GraphicsPath();
            paths.AddArc(new Rectangle(0, 0, a, a), 180, 90);
            paths.AddArc(new Rectangle(Width - a, 0, a, a), -90, 90);
            paths.AddArc(new Rectangle(Width - a, Height - a, a, a), 0, 90);
            paths.AddArc(new Rectangle(0, Height - a, a, a), 90, 90);
            return paths;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Color bor = BackColor;
            if (c > 0) bor = cl3;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            Graphics graphic = e.Graphics;
            e.Graphics.FillPath(new SolidBrush(BackColor), ShadowPaint());
            var rectBorderSmooth = this.ClientRectangle;
            var rectBorder = Rectangle.Inflate(rectBorderSmooth, -c, -c);
            int smoothSize = c > 0 ? c : 1;
            using (GraphicsPath pathBorderSmooth = GetDrawPath(rectBorderSmooth, a))
            using (GraphicsPath pathBorder = GetDrawPath(rectBorder, a - c))
            using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
            using (Pen penBorder = new Pen(bor, c))
            {
                this.Region = new Region(pathBorderSmooth);
                graphic.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                graphic.DrawPath(penBorderSmooth, pathBorderSmooth);
                graphic.DrawPath(penBorder, pathBorder);
            }
        }
    }
}
