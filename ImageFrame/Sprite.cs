/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 22/06/2017
 * Hora: 16:15
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace ImageFrame
{
    /// <summary>
    /// Description of Sprite.
    /// </summary>
    public partial class Sprite : Form
    {
        public Sprite()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.ResizeRedraw = true;
        }

        string filename = string.Empty;
        string name_Only;

        void SpritePane1Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog()
            {
                Filter = "Gif file(*.gif*)|*.gif|All files(*.*)|*.*",
                Title = @"Open gif to load",
                InitialDirectory = Environment.CurrentDirectory,
                RestoreDirectory = true,
                Multiselect = true
            };

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                filename = openfile.FileName;
                name_Only = openfile.SafeFileName;
                if (Path.GetExtension(filename).ToUpper().Equals(".GIF"))
                {
                    //imagegif = new ImageGif(filename);
                    spritePane1.SetImageGif = new ImageGif(filename);
					//spritePane1.Refresh();
                    //spritePane1.InitialImage(0);
                    //label.Text = imagegif.Count.ToString();
                    spritePane1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                foreach (var item in openfile.FileNames)
                {
                    if (Path.GetExtension(item).ToUpper().Equals(".JPG") || Path.GetExtension(item).ToUpper().Equals(".PNG"))
                    {
                        if (spritePane1.SetImageGif == null)
                        {
                            spritePane1.SetImageGif = new ImageGif();
                            spritePane1.SetImageGif.AddImage((Image)Image.FromFile(item).Clone());
                            spritePane1.InitialImage(0);
                        }
                        else
                        {
                            spritePane1.SetImageGif.AddImage((Image)Image.FromFile(item).Clone());
                        }
                    }

                }
            }
        }
        void SpritePane1MouseHover(object sender, EventArgs e)
        {
            Debug.WriteLine("SpritePane1.MouseHover()....");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.G))
            {
                Debug.WriteLine("<CTRL> + Alt + S Captured");
                SaveFileToDisk();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SaveFileToDisk()
        {
            SaveFileDialog savefile = new SaveFileDialog()
            {
                Filter = "Gif file(*.gif*)|*.gif",
                Title = @"Save gif to disk",
                InitialDirectory = Environment.CurrentDirectory,
                RestoreDirectory = true,
            };
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                spritePane1.SaveGif(savefile.FileName);
            }
        }
		
    }
}
