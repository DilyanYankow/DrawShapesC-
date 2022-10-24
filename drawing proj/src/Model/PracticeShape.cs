using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{

    [Serializable]
    public class PracticeShape : Shape
    {
        public List<Shape> ShapeComponents { get; set; } = new List<Shape>(); 

        private List<float> offSetX = new List<float>();
        private List<float> offSetY = new List<float>();
        private List<float> Widths = new List<float>();
        private List<float> Heights = new List<float>();

        private float ShapeWidth;
        private float ShapeHeight;

        public PracticeShape(RectangleF rect)
        {

            Rectangle = rect;

            List<Shape> shapes = new List<Shape>();

            RectangleShape shape1 = new RectangleShape(new RectangleF((Rectangle.X), (Rectangle.Y), (Rectangle.Width), (Rectangle.Height)));

            shape1.FillColor = Color.White;
            shape1.BorderColor = Color.Black;
            shape1.BorderWidth = 2;
            shape1.Transparency = 255;
            

            LineShape shape2 = new LineShape(new RectangleF((Rectangle.X + Rectangle.Width / 2), (Rectangle.Y), (Rectangle.Width / 2), (Rectangle.Height / 2)));

            shape2.FillColor = Color.White;
            shape2.BorderColor = Color.Black;
            shape2.BorderWidth = 2;
            shape2.Transparency = 255;

            RectangleShape shape3 = new RectangleShape(new RectangleF((Rectangle.X),
                                                                      (Rectangle.Y + Rectangle.Height / 2),
                                                                      (Rectangle.Width / 2),
                                                                      (Rectangle.Height / 2)));

            shape3.FillColor = Color.White;
            shape3.BorderColor = Color.Black;
            shape3.BorderWidth = 2;
            shape3.Transparency = 255;


            shapes.Add(shape1);
            shapes.Add(shape2);
            shapes.Add(shape3);

            for (int i = 0; i < shapes.Count; i++)
            {
                ShapeComponents.Add(shapes[i].Copy());
                offSetX.Add(shapes[i].Location.X - Rectangle.X);
                offSetY.Add(shapes[i].Location.Y - Rectangle.Y);
                Widths.Add(shapes[i].Width);
                Heights.Add(shapes[i].Height);
            }

            ShapeWidth = rect.Width;
            ShapeHeight = rect.Height;

        }

        public PracticeShape(PracticeShape group) : base(group)
        {

        }

        public override bool Contains(PointF point)
        {
            for (int i = 0; i< ShapeComponents.Count;i++)
            {
                if (ShapeComponents[i].Contains(point))
                {
                    return true;
                }
            }

            return false;

        }

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

            for (int i = ShapeComponents.Count - 1; i >= 0; i--)
            {

                offSetX[i] = offSetX[i] * scaleGroupWidth;
                offSetY[i] = offSetY[i] * scaleGroupHeight;
                ShapeComponents[i].Width *= scaleGroupWidth;
                ShapeComponents[i].Height *= scaleGroupHeight;

                Widths[i] = ShapeComponents[i].Width;
                Heights[i] = ShapeComponents[i].Height;
            }

            Width = ShapeWidth;
            Height = ShapeHeight;

        }
        public override Shape Copy()
        {

            PracticeShape clone = new PracticeShape(new RectangleF(Rectangle.X, Rectangle.Y,
                                              Rectangle.Width, Rectangle.Height));


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
            Pen pen = new Pen(Color.FromArgb(Transparency, BorderColor), BorderWidth);

            //i=0/shape1, golqm rectangle
            //i=1/shape2, liniq
            //i=2/shape3, maluk rectangle

            for (int i = 0; i < ShapeComponents.Count; i++)
            {

                float xValue = offSetX[i];
                float yValue = offSetY[i];
                ShapeComponents[i].Location = new PointF()
                {
                    X = Rectangle.X + xValue,
                    
                    Y = Rectangle.Y + yValue
                };

                switch (i)
                {
                    case 0:
                        {
                            grfx.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, FillColor)), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
                            if (IsSelected)
                            {
                                pen.DashPattern = new float[] { 2, 1, 2 };
                            }
                            grfx.DrawRectangle(pen, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

                            break;
                        }
                    case 1:
                        {
                            grfx.DrawLine(pen, Rectangle.X+(Rectangle.Width/2), Rectangle.Y+(Rectangle.Height/2), Rectangle.Right, Rectangle.Top);

                            break;
                        }
                    case 2:
                        {
                            grfx.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, FillColor)), Rectangle.X, Rectangle.Y + (Rectangle.Height / 2), Rectangle.Width/2, Rectangle.Height/2); //x i y sa na malkiq rectangle/i=2, width i height sa na golemiq rectangle, i=0
                            if (IsSelected)
                            {
                                pen.DashPattern = new float[] { 2, 1, 2 };
                            }
                            grfx.DrawRectangle(pen, Rectangle.X, Rectangle.Y+Rectangle.Height/2, Rectangle.Width/2, Rectangle.Height/2);

                            break;
                        }
                }
                   


            }

            grfx.Transform = new Matrix(ShapeMatrix[0], ShapeMatrix[1], ShapeMatrix[2], ShapeMatrix[3], ShapeMatrix[4], ShapeMatrix[5]);


        }

    }
}
