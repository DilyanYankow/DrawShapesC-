using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Draw
{

	public partial class MainForm : Form
	{

		private DialogProcessor dialogProcessor = new DialogProcessor();

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}


		void ViewPortPaint(object sender, PaintEventArgs e)
		{
			dialogProcessor.ReDraw(sender, e);
			if (dialogProcessor.IsMarking)
			{
				//risuva sin pravougulnik pri vlachene, markirane
				e.Graphics.DrawRectangle(Pens.LightBlue, dialogProcessor.getRectangle());
				e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(64, Color.Blue)), dialogProcessor.getRectangle());
			}

			if (dialogProcessor.IsDrawing)
				//risuva vsichki figuri s checknati butoni
			{
				if (drawRectangleSpeedButton.Checked)
				{
					e.Graphics.DrawRectangle(Pens.Black, dialogProcessor.getRectangle());
				}

				if (drawEllipseSpeedButton.Checked)
				{
					e.Graphics.DrawEllipse(Pens.Black, dialogProcessor.getRectangle());
				}

				if (drawSquareSpeedButton.Checked)
				{
					e.Graphics.DrawRectangle(Pens.Black, dialogProcessor.getSquare());
				}

				if (drawCircleSpeedButton.Checked)
				{
					e.Graphics.DrawEllipse(Pens.Black, dialogProcessor.getSquare());
				}


				if (drawLineSpeedButton.Checked)
				{
					e.Graphics.DrawLine(Pens.Black, dialogProcessor.StartingPoint, dialogProcessor.EndingPoint);
				}

				if (drawPracticeSpeedButton.Checked)
				{
					e.Graphics.DrawRectangle(Pens.Black, dialogProcessor.getRectangle());
				}

				if (drawPractice3SpeedButton.Checked)
				{
					e.Graphics.DrawEllipse(Pens.Black, dialogProcessor.getSquare());
				}


			}

		}
		void DrawRectangleSpeedButtonClick(object sender, EventArgs e)
		{

		}


		void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			//povdigane na butona na mishkata, eventa
			if (dialogProcessor.IsDragging)
			{
				dialogProcessor.IsDragging = false;
				//spira vlacheneto pri otpuskane na mishkata
				shapesPropertiesGroupBox.Visible = true;
				if (dialogProcessor.Selection.Count == 1)
				{
					shapeNameTextBox.Text = dialogProcessor.Selection[0].Name;
					fillColorButtonGB.BackColor = dialogProcessor.Selection[0].FillColor;
					borderWidthNumberBar.Value = dialogProcessor.Selection[0].BorderWidth;
					borderColorButtonGB.BackColor = dialogProcessor.Selection[0].BorderColor;
					transparencyTB.Value = dialogProcessor.Selection[0].Transparency;
					transparencyNumberBar.Value = dialogProcessor.Selection[0].Transparency;
					shapeWidthNumberBar.Value = (int)dialogProcessor.Selection[0].Width;
					shapeHeightNumberBar.Value = (int)dialogProcessor.Selection[0].Height;
					rotateShapeNumberBar.Value = dialogProcessor.Selection[0].Rotation;
					shapeXCoordinateNB.Enabled = true;
					shapeYCoordinateNB.Enabled = true;
					shapeXCoordinateNB.Value = (decimal)dialogProcessor.Selection[0].Location.X;
					shapeYCoordinateNB.Value = (decimal)dialogProcessor.Selection[0].Location.Y;
					dialogProcessor.RotateShape(dialogProcessor.Selection);
				}
				else
				{
					//selection count != 1, pri dragvane ( ne pri shift+ click)
					shapeNameTextBox.Text = "selected multiple shapes";
					fillColorButtonGB.BackColor = dialogProcessor.Selection[0].FillColor;
					borderWidthNumberBar.Value = dialogProcessor.Selection[0].BorderWidth;
					borderColorButtonGB.BackColor = dialogProcessor.Selection[0].BorderColor;
					transparencyNumberBar.Value = dialogProcessor.Selection[0].Transparency;
					transparencyTB.Value = dialogProcessor.Selection[0].Transparency;
					shapeWidthNumberBar.Value = (decimal)dialogProcessor.Selection[0].Width;
					shapeHeightNumberBar.Value = (decimal)dialogProcessor.Selection[0].Height;
					rotateShapeNumberBar.Value = 0;
					shapeXCoordinateNB.Enabled = false;
					shapeYCoordinateNB.Enabled = false;

					dialogProcessor.RotateShape(dialogProcessor.Selection);

				}
				viewPort.Invalidate();
			}

			if (dialogProcessor.IsMarking)
			{
				dialogProcessor.IsMarking = false;
				dialogProcessor.Selection = dialogProcessor.Multi_Contains(e.Location);

				if (dialogProcessor.Selection.Count > 1)
				{
					shapesPropertiesGroupBox.Visible = true;
					//pri Multi select sus shift + click(a ne pri dragvane)
					shapeNameTextBox.Text = "selected multiple shapes";
					fillColorButtonGB.BackColor = dialogProcessor.Selection[0].FillColor;
					borderWidthNumberBar.Value = dialogProcessor.Selection[0].BorderWidth;
					borderColorButtonGB.BackColor = dialogProcessor.Selection[0].BorderColor;
					transparencyNumberBar.Value = dialogProcessor.Selection[0].Transparency;
					transparencyTB.Value = dialogProcessor.Selection[0].Transparency;
					shapeWidthNumberBar.Value = (decimal)dialogProcessor.Selection[0].Width;
					shapeHeightNumberBar.Value = (decimal)dialogProcessor.Selection[0].Height;
					rotateShapeNumberBar.Value = 0;
					shapeXCoordinateNB.Enabled = false;
					shapeYCoordinateNB.Enabled = false;
				}

				else if (dialogProcessor.Selection.Count == 1)
				{
					shapesPropertiesGroupBox.Visible = true;

					shapeNameTextBox.Text = dialogProcessor.Selection[0].Name;
					FillColorButton.BackColor = dialogProcessor.Selection[0].FillColor;
					borderWidthNumberBar.Value = dialogProcessor.Selection[0].BorderWidth;
					BorderColorButton.BackColor = dialogProcessor.Selection[0].BorderColor;
					transparencyNumberBar.Value = dialogProcessor.Selection[0].Transparency;
					shapeWidthNumberBar.Value = (int)dialogProcessor.Selection[0].Width;
					shapeHeightNumberBar.Value = (int)dialogProcessor.Selection[0].Height;
					rotateShapeNumberBar.Value = dialogProcessor.Selection[0].Rotation;
					shapeXCoordinateNB.Enabled = true;
					shapeYCoordinateNB.Enabled = true;
					shapeXCoordinateNB.Value = (decimal)dialogProcessor.Selection[0].Location.X;
					shapeYCoordinateNB.Value = (decimal)dialogProcessor.Selection[0].Location.Y;
				}

			}


			if (drawRectangleSpeedButton.Checked)
			{
				dialogProcessor.ShapeList.Add(dialogProcessor.AddRectangle());
				drawRectangleSpeedButton.Checked = false;
			}

			if (drawSquareSpeedButton.Checked)
			{
				dialogProcessor.ShapeList.Add(dialogProcessor.AddSquare());
				drawSquareSpeedButton.Checked = false;
			}

			if (drawEllipseSpeedButton.Checked)
			{
				dialogProcessor.ShapeList.Add(dialogProcessor.AddEllipse());
				drawEllipseSpeedButton.Checked = false;
			}

			if (drawCircleSpeedButton.Checked)
			{
				dialogProcessor.ShapeList.Add(dialogProcessor.AddCircle());
				drawCircleSpeedButton.Checked = false;
			}


			if (drawLineSpeedButton.Checked)
			{
				dialogProcessor.ShapeList.Add(dialogProcessor.AddLine());
				drawLineSpeedButton.Checked = false;
			}
			if (drawPracticeSpeedButton.Checked)
			{
				dialogProcessor.ShapeList.Add(dialogProcessor.AddPracticeShape());
				drawPracticeSpeedButton.Checked = false;
			}
			if (drawPractice3SpeedButton.Checked)
			{
				dialogProcessor.ShapeList.Add(dialogProcessor.AddPracticeShape3());
				drawPractice3SpeedButton.Checked = false;
			}

			dialogProcessor.IsDrawing = false;
			dialogProcessor.EndingPoint = PointF.Empty;

			viewPort.Invalidate();
			//prerisuva vsichko /refresh


		}
		private void viewPort_MouseDown(object sender, MouseEventArgs e)
		{

			if (e.Button == MouseButtons.Left)
			{
				if (pickUpSpeedButton.Checked)
				{
					dialogProcessor.Deselect();
					dialogProcessor.Select = dialogProcessor.ContainsPoint(e.Location);

					if (dialogProcessor.Select != null)
					{
						if ((dialogProcessor.Selection.Count > 1) && dialogProcessor.Selection.Contains(dialogProcessor.Select))
						{
							
							dialogProcessor.IsDragging = true;

							dialogProcessor.EndingPoint = e.Location;
							viewPort.Invalidate();
						}
						else
						{
							
							if (dialogProcessor.IsMultiSelecting == false)
							{
								dialogProcessor.ClearSelection();
								dialogProcessor.Deselect();
							}

							if (!dialogProcessor.Selection.Contains(dialogProcessor.Select))
							{
								dialogProcessor.Selection.Add(dialogProcessor.Select);
							}

							statusBar.Items[0].Text = "Last action: Shape selected";
							dialogProcessor.SelectAll();
							dialogProcessor.IsDragging = true;
							dialogProcessor.EndingPoint = e.Location;

							viewPort.Invalidate();
						}
					}
					else
					{
						dialogProcessor.Deselect();
						dialogProcessor.ClearSelection();
						dialogProcessor.StartingPoint = e.Location;
						dialogProcessor.EndingPoint = e.Location;

						dialogProcessor.IsMarking = true;
						shapesPropertiesGroupBox.Visible = false;

						viewPort.Invalidate();
					}
				}
			}
			if (e.Button == MouseButtons.Right && pickUpSpeedButton.Checked)
			{
				dialogProcessor.Deselect();
				shapesPropertiesGroupBox.Visible = false;
				dialogProcessor.ClearSelection();

			}

			if (drawRectangleSpeedButton.Checked || drawCircleSpeedButton.Checked || drawEllipseSpeedButton.Checked
				|| drawLineSpeedButton.Checked || drawSquareSpeedButton.Checked || drawPracticeSpeedButton.Checked || drawPractice3SpeedButton.Checked)
			{
				dialogProcessor.StartingPoint = e.Location;
				if (dialogProcessor.StartingPoint != null)
				{
					dialogProcessor.IsDrawing = true;
				}
			}



		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{

		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{

		}

		private void pickUpSpeedButton_Click(object sender, EventArgs e)
		{

		}

		private void imageToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void speedMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void viewPort_Load(object sender, EventArgs e)
		{

		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{

		}

		private void toolStripLabel1_Click(object sender, EventArgs e)
		{

		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{

			viewPort.Invalidate();

		}

		private void BorderColor_Click(object sender, EventArgs e)
		{
			if (BorderColorButtonDialog.ShowDialog() == DialogResult.OK)
			{
				BorderColorButton.BackColor = BorderColorButtonDialog.Color;
			}

		}

		private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{

		}

		private void toolStripButton2_Click_1(object sender, EventArgs e)
		{

		}


		private void toolStripButton4_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Apply Changes button
			if (dialogProcessor.Selection.Count > 0)
			{
				if (dialogProcessor.Selection.Count == 1)
				{
					dialogProcessor.Selection[0].Name = shapeNameTextBox.Text;
					dialogProcessor.Selection[0].FillColor = fillColorButtonGB.BackColor;
					dialogProcessor.Selection[0].BorderWidth = (int)borderWidthNumberBar.Value;
					dialogProcessor.Selection[0].BorderColor = borderColorButtonGB.BackColor;
					dialogProcessor.Selection[0].Transparency = (int)transparencyNumberBar.Value;
					dialogProcessor.Selection[0].Rotation = (int)rotateShapeNumberBar.Value;
					dialogProcessor.Selection[0].Location = new PointF()
					{
						X = (int)shapeXCoordinateNB.Value,
						Y = (int)shapeYCoordinateNB.Value
					};
					
					dialogProcessor.ScaleShape((int)shapeWidthNumberBar.Value, (int)shapeHeightNumberBar.Value);
					dialogProcessor.RotateShape(dialogProcessor.Selection);

					viewPort.Invalidate();
				}
				else if (dialogProcessor.Selection.Count > 1)
				{
					
					shapeWidthNumberBar.Value = (decimal)dialogProcessor.Selection[0].Width;
					shapeHeightNumberBar.Value = (decimal)dialogProcessor.Selection[0].Height;
					for (int i = 0; i < dialogProcessor.Selection.Count; i++)
					{
						dialogProcessor.Selection[i].FillColor = fillColorButtonGB.BackColor;
						dialogProcessor.Selection[i].BorderWidth = (int)borderWidthNumberBar.Value;
						dialogProcessor.Selection[i].BorderColor = borderColorButtonGB.BackColor;
						dialogProcessor.Selection[i].Transparency = (int)transparencyNumberBar.Value;
						dialogProcessor.Selection[i].Rotation = (int)rotateShapeNumberBar.Value;
						

						/*dialogProcessor.Selection[i].Location = new PointF()
						{
							X = (int)shapeXCoordinateNB.Value,
							Y = (int)shapeYCoordinateNB.Value
						};
						*/
						if (shapeWidthNumberBar.Value > 0 && shapeHeightNumberBar.Value > 0)
						{
							dialogProcessor.ScaleShape((int)shapeWidthNumberBar.Value, (int)shapeHeightNumberBar.Value);
						}
						dialogProcessor.RotateShape(dialogProcessor.Selection);

						viewPort.Invalidate();
					}
				}

				viewPort.Invalidate();
			}
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void FillColorButton_Click(object sender, EventArgs e)
		{
			if (FillColorButtonDialog.ShowDialog() == DialogResult.OK)
			{
				FillColorButton.BackColor = FillColorButtonDialog.Color;
				dialogProcessor.FillColor = FillColorButtonDialog.Color;
			}
		}

		private void BorderColorButton_Click(object sender, EventArgs e)
		{
			if (BorderColorButtonDialog.ShowDialog() == DialogResult.OK)
			{
				BorderColorButton.BackColor = BorderColorButtonDialog.Color;
				dialogProcessor.BorderColor = BorderColorButtonDialog.Color;
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}


		private void transparencyScrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			transparencyNumberBar.Value = transparencyTB.Value;

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void numericUpDown2_ValueChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void drawCircleSpeedButton_Click(object sender, EventArgs e)
		{

		}

		private void BorderColorButton_Click_1(object sender, EventArgs e)
		{
			if (BorderColorButtonDialog.ShowDialog() == DialogResult.OK)
			{
				BorderColorButton.BackColor = BorderColorButtonDialog.Color;
				dialogProcessor.BorderColor = BorderColorButton.BackColor;
			}
		}

		private void FillColorButton_Click_1(object sender, EventArgs e)
		{
			if (FillColorButtonDialog.ShowDialog() == DialogResult.OK)
			{
				FillColorButton.BackColor = FillColorButtonDialog.Color;
				dialogProcessor.FillColor = FillColorButton.BackColor;
			}
		}

		private void borderColorButtonGB_Click(object sender, EventArgs e)
		{
			if (BorderColorButtonDialog.ShowDialog() == DialogResult.OK)
			{
				borderColorButtonGB.BackColor = BorderColorButtonDialog.Color;
			}
		}

		private void fillColorButtonGB_Click(object sender, EventArgs e)
		{
			if (FillColorButtonDialog.ShowDialog() == DialogResult.OK)
			{
				fillColorButtonGB.BackColor = FillColorButtonDialog.Color;
			}

		}

		private void drawSquareSpeedButton_Click(object sender, EventArgs e)
		{

		}

		private void transparencyNumberBar_ValueChanged(object sender, EventArgs e)
		{
			transparencyTB.Value = (int)transparencyNumberBar.Value;
		}

		private void transparencyTB_Scroll(object sender, EventArgs e)
		{
			transparencyNumberBar.Value = transparencyTB.Value;

		}


		private void shapeHeightNumberBar_ValueChanged(object sender, EventArgs e)
		{

		}

		private void rotateShapeNumberBar_ValueChanged(object sender, EventArgs e)
		{

		}

		private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenImageDialog.Filter = "Bin file (*.bin)|*.bin|Picture (*.bmp)|*.bmp";

			if (OpenImageDialog.ShowDialog() == DialogResult.OK)
			{
				switch (OpenImageDialog.FilterIndex)
				{
					case 1:
						{
							dialogProcessor.LoadFromBin(OpenImageDialog.FileName);
						}
						break;
					case 2:
						{
							dialogProcessor.LoadFromBmp(OpenImageDialog.FileName, viewPort);
						}
						break;
				}
			}

			viewPort.Invalidate();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveShapeDialog.Filter = "Bin file (*.bin)|*.bin|Picture (*.bmp)|*.bmp";

			if (SaveShapeDialog.ShowDialog() == DialogResult.OK)
			{
				switch (SaveShapeDialog.FilterIndex)
				{
					case 1:
						{
							dialogProcessor.SaveToBin(SaveShapeDialog.FileName);
						}
						break;
					case 2:
						{
							dialogProcessor.SaveToBmp(SaveShapeDialog.FileName, viewPort);
						}
						break;
				}
			}
		}

		private void SaveShapeDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{

		}

		private void CopyButton_Click(object sender, EventArgs e)
		{
			dialogProcessor.CopyShape.Clear();
			dialogProcessor.CopySelection();
		}

		private void PasteButton_Click(object sender, EventArgs e)
		{
			dialogProcessor.PasteSelection();

			viewPort.Invalidate();
		}

		private void GroupShapesButton_Click(object sender, EventArgs e)
		{
			if (dialogProcessor.Selection.Count > 1)
			{
				dialogProcessor.GroupShapes();
				statusBar.Items[0].Text = "Last action: Group Shapes";

				viewPort.Invalidate();
			}


			viewPort.Invalidate();
		}

		private void UngroupShapesButton_Click(object sender, EventArgs e)
		{
			if (dialogProcessor.Select != null)
			{
				if (dialogProcessor.Select.IsGrouped)
				{
					dialogProcessor.UngroupShapes();
				}
			}

			viewPort.Invalidate();
		}

		private void viewPort_MouseMove(object sender, MouseEventArgs e)
		{
			if (dialogProcessor.IsDragging)
			{
				if (dialogProcessor.Selection.Count > 0)
				{
					if (dialogProcessor.Selection.Count > 1)
					{
						statusBar.Items[0].Text = "Last action: Dragging multiple shapes";

						dialogProcessor.TranslateTo(dialogProcessor.Selection, e.Location);
					}
					else
					{
						statusBar.Items[0].Text = "Last action: Dragging shape";

						dialogProcessor.TranslateTo(dialogProcessor.Selection, e.Location);
					}
				}


			}

			if (dialogProcessor.IsDrawing)
			{
				dialogProcessor.EndingPoint = e.Location;

			}

			if (dialogProcessor.IsMarking)
			{
				dialogProcessor.EndingPoint = e.Location;

			}


			viewPort.Invalidate();
		}


		private void deleteShapeButton_Click(object sender, EventArgs e)
		{
			
			for (int i = 0; i < dialogProcessor.Selection.Count; i++)
			{
				dialogProcessor.ShapeList.Remove(dialogProcessor.Selection[i]);
			}
			dialogProcessor.ClearSelection();
			dialogProcessor.DeselectAllShapes();
			shapesPropertiesGroupBox.Visible = false;
			MessageBox.Show("Shape(s) Deleted!");

			viewPort.Invalidate();
		}

		private void drawPracticeSpeedButton_Click(object sender, EventArgs e)
		{
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			
		}

		private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
		{

		}

		private void viewPort_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
				//zamenq delete butona
			{
				for (int i = 0; i < dialogProcessor.Selection.Count; i++)
				{
					dialogProcessor.ShapeList.Remove(dialogProcessor.Selection[i]);
				}
				dialogProcessor.ClearSelection();
				shapesPropertiesGroupBox.Visible = false;

				viewPort.Invalidate();
				MessageBox.Show("Shapes deleted successfully!");
			}

			if (e.KeyCode == Keys.ShiftKey)
				//izbira nqkolko elementa
			{
				if (dialogProcessor.IsMultiSelecting == true)
				{
					dialogProcessor.IsMultiSelecting = false;
				}
				else
				{
					dialogProcessor.IsMultiSelecting = true;
				}
			}

			if (e.Control)	//control button + 
			{

				if (e.KeyCode == Keys.C)
				{
					dialogProcessor.CopyShape.Clear();
					dialogProcessor.CopySelection();
				}

				if (e.KeyCode == Keys.V)
				{
					dialogProcessor.PasteSelection();
					viewPort.Invalidate();
				}

				if (e.KeyCode == Keys.S)
				{
					saveToolStripMenuItem.PerformClick();
				}

				if (e.KeyCode == Keys.L)
				{
					openImageToolStripMenuItem.PerformClick();
				}

				if (e.KeyCode == Keys.G)
				{
					GroupShapesButton.PerformClick();
				}

			}


			if (dialogProcessor.Selection.Count > 0)
			{
				if (e.KeyCode == Keys.Enter)
				{
					applyChangesButton.PerformClick();
				}
			}
		
		}

		private void deleteAllShapesBtn_Click(object sender, EventArgs e)
		{
			dialogProcessor.SelectAllShapes();

			for (int i = 0; i < dialogProcessor.Selection.Count; i++)
			{
				dialogProcessor.ShapeList.Remove(dialogProcessor.Selection[i]);
			}
			dialogProcessor.ClearSelection();
			dialogProcessor.DeselectAllShapes();
			shapesPropertiesGroupBox.Visible = false;
			viewPort.Invalidate();

			MessageBox.Show("ALL Shape(s) Deleted!");

		}

		private void drawPractice3SpeedButton_Click(object sender, EventArgs e)
		{

		}
	}
}
