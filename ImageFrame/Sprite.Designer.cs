/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 22/06/2017
 * Hora: 16:15
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ImageFrame
{
	partial class Sprite
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private ImageFrame.SpritePane spritePane1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.spritePane1 = new ImageFrame.SpritePane();
			this.SuspendLayout();
			// 
			// spritePane1
			// 
			this.spritePane1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.spritePane1.BackColor = System.Drawing.Color.Yellow;
			this.spritePane1.Location = new System.Drawing.Point(9, 12);
			this.spritePane1.Name = "spritePane1";
			this.spritePane1.SetImageGif = null;
			this.spritePane1.Size = new System.Drawing.Size(252, 150);
			this.spritePane1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.spritePane1.TabIndex = 0;
			this.spritePane1.Time = 800;
			this.spritePane1.Click += new System.EventHandler(this.SpritePane1Click);
			this.spritePane1.MouseHover += new System.EventHandler(this.SpritePane1MouseHover);
			// 
			// Sprite
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(273, 174);
			this.Controls.Add(this.spritePane1);
			this.DoubleBuffered = true;
			this.Name = "Sprite";
			this.Text = "Sprite";
			this.ResumeLayout(false);

		}
	}
}
