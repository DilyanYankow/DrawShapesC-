using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
	[Serializable]
	public class ImageShape : Shape
	{

		private Bitmap img;

		#region Constructor

		public ImageShape(string location)
		{
			img = new Bitmap(location);
		}

		public ImageShape(ImageShape img) : base(img)
		{
		}

		#endregion

		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);

			grfx.DrawImage(img, 0, 0);

		}
	}
}
