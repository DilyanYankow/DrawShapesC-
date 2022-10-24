using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw
{
	/// <summary>
	/// Базовия клас на примитивите, който съдържа общите характеристики на примитивите.
	/// </summary>
	[Serializable]

	public abstract class Shape
	{
		#region Constructors

		public Shape()
		{

		}
		public virtual Shape Copy()
		{
			return this;
		}
		public Shape(RectangleF rect)
		{
			rectangle = rect;
		}

		public virtual string Name { get; set; }

		public Shape(Shape shape)
		{
			this.Height = shape.Height;
			this.Width = shape.Width;
			this.Location = shape.Location;
			this.rectangle = shape.rectangle;
			this.BorderColor = shape.BorderColor;
			this.BorderWidth = shape.BorderWidth;
			this.FillColor = shape.FillColor;
		}
		#endregion

		#region Properties

		private RectangleF rectangle;
		public virtual RectangleF Rectangle
		{
			get { return rectangle; }
			set { rectangle = value; }
		}
		public virtual float Width
		{
			get { return Rectangle.Width; }
			set { rectangle.Width = value; }
		}
		public virtual float Height
		{
			get { return Rectangle.Height; }
			set { rectangle.Height = value; }
		}
		private int fixedRotation = 0;
		public int FixedRotation
		{
			get { return fixedRotation; }
			set { fixedRotation = value; }
		}
		private float[] shapeMatrix = new Matrix().Elements;
		public float[] ShapeMatrix
		{
			get { return shapeMatrix; }
			set { shapeMatrix = value; }
		}
		public virtual PointF Location
		{
			get { return Rectangle.Location; }
			set { rectangle.Location = value; }
		}
		
		private bool isGrouped;
		public bool IsGrouped
		{
			get { return isGrouped; }
			set { isGrouped = value; }
		}

		
		private int transparency;
		public virtual int Transparency
		{
			get { return transparency; }
			set { transparency = value; }
		}

		private Color fillColor;
		public virtual Color FillColor
		{

			get { return fillColor; }
			set { fillColor = value; }
		}

		private Color borderColor;
		public virtual Color BorderColor
		{
			get { return borderColor; }
			set { borderColor = value; }
		}

		private int borderWidth;
		public virtual int BorderWidth
		{
			get { return borderWidth; }
			set { borderWidth = value; }
		}
		
		
		private bool isSelected;
		public bool IsSelected
		{
			get { return isSelected; }
			set { isSelected = value; }
		}
		
		
		private int rotation;
		public virtual int Rotation
		{
			get { return rotation; }
			set { rotation = value; }
		}
		
		#endregion
		public virtual void Resize(int width, int height)
		{

		}
		
		
		public virtual Shape CopyShape()
		{
			return this;
		}
		public virtual bool Contains(PointF point)
		{
			return Rectangle.Contains(point.X, point.Y);
		}

		public virtual void DrawSelf(Graphics grfx)
		{
			// shape.Rectangle.Inflate(shape.BorderWidth, shape.BorderWidth);
		}

	}
}
