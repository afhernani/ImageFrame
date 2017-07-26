/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 22/06/2017
 * Hora: 14:20
 * 
 * 
 */
using System;
using System.IO;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ImageFrame
{
	/// <summary>
	/// Description of SpritePane.
	/// </summary>
	[Serializable, XmlRoot("SpritePane", Namespace = "", IsNullable = false)]
	public partial class SpritePane : UserControl
	{
		
		public SpritePane()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw |
			ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
			
			Time = 800;
			Accion = false;
			CurrentFrame = -1;
			//this.Invalidate(this.ClientRectangle);
		}
		
		public SpritePane(string path)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw |
			ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
			
			if (Path.GetExtension(path).ToUpper() == ".gif".ToUpper()) {
				_imagegif = new ImageGif(path);
			}
			
			Time = 800;
			Accion = false;
			CurrentFrame = -1;
			this.Invalidate(this.ClientRectangle);
		}
		
		public PictureBoxSizeMode SizeMode{ get; set; }
		[NonSerialized]
		private Thread t;
		[NonSerialized]
		private ImageGif _imagegif = null;
		private int CurrentFrame{ get; set; }
		
		
		public Image GetImage {
			get { 
				if (_imagegif != null) {
					
					return (Image)_imagegif.GetFrame(_imagegif.CurrentFrame).Clone();
				} else {
					return new Bitmap(this.Width, this.Height);
				}
			}
		}
		
		public ImageGif SetImageGif { 
			set { 
				_imagegif = value;
				Invalidate(this.ClientRectangle);
			}
			get {
				return _imagegif;
			}
		}
		
		private void ActionImagen()
		{
			do {/*
				Image newImage = new Bitmap(this.Width, this.Height, PixelFormat.Format64bppPArgb);
                
				using (Graphics g = this.CreateGraphics()) {
					g.Clear(this.BackColor); //produce pantallazo.
					g.SmoothingMode = SmoothingMode.AntiAlias;
					g.InterpolationMode = InterpolationMode.HighQualityBicubic;
					g.PixelOffsetMode = PixelOffsetMode.HighQuality;
					switch (SizeMode) {
						case PictureBoxSizeMode.Normal:
							g.DrawImage(_imagegif.GetNextFrame(), 0, 0,
								new RectangleF(0, 0, this.Width, this.Height), 
								GraphicsUnit.Pixel);
							break;
						case PictureBoxSizeMode.Zoom:
							g.DrawImage(LibUtility.Utility.ResizeImage(_imagegif.GetNextFrame(), this.Width, this.Height, true), 0, 0, 
								new RectangleF(0, 0, this.Width, this.Height), 
								GraphicsUnit.Pixel);				
							break;	
					}
				}*/
				using (PaintEventArgs e = new PaintEventArgs(this.CreateGraphics(), ClientRectangle)) {
					OnPaint(e);
					//OnPaint(e);
				}
				Debug.WriteLine("dibujando image ...{" + _imagegif.CurrentFrame + "}");
				Thread.Sleep(Time);
				
                
			} while (Accion);
		}
		//[XmlSerializable]
		private bool Accion{ get; set; }
		
		//[XmlSerializable]
		public int Time { get; set; }
		
		void SpritePaneMouseHover(object sender, EventArgs e)
		{
			if (t != null)
			if (t.IsAlive)
				return;
			if (_imagegif == null)
				return;
			System.Action action = ActionImagen;
			t = new Thread(ActionImagen);
			t.Start();
			Debug.WriteLine("SpritePane.MouseHove()...");
		}
		void SpritePaneMouseEnter(object sender, EventArgs e)
		{
			Debug.WriteLine("MouseEnter ...");
			Accion = true;
		}
		void SpritePaneMouseLeave(object sender, EventArgs e)
		{
			Debug.WriteLine("Mouseleave ...");
			Accion = false;
			if (t != null)
				t.Abort();
		}
		public void SaveGif(string pathfile)
		{
			if (_imagegif != null && Path.GetExtension(pathfile).ToUpper().Equals(".GIF")) {
				_imagegif.SaveImageGif(pathfile);
			}
		}
		
		protected override void OnPaint(PaintEventArgs e)
		{
			Debug.WriteLine("OnPaint");
			if (_imagegif != null && Accion==true)
				DrawNextFrame(e);
			if (_imagegif != null && Accion == false)
				DrawCurrentFrame(e);
			base.OnPaint(e);		
		}
		/// <summary>
		/// complementa OnPaint(PaintEventArgs e)
		/// </summary>
		/// <param name="e"></param>
		private void DrawNextFrame(PaintEventArgs e)
		{
			Image newImage = new Bitmap(this.Width, this.Height, PixelFormat.Format64bppPArgb);
                
			{
				switch (SizeMode) {
					case PictureBoxSizeMode.Normal:
						e.Graphics.DrawImage(_imagegif.GetNextFrame(), 0, 0,
							new RectangleF(0, 0, this.Width, this.Height), 
							GraphicsUnit.Pixel);
						break;
					case PictureBoxSizeMode.Zoom:
						e.Graphics.DrawImage(LibUtility.Utility.ResizeImage(_imagegif.GetNextFrame(), this.Width, this.Height, true), 0, 0, 
							new RectangleF(0, 0, this.Width, this.Height), 
							GraphicsUnit.Pixel);				
						break;	
				}
				CurrentFrame = _imagegif.CurrentFrame;
			}
		}
		private void DrawCurrentFrame(PaintEventArgs e)
		{
			if (CurrentFrame == -1)
				CurrentFrame = 0;
			Image newImage = new Bitmap(this.Width, this.Height, PixelFormat.Format64bppPArgb);
                
			{
				switch (SizeMode) {
					case PictureBoxSizeMode.Normal:
						e.Graphics.DrawImage(_imagegif.GetFrame(CurrentFrame), 0, 0,
							new RectangleF(0, 0, this.Width, this.Height), 
							GraphicsUnit.Pixel);
						break;
					case PictureBoxSizeMode.Zoom:
						e.Graphics.DrawImage(LibUtility.Utility.ResizeImage(_imagegif.GetFrame(CurrentFrame), this.Width, this.Height, true), 0, 0, 
							new RectangleF(0, 0, this.Width, this.Height), 
							GraphicsUnit.Pixel);				
						break;	
				}
			}
		}
	}
}
