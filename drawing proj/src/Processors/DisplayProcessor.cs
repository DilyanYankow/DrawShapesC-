using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Imaging;

namespace Draw


{
	/// <summary>
	/// Класът, който ще бъде използван при управляване на дисплейната система.
	/// </summary>
	public class DisplayProcessor
	{
		#region Constructor
		
		public DisplayProcessor()
		{
		}
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Списък с всички елементи формиращи изображението.
		/// </summary>
		private List<Shape> shapeList = new List<Shape>();		
		public List<Shape> ShapeList {
			get { return shapeList; }
			set { shapeList = value; }
		}
		private List<Shape> copiesList = new List<Shape>();
		public List<Shape> CopiesList
		{
			get { return copiesList; }
			set { copiesList = value; }
		}

		#endregion

		#region Drawing

		
		public void ReDraw(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Draw(e.Graphics);
		}
		
		/// <summary>
		/// Визуализация.
		/// Обхождане на всички елементи в списъка и извикване на визуализиращия им метод.
		/// </summary>
		/// <param name="grfx">Къде да се извърши визуализацията.</param>
		public virtual void Draw(Graphics grfx)
		{
			foreach (Shape item in ShapeList){
				DrawShape(grfx, item);
			}
		}

		public void LoadFromBin(string location)
		{
			Stream stream = File.Open(location, FileMode.Open);

			BinaryFormatter bin = new BinaryFormatter();
			var shapes = (List<Shape>)bin.Deserialize(stream);
			ShapeList.Clear();
			ShapeList.AddRange(shapes);
		}

		public void LoadFromBmp(string location, DoubleBufferedPanel viewPort)
		{

			ShapeList.Clear();

			DialogProcessor dp = new DialogProcessor();

			ShapeList.Add(dp.LoadBmp(location));

		}

		public void SaveToBin(string location)
		{

			Stream stream = File.Open(location, FileMode.Create);

			BinaryFormatter bin = new BinaryFormatter();
			bin.Serialize(stream, ShapeList);

		}
		public void SaveToBmp(string location, DoubleBufferedPanel viewPort)
		{
			using (Bitmap bmp = new Bitmap(viewPort.Width, viewPort.Height))
			{
				viewPort.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
				bmp.Save(location, ImageFormat.Bmp);
			}
		}

		public virtual void DrawShape(Graphics grfx, Shape item)
		{
			item.DrawSelf(grfx);
		}
		
		#endregion
	}
}
