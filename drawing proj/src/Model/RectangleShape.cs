using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw.src.Model
{

	[Serializable]

	public class RectangleShape : Shape
	{
		
		
		public RectangleShape(RectangleF rect) : base(rect)
		{
		}
		
		public RectangleShape(RectangleShape rectangle) : base(rectangle)
		{

		}
		
		

		public override bool Contains(PointF point)
		{
			if (base.Contains(point))
				// Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
				// В случая на правоъгълник - директно връщаме true
				return true;
			else
				// Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
				return false;
		}
		public override Shape Copy()
		{

			RectangleShape copy = new RectangleShape(new RectangleF(this.Location.X, this.Location.Y, this.Width, this.Height));

			copy.Name = this.Name;
			copy.BorderColor = this.BorderColor;
			copy.FillColor = this.FillColor;
			copy.Transparency = this.Transparency;
			copy.ShapeMatrix = this.ShapeMatrix;
			copy.BorderWidth = this.BorderWidth;
			copy.Rotation = this.Rotation;

			return copy;

		}
		
		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);
			grfx.Transform = new Matrix(ShapeMatrix[0], ShapeMatrix[1], ShapeMatrix[2], ShapeMatrix[3], ShapeMatrix[4], ShapeMatrix[5]);
			grfx.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, FillColor)), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			Pen pen = new Pen(Color.FromArgb(Transparency, BorderColor), BorderWidth);
			if (IsSelected)
			{
				pen.DashPattern = new float[] { 2, 1, 2 };
			}
			grfx.DrawRectangle(pen, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

			grfx.ResetTransform();

		}
	}
}
