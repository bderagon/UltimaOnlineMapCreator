namespace ServerFacetRegionEditor
{
    partial class RegionEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegionEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compatible = new System.Windows.Forms.ToolStripMenuItem();
            this.facetPathLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regionsXMLPathLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshRegionsxmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.facetList = new System.Windows.Forms.ComboBox();
            this.ShowMapButton = new System.Windows.Forms.Button();
            this.renderProgress = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.facetView = new System.Windows.Forms.TreeView();
            this.newRegion = new System.Windows.Forms.Button();
            this.modifyRegion = new System.Windows.Forms.Button();
            this.removeRegion = new System.Windows.Forms.Button();
            this.addSpawn = new System.Windows.Forms.Button();
            this.removeSpawn = new System.Windows.Forms.Button();
            this.addSubRegion = new System.Windows.Forms.Button();
            this.addArea = new System.Windows.Forms.Button();
            this.removeArea = new System.Windows.Forms.Button();
            this.areaModify = new System.Windows.Forms.Button();
            this.modifySpawn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.clearFacet = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.goY = new ServerFacetRegionEditor.FilteredTextBox();
            this.goX = new ServerFacetRegionEditor.FilteredTextBox();
            this.scaleSlider = new ServerFacetRegionEditor.Slider();
            this.ySlider = new ServerFacetRegionEditor.Slider();
            this.xSlider = new ServerFacetRegionEditor.Slider();
            this.mapDisplay = new ServerFacetRegionEditor.MapDisplay();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.facetPathLocationToolStripMenuItem,
            this.regionsXMLPathLocationToolStripMenuItem,
            this.refreshRegionsxmlToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.mainMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1266, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compatible});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 32);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Visible = false;
            // 
            // compatible
            // 
            this.compatible.CheckOnClick = true;
            this.compatible.Name = "compatible";
            this.compatible.Size = new System.Drawing.Size(281, 22);
            this.compatible.Text = "Enable Compatibility with Older Clients";
            this.compatible.CheckedChanged += new System.EventHandler(this.compatible_CheckedChanged);
            // 
            // facetPathLocationToolStripMenuItem
            // 
            this.facetPathLocationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("facetPathLocationToolStripMenuItem.Image")));
            this.facetPathLocationToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.facetPathLocationToolStripMenuItem.Name = "facetPathLocationToolStripMenuItem";
            this.facetPathLocationToolStripMenuItem.Size = new System.Drawing.Size(167, 28);
            this.facetPathLocationToolStripMenuItem.Text = "Map.mul Path Location";
            this.facetPathLocationToolStripMenuItem.Click += new System.EventHandler(this.facetPathLocationToolStripMenuItem_Click);
            // 
            // regionsXMLPathLocationToolStripMenuItem
            // 
            this.regionsXMLPathLocationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("regionsXMLPathLocationToolStripMenuItem.Image")));
            this.regionsXMLPathLocationToolStripMenuItem.Name = "regionsXMLPathLocationToolStripMenuItem";
            this.regionsXMLPathLocationToolStripMenuItem.Size = new System.Drawing.Size(183, 32);
            this.regionsXMLPathLocationToolStripMenuItem.Text = "Regions.xml Path Location";
            this.regionsXMLPathLocationToolStripMenuItem.Click += new System.EventHandler(this.regionsXMLPathLocationToolStripMenuItem_Click);
            // 
            // refreshRegionsxmlToolStripMenuItem
            // 
            this.refreshRegionsxmlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshRegionsxmlToolStripMenuItem.Image")));
            this.refreshRegionsxmlToolStripMenuItem.Name = "refreshRegionsxmlToolStripMenuItem";
            this.refreshRegionsxmlToolStripMenuItem.Size = new System.Drawing.Size(198, 32);
            this.refreshRegionsxmlToolStripMenuItem.Text = "Reload Regions.xml From File";
            this.refreshRegionsxmlToolStripMenuItem.Click += new System.EventHandler(this.refreshRegionsxmlToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(505, 0, 0, 0);
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(92, 32);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mainMenuToolStripMenuItem.Image")));
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(104, 32);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Facet";
            // 
            // facetList
            // 
            this.facetList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facetList.FormattingEnabled = true;
            this.facetList.Items.AddRange(new object[] {
            "Felucca",
            "Trammel",
            "Ilshenar",
            "Malas",
            "Tokuno",
            "Ter Mur"});
            this.facetList.Location = new System.Drawing.Point(49, 50);
            this.facetList.Name = "facetList";
            this.facetList.Size = new System.Drawing.Size(166, 21);
            this.facetList.TabIndex = 12;
            this.facetList.TabStop = false;
            this.facetList.SelectedIndexChanged += new System.EventHandler(this.facetList_SelectedIndexChanged);
            // 
            // ShowMapButton
            // 
            this.ShowMapButton.Location = new System.Drawing.Point(746, 48);
            this.ShowMapButton.Name = "ShowMapButton";
            this.ShowMapButton.Size = new System.Drawing.Size(95, 23);
            this.ShowMapButton.TabIndex = 13;
            this.ShowMapButton.TabStop = false;
            this.ShowMapButton.Text = "Map Display";
            this.ShowMapButton.UseVisualStyleBackColor = true;
            this.ShowMapButton.Click += new System.EventHandler(this.ShowMapButton_Click);
            // 
            // renderProgress
            // 
            this.renderProgress.Location = new System.Drawing.Point(847, 48);
            this.renderProgress.Name = "renderProgress";
            this.renderProgress.Size = new System.Drawing.Size(405, 23);
            this.renderProgress.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location :";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(300, 54);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(25, 13);
            this.locationLabel.TabIndex = 3;
            this.locationLabel.Text = "0, 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Map Scale";
            // 
            // facetView
            // 
            this.facetView.Location = new System.Drawing.Point(730, 107);
            this.facetView.Name = "facetView";
            this.facetView.Size = new System.Drawing.Size(398, 377);
            this.facetView.TabIndex = 15;
            this.facetView.TabStop = false;
            this.facetView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.facetView_AfterSelect);
            this.facetView.DoubleClick += new System.EventHandler(this.facetView_DoubleClick);
            // 
            // newRegion
            // 
            this.newRegion.Location = new System.Drawing.Point(1157, 107);
            this.newRegion.Name = "newRegion";
            this.newRegion.Size = new System.Drawing.Size(95, 23);
            this.newRegion.TabIndex = 16;
            this.newRegion.TabStop = false;
            this.newRegion.Text = "New Region";
            this.newRegion.UseVisualStyleBackColor = true;
            this.newRegion.Click += new System.EventHandler(this.newRegion_Click);
            // 
            // modifyRegion
            // 
            this.modifyRegion.Enabled = false;
            this.modifyRegion.Location = new System.Drawing.Point(1157, 165);
            this.modifyRegion.Name = "modifyRegion";
            this.modifyRegion.Size = new System.Drawing.Size(95, 23);
            this.modifyRegion.TabIndex = 18;
            this.modifyRegion.TabStop = false;
            this.modifyRegion.Text = "Modify Region";
            this.modifyRegion.UseVisualStyleBackColor = true;
            this.modifyRegion.Click += new System.EventHandler(this.modifyRegion_Click);
            // 
            // removeRegion
            // 
            this.removeRegion.Enabled = false;
            this.removeRegion.Location = new System.Drawing.Point(1157, 194);
            this.removeRegion.Name = "removeRegion";
            this.removeRegion.Size = new System.Drawing.Size(95, 23);
            this.removeRegion.TabIndex = 19;
            this.removeRegion.TabStop = false;
            this.removeRegion.Text = "Remove Region";
            this.removeRegion.UseVisualStyleBackColor = true;
            this.removeRegion.Click += new System.EventHandler(this.removeRegion_Click);
            // 
            // addSpawn
            // 
            this.addSpawn.Enabled = false;
            this.addSpawn.Location = new System.Drawing.Point(1157, 354);
            this.addSpawn.Name = "addSpawn";
            this.addSpawn.Size = new System.Drawing.Size(95, 23);
            this.addSpawn.TabIndex = 20;
            this.addSpawn.TabStop = false;
            this.addSpawn.Text = "Add Spawn";
            this.addSpawn.UseVisualStyleBackColor = true;
            this.addSpawn.Click += new System.EventHandler(this.addSpawn_Click);
            // 
            // removeSpawn
            // 
            this.removeSpawn.Enabled = false;
            this.removeSpawn.Location = new System.Drawing.Point(1157, 412);
            this.removeSpawn.Name = "removeSpawn";
            this.removeSpawn.Size = new System.Drawing.Size(95, 23);
            this.removeSpawn.TabIndex = 22;
            this.removeSpawn.TabStop = false;
            this.removeSpawn.Text = "Remove Spawn";
            this.removeSpawn.UseVisualStyleBackColor = true;
            this.removeSpawn.Click += new System.EventHandler(this.removeSpawn_Click);
            // 
            // addSubRegion
            // 
            this.addSubRegion.Enabled = false;
            this.addSubRegion.Location = new System.Drawing.Point(1157, 136);
            this.addSubRegion.Name = "addSubRegion";
            this.addSubRegion.Size = new System.Drawing.Size(95, 23);
            this.addSubRegion.TabIndex = 17;
            this.addSubRegion.TabStop = false;
            this.addSubRegion.Text = "Add SubRegion";
            this.addSubRegion.UseVisualStyleBackColor = true;
            this.addSubRegion.Click += new System.EventHandler(this.addSubRegion_Click);
            // 
            // addArea
            // 
            this.addArea.Enabled = false;
            this.addArea.Location = new System.Drawing.Point(1157, 246);
            this.addArea.Name = "addArea";
            this.addArea.Size = new System.Drawing.Size(95, 23);
            this.addArea.TabIndex = 23;
            this.addArea.TabStop = false;
            this.addArea.Text = "Add Area";
            this.addArea.UseVisualStyleBackColor = true;
            this.addArea.Click += new System.EventHandler(this.addArea_Click);
            // 
            // removeArea
            // 
            this.removeArea.Enabled = false;
            this.removeArea.Location = new System.Drawing.Point(1157, 304);
            this.removeArea.Name = "removeArea";
            this.removeArea.Size = new System.Drawing.Size(95, 23);
            this.removeArea.TabIndex = 25;
            this.removeArea.TabStop = false;
            this.removeArea.Text = "Remove Area";
            this.removeArea.UseVisualStyleBackColor = true;
            this.removeArea.Click += new System.EventHandler(this.removeArea_Click);
            // 
            // areaModify
            // 
            this.areaModify.Enabled = false;
            this.areaModify.Location = new System.Drawing.Point(1157, 275);
            this.areaModify.Name = "areaModify";
            this.areaModify.Size = new System.Drawing.Size(95, 23);
            this.areaModify.TabIndex = 24;
            this.areaModify.TabStop = false;
            this.areaModify.Text = "Modify Area";
            this.areaModify.UseVisualStyleBackColor = true;
            this.areaModify.Click += new System.EventHandler(this.areaModify_Click);
            // 
            // modifySpawn
            // 
            this.modifySpawn.Enabled = false;
            this.modifySpawn.Location = new System.Drawing.Point(1157, 383);
            this.modifySpawn.Name = "modifySpawn";
            this.modifySpawn.Size = new System.Drawing.Size(95, 23);
            this.modifySpawn.TabIndex = 21;
            this.modifySpawn.TabStop = false;
            this.modifySpawn.Text = "Modify Spawn";
            this.modifySpawn.UseVisualStyleBackColor = true;
            this.modifySpawn.Click += new System.EventHandler(this.modifySpawn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Y";
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(492, 48);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(85, 23);
            this.goButton.TabIndex = 8;
            this.goButton.Text = "View Location";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // clearFacet
            // 
            this.clearFacet.Location = new System.Drawing.Point(1157, 461);
            this.clearFacet.Name = "clearFacet";
            this.clearFacet.Size = new System.Drawing.Size(95, 23);
            this.clearFacet.TabIndex = 26;
            this.clearFacet.TabStop = false;
            this.clearFacet.Text = "Clear Facet";
            this.clearFacet.UseVisualStyleBackColor = true;
            this.clearFacet.Click += new System.EventHandler(this.clearFacet_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-4, 34);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1408, 6);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 47;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-25, 80);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1477, 6);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1140, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(7, 469);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1157, 230);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 6);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 50;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1157, 338);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(95, 6);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 51;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1157, 445);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(95, 6);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 52;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(-73, 520);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(1477, 6);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 53;
            this.pictureBox7.TabStop = false;
            // 
            // goY
            // 
            this.goY.AllowedChars = "1234567890";
            this.goY.Location = new System.Drawing.Point(445, 51);
            this.goY.MaxLength = 4;
            this.goY.Name = "goY";
            this.goY.Size = new System.Drawing.Size(32, 20);
            this.goY.TabIndex = 7;
            // 
            // goX
            // 
            this.goX.AllowedChars = "1234567890";
            this.goX.Location = new System.Drawing.Point(386, 51);
            this.goX.MaxLength = 4;
            this.goX.Name = "goX";
            this.goX.Size = new System.Drawing.Size(32, 20);
            this.goX.TabIndex = 5;
            // 
            // scaleSlider
            // 
            this.scaleSlider.Location = new System.Drawing.Point(595, 490);
            this.scaleSlider.Maximum = 6;
            this.scaleSlider.MaximumSize = new System.Drawing.Size(1000, 22);
            this.scaleSlider.MinimumSize = new System.Drawing.Size(100, 22);
            this.scaleSlider.Name = "scaleSlider";
            this.scaleSlider.Size = new System.Drawing.Size(100, 22);
            this.scaleSlider.TabIndex = 10;
            this.scaleSlider.TabStop = false;
            this.scaleSlider.Value = 6;
            this.scaleSlider.SliderMoveComplete += new System.EventHandler(this.scaleSlider_SliderMoveComplete);
            // 
            // ySlider
            // 
            this.ySlider.Location = new System.Drawing.Point(701, 107);
            this.ySlider.MaximumSize = new System.Drawing.Size(22, 1000);
            this.ySlider.MinimumSize = new System.Drawing.Size(22, 100);
            this.ySlider.Name = "ySlider";
            this.ySlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ySlider.Size = new System.Drawing.Size(22, 377);
            this.ySlider.SmallChange = 5;
            this.ySlider.TabIndex = 0;
            this.ySlider.TabStop = false;
            this.ySlider.ValueChanged += new System.EventHandler(this.Slider_ValueChanged);
            this.ySlider.SliderMoveComplete += new System.EventHandler(this.Slider_SliderMoveComplete);
            // 
            // xSlider
            // 
            this.xSlider.Location = new System.Drawing.Point(12, 490);
            this.xSlider.MaximumSize = new System.Drawing.Size(1024, 22);
            this.xSlider.MinimumSize = new System.Drawing.Size(100, 22);
            this.xSlider.Name = "xSlider";
            this.xSlider.Size = new System.Drawing.Size(497, 22);
            this.xSlider.SmallChange = 5;
            this.xSlider.TabIndex = 1;
            this.xSlider.TabStop = false;
            this.xSlider.ValueChanged += new System.EventHandler(this.Slider_ValueChanged);
            this.xSlider.SliderMoveComplete += new System.EventHandler(this.Slider_SliderMoveComplete);
            // 
            // mapDisplay
            // 
            this.mapDisplay.Location = new System.Drawing.Point(12, 107);
            this.mapDisplay.MapScale = ServerFacetRegionEditor.Scaling.Scale30;
            this.mapDisplay.Name = "mapDisplay";
            this.mapDisplay.Size = new System.Drawing.Size(683, 377);
            this.mapDisplay.TabIndex = 6;
            this.mapDisplay.TabStop = false;
            this.mapDisplay.HoverCoordinatedChanged += new System.EventHandler(this.mapDisplay_HoverCoordinatedChanged);
            // 
            // RegionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 533);
            this.Controls.Add(this.renderProgress);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.clearFacet);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.goY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.goX);
            this.Controls.Add(this.modifySpawn);
            this.Controls.Add(this.areaModify);
            this.Controls.Add(this.removeArea);
            this.Controls.Add(this.addArea);
            this.Controls.Add(this.addSubRegion);
            this.Controls.Add(this.removeSpawn);
            this.Controls.Add(this.addSpawn);
            this.Controls.Add(this.removeRegion);
            this.Controls.Add(this.modifyRegion);
            this.Controls.Add(this.newRegion);
            this.Controls.Add(this.facetView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scaleSlider);
            this.Controls.Add(this.ySlider);
            this.Controls.Add(this.xSlider);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mapDisplay);
            this.Controls.Add(this.ShowMapButton);
            this.Controls.Add(this.facetList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegionEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultima Online™ Map Creator:  Server Facet Region Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegionEditor_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox facetList;
        private System.Windows.Forms.Button ShowMapButton;
        private System.Windows.Forms.ProgressBar renderProgress;
        private MapDisplay mapDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label locationLabel;
        private Slider xSlider;
        private Slider ySlider;
        private Slider scaleSlider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView facetView;
        private System.Windows.Forms.Button newRegion;
        private System.Windows.Forms.Button modifyRegion;
        private System.Windows.Forms.Button removeRegion;
        private System.Windows.Forms.Button addSpawn;
        private System.Windows.Forms.Button removeSpawn;
        private System.Windows.Forms.Button addSubRegion;
        private System.Windows.Forms.Button addArea;
        private System.Windows.Forms.Button removeArea;
        private System.Windows.Forms.Button areaModify;
        private System.Windows.Forms.Button modifySpawn;
        private FilteredTextBox goX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FilteredTextBox goY;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button clearFacet;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compatible;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.ToolStripMenuItem facetPathLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regionsXMLPathLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshRegionsxmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
    }
}

