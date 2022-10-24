using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    [Serializable]
    public class GroupShape : Shape
    {
        public List<Shape> GroupedShapes { get; set; } = new List<Shape>();
        private List<float> offSetX = new List<float>();
        private List<float> offSetX_Mirror = new List<float>();
        private List<float> offSetY = new List<float>();
        private List<float> offSetY_Mirror = new List<float>();
        private List<float> widths = new List<float>();
        private List<float> heights = new List<float>();

        private float groupWidth;
        private float groupHeight;

        public GroupShape(GroupShape group) : base(group)
        {
            //Uses a new instance GroupShape from base to create this Shape

        }
        public GroupShape(List<Shape> shapes, RectangleF group)
        {

            Rectangle = group;


            for (int i = 0; i < shapes.Count ; i++)
            {
                GroupedShapes.Add(shapes[i].Copy());
                offSetX.Add(shapes[i].Location.X - Rectangle.X);
                offSetX_Mirror.Add(Rectangle.Width - (offSetX[i] + GroupedShapes[i].Width));
                offSetY.Add(shapes[i].Location.Y - Rectangle.Y);
                offSetY_Mirror.Add(Rectangle.Height - (offSetY[i] + GroupedShapes[i].Height));
                widths.Add(shapes[i].Width);
                heights.Add(shapes[i].Height);
            }

            groupWidth = group.Width;
            groupHeight = group.Height;

        }


        public override bool Contains(PointF point)
        {

            for (int i = 0; i< GroupedShapes.Count; i++)
            {
                if (GroupedShapes[i].Contains(point))
                {
                    return true;
                }
            }

            return false;

        }
        /* practice
          public override bool Contains(PointF point)
        {
            for (int i = 0; i< ShapeElements.Count;i++)
            {
                if (ShapeElements[i].Contains(point))
                {
                    return true;
                }
            }

            return false;

        }
         */
        public override void Resize(int width, int height)
        {
            float scaleGroupWidth = 1;
            float scaleGroupHeight = 1;

            if (width != groupWidth || height != groupHeight)
            {
                scaleGroupWidth += ((width - groupWidth) / (groupWidth / 100)) / 100;
                scaleGroupHeight += ((height - groupHeight) / (groupHeight / 100)) / 100;

                groupWidth = width;
                groupHeight = height;
            }

            for (int i=0; i< GroupedShapes.Count; i++)
            {
                offSetX[i] = offSetX[i] * scaleGroupWidth;
                offSetY[i] = offSetY[i] * scaleGroupHeight;
                GroupedShapes[i].Width *= scaleGroupWidth;
                GroupedShapes[i].Height *= scaleGroupHeight;

                widths[i] = GroupedShapes[i].Width;
                heights[i] = GroupedShapes[i].Height;
            }

            Width = groupWidth;
            Height = groupHeight;

        }

       
        public override Shape Copy()
        {

            GroupShape copy = new GroupShape(this.GroupedShapes, new RectangleF(Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height));

            copy.Name = this.Name;
            copy.BorderColor = this.BorderColor;
            copy.FillColor = this.FillColor;
            copy.Transparency = this.Transparency;
            copy.ShapeMatrix = this.ShapeMatrix;
            copy.BorderWidth = this.BorderWidth;
            copy.Rotation = this.Rotation;
            copy.IsGrouped = true;

            return copy;

        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            for (int i = 0; i < GroupedShapes.Count; i++)
            {
                float xValue = offSetX[i];
                float yValue = offSetY[i];

                switch (FixedRotation)
                {

                    case 0:
                        {
                            GroupedShapes[i].Location = new PointF()
                            {
                                X = Rectangle.X + xValue,
                                Y = Rectangle.Y + yValue
                            };
                        }
                        break;

                    case 1:
                        {
                            GroupedShapes[i].Location = new PointF()
                            {
                                X = Rectangle.X + (Rectangle.Width - (GroupedShapes[i].Width + yValue)),
                                Y = Rectangle.Y + xValue
                            };
                        }
                        break;

                    case 2:
                        { 
                            GroupedShapes[i].Location = new PointF()
                            {
                                X = Rectangle.X + (Rectangle.Width - (GroupedShapes[i].Width + xValue)),
                                Y = Rectangle.Y + (Rectangle.Height - (GroupedShapes[i].Height + yValue))
                            };
                        }
                        break;

                    case 3:
                        {
                            GroupedShapes[i].Location = new PointF()
                            {
                                X = Rectangle.X + yValue,
                                Y = Rectangle.Y + (Rectangle.Height - (GroupedShapes[i].Height + xValue))
                            };
                        }
                        break;

                }

                GroupedShapes[i].DrawSelf(grfx);

            }

            grfx.Transform = new Matrix(ShapeMatrix[0], ShapeMatrix[1], ShapeMatrix[2], ShapeMatrix[3], ShapeMatrix[4], ShapeMatrix[5]);

            if (IsSelected)
            {
                Pen pen = new Pen(Color.Black);
                pen.DashPattern = new float[] { 4, 2, 4 };

                grfx.DrawRectangle(pen, Rectangle.X - 10, Rectangle.Y - 10, Rectangle.Width + 10, Rectangle.Height + 10);

            }
        }

    }
}
