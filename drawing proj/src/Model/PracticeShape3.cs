using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    [Serializable]

    public class PracticeShape3 : Shape
    {
        public List<Shape> ShapeComponents { get; set; } = new List<Shape>();
        private List<float> offsetX = new List<float>();
        private List<float> offsetY = new List<float>();
        private List<float> LHeights = new List<float>();
        private List<float> LWidths = new List<float>();
        private float PShapeWidth;
        private float PShapeHeight;
        public PointF Center { get; set; }
        public double r = 0;   //radius
        public double a = 0;   //1/2 ot vpisan kvadrat
        public PracticeShape3(RectangleF circl) : base(circl)
        {
            Rectangle = circl;

            List<Shape> containShapes = new List<Shape>();

            Center = new Point
            {
                X = (int)(Rectangle.X + Rectangle.Width / 2),
                Y = (int)(Rectangle.Y + Rectangle.Height / 2)
            };
            CircleShape containShapes1 = new CircleShape(new RectangleF(Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height));

            containShapes1.FillColor = Color.White;
            containShapes1.BorderColor = Color.Black;
            containShapes1.BorderWidth = 2;
            containShapes1.Transparency = 255;
            containShapes1.Rotation = 0;


            r = Rectangle.Width / 2;
            a = Math.Sqrt(Math.Pow(r, 2) / 2);
            //r = Math.Sqrt(Math.Pow((Rectangle.Width / 2), 2) + Math.Pow((Rectangle.Height / 2), 2));
            LineShape containShapes2 = new LineShape(new RectangleF((float)(Center.X - a), (float)(Center.Y - a), (float)a * 2, (float)a * 2));

            containShapes2.FillColor = Color.White;
            containShapes2.BorderColor = Color.Black;
            containShapes2.BorderWidth = 2;
            containShapes2.Transparency = 255;
            containShapes2.Rotation = 0;

            LineShape containShapes3 = new LineShape(new RectangleF((float)(Center.X - a), (float)(Center.Y - a), (float)a * 2, (float)a * 2));
            containShapes2.FillColor = Color.White;
            containShapes2.BorderColor = Color.Black;
            containShapes2.BorderWidth = 2;
            containShapes2.Transparency = 255;
            containShapes2.Rotation = 0;

            containShapes.Add(containShapes1);
            containShapes.Add(containShapes2);
            containShapes.Add(containShapes3);

            for (int i = 0; i < containShapes.Count; i++)
            {
                ShapeComponents.Add(containShapes[i].Copy());
                offsetX.Add(containShapes[i].Location.X - Rectangle.X);
                offsetY.Add(containShapes[i].Location.Y - Rectangle.Y);
                LHeights.Add(containShapes[i].Height);
                LWidths.Add(containShapes[i].Width);
            }


        }
        public PracticeShape3(PracticeShape3 prc) : base(prc)
        {
        }
        public override bool Contains(PointF point)
        {
            for (int i = 0; i < ShapeComponents.Count; i++)
            {
                if (ShapeComponents[i].Contains(point) == true)
                {
                    return true;
                }
            }
            return false;
        }

        public override void Resize(int width, int height)
        {
            float shapeWidths = 1;
            float shapeHeights = 1;

            if (width != PShapeWidth || height != PShapeHeight)
            {
                shapeWidths += ((width - PShapeWidth) / (PShapeWidth / 100)) / 100;
                shapeHeights += ((height - PShapeHeight) / (PShapeHeight / 100)) / 100;

                PShapeWidth = width;
                PShapeHeight = height;
            }

            for (int i = 0; i < ShapeComponents.Count; i++)
            {

                offsetX[i] = offsetX[i] * shapeWidths;
                offsetY[i] = offsetY[i] * shapeHeights;
                ShapeComponents[i].Width *= shapeWidths;
                ShapeComponents[i].Height *= shapeHeights;

                LWidths[i] = ShapeComponents[i].Width;
                LHeights[i] = ShapeComponents[i].Height;
            }

            Width = PShapeWidth;
            Height = PShapeHeight;
        }

        public override Shape Copy()
        {

            PracticeShape3 copy = new PracticeShape3(new RectangleF(Location.X, Location.Y, Width, Height));

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

            Pen pen = new Pen(Color.FromArgb(Transparency, BorderColor), BorderWidth);

            for (int i = 0; i < ShapeComponents.Count; i++)
            {
                float xValue = offsetX[i];
                float yValue = offsetY[i];

                ShapeComponents[i].Location = new PointF()
                {
                    X = Rectangle.X + xValue,
                    Y = Rectangle.Y + yValue
                };


                switch (i)
                {
                    case 0:
                        {
                            grfx.FillEllipse(new SolidBrush(Color.FromArgb(Transparency, FillColor)), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
                            if (IsSelected == true)
                            {
                                pen.DashPattern = new float[] { 3, 1, 3 };
                            }
                            grfx.DrawEllipse(pen, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

                            break;
                        }
                    case 1:
                        {

                            grfx.DrawLine(pen, Rectangle.X + (Rectangle.Width / 2) - (float)a, Rectangle.Y + (Rectangle.Height / 2) - (float)a, Rectangle.X + (Rectangle.Width / 2) + (float)a, Rectangle.Y + (Rectangle.Height / 2) + (float)a);

                            break;
                        }
                    case 2:
                        {
                            grfx.DrawLine(pen, Rectangle.X + (Rectangle.Width / 2) + (float)a, Rectangle.Y + (Rectangle.Height / 2) - (float)a, Rectangle.X + (Rectangle.Width / 2) - (float)a, Rectangle.Y + (Rectangle.Height / 2) + (float)a);

                            break;
                        }
                }

                grfx.Transform = new Matrix(ShapeMatrix[0], ShapeMatrix[1], ShapeMatrix[2], ShapeMatrix[3], ShapeMatrix[4], ShapeMatrix[5]);


            }


        }

    }
}
