using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw
{
	public class DialogProcessor : DisplayProcessor
	{

		#region Constructor
		
		public DialogProcessor()
		{
		}

		#endregion

		#region Properties

		private List<Shape> selection = new List<Shape>();
		public List<Shape> Selection {
			get { return selection; }
			set { selection = value; }
		}
		private Shape select;
		public Shape Select
		{
			get { return select; }
			set { select = value; }
		}

		private bool isMultiSelecting;
		public bool IsMultiSelecting
		{
			get { return isMultiSelecting; }
			set { isMultiSelecting = value; }
		}

		private bool isDragging;
		public bool IsDragging {
			get { return isDragging; }
			set { isDragging = value; }
		}

		private bool isMarking;
		public bool IsMarking
		{
			get { return isMarking; }
			set { isMarking = value; }
		}



		#endregion

		private Color fillColor = Color.White;
		public Color FillColor
		{
			get { return fillColor; }
			set { fillColor = value; }
		}
		private List<Shape> copyShape = new List<Shape>();
		public List<Shape> CopyShape
		{
			get { return copyShape; }
			set { copyShape = value; }
		}
		private int transparency = 255;
		public int Transparency
		{
			get { return transparency; }
			set { transparency = value; }
		}
		private Color borderColor = Color.Black;
		public Color BorderColor
		{
			get { return borderColor; }
			set { borderColor = value; }
		}

		private int borderWidth = 2;
		public int BorderWidth
		{
			get { return borderWidth; }
			set { borderWidth = value; }
		}

		private bool isDrawing;
		public bool IsDrawing
		{
			get { return isDrawing; }
			set { isDrawing = value; }
		}



		private PointF startingPoint;
		public PointF StartingPoint
		{
			get { return startingPoint; }
			set { startingPoint = value; }
		}

		private PointF endingPoint;
		public PointF EndingPoint
		{
			get { return endingPoint; }
			set { endingPoint = value; }
		}
		/// <summary>
		/// Добавя примитив - правоъгълник на произволно място върху клиентската област.
		/// </summary>

		/*public void AddRandomEllipse()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, 100, 200));
			{
				ellipse.FillColor = Color.White;
				ellipse.BorderColor = Color.White;
			};

			ShapeList.Add(ellipse);
		}*/

		public Rectangle getSquare()
		{
			return new Rectangle((int)Math.Min(StartingPoint.X, EndingPoint.X),
								(int)Math.Min(StartingPoint.Y, EndingPoint.Y),
								(int)Math.Abs(StartingPoint.X - EndingPoint.X),
								(int)Math.Abs(StartingPoint.X - EndingPoint.X));
		}

		public Rectangle getRectangle()
		{
			return new Rectangle((int)Math.Min(StartingPoint.X, EndingPoint.X),
								 (int)Math.Min(StartingPoint.Y, EndingPoint.Y),
								 (int)Math.Abs(StartingPoint.X - EndingPoint.X),
								 (int)Math.Abs(StartingPoint.Y - EndingPoint.Y));
		}

		public void Deselect()
		{
			for (int i=0; i < Selection.Count; i++)
			{
				Selection[i].IsSelected = false;
			}
		}
		public void SelectAll()
		{
			for (int i=0; i < Selection.Count; i++)
			{
				Selection[i].IsSelected = true;
			}
		}
		public void SelectAllShapes()
		{
			for (int i = 0; i < ShapeList.Count; i++)
			{
				ShapeList[i].IsSelected = true;
			}
			Selection = ShapeList;
		}
		public void DeselectAllShapes()
		{

			for (int i = 0; i < ShapeList.Count; i++)
			{
				ShapeList[i].IsSelected = false;
			}
			Selection = ShapeList;
		}
		public virtual void PasteSelection()
		{
			for (int i = 0; i < Selection.Count; i++)
			{
				Shape copy = CopiesList[i];

				ShapeList.Add(copy.Copy());
			}
		}
		public void ClearSelection()
		{
			Selection.Clear();
		}
		public virtual void CopySelection()
		{
			for (int i = 0; i < Selection.Count; i++)
			{
				CopiesList.Add(Selection[i].Copy());
			}
		}
		public virtual void ScaleShape(int width, int height)
		{
			for (int i = 0; i < Selection.Count; i++)
			{

				Selection[i].Resize(width, height);

			}
		}



		private int groupNum = 1;
		public void GroupShapes()
		{

			float TLX = Selection[0].Rectangle.Left;
			float TLY = Selection[0].Rectangle.Top;
			float BRX = Selection[0].Rectangle.Right;
			float BRY = Selection[0].Rectangle.Bottom;

			for (int i = 0; i < Selection.Count; i++)
			{
				if (Selection[i].Rectangle.Left < TLX)
					TLX = Selection[i].Rectangle.Left;

				if (Selection[i].Rectangle.Top < TLY)
					TLY = Selection[i].Rectangle.Top;

				if (Selection[i].Rectangle.Right > BRX)
					BRX = Selection[i].Rectangle.Right;

				if (Selection[i].Rectangle.Bottom > BRY)
					BRY = Selection[i].Rectangle.Bottom;
				ShapeList.Remove(Selection[i]);
			}
			GroupShape group = new GroupShape(Selection, RectangleF.FromLTRB(TLX, TLY, BRX, BRY));
			
			group.IsGrouped = true;
			group.Name = "Group " + groupNum;
			groupNum++;
			group.BorderWidth = 2;
			group.BorderColor = Color.Black;
			group.FillColor = Color.White;
			group.Transparency = 255;
			

			Selection.Clear();

			ShapeList.Add(group);

		}
		public void UngroupShapes()
		{

			GroupShape group = (GroupShape)Select;

			for (int i = 0; i< group.GroupedShapes.Count; i++)
			{
				ShapeList.Add(group.GroupedShapes[i]);
				Selection.Add(group.GroupedShapes[i]);
			}

			Selection.Remove(group);
			ShapeList.Remove(group);

			RotateShape(Selection);

			Deselect();
			ClearSelection();
		}
		public void RotateGroupShapes(GroupShape group)
		{
			Matrix matrix2 = new Matrix();

			PointF groupCenter = new PointF()
			{
				X = group.Location.X + group.Width / 2,
				Y = group.Location.Y + group.Height / 2
			};


			for (int i = 0; i < group.GroupedShapes.Count; i++)
			{
				PointF center = new PointF()
				{
					X = group.GroupedShapes[i].Location.X + group.GroupedShapes[i].Width / 2,
					Y = group.GroupedShapes[i].Location.Y + group.GroupedShapes[i].Height / 2
				};

				if (group.GroupedShapes[i].IsGrouped)
				{
					group.GroupedShapes[i].Rotation += group.Rotation;
					RotateGroupShapes((GroupShape)group.GroupedShapes[i]);
					group.GroupedShapes[i].Rotation -= group.Rotation;
				}

				matrix2.Reset();

				matrix2.RotateAt(group.Rotation, groupCenter);
				matrix2.RotateAt(group.GroupedShapes[i].Rotation, center);

				group.GroupedShapes[i].ShapeMatrix = matrix2.Elements;

			}
		}
		
		public void RotateShape(List<Shape> shapes)
		{
			
			Matrix transMatrix = new Matrix();
			
			for (int i = 0; i < shapes.Count; i++)
			{

				PointF center = new PointF()
				{
					X = shapes[i].Location.X + shapes[i].Width / 2,
					Y = shapes[i].Location.Y + shapes[i].Height / 2
				};

				if (shapes[i].IsGrouped)
				{
					RotateGroupShapes((GroupShape)shapes[i]);
				}

				transMatrix.Reset();

				transMatrix.RotateAt(shapes[i].Rotation, center);
				shapes[i].ShapeMatrix = transMatrix.Elements;


			}
		}

		private int ellipseNum = 1;
		public EllipseShape AddEllipse()
		{
			EllipseShape ellipse = new EllipseShape(new Rectangle
			   ((int)Math.Min(StartingPoint.X, EndingPoint.X),
			   (int)Math.Min(StartingPoint.Y, EndingPoint.Y),
			   (int)Math.Abs(StartingPoint.X - EndingPoint.X),
			   (int)Math.Abs(StartingPoint.Y - EndingPoint.Y)))
			{
				Name = "Ellipse " + ellipseNum
			};
			ellipseNum++;
			ellipse.FillColor = FillColor;
			ellipse.BorderWidth = BorderWidth;
			ellipse.BorderColor = BorderColor;
			ellipse.Transparency = Transparency;

			return ellipse;
		}
		private int rectangleNum = 1;
		public RectangleShape AddRectangle()
		{

			RectangleShape rect = new RectangleShape(new Rectangle((int)Math.Min(StartingPoint.X, EndingPoint.X),
																   (int)Math.Min(StartingPoint.Y, EndingPoint.Y),
																   (int)Math.Abs(StartingPoint.X - EndingPoint.X),
																   (int)Math.Abs(StartingPoint.Y - EndingPoint.Y)))
			{
				Name = "Rectangle " + rectangleNum
			};
			rectangleNum++;
			rect.FillColor = FillColor;
			rect.BorderWidth = BorderWidth;
			rect.BorderColor = BorderColor;
			rect.Transparency = transparency;

			return rect;
		}
		private int squareNum = 1;
		public SquareShape AddSquare()
		{

			SquareShape sqr = new SquareShape(new Rectangle((int)Math.Min(StartingPoint.X, EndingPoint.X),
															(int)Math.Min(StartingPoint.Y, EndingPoint.Y),
															(int)Math.Abs(StartingPoint.X - EndingPoint.X),
															(int)Math.Abs(StartingPoint.X - EndingPoint.X)))
			{
				Name = "Square " + squareNum
			};
			squareNum++;
			sqr.FillColor = FillColor;
			sqr.BorderWidth = BorderWidth;
			sqr.BorderColor = BorderColor;
			sqr.Transparency = transparency;

			return sqr;
		}

		private int circleNum = 1;
		public CircleShape AddCircle()
		{

			CircleShape crcl = new CircleShape(new Rectangle((int)Math.Min(StartingPoint.X, EndingPoint.X),
															(int)Math.Min(StartingPoint.Y, EndingPoint.Y),
															(int)Math.Abs(StartingPoint.X - EndingPoint.X),
															(int)Math.Abs(StartingPoint.X - EndingPoint.X)));

			crcl.Name = "Circle " + circleNum;
			circleNum++;
			crcl.FillColor = FillColor;
			crcl.BorderWidth = BorderWidth;
			crcl.BorderColor = BorderColor;
			crcl.Transparency = transparency;

			return crcl;
		}

		private int linesNumb = 1;
		public LineShape AddLine()
		{

			LineShape line = new LineShape(StartingPoint, EndingPoint);

			line.Name = "Line " + linesNumb;
			linesNumb++;
			line.BorderWidth = BorderWidth;
			line.BorderColor = BorderColor;
			line.Transparency = transparency;

			return line;
		}
		public PracticeShape AddPracticeShape()
		{

			PracticeShape exm = new PracticeShape(new Rectangle((int)Math.Min(StartingPoint.X, EndingPoint.X),
																   (int)Math.Min(StartingPoint.Y, EndingPoint.Y),
																   (int)Math.Abs(StartingPoint.X - EndingPoint.X),
																   (int)Math.Abs(StartingPoint.Y - EndingPoint.Y)));

			exm.Name = "PracticeShape " + rectangleNum;
			rectangleNum++;
			exm.FillColor = FillColor;
			exm.BorderWidth = BorderWidth;
			exm.BorderColor = BorderColor;
			exm.Transparency = Transparency;

			return exm;
		}
		public PracticeShape3 AddPracticeShape3()
		{

			PracticeShape3 prc3 = new PracticeShape3(new Rectangle((int)Math.Min(StartingPoint.X, EndingPoint.X),
																   (int)Math.Min(StartingPoint.Y, EndingPoint.Y),
																   (int)Math.Abs(StartingPoint.X - EndingPoint.X),
																   (int)Math.Abs(StartingPoint.X - EndingPoint.X)));

			prc3.Name = "PracticeShape3 " + rectangleNum;
			rectangleNum++;
			prc3.FillColor = FillColor;
			prc3.BorderWidth = BorderWidth;
			prc3.BorderColor = BorderColor;
			prc3.Transparency = Transparency;

			return prc3;
		}
		
		public List<Shape> Multi_Contains(PointF point)
		{
			var selectedShps = new List<Shape>();

			var select = RectangleF.FromLTRB(StartingPoint.X, StartingPoint.Y, point.X, point.Y);

			for(int i=0; i< ShapeList.Count; i++)
			{
				if (select.Contains(ShapeList[i].Location))
				{
					ShapeList[i].IsSelected = true;
					selectedShps.Add(ShapeList[i]);
				}
			}

			return selectedShps;
		}
		public Shape ContainsPoint(PointF point)
		{
			for(int i=0; i < ShapeList.Count; i++){
				if (ShapeList[i].Contains(point)){
					ShapeList[i].IsSelected = true;

						
					return ShapeList[i];
				}	
			}
			return null;
		}
		public ImageShape LoadBmp(string bmpLocation)
		{
			ImageShape loadBmp = new ImageShape(bmpLocation);

			return loadBmp;
		}


		
		public void TranslateTo(List<Shape> shapes, PointF point)
		{
			float offSetX = point.X - endingPoint.X;
			float offSetY = point.Y - endingPoint.Y;
			for (int i = 0; i < shapes.Count; i++)
			{
				shapes[i].ShapeMatrix = new Matrix().Elements;
				shapes[i].Location = new PointF(shapes[i].Location.X + offSetX, shapes[i].Location.Y + offSetY);
				if (shapes[i].IsGrouped)
				{
					GroupShape group = (GroupShape)shapes[i];
					TranslateTo(group.GroupedShapes, point);
				}
			}

			endingPoint = point;
		}
	}
}

