﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace XnaToAnxConverter
{
	public partial class ConverterForm : Form
	{
		#region Constructor
		public ConverterForm()
		{
			InitializeComponent();

			destPath.Enabled = false;
			browsePath2.Enabled = false;
		}
		#endregion

		#region OnPaintBackground
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);

			e.Graphics.FillRectangle(new LinearGradientBrush(
				Point.Empty, new Point(0, ClientSize.Height),
				Color.CornflowerBlue, Color.White),
				ClientRectangle);
		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			destPath.Enabled = checkBox1.Checked;
			browsePath2.Enabled = checkBox1.Checked;
		}

		private void browsePath1_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dialog = new OpenFileDialog())
			{
				dialog.Title = "Select a .csproj file to convert...";
				dialog.InitialDirectory = "C:\\";
				dialog.Filter = "csproj file|*.csproj";
				dialog.CheckFileExists = true;
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					sourcePath.Text = dialog.FileName;
				}
			}
		}

		private void browsePath2_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog dialog = new SaveFileDialog())
			{
				dialog.Title = "Select where to save the converted files...";
				dialog.InitialDirectory = "C:\\";
				dialog.Filter = "csproj file|*.csproj";
				dialog.CheckFileExists = false;
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					destPath.Text = dialog.FileName;
				}
			}
		}

		private void convertButton_Click(object sender, EventArgs e)
		{
			string source = sourcePath.Text;
			string dest = checkBox1.Checked ? destPath.Text : sourcePath.Text;

			if (String.IsNullOrEmpty(source))
			{
				MessageBox.Show("Failed to convert because you need to enter a " +
					"source filepath!");
				return;
			}

			if (File.Exists(source) == false)
			{
				MessageBox.Show("Failed to convert because the source project file " +
					"doesn't exist!");
				return;
			}

			if (String.IsNullOrEmpty(dest))
			{
				MessageBox.Show("Failed to convert because you need to enter a " +
					"destination filepath!");
				return;
			}

			// TODO: convert
		}
	}
}
