/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 23/05/2017
 * Hora: 19:24
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using LibPanes;

namespace ImageFrame
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
		
		string filename = string.Empty;
		string name_Only;
		ImageGif imagegif;
		void BtnOpenClick(object sender, EventArgs e)
		{
			OpenFileDialog openfile =new OpenFileDialog()
			{
				Filter = "Gif file(*.gif*)|*.gif",
				Title = @"Open gif to load",
				InitialDirectory = Environment.CurrentDirectory,
				RestoreDirectory = true
			};
			
			if(openfile.ShowDialog()==DialogResult.OK){
				filename = openfile.FileName;
				name_Only = openfile.SafeFileName;
				if(Path.GetExtension(filename).ToUpper().Equals(".GIF"))
				{
					imagegif = new ImageGif(filename);
					pictureBox.Image = imagegif.GetFrame(0);
					//label.Text = imagegif.Count.ToString();
				}
			}
		}
		
		void BtnInabilitaClick(object sender, EventArgs e)
		{
			pictureBox.Enabled = !pictureBox.Enabled;
		}
		
		void PictureBoxClick(object sender, EventArgs e)
		{
			Debug.WriteLine("Next frame ...");
			pictureBox.Image = imagegif.GetNextFrame();
		}
		void BtnNextClick(object sender, EventArgs e)
		{
			pictureBox.Image = imagegif.GetNextFrame();
		}
		
	}
}
