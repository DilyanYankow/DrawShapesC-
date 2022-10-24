using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;


namespace Draw.src.Model
{
    [Serializable]
    public class EllipseShape : Shape
    {
        public EllipseShape(RectangleF ellipse) : base(ellipse)
		{
            //Uses a new instance RectangleF from base to create this Shape

        }
        public EllipseShape(EllipseShape ellipse) : base(ellipse)
		{
		}
        public PointF Center { get; set; }

        public override bool Contains(PointF point)
        {
            Center = new Point
            {
                X = (int)(Rectangle.X + Rectangle.Width / 2),
                Y = (int)(Rectangle.Y + Rectangle.Height / 2)
            };

            if ((Math.Pow((point.X - Center.X), 2) / Math.Pow(Rectangle.Width / 2, 2)) +
                (Math.Pow((point.Y - Center.Y), 2) / Math.Pow(Rectangle.Height / 2, 2)) <= 1)
                //formula to see if its inside ellipse, same for circleShape

                return true;
            else
                return false;
        }
        /* old formula
          public bool Contains(Ellipse Ellipse, Point location)
          {
              Point center = new Point(
                    Canvas.GetLeft(Ellipse) + (Ellipse.Width / 2),
                    Canvas.GetTop(Ellipse) + (Ellipse.Height / 2));

              double _xRadius = Ellipse.Width / 2;
              double _yRadius = Ellipse.Height / 2;


              if (_xRadius <= 0.0 || _yRadius <= 0.0)
                  return false;
              /* This is a more general form of the circle equation

                X^2/a^2 + Y^2/b^2 <= 1


              Point normalized = new Point(location.X - center.X,
                                           location.Y - center.Y);

              return ((double)(normalized.X * normalized.X)
                       / (_xRadius * _xRadius)) + ((double)(normalized.Y * normalized.Y) / (_yRadius * _yRadius))
                  <= 1.0;
          }
      */
        
        public override Shape Copy()
        {
            //creates a new EllipseShape, with the same parameters
            EllipseShape copy = new EllipseShape(new RectangleF(this.Location.X, this.Location.Y, this.Width, this.Height));

            copy.Name = this.Name;
            copy.BorderColor = this.BorderColor;
            copy.FillColor = this.FillColor;
            copy.Transparency = this.Transparency;
            copy.ShapeMatrix = this.ShapeMatrix;
            copy.BorderWidth = this.BorderWidth;
            copy.Rotation = this.Rotation;
            return copy;

        }
        public override void Resize (int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

       
        public override void DrawSelf(Graphics grfx)
		{

            base.DrawSelf(grfx);
            grfx.Transform = new Matrix(ShapeMatrix[0], ShapeMatrix[1], ShapeMatrix[2], ShapeMatrix[3], ShapeMatrix[4], ShapeMatrix[5]);
            grfx.FillEllipse(new SolidBrush(Color.FromArgb(Transparency, FillColor)), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            Pen pen = new Pen(Color.FromArgb(Transparency, BorderColor), BorderWidth);

            if (IsSelected == true)
            {
                pen.DashPattern = new float[] { 2, 1, 2 };
            }

            grfx.DrawEllipse(pen, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.ResetTransform();

        }
    }
}
/*
  public void DrawRectangleRectangle(PaintEventArgs e)
{
             
    // Create pen.
    Pen blackPen = new Pen(Color.Black, 3);
             
    // Create rectangle.
    Rectangle rect = new Rectangle(0, 0, 200, 200);
             
    // Draw rectangle to screen.
    e.Graphics.DrawRectangle(blackPen, rect);
}
*/