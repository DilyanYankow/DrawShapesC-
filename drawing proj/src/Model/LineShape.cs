using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    [Serializable]
    public class LineShape : Shape
    {
        private bool Downwards { get; set; }  //dali vuv Lineshape(start, end) purvata tochka e otgore,2rata otdolu ili ne 

        #region Constructor

        public LineShape(PointF start, PointF end)
        {

            RectangleF ln = new Rectangle((int)Math.Min(start.X, end.X),        //Rectangle X (upper left)
                                          (int)Math.Min(start.Y, end.Y),        //Rectangle Y (upper left)
                                          (int)Math.Abs(start.X - end.X),       //Rectangle Width
                                          (int)Math.Abs(start.Y - end.Y));      //Rectangle Height

            Rectangle = ln;

            if (Rectangle.Location == start || Rectangle.Location == end)
                Downwards = true;
        }
        public LineShape(RectangleF ln) : base(ln)
        {

        }

        public LineShape(LineShape line) : base(line)
        {

        }

        #endregion

        public override bool Contains(PointF point)
        {
            int Y1, Y2;
            if (Downwards == true)
            {
                Y1 = (int)Rectangle.Y;
                Y2 = (int)(Rectangle.Y + Rectangle.Height);
            }
            else
            {
                Y1 = (int)(Rectangle.Y + Rectangle.Height);
                Y2 = (int)Rectangle.Y;
            }
         

            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(Rectangle.X, Y1, (Rectangle.X + Rectangle.Width), Y2);


            if
                (gp.IsOutlineVisible(point, new Pen(Color.Black, BorderWidth)))
            {
                return true;
            }
            else
                return false;
        }
        public override Shape Copy()
        {

            LineShape copy = new LineShape(new RectangleF(this.Location.X, this.Location.Y, this.Width, this.Height));


            if (Downwards == true)
            {
                copy.Downwards = true;
            }


            copy.Name = this.Name;
            copy.BorderColor = this.BorderColor;
            copy.FillColor = this.FillColor;
            copy.Transparency = this.Transparency;
            copy.ShapeMatrix = this.ShapeMatrix;
            copy.BorderWidth = this.BorderWidth;
            copy.Rotation = this.Rotation;
            copy.Downwards = this.Downwards;

            return copy;

        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            int Y1 = (int)(Rectangle.Y + Rectangle.Height);
            int Y2 = (int)Rectangle.Y;

            if (Downwards)
            {
                Y1 = (int)Rectangle.Y;
                Y2 = (int)(Rectangle.Y + Rectangle.Height);
            }

            grfx.Transform = new Matrix(ShapeMatrix[0], ShapeMatrix[1], ShapeMatrix[2], ShapeMatrix[3], ShapeMatrix[4], ShapeMatrix[5]);

            Pen pen = new Pen(Color.FromArgb(Transparency, BorderColor), BorderWidth);

            if (IsSelected)
            {

                pen.DashPattern = new float[] {2, 1, 2};

            }
            grfx.DrawLine(pen, Rectangle.X, Y1, (Rectangle.X + Rectangle.Width), Y2);


            grfx.ResetTransform();

        }
    }
}
/*
 public override void Resize(int width, int height)
        {
            float scaleGroupWidth = 1;
            float scaleGroupHeight = 1;

            if (width != ShapeWidth || height != ShapeHeight)
            {
                scaleGroupWidth += ((width - ShapeWidth) / (ShapeWidth / 100)) / 100;
                scaleGroupHeight += ((height - ShapeHeight) / (ShapeHeight / 100)) / 100;

                ShapeWidth = width;
                ShapeHeight = height;
            }

            for (int i = ShapeElements.Count - 1; i >= 0; i--)
            {

                offSetX[i] = offSetX[i] * scaleGroupWidth;
                offSetY[i] = offSetY[i] * scaleGroupHeight;
                ShapeElements[i].Width *= scaleGroupWidth;
                ShapeElements[i].Height *= scaleGroupHeight;

                Widths[i] = ShapeElements[i].Width;
                Heights[i] = ShapeElements[i].Height;
            }

            Width = ShapeWidth;
            Height = ShapeHeight;

        }
 */
 //old code