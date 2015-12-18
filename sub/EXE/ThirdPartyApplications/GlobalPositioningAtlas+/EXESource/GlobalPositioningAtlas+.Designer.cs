namespace GlobalPositioningAtlas
{
    partial class GlobalPositioningAtlas
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlobalPositioningAtlas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonUP = new System.Windows.Forms.Button();
            this.buttonDOWN = new System.Windows.Forms.Button();
            this.buttonLEFT = new System.Windows.Forms.Button();
            this.buttonRIGHT = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chooseFacetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feluccaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trammelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilshenarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tokunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terMurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 432);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonUP
            // 
            this.buttonUP.Image = ((System.Drawing.Image)(resources.GetObject("buttonUP.Image")));
            this.buttonUP.Location = new System.Drawing.Point(636, 355);
            this.buttonUP.Name = "buttonUP";
            this.buttonUP.Size = new System.Drawing.Size(43, 40);
            this.buttonUP.TabIndex = 1;
            this.buttonUP.UseVisualStyleBackColor = true;
            this.buttonUP.Click += new System.EventHandler(this.buttonUP_Click);
            // 
            // buttonDOWN
            // 
            this.buttonDOWN.Image = ((System.Drawing.Image)(resources.GetObject("buttonDOWN.Image")));
            this.buttonDOWN.Location = new System.Drawing.Point(636, 439);
            this.buttonDOWN.Name = "buttonDOWN";
            this.buttonDOWN.Size = new System.Drawing.Size(43, 40);
            this.buttonDOWN.TabIndex = 2;
            this.buttonDOWN.UseVisualStyleBackColor = true;
            this.buttonDOWN.Click += new System.EventHandler(this.buttonDOWN_Click);
            // 
            // buttonLEFT
            // 
            this.buttonLEFT.Image = ((System.Drawing.Image)(resources.GetObject("buttonLEFT.Image")));
            this.buttonLEFT.Location = new System.Drawing.Point(590, 398);
            this.buttonLEFT.Name = "buttonLEFT";
            this.buttonLEFT.Size = new System.Drawing.Size(43, 40);
            this.buttonLEFT.TabIndex = 3;
            this.buttonLEFT.UseVisualStyleBackColor = true;
            this.buttonLEFT.Click += new System.EventHandler(this.buttonLEFT_Click);
            // 
            // buttonRIGHT
            // 
            this.buttonRIGHT.Image = ((System.Drawing.Image)(resources.GetObject("buttonRIGHT.Image")));
            this.buttonRIGHT.Location = new System.Drawing.Point(679, 398);
            this.buttonRIGHT.Name = "buttonRIGHT";
            this.buttonRIGHT.Size = new System.Drawing.Size(43, 40);
            this.buttonRIGHT.TabIndex = 4;
            this.buttonRIGHT.UseVisualStyleBackColor = true;
            this.buttonRIGHT.Click += new System.EventHandler(this.buttonRIGHT_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseFacetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 32);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chooseFacetToolStripMenuItem
            // 
            this.chooseFacetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feluccaToolStripMenuItem,
            this.trammelToolStripMenuItem,
            this.malasToolStripMenuItem,
            this.ilshenarToolStripMenuItem,
            this.tokunoToolStripMenuItem,
            this.terMurToolStripMenuItem});
            this.chooseFacetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("chooseFacetToolStripMenuItem.Image")));
            this.chooseFacetToolStripMenuItem.Name = "chooseFacetToolStripMenuItem";
            this.chooseFacetToolStripMenuItem.Size = new System.Drawing.Size(105, 28);
            this.chooseFacetToolStripMenuItem.Text = "Select Facet";
            // 
            // feluccaToolStripMenuItem
            // 
            this.feluccaToolStripMenuItem.Name = "feluccaToolStripMenuItem";
            this.feluccaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.feluccaToolStripMenuItem.Text = "Felucca";
            this.feluccaToolStripMenuItem.Click += new System.EventHandler(this.feluccaToolStripMenuItem_Click);
            // 
            // trammelToolStripMenuItem
            // 
            this.trammelToolStripMenuItem.Name = "trammelToolStripMenuItem";
            this.trammelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.trammelToolStripMenuItem.Text = "Trammel";
            this.trammelToolStripMenuItem.Click += new System.EventHandler(this.trammelToolStripMenuItem_Click);
            // 
            // malasToolStripMenuItem
            // 
            this.malasToolStripMenuItem.Name = "malasToolStripMenuItem";
            this.malasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.malasToolStripMenuItem.Text = "Malas";
            this.malasToolStripMenuItem.Click += new System.EventHandler(this.malasToolStripMenuItem_Click);
            // 
            // ilshenarToolStripMenuItem
            // 
            this.ilshenarToolStripMenuItem.Name = "ilshenarToolStripMenuItem";
            this.ilshenarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ilshenarToolStripMenuItem.Text = "Ilshenar";
            this.ilshenarToolStripMenuItem.Click += new System.EventHandler(this.ilshenarToolStripMenuItem_Click);
            // 
            // tokunoToolStripMenuItem
            // 
            this.tokunoToolStripMenuItem.Name = "tokunoToolStripMenuItem";
            this.tokunoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tokunoToolStripMenuItem.Text = "Tokuno";
            this.tokunoToolStripMenuItem.Click += new System.EventHandler(this.tokunoToolStripMenuItem_Click);
            // 
            // terMurToolStripMenuItem
            // 
            this.terMurToolStripMenuItem.Name = "terMurToolStripMenuItem";
            this.terMurToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.terMurToolStripMenuItem.Text = "TerMur";
            this.terMurToolStripMenuItem.Click += new System.EventHandler(this.terMurToolStripMenuItem_Click);
            // 
            // GlobalPositioningAtlas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 505);
            this.Controls.Add(this.buttonRIGHT);
            this.Controls.Add(this.buttonLEFT);
            this.Controls.Add(this.buttonDOWN);
            this.Controls.Add(this.buttonUP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GlobalPositioningAtlas";
            this.Text = "Ultima Online™ Map Creator:  Global Positioning Atlas+";
            this.Load += new System.EventHandler(this.GlobalPositioningAtlas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonUP;
        private System.Windows.Forms.Button buttonDOWN;
        private System.Windows.Forms.Button buttonLEFT;
        private System.Windows.Forms.Button buttonRIGHT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chooseFacetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feluccaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trammelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilshenarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tokunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terMurToolStripMenuItem;
    }
}

