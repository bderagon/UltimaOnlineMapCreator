using Altitude;
using Logger;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Terrain;

namespace DragonConv
{
	public class DragonConv : Form
	{
		[AccessedThroughProperty("MainMenu1")]
		private MainMenu _MainMenu1;

		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[AccessedThroughProperty("MenuItem1")]
		private MenuItem _MenuItem1;

		[AccessedThroughProperty("MenuUOLPath")]
		private MenuItem _MenuUOLPath;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;

		[AccessedThroughProperty("MenuDragonPath")]
		private MenuItem _MenuDragonPath;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("MenuConv")]
		private MenuItem _MenuConv;

		[AccessedThroughProperty("MenuItem2")]
		private MenuItem _MenuItem2;

		[AccessedThroughProperty("MenuDragonFile")]
		private MenuItem _MenuDragonFile;

		[AccessedThroughProperty("AltitudeFile")]
		private TextBox _AltitudeFile;

		[AccessedThroughProperty("TerrainFile")]
		private TextBox _TerrainFile;

		[AccessedThroughProperty("ProjectPath")]
		private TextBox _ProjectPath;

		[AccessedThroughProperty("ProjectName")]
		private TextBox _ProjectName;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("DragonPath")]
		private TextBox _DragonPath;

		[AccessedThroughProperty("DragonImage")]
		private TextBox _DragonImage;

		[AccessedThroughProperty("MenuUOLProjectName")]
		private MenuItem _MenuUOLProjectName;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		[AccessedThroughProperty("ComboBox1")]
		private ComboBox _ComboBox1;

		private Bitmap i_Dragon;

		private Bitmap i_Terrain;

		private Bitmap i_Altitude;

		private ClsTerrainTable iTerrain;

		private ClsAltitudeTable iAltitude;

		private ClsDragonTable iDragon;

		public LoggerForm iLogger;

		private IContainer components;

		internal virtual TextBox AltitudeFile
		{
			get
			{
				return this._AltitudeFile;
			}
			set
			{
				this._AltitudeFile == null;
				this._AltitudeFile = value;
				this._AltitudeFile == null;
			}
		}

		internal virtual ComboBox ComboBox1
		{
			get
			{
				return this._ComboBox1;
			}
			set
			{
				if (this._ComboBox1 != null)
				{
					DragonConv dragonConv = this;
					this._ComboBox1.remove_SelectedIndexChanged(new EventHandler(dragonConv, dragonConv.ComboBox1_SelectedIndexChanged));
				}
				this._ComboBox1 = value;
				if (this._ComboBox1 != null)
				{
					DragonConv dragonConv1 = this;
					this._ComboBox1.add_SelectedIndexChanged(new EventHandler(dragonConv1, dragonConv1.ComboBox1_SelectedIndexChanged));
				}
			}
		}

		internal virtual TextBox DragonImage
		{
			get
			{
				return this._DragonImage;
			}
			set
			{
				this._DragonImage == null;
				this._DragonImage = value;
				this._DragonImage == null;
			}
		}

		internal virtual TextBox DragonPath
		{
			get
			{
				return this._DragonPath;
			}
			set
			{
				this._DragonPath == null;
				this._DragonPath = value;
				this._DragonPath == null;
			}
		}

		internal virtual GroupBox GroupBox1
		{
			get
			{
				return this._GroupBox1;
			}
			set
			{
				this._GroupBox1 == null;
				this._GroupBox1 = value;
				this._GroupBox1 == null;
			}
		}

		internal virtual GroupBox GroupBox2
		{
			get
			{
				return this._GroupBox2;
			}
			set
			{
				this._GroupBox2 == null;
				this._GroupBox2 = value;
				this._GroupBox2 == null;
			}
		}

		internal virtual Label Label1
		{
			get
			{
				return this._Label1;
			}
			set
			{
				this._Label1 == null;
				this._Label1 = value;
				this._Label1 == null;
			}
		}

		internal virtual Label Label2
		{
			get
			{
				return this._Label2;
			}
			set
			{
				this._Label2 == null;
				this._Label2 = value;
				this._Label2 == null;
			}
		}

		internal virtual Label Label3
		{
			get
			{
				return this._Label3;
			}
			set
			{
				this._Label3 == null;
				this._Label3 = value;
				this._Label3 == null;
			}
		}

		internal virtual Label Label4
		{
			get
			{
				return this._Label4;
			}
			set
			{
				this._Label4 == null;
				this._Label4 = value;
				this._Label4 == null;
			}
		}

		internal virtual Label Label5
		{
			get
			{
				return this._Label5;
			}
			set
			{
				this._Label5 == null;
				this._Label5 = value;
				this._Label5 == null;
			}
		}

		internal virtual Label Label6
		{
			get
			{
				return this._Label6;
			}
			set
			{
				this._Label6 == null;
				this._Label6 = value;
				this._Label6 == null;
			}
		}

		internal virtual Label Label7
		{
			get
			{
				return this._Label7;
			}
			set
			{
				this._Label7 == null;
				this._Label7 = value;
				this._Label7 == null;
			}
		}

		internal virtual MainMenu MainMenu1
		{
			get
			{
				return this._MainMenu1;
			}
			set
			{
				this._MainMenu1 == null;
				this._MainMenu1 = value;
				this._MainMenu1 == null;
			}
		}

		internal virtual MenuItem MenuConv
		{
			get
			{
				return this._MenuConv;
			}
			set
			{
				if (this._MenuConv != null)
				{
					DragonConv dragonConv = this;
					this._MenuConv.remove_Click(new EventHandler(dragonConv, dragonConv.MenuConv_Click));
				}
				this._MenuConv = value;
				if (this._MenuConv != null)
				{
					DragonConv dragonConv1 = this;
					this._MenuConv.add_Click(new EventHandler(dragonConv1, dragonConv1.MenuConv_Click));
				}
			}
		}

		internal virtual MenuItem MenuDragonFile
		{
			get
			{
				return this._MenuDragonFile;
			}
			set
			{
				if (this._MenuDragonFile != null)
				{
					DragonConv dragonConv = this;
					this._MenuDragonFile.remove_Click(new EventHandler(dragonConv, dragonConv.MenuDragonFile_Click));
				}
				this._MenuDragonFile = value;
				if (this._MenuDragonFile != null)
				{
					DragonConv dragonConv1 = this;
					this._MenuDragonFile.add_Click(new EventHandler(dragonConv1, dragonConv1.MenuDragonFile_Click));
				}
			}
		}

		internal virtual MenuItem MenuDragonPath
		{
			get
			{
				return this._MenuDragonPath;
			}
			set
			{
				if (this._MenuDragonPath != null)
				{
					DragonConv dragonConv = this;
					this._MenuDragonPath.remove_Click(new EventHandler(dragonConv, dragonConv.MenuDragonPath_Click));
				}
				this._MenuDragonPath = value;
				if (this._MenuDragonPath != null)
				{
					DragonConv dragonConv1 = this;
					this._MenuDragonPath.add_Click(new EventHandler(dragonConv1, dragonConv1.MenuDragonPath_Click));
				}
			}
		}

		internal virtual MenuItem MenuItem1
		{
			get
			{
				return this._MenuItem1;
			}
			set
			{
				this._MenuItem1 == null;
				this._MenuItem1 = value;
				this._MenuItem1 == null;
			}
		}

		internal virtual MenuItem MenuItem2
		{
			get
			{
				return this._MenuItem2;
			}
			set
			{
				this._MenuItem2 == null;
				this._MenuItem2 = value;
				this._MenuItem2 == null;
			}
		}

		internal virtual MenuItem MenuUOLPath
		{
			get
			{
				return this._MenuUOLPath;
			}
			set
			{
				if (this._MenuUOLPath != null)
				{
					DragonConv dragonConv = this;
					this._MenuUOLPath.remove_Click(new EventHandler(dragonConv, dragonConv.MenuUOLPath_Click));
				}
				this._MenuUOLPath = value;
				if (this._MenuUOLPath != null)
				{
					DragonConv dragonConv1 = this;
					this._MenuUOLPath.add_Click(new EventHandler(dragonConv1, dragonConv1.MenuUOLPath_Click));
				}
			}
		}

		internal virtual MenuItem MenuUOLProjectName
		{
			get
			{
				return this._MenuUOLProjectName;
			}
			set
			{
				if (this._MenuUOLProjectName != null)
				{
					DragonConv dragonConv = this;
					this._MenuUOLProjectName.remove_Click(new EventHandler(dragonConv, dragonConv.MenuUOLProjectName_Click));
				}
				this._MenuUOLProjectName = value;
				if (this._MenuUOLProjectName != null)
				{
					DragonConv dragonConv1 = this;
					this._MenuUOLProjectName.add_Click(new EventHandler(dragonConv1, dragonConv1.MenuUOLProjectName_Click));
				}
			}
		}

		internal virtual ProgressBar ProgressBar1
		{
			get
			{
				return this._ProgressBar1;
			}
			set
			{
				this._ProgressBar1 == null;
				this._ProgressBar1 = value;
				this._ProgressBar1 == null;
			}
		}

		internal virtual TextBox ProjectName
		{
			get
			{
				return this._ProjectName;
			}
			set
			{
				this._ProjectName == null;
				this._ProjectName = value;
				this._ProjectName == null;
			}
		}

		internal virtual TextBox ProjectPath
		{
			get
			{
				return this._ProjectPath;
			}
			set
			{
				this._ProjectPath == null;
				this._ProjectPath = value;
				this._ProjectPath == null;
			}
		}

		internal virtual TextBox TerrainFile
		{
			get
			{
				return this._TerrainFile;
			}
			set
			{
				this._TerrainFile == null;
				this._TerrainFile = value;
				this._TerrainFile == null;
			}
		}

		public DragonConv()
		{
			DragonConv dragonConv = this;
			base.add_Load(new EventHandler(dragonConv, dragonConv.DragonConv_Load));
			this.iTerrain = new ClsTerrainTable();
			this.iAltitude = new ClsAltitudeTable();
			this.iDragon = new ClsDragonTable();
			this.iLogger = new LoggerForm();
			this.InitializeComponent();
		}

		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.components != null)
				{
					this.components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		private void DragonConv_Load(object sender, EventArgs e)
		{
			this.iLogger.Show();
			this.Load_TransMap();
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.MainMenu1 = new MainMenu();
			this.MenuItem1 = new MenuItem();
			this.MenuDragonPath = new MenuItem();
			this.MenuDragonFile = new MenuItem();
			this.MenuItem2 = new MenuItem();
			this.MenuUOLPath = new MenuItem();
			this.MenuUOLProjectName = new MenuItem();
			this.MenuConv = new MenuItem();
			this.Label1 = new Label();
			this.DragonPath = new TextBox();
			this.Label2 = new Label();
			this.DragonImage = new TextBox();
			this.GroupBox1 = new GroupBox();
			this.Label3 = new Label();
			this.ComboBox1 = new ComboBox();
			this.GroupBox2 = new GroupBox();
			this.Label4 = new Label();
			this.ProjectPath = new TextBox();
			this.Label5 = new Label();
			this.ProjectName = new TextBox();
			this.Label7 = new Label();
			this.TerrainFile = new TextBox();
			this.Label6 = new Label();
			this.AltitudeFile = new TextBox();
			this.ProgressBar1 = new ProgressBar();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.SuspendLayout();
			Menu.MenuItemCollection menuItems = this.MainMenu1.get_MenuItems();
			MenuItem[] menuItem1 = new MenuItem[] { this.MenuItem1, this.MenuItem2, this.MenuConv };
			menuItems.AddRange(menuItem1);
			this.MenuItem1.set_Index(0);
			Menu.MenuItemCollection menuItemCollection = this.MenuItem1.get_MenuItems();
			menuItem1 = new MenuItem[] { this.MenuDragonPath, this.MenuDragonFile };
			menuItemCollection.AddRange(menuItem1);
			this.MenuItem1.set_Text("Dragon");
			this.MenuDragonPath.set_Index(0);
			this.MenuDragonPath.set_Text("Select Path");
			this.MenuDragonFile.set_Index(1);
			this.MenuDragonFile.set_Text("Select Map File");
			this.MenuItem2.set_Index(1);
			Menu.MenuItemCollection menuItems1 = this.MenuItem2.get_MenuItems();
			menuItem1 = new MenuItem[] { this.MenuUOLPath, this.MenuUOLProjectName };
			menuItems1.AddRange(menuItem1);
			this.MenuItem2.set_Text("UO Landscaper");
			this.MenuUOLPath.set_Index(0);
			this.MenuUOLPath.set_Text("Select Path");
			this.MenuUOLProjectName.set_Index(1);
			this.MenuUOLProjectName.set_Text("Select Project Name");
			this.MenuConv.set_Index(2);
			this.MenuConv.set_Text("Convert");
			this.Label1.set_AutoSize(true);
			Label label1 = this.Label1;
			Point point = new Point(8, 16);
			label1.set_Location(point);
			this.Label1.set_Name("Label1");
			Label label = this.Label1;
			Size size = new Size(27, 16);
			label.set_Size(size);
			this.Label1.set_TabIndex(0);
			this.Label1.set_Text("Path");
			TextBox dragonPath = this.DragonPath;
			point = new Point(24, 32);
			dragonPath.set_Location(point);
			this.DragonPath.set_Name("DragonPath");
			TextBox textBox = this.DragonPath;
			size = new Size(240, 20);
			textBox.set_Size(size);
			this.DragonPath.set_TabIndex(1);
			this.DragonPath.set_Text("");
			this.Label2.set_AutoSize(true);
			Label label2 = this.Label2;
			point = new Point(8, 56);
			label2.set_Location(point);
			this.Label2.set_Name("Label2");
			Label label21 = this.Label2;
			size = new Size(61, 16);
			label21.set_Size(size);
			this.Label2.set_TabIndex(2);
			this.Label2.set_Text("Map Image");
			TextBox dragonImage = this.DragonImage;
			point = new Point(24, 72);
			dragonImage.set_Location(point);
			this.DragonImage.set_Name("DragonImage");
			TextBox dragonImage1 = this.DragonImage;
			size = new Size(104, 20);
			dragonImage1.set_Size(size);
			this.DragonImage.set_TabIndex(3);
			this.DragonImage.set_Text("");
			this.GroupBox1.get_Controls().Add(this.Label3);
			this.GroupBox1.get_Controls().Add(this.Label1);
			this.GroupBox1.get_Controls().Add(this.DragonPath);
			this.GroupBox1.get_Controls().Add(this.DragonImage);
			this.GroupBox1.get_Controls().Add(this.Label2);
			this.GroupBox1.get_Controls().Add(this.ComboBox1);
			GroupBox groupBox1 = this.GroupBox1;
			point = new Point(8, 8);
			groupBox1.set_Location(point);
			this.GroupBox1.set_Name("GroupBox1");
			GroupBox groupBox = this.GroupBox1;
			size = new Size(272, 144);
			groupBox.set_Size(size);
			this.GroupBox1.set_TabIndex(4);
			this.GroupBox1.set_TabStop(false);
			this.GroupBox1.set_Text("Dragon Image Info");
			this.Label3.set_AutoSize(true);
			Label label3 = this.Label3;
			point = new Point(8, 96);
			label3.set_Location(point);
			this.Label3.set_Name("Label3");
			Label label31 = this.Label3;
			size = new Size(93, 16);
			label31.set_Size(size);
			this.Label3.set_TabIndex(4);
			this.Label3.set_Text("Select MOD Type");
			ComboBox comboBox1 = this.ComboBox1;
			point = new Point(24, 112);
			comboBox1.set_Location(point);
			this.ComboBox1.set_Name("ComboBox1");
			ComboBox comboBox = this.ComboBox1;
			size = new Size(136, 21);
			comboBox.set_Size(size);
			this.ComboBox1.set_TabIndex(7);
			this.GroupBox2.get_Controls().Add(this.Label4);
			this.GroupBox2.get_Controls().Add(this.ProjectPath);
			this.GroupBox2.get_Controls().Add(this.Label5);
			this.GroupBox2.get_Controls().Add(this.ProjectName);
			this.GroupBox2.get_Controls().Add(this.Label7);
			this.GroupBox2.get_Controls().Add(this.TerrainFile);
			this.GroupBox2.get_Controls().Add(this.Label6);
			this.GroupBox2.get_Controls().Add(this.AltitudeFile);
			GroupBox groupBox2 = this.GroupBox2;
			point = new Point(8, 160);
			groupBox2.set_Location(point);
			this.GroupBox2.set_Name("GroupBox2");
			GroupBox groupBox21 = this.GroupBox2;
			size = new Size(272, 184);
			groupBox21.set_Size(size);
			this.GroupBox2.set_TabIndex(5);
			this.GroupBox2.set_TabStop(false);
			this.GroupBox2.set_Text("UO Landscaper Info");
			this.Label4.set_AutoSize(true);
			Label label4 = this.Label4;
			point = new Point(8, 16);
			label4.set_Location(point);
			this.Label4.set_Name("Label4");
			Label label41 = this.Label4;
			size = new Size(31, 16);
			label41.set_Size(size);
			this.Label4.set_TabIndex(35);
			this.Label4.set_Text("Path:");
			TextBox projectPath = this.ProjectPath;
			point = new Point(24, 32);
			projectPath.set_Location(point);
			this.ProjectPath.set_Name("ProjectPath");
			TextBox projectPath1 = this.ProjectPath;
			size = new Size(240, 20);
			projectPath1.set_Size(size);
			this.ProjectPath.set_TabIndex(34);
			this.ProjectPath.set_Text("");
			this.Label5.set_AutoSize(true);
			Label label5 = this.Label5;
			point = new Point(8, 56);
			label5.set_Location(point);
			this.Label5.set_Name("Label5");
			Label label51 = this.Label5;
			size = new Size(73, 16);
			label51.set_Size(size);
			this.Label5.set_TabIndex(51);
			this.Label5.set_Text("Project Name");
			TextBox projectName = this.ProjectName;
			point = new Point(24, 72);
			projectName.set_Location(point);
			this.ProjectName.set_Name("ProjectName");
			TextBox projectName1 = this.ProjectName;
			size = new Size(136, 20);
			projectName1.set_Size(size);
			this.ProjectName.set_TabIndex(52);
			this.ProjectName.set_Text("");
			this.Label7.set_AutoSize(true);
			Label label7 = this.Label7;
			point = new Point(8, 96);
			label7.set_Location(point);
			this.Label7.set_Name("Label7");
			this.Label7.set_TabIndex(57);
			this.Label7.set_Text("Terrain Image Map");
			TextBox terrainFile = this.TerrainFile;
			point = new Point(24, 112);
			terrainFile.set_Location(point);
			this.TerrainFile.set_Name("TerrainFile");
			TextBox terrainFile1 = this.TerrainFile;
			size = new Size(104, 20);
			terrainFile1.set_Size(size);
			this.TerrainFile.set_TabIndex(54);
			this.TerrainFile.set_Text("Terrain.bmp");
			this.Label6.set_AutoSize(true);
			Label label6 = this.Label6;
			point = new Point(8, 136);
			label6.set_Location(point);
			this.Label6.set_Name("Label6");
			Label label61 = this.Label6;
			size = new Size(102, 16);
			label61.set_Size(size);
			this.Label6.set_TabIndex(58);
			this.Label6.set_Text("Altitude Image Map");
			TextBox altitudeFile = this.AltitudeFile;
			point = new Point(24, 152);
			altitudeFile.set_Location(point);
			this.AltitudeFile.set_Name("AltitudeFile");
			TextBox altitudeFile1 = this.AltitudeFile;
			size = new Size(104, 20);
			altitudeFile1.set_Size(size);
			this.AltitudeFile.set_TabIndex(56);
			this.AltitudeFile.set_Text("Altitude.bmp");
			this.ProgressBar1.set_Dock(2);
			ProgressBar progressBar1 = this.ProgressBar1;
			point = new Point(0, 351);
			progressBar1.set_Location(point);
			this.ProgressBar1.set_Name("ProgressBar1");
			ProgressBar progressBar = this.ProgressBar1;
			size = new Size(286, 16);
			progressBar.set_Size(size);
			this.ProgressBar1.set_TabIndex(6);
			size = new Size(5, 13);
			this.set_AutoScaleBaseSize(size);
			this.set_BackColor(Color.FromArgb(224, 224, 224));
			size = new Size(286, 367);
			this.set_ClientSize(size);
			this.get_Controls().Add(this.ProgressBar1);
			this.get_Controls().Add(this.GroupBox2);
			this.get_Controls().Add(this.GroupBox1);
			this.set_FormBorderStyle(2);
			this.set_Menu(this.MainMenu1);
			this.set_Name("DragonConv");
			this.set_Text("Dragon to UO Landscaper Image Convertor");
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private void Load_TransMap()
		{
			IEnumerator enumerator = null;
			string str = string.Format("{0}\\Data\\System\\MapTrans\\{1}", AppDomain.get_CurrentDomain().get_BaseDirectory(), "TransInfo.xml");
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(str);
				try
				{
					this.ComboBox1.get_Items().Clear();
					try
					{
						enumerator = xmlDocument.SelectNodes("//Dragon/MapTrans").GetEnumerator();
						while (enumerator.MoveNext())
						{
							XmlElement current = (XmlElement)enumerator.get_Current();
							this.ComboBox1.get_Items().Add(new TransInfo(current));
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							((IDisposable)enumerator).Dispose();
						}
					}
				}
				catch (Exception exception1)
				{
					ProjectData.SetProjectError(exception1);
					Exception exception = exception1;
					this.iLogger.LogMessage(string.Format("XML Error:{0}", exception.get_Message()));
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception exception2)
			{
				ProjectData.SetProjectError(exception2);
				this.iLogger.LogMessage(string.Format("Unable to find:{0}", str));
				ProjectData.ClearProjectError();
			}
		}

		[STAThread]
		public static void Main()
		{
			Application.Run(new DragonConv());
		}

		private void Make()
		{
			this.iLogger.LogMessage("Dragon to UO Landscaper Conversion");
			this.iLogger.StartTask();
			if (StringType.StrCmp(this.ProjectName.get_Text(), string.Empty, false) != 0)
			{
				this.iLogger.LogMessage("Loading Dragon Image.");
				try
				{
					string str = string.Format("{0}\\{1}", this.DragonPath.get_Text(), this.DragonImage.get_Text());
					this.iLogger.LogMessage(str);
					this.i_Dragon = new Bitmap(str);
				}
				catch (Exception exception1)
				{
					ProjectData.SetProjectError(exception1);
					Exception exception = exception1;
					this.iLogger.LogMessage("Problem with Loading Dragon Image.");
					this.iLogger.LogMessage(exception.get_Message());
					ProjectData.ClearProjectError();
					return;
				}
				this.iLogger.LogMessage("Preparing Dragon Image.");
				int width = this.i_Dragon.get_Width();
				int height = this.i_Dragon.get_Height();
				Rectangle rectangle = new Rectangle(0, 0, width, height);
				BitmapData bitmapDatum = this.i_Dragon.LockBits(rectangle, 3, 198659);
				IntPtr scan0 = bitmapDatum.get_Scan0();
				int num = checked(bitmapDatum.get_Width() * bitmapDatum.get_Height());
				byte[] numArray = new byte[checked(checked(num - 1) + 1)];
				Marshal.Copy(scan0, numArray, 0, num);
				Bitmap bitmap = new Bitmap(width, height, 198659);
				BitmapData bitmapDatum1 = bitmap.LockBits(rectangle, 3, 198659);
				IntPtr intPtr = bitmapDatum1.get_Scan0();
				int width1 = checked(bitmapDatum1.get_Width() * bitmapDatum1.get_Height());
				byte[] terrainID = new byte[checked(checked(width1 - 1) + 1)];
				Marshal.Copy(intPtr, terrainID, 0, width1);
				Bitmap bitmap1 = new Bitmap(width, height, 198659);
				BitmapData bitmapDatum2 = bitmap1.LockBits(rectangle, 3, 198659);
				IntPtr scan01 = bitmapDatum2.get_Scan0();
				int num1 = checked(bitmapDatum2.get_Width() * bitmapDatum2.get_Height());
				byte[] altitudeID = new byte[checked(checked(num1 - 1) + 1)];
				Marshal.Copy(scan01, altitudeID, 0, num1);
				this.iAltitude.Load();
				this.iTerrain.Load();
				TransInfo selectedItem = (TransInfo)this.ComboBox1.get_SelectedItem();
				if (selectedItem != null)
				{
					string str1 = string.Format("{0}{1}", AppDomain.get_CurrentDomain().get_BaseDirectory(), selectedItem.Location);
					this.iDragon.Load(str1);
					this.ProgressBar1.set_Maximum(checked(num - 1));
					int num2 = checked(num - 1);
					for (int i = 0; i <= num2; i++)
					{
						byte num3 = numArray[i];
						ClsDragon getDragon = this.iDragon[num3];
						if (getDragon == null)
						{
							this.iLogger.LogMessage(string.Format("Loc:{0} Color:{1}", i, num3));
							altitudeID[i] = 0;
							terrainID[i] = 0;
						}
						else
						{
							altitudeID[i] = getDragon.AltitudeID;
							terrainID[i] = getDragon.TerrainID;
						}
						this.ProgressBar1.set_Value(i);
					}
					Marshal.Copy(altitudeID, 0, scan01, num1);
					bitmap1.UnlockBits(bitmapDatum2);
					Marshal.Copy(terrainID, 0, intPtr, width1);
					bitmap.UnlockBits(bitmapDatum1);
					string str2 = string.Format("{0}/{1}/Dragon", this.ProjectPath.get_Text(), this.ProjectName.get_Text());
					if (!Directory.Exists(str2))
					{
						Directory.CreateDirectory(str2);
					}
					string str3 = string.Format("{0}/{1}", str2, this.TerrainFile.get_Text());
					this.iTerrain.Load();
					bitmap.set_Palette(this.iTerrain.GetPalette());
					bitmap.Save(str3, ImageFormat.get_Bmp());
					bitmap.Dispose();
					str3 = string.Format("{0}/{1}", str2, this.AltitudeFile.get_Text());
					this.iAltitude.Load();
					bitmap1.set_Palette(this.iAltitude.GetAltPalette());
					bitmap1.Save(str3, ImageFormat.get_Bmp());
					bitmap1.Dispose();
					this.iLogger.EndTask();
					this.iLogger.LogTimeStamp();
					this.iLogger.LogMessage("Done.");
				}
				else
				{
					this.iLogger.LogMessage("Error: Please select which dragon mod to convert from.");
				}
			}
			else
			{
				this.iLogger.LogMessage("Error: Enter a project Name.");
			}
		}

		private void MenuConv_Click(object sender, EventArgs e)
		{
			DragonConv dragonConv = this;
			(new Thread(new ThreadStart(dragonConv, dragonConv.Make))).Start();
		}

		private void MenuDragonFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.set_InitialDirectory(this.DragonPath.get_Text());
			if (openFileDialog.ShowDialog() == 1)
			{
				FileInfo fileInfo = new FileInfo(openFileDialog.get_FileName());
				this.DragonImage.set_Text(fileInfo.get_Name());
			}
		}

		private void MenuDragonPath_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.set_SelectedPath(AppDomain.get_CurrentDomain().get_BaseDirectory());
			if (folderBrowserDialog.ShowDialog() == 1)
			{
				this.DragonPath.set_Text(folderBrowserDialog.get_SelectedPath());
			}
		}

		private void MenuUOLPath_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.set_SelectedPath(AppDomain.get_CurrentDomain().get_BaseDirectory());
			if (folderBrowserDialog.ShowDialog() == 1)
			{
				this.ProjectPath.set_Text(folderBrowserDialog.get_SelectedPath());
			}
		}

		private void MenuUOLProjectName_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.set_InitialDirectory(this.ProjectPath.get_Text());
			if (openFileDialog.ShowDialog() == 1)
			{
				FileInfo fileInfo = new FileInfo(openFileDialog.get_FileName());
				this.DragonImage.set_Text(fileInfo.get_Name());
			}
		}
	}
}