using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using maze;

namespace RandomCaveGenerator
{
    public partial class RandomCaveGenerator : Form
    {
        public RandomCaveGenerator()
        {
            InitializeComponent();
        }

        csCaveGenerator cavgen;
        Size blocksize = new Size(5, 5);

        private void Form1_Load(object sender, EventArgs e)
        {
            cavgen = new csCaveGenerator();
            prop.SelectedObject = cavgen;
        }

        private void Draw()
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            Graphics g = Graphics.FromImage(pictureBox1.Image);


            if (cavgen.Map == null) return;

            //draw the map
            using (SolidBrush sb = new SolidBrush(Color.Red), sb1 = new SolidBrush(Color.Blue))
            {
                Rectangle r = new Rectangle();
                r.Size = blocksize;

                for (int x = 0; x < cavgen.Map.GetLength(0); x++)
                    for (int y = 0; y < cavgen.Map.GetLength(1); y++)
                        if (cavgen.Map[x, y] == 1)
                            
                            g.FillRectangle(sb, new Rectangle(x * blocksize.Width, y * blocksize.Height, blocksize.Width, blocksize.Height));
                        else if (cavgen.Map[x, y] == 2)
                        {
                            g.FillRectangle(sb1, new Rectangle(x * blocksize.Width, y * blocksize.Height, blocksize.Width, blocksize.Height));
                        }

            }
            g.Dispose();

            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //if (cavgen.Map == null) return;
            //
            ////draw the map
            //using (SolidBrush sb = new SolidBrush(Color.Black), sb1 = new SolidBrush(Color.Blue))
            //{
            //    Rectangle r = new Rectangle();
            //    r.Size = blocksize;
            //
            //    for (int x = 0; x < cavgen.Map.GetLength(0); x++)
            //        for (int y = 0; y < cavgen.Map.GetLength(1); y++)
            //            if (cavgen.Map[x, y] == 1)
            //                e.Graphics.FillRectangle(sb, new Rectangle(x * blocksize.Width, y * blocksize.Height, blocksize.Width, blocksize.Height));
            //            else if (cavgen.Map[x, y] == 2)
            //            {
            //                e.Graphics.FillRectangle(sb1, new Rectangle(x * blocksize.Width, y * blocksize.Height, blocksize.Width, blocksize.Height));
            //            }
            //
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cavgen.Build();
            prop.Refresh();
            Draw();

            //pictureBox1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cavgen.ConnectCaves();
            Draw();

            //pictureBox1.Invalidate();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Images (*.png,*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
            if (this.saveFileDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = this.saveFileDialog1.FileName;
                this.pictureBox1.Image.Save(fileName);

                //  this.pictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
            }
        }

        private void resetFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cavgen = new csCaveGenerator();
            prop.SelectedObject = cavgen;
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This Snippet Hides One Form To Simulate Opening Another
            this.Hide();

            //This Snippet Launches An Application In Another Folder
            Directory.SetCurrentDirectory(@"../");
            Process.Start("UltimaOnlineMapCreator.exe");

            //This Snippet Exits The Application And Kills The Thread
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void RandomCaveGenerator_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}