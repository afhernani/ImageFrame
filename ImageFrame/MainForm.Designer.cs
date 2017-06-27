/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 23/05/2017
 * Hora: 19:24
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ImageFrame
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnInabilita;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.PictureBox pictureBox;
		
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
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnInabilita = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.label = new System.Windows.Forms.Label();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOpen
			// 
			this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpen.BackColor = System.Drawing.Color.Orange;
			this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpen.Location = new System.Drawing.Point(293, 12);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(82, 29);
			this.btnOpen.TabIndex = 1;
			this.btnOpen.Text = "Open";
			this.btnOpen.UseVisualStyleBackColor = false;
			this.btnOpen.Click += new System.EventHandler(this.BtnOpenClick);
			// 
			// btnInabilita
			// 
			this.btnInabilita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnInabilita.BackColor = System.Drawing.Color.Orange;
			this.btnInabilita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInabilita.Location = new System.Drawing.Point(293, 47);
			this.btnInabilita.Name = "btnInabilita";
			this.btnInabilita.Size = new System.Drawing.Size(82, 29);
			this.btnInabilita.TabIndex = 2;
			this.btnInabilita.Text = "Inabilita";
			this.btnInabilita.UseVisualStyleBackColor = false;
			this.btnInabilita.Click += new System.EventHandler(this.BtnInabilitaClick);
			// 
			// btnNext
			// 
			this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNext.BackColor = System.Drawing.Color.Orange;
			this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.Location = new System.Drawing.Point(293, 82);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(82, 29);
			this.btnNext.TabIndex = 4;
			this.btnNext.Text = "Siguiente";
			this.btnNext.UseVisualStyleBackColor = false;
			this.btnNext.Click += new System.EventHandler(this.BtnNextClick);
			// 
			// label
			// 
			this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label.Location = new System.Drawing.Point(295, 124);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(82, 24);
			this.label.TabIndex = 5;
			this.label.Text = "0";
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(13, 20);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(267, 223);
			this.pictureBox.TabIndex = 6;
			this.pictureBox.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(387, 260);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.label);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnInabilita);
			this.Controls.Add(this.btnOpen);
			this.Name = "MainForm";
			this.Text = "ImageFrame";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
