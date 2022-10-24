using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    [Serializable]
    public class CircleShape : Shape
    {
        public CircleShape(RectangleF circl) : base(circl)
        {
            //Uses a new instance RectangleF from base to create this Shape
        }
        public CircleShape(CircleShape circle) : base(circle)
        {
            // ???
        }
        public PointF Center { get; set; }  //used in Contains

        public override bool Contains(PointF point)
        {
            Center = new Point
            {
                X = (int)(Rectangle.X + Rectangle.Width / 2),
                Y = (int)(Rectangle.Y + Rectangle.Height / 2)
            };

            if ((Math.Pow((point.X - Center.X), 2) / Math.Pow(Rectangle.Width / 2, 2)) +
                (Math.Pow((point.Y - Center.Y), 2) / Math.Pow(Rectangle.Height / 2, 2)) <= 1)
                //formula to see if its inside circle, same for ellipse
                return true;
            else
                return false;
        }
      
        public override void Resize(int width, int height)
        {
            Width = width;
            this.Height = width;
        }
        public override Shape Copy()
        {
            //creates a new CircleShape, with the same parameters

            CircleShape copy = new CircleShape(new RectangleF(Location.X, Location.Y, Width, Height));

            copy.Name = Name;
            copy.BorderColor = BorderColor;
            copy.FillColor = FillColor;
            copy.Transparency = Transparency;
            copy.ShapeMatrix = ShapeMatrix;
            copy.BorderWidth = BorderWidth;
            copy.Rotation = Rotation;
            copy.FixedRotation = FixedRotation;

            return copy;

        }

        public override void DrawSelf(Graphics grfx)
        {

            base.DrawSelf(grfx);
            //transforms from Graphics grfx to Matrix(m0,m1,m2,m3,m4,m5)
            grfx.Transform = new Matrix(ShapeMatrix[0], ShapeMatrix[1], ShapeMatrix[2], ShapeMatrix[3], ShapeMatrix[4], ShapeMatrix[5]);
            grfx.FillEllipse(new SolidBrush(Color.FromArgb(Transparency, FillColor)), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            Pen pen = new Pen(Color.FromArgb(Transparency, BorderColor), BorderWidth);
            //Makes a new Pen which uses saved variables
            if (IsSelected == true)
            {
                pen.DashPattern = new float[] { 2, 1, 2 };
            }
            grfx.DrawEllipse(pen, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.ResetTransform();
            //returns from the transformation, turns into Graphics again

        }
    }
}
