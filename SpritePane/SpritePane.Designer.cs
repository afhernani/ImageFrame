/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 22/06/2017
 * Hora: 14:20
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace LibPanes
{
	partial class SpritePane
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			this.SuspendLayout();
			// 
			// SpritePane
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.DoubleBuffered = true;
			this.Name = "SpritePane";
			this.Size = new System.Drawing.Size(238, 140);
			this.MouseEnter += new System.EventHandler(this.SpritePaneMouseEnter);
			this.MouseLeave += new System.EventHandler(this.SpritePaneMouseLeave);
			this.MouseHover += new System.EventHandler(this.SpritePaneMouseHover);
			this.ResumeLayout(false);

		}
	}
}
