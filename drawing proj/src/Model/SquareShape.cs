using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    [Serializable]
    public class SquareShape : Shape
    {

        #region Constructor

        public SquareShape(RectangleF square) : base(square)
        {

        }
        public SquareShape(SquareShape square) : base(square)
        {

        }

        #endregion

        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
                return true;
            else
                return false;
        }

        public override void Resize(int width, int height)
        {
            this.Width = width;
            this.Height = width;
        }

        public override Shape Copy()
        {

            SquareShape clone = new SquareShape(new RectangleF(this.Location.X, this.Location.Y, this.Width, this.Height));
            clone.Name = this.Name;
            clone.ShapeMatrix = this.ShapeMatrix;
            clone.BorderColor = this.BorderColor;
            clone.BorderWidth = this.BorderWidth;
            clone.FillColor = this.FillColor;
            clone.Transparency = this.Transparency;
            clone.Rotation = this.Rotation;
            clone.FixedRotation = this.FixedRotation;

            return clone;

        }
        
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);


            grfx.Transform = new Matrix(ShapeMatrix[0], ShapeMatrix[1], ShapeMatrix[2], ShapeMatrix[3], ShapeMatrix[4], ShapeMatrix[5]);


            grfx.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, FillColor)), Rectangle.X, Rectangle.Y,
                               Rectangle.Width, Rectangle.Height);

            Pen pen = new Pen(Color.FromArgb(Transparency, BorderColor), BorderWidth);

            if (IsSelected)
            {

                pen.DashPattern = new float[] { 2, 1, 2};

                grfx.DrawRectangle(pen, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

            }
            else
            {
                grfx.DrawRectangle(pen, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            }

            grfx.ResetTransform();

        }
    }
}

