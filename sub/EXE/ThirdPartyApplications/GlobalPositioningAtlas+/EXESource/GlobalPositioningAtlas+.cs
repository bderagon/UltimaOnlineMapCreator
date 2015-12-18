using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ultima;

namespace GlobalPositioningAtlas
{
    public partial class GlobalPositioningAtlas : Form
    {
        public GlobalPositioningAtlas()
        {
            InitializeComponent();
        }

        private void GlobalPositioningAtlas_Load(object sender, EventArgs e)
        {
            //DrawMap();
        }

        int x = 0;
        int y = 0;

        Ultima.Map facet;

        #region Select Facet Menu Items

        private void feluccaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
                pictureBox1.Refresh();

            DrawMap();
            facet = Ultima.Map.InitializeMap("Felucca");
            
        }

        private void trammelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
                pictureBox1.Refresh();
            
            DrawMap();
            facet = Ultima.Map.InitializeMap("Trammel");        
        }

        private void malasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
                pictureBox1.Refresh();

            DrawMap();        
            facet = Ultima.Map.InitializeMap("Malas"); 
        }

        private void ilshenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
                pictureBox1.Refresh();

            DrawMap();
            facet = Ultima.Map.InitializeMap("Ilshenar");
        }

        private void tokunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
                pictureBox1.Refresh();

            DrawMap();
            facet = Ultima.Map.InitializeMap("Tokuno");
        }

        private void terMurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
                pictureBox1.Refresh();

            DrawMap();
            facet = Ultima.Map.InitializeMap("TerMur");
        }

        #endregion

        private void DrawMap()
        {
            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(pictureBox1.Image); //4704>>3, 3747>>3

            if (facet == null)
                facet = Ultima.Map.InitializeMap("Felucca");

            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            g.PageUnit = GraphicsUnit.Pixel;
            g.DrawImage(facet.GetImage(x >> 3, y >> 3, pictureBox1.Width >> 3, pictureBox1.Height >> 3, true), 0, 0);
            g.Dispose();

            pictureBox1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DrawMap();
        }

        #region Facet Navigation Arrows

        private void buttonUP_Click(object sender, EventArgs e)
        {
            y -= 50;
            DrawMap();
        }

        private void buttonDOWN_Click(object sender, EventArgs e)
        {
            y += 50;
            DrawMap();
        }

        private void buttonRIGHT_Click(object sender, EventArgs e)
        {
            x += 50;
            DrawMap();
        }

        private void buttonLEFT_Click(object sender, EventArgs e)
        {
            x -= 50;
            DrawMap();
        }

        #endregion
    }
}
