namespace Quickly_Helper
{
	// Token: 0x02000008 RID: 8
	public partial class BackGround : global::System.Windows.Forms.Form, global::Quickly_Helper.IOkButtonPressedInSavePresetDialog, global::Quickly_Helper.IOnHotkeyPressed
	{
		// Token: 0x06000065 RID: 101 RVA: 0x000042EC File Offset: 0x000024EC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000431C File Offset: 0x0000251C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Quickly_Helper.BackGround));
			this.toolStripContainer1 = new global::System.Windows.Forms.ToolStripContainer();
			this.About_button = new global::System.Windows.Forms.Button();
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.closeToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.trackBarDy = new global::System.Windows.Forms.TrackBar();
			this.trackBarShotInterval = new global::System.Windows.Forms.TrackBar();
			this.trackBarPullDelay = new global::System.Windows.Forms.TrackBar();
			this.QuicklyPanel = new global::System.Windows.Forms.Panel();
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.groupBox23 = new global::System.Windows.Forms.GroupBox();
			this.FirecomboBox = new global::System.Windows.Forms.ComboBox();
			this.groupBox18 = new global::System.Windows.Forms.GroupBox();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.JumpCrouchcomboBox = new global::System.Windows.Forms.ComboBox();
			this.groupBox17 = new global::System.Windows.Forms.GroupBox();
			this.label14 = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.Dodge_comboBox2 = new global::System.Windows.Forms.ComboBox();
			this.label12 = new global::System.Windows.Forms.Label();
			this.Dodge_Timer = new global::System.Windows.Forms.TextBox();
			this.Dodge_comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.QuickSitComboBox = new global::System.Windows.Forms.ComboBox();
			this.button2 = new global::System.Windows.Forms.Button();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.slidingcomboBox = new global::System.Windows.Forms.ComboBox();
			this.startEmalutor = new global::System.Windows.Forms.Button();
			this.groupBox16 = new global::System.Windows.Forms.GroupBox();
			this.checkBox3 = new global::System.Windows.Forms.CheckBox();
			this.Active_button = new global::System.Windows.Forms.Button();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.jump_prone_comboBox = new global::System.Windows.Forms.ComboBox();
			this.groupBox15 = new global::System.Windows.Forms.GroupBox();
			this.checkBox2 = new global::System.Windows.Forms.CheckBox();
			this.groupBox13 = new global::System.Windows.Forms.GroupBox();
			this.fixproneComboBox = new global::System.Windows.Forms.ComboBox();
			this.groupBox14 = new global::System.Windows.Forms.GroupBox();
			this.SpacecomboBox = new global::System.Windows.Forms.ComboBox();
			this.Show = new global::System.Windows.Forms.Button();
			this.groupBox5 = new global::System.Windows.Forms.GroupBox();
			this.Weapon_1 = new global::System.Windows.Forms.Label();
			this.Recoil_1 = new global::System.Windows.Forms.TextBox();
			this.Shot_Text_X = new global::System.Windows.Forms.TextBox();
			this.FastProne = new global::System.Windows.Forms.TextBox();
			this.RightLeft = new global::System.Windows.Forms.TextBox();
			this.Emulator = new global::System.Windows.Forms.TextBox();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.Ready = new global::System.Windows.Forms.Label();
			this.LeftClick = new global::System.Windows.Forms.PictureBox();
			this.trackBarRight = new global::System.Windows.Forms.TrackBar();
			this.trackBarleft = new global::System.Windows.Forms.TrackBar();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.menuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.toolStripMenuItemSaveAsPreset = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemFireButton = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBoxFireButton = new global::System.Windows.Forms.ToolStripComboBox();
			this.toolStripMenuItemEdit = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemEnableAntiRecoil = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemActivate = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemPresets = new global::System.Windows.Forms.ToolStripMenuItem();
			this.About = new global::System.Windows.Forms.PictureBox();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.notifyIcon1 = new global::System.Windows.Forms.NotifyIcon(this.components);
			this.StartEmalutorTimer = new global::System.Windows.Forms.Timer(this.components);
			this.JumpCrouchtimer = new global::System.Windows.Forms.Timer(this.components);
			this.Jump_pronetimer = new global::System.Windows.Forms.Timer(this.components);
			this.Pronet = new global::System.Windows.Forms.Timer(this.components);
			this.rightleftmove = new global::System.Windows.Forms.Timer(this.components);
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.trackBarDy).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBarShotInterval).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBarPullDelay).BeginInit();
			this.QuicklyPanel.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox23.SuspendLayout();
			this.groupBox18.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox17.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox16.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox15.SuspendLayout();
			this.groupBox13.SuspendLayout();
			this.groupBox14.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.LeftClick).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBarRight).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBarleft).BeginInit();
			this.menuStrip1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.About).BeginInit();
			base.SuspendLayout();
			componentResourceManager.ApplyResources(this.toolStripContainer1, "toolStripContainer1");
			componentResourceManager.ApplyResources(this.toolStripContainer1.BottomToolStripPanel, "toolStripContainer1.BottomToolStripPanel");
			this.toolTip1.SetToolTip(this.toolStripContainer1.BottomToolStripPanel, componentResourceManager.GetString("toolStripContainer1.BottomToolStripPanel.ToolTip"));
			componentResourceManager.ApplyResources(this.toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
			this.toolStripContainer1.ContentPanel.Controls.Add(this.About_button);
			this.toolTip1.SetToolTip(this.toolStripContainer1.ContentPanel, componentResourceManager.GetString("toolStripContainer1.ContentPanel.ToolTip"));
			componentResourceManager.ApplyResources(this.toolStripContainer1.LeftToolStripPanel, "toolStripContainer1.LeftToolStripPanel");
			this.toolTip1.SetToolTip(this.toolStripContainer1.LeftToolStripPanel, componentResourceManager.GetString("toolStripContainer1.LeftToolStripPanel.ToolTip"));
			this.toolStripContainer1.Name = "toolStripContainer1";
			componentResourceManager.ApplyResources(this.toolStripContainer1.RightToolStripPanel, "toolStripContainer1.RightToolStripPanel");
			this.toolTip1.SetToolTip(this.toolStripContainer1.RightToolStripPanel, componentResourceManager.GetString("toolStripContainer1.RightToolStripPanel.ToolTip"));
			this.toolTip1.SetToolTip(this.toolStripContainer1, componentResourceManager.GetString("toolStripContainer1.ToolTip"));
			componentResourceManager.ApplyResources(this.toolStripContainer1.TopToolStripPanel, "toolStripContainer1.TopToolStripPanel");
			this.toolTip1.SetToolTip(this.toolStripContainer1.TopToolStripPanel, componentResourceManager.GetString("toolStripContainer1.TopToolStripPanel.ToolTip"));
			componentResourceManager.ApplyResources(this.About_button, "About_button");
			this.About_button.Name = "About_button";
			this.toolTip1.SetToolTip(this.About_button, componentResourceManager.GetString("About_button.ToolTip"));
			componentResourceManager.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.closeToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.toolTip1.SetToolTip(this.contextMenuStrip1, componentResourceManager.GetString("contextMenuStrip1.ToolTip"));
			componentResourceManager.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Click += new global::System.EventHandler(this.closeToolStripMenuItem_Click);
			componentResourceManager.ApplyResources(this.trackBarDy, "trackBarDy");
			this.trackBarDy.Maximum = 1000000;
			this.trackBarDy.Name = "trackBarDy";
			this.trackBarDy.TickStyle = global::System.Windows.Forms.TickStyle.Both;
			this.toolTip1.SetToolTip(this.trackBarDy, componentResourceManager.GetString("trackBarDy.ToolTip"));
			this.trackBarDy.Value = 1;
			componentResourceManager.ApplyResources(this.trackBarShotInterval, "trackBarShotInterval");
			this.trackBarShotInterval.Maximum = 1000000;
			this.trackBarShotInterval.Minimum = 1;
			this.trackBarShotInterval.Name = "trackBarShotInterval";
			this.trackBarShotInterval.TickFrequency = 10;
			this.trackBarShotInterval.TickStyle = global::System.Windows.Forms.TickStyle.Both;
			this.toolTip1.SetToolTip(this.trackBarShotInterval, componentResourceManager.GetString("trackBarShotInterval.ToolTip"));
			this.trackBarShotInterval.Value = 1;
			componentResourceManager.ApplyResources(this.trackBarPullDelay, "trackBarPullDelay");
			this.trackBarPullDelay.Maximum = 1000000;
			this.trackBarPullDelay.Name = "trackBarPullDelay";
			this.trackBarPullDelay.TickFrequency = 10;
			this.trackBarPullDelay.TickStyle = global::System.Windows.Forms.TickStyle.Both;
			this.toolTip1.SetToolTip(this.trackBarPullDelay, componentResourceManager.GetString("trackBarPullDelay.ToolTip"));
			this.trackBarPullDelay.Value = 1;
			componentResourceManager.ApplyResources(this.QuicklyPanel, "QuicklyPanel");
			this.QuicklyPanel.BackColor = global::System.Drawing.Color.Transparent;
			this.QuicklyPanel.BackgroundImage = global::Quickly_Helper.Properties.Resources.Logos;
			this.QuicklyPanel.Controls.Add(this.tabControl1);
			this.QuicklyPanel.Controls.Add(this.Show);
			this.QuicklyPanel.Controls.Add(this.groupBox5);
			this.QuicklyPanel.Controls.Add(this.Shot_Text_X);
			this.QuicklyPanel.Controls.Add(this.FastProne);
			this.QuicklyPanel.Controls.Add(this.RightLeft);
			this.QuicklyPanel.Controls.Add(this.Emulator);
			this.QuicklyPanel.Controls.Add(this.panel2);
			this.QuicklyPanel.Controls.Add(this.LeftClick);
			this.QuicklyPanel.Controls.Add(this.trackBarRight);
			this.QuicklyPanel.Controls.Add(this.trackBarleft);
			this.QuicklyPanel.Controls.Add(this.label5);
			this.QuicklyPanel.Controls.Add(this.label2);
			this.QuicklyPanel.Controls.Add(this.label4);
			this.QuicklyPanel.Controls.Add(this.label1);
			this.QuicklyPanel.Controls.Add(this.menuStrip1);
			this.QuicklyPanel.Controls.Add(this.About);
			this.QuicklyPanel.Name = "QuicklyPanel";
			this.toolTip1.SetToolTip(this.QuicklyPanel, componentResourceManager.GetString("QuicklyPanel.ToolTip"));
			componentResourceManager.ApplyResources(this.tabControl1, "tabControl1");
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.toolTip1.SetToolTip(this.tabControl1, componentResourceManager.GetString("tabControl1.ToolTip"));
			componentResourceManager.ApplyResources(this.tabPage1, "tabPage1");
			this.tabPage1.BackColor = global::System.Drawing.Color.Black;
			this.tabPage1.BackgroundImage = global::Quickly_Helper.Properties.Resources.Logo;
			this.tabPage1.Controls.Add(this.groupBox23);
			this.tabPage1.Controls.Add(this.groupBox18);
			this.tabPage1.Controls.Add(this.groupBox3);
			this.tabPage1.Controls.Add(this.groupBox17);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.startEmalutor);
			this.tabPage1.Controls.Add(this.groupBox16);
			this.tabPage1.Controls.Add(this.Active_button);
			this.tabPage1.Controls.Add(this.groupBox4);
			this.tabPage1.Controls.Add(this.groupBox15);
			this.tabPage1.Controls.Add(this.groupBox13);
			this.tabPage1.Controls.Add(this.groupBox14);
			this.tabPage1.Name = "tabPage1";
			this.toolTip1.SetToolTip(this.tabPage1, componentResourceManager.GetString("tabPage1.ToolTip"));
			componentResourceManager.ApplyResources(this.groupBox23, "groupBox23");
			this.groupBox23.BackColor = global::System.Drawing.Color.Transparent;
			this.groupBox23.Controls.Add(this.FirecomboBox);
			this.groupBox23.ForeColor = global::System.Drawing.Color.Lime;
			this.groupBox23.Name = "groupBox23";
			this.groupBox23.TabStop = false;
			this.toolTip1.SetToolTip(this.groupBox23, componentResourceManager.GetString("groupBox23.ToolTip"));
			componentResourceManager.ApplyResources(this.FirecomboBox, "FirecomboBox");
			this.FirecomboBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FirecomboBox.FormattingEnabled = true;
			this.FirecomboBox.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("FirecomboBox.Items"),
				componentResourceManager.GetString("FirecomboBox.Items1"),
				componentResourceManager.GetString("FirecomboBox.Items2"),
				componentResourceManager.GetString("FirecomboBox.Items3"),
				componentResourceManager.GetString("FirecomboBox.Items4"),
				componentResourceManager.GetString("FirecomboBox.Items5"),
				componentResourceManager.GetString("FirecomboBox.Items6"),
				componentResourceManager.GetString("FirecomboBox.Items7"),
				componentResourceManager.GetString("FirecomboBox.Items8"),
				componentResourceManager.GetString("FirecomboBox.Items9"),
				componentResourceManager.GetString("FirecomboBox.Items10"),
				componentResourceManager.GetString("FirecomboBox.Items11"),
				componentResourceManager.GetString("FirecomboBox.Items12"),
				componentResourceManager.GetString("FirecomboBox.Items13"),
				componentResourceManager.GetString("FirecomboBox.Items14"),
				componentResourceManager.GetString("FirecomboBox.Items15"),
				componentResourceManager.GetString("FirecomboBox.Items16"),
				componentResourceManager.GetString("FirecomboBox.Items17"),
				componentResourceManager.GetString("FirecomboBox.Items18"),
				componentResourceManager.GetString("FirecomboBox.Items19"),
				componentResourceManager.GetString("FirecomboBox.Items20"),
				componentResourceManager.GetString("FirecomboBox.Items21"),
				componentResourceManager.GetString("FirecomboBox.Items22"),
				componentResourceManager.GetString("FirecomboBox.Items23"),
				componentResourceManager.GetString("FirecomboBox.Items24"),
				componentResourceManager.GetString("FirecomboBox.Items25"),
				componentResourceManager.GetString("FirecomboBox.Items26"),
				componentResourceManager.GetString("FirecomboBox.Items27"),
				componentResourceManager.GetString("FirecomboBox.Items28"),
				componentResourceManager.GetString("FirecomboBox.Items29"),
				componentResourceManager.GetString("FirecomboBox.Items30"),
				componentResourceManager.GetString("FirecomboBox.Items31"),
				componentResourceManager.GetString("FirecomboBox.Items32"),
				componentResourceManager.GetString("FirecomboBox.Items33"),
				componentResourceManager.GetString("FirecomboBox.Items34"),
				componentResourceManager.GetString("FirecomboBox.Items35"),
				componentResourceManager.GetString("FirecomboBox.Items36"),
				componentResourceManager.GetString("FirecomboBox.Items37"),
				componentResourceManager.GetString("FirecomboBox.Items38"),
				componentResourceManager.GetString("FirecomboBox.Items39"),
				componentResourceManager.GetString("FirecomboBox.Items40"),
				componentResourceManager.GetString("FirecomboBox.Items41"),
				componentResourceManager.GetString("FirecomboBox.Items42"),
				componentResourceManager.GetString("FirecomboBox.Items43"),
				componentResourceManager.GetString("FirecomboBox.Items44"),
				componentResourceManager.GetString("FirecomboBox.Items45"),
				componentResourceManager.GetString("FirecomboBox.Items46"),
				componentResourceManager.GetString("FirecomboBox.Items47"),
				componentResourceManager.GetString("FirecomboBox.Items48"),
				componentResourceManager.GetString("FirecomboBox.Items49"),
				componentResourceManager.GetString("FirecomboBox.Items50"),
				componentResourceManager.GetString("FirecomboBox.Items51"),
				componentResourceManager.GetString("FirecomboBox.Items52"),
				componentResourceManager.GetString("FirecomboBox.Items53"),
				componentResourceManager.GetString("FirecomboBox.Items54"),
				componentResourceManager.GetString("FirecomboBox.Items55"),
				componentResourceManager.GetString("FirecomboBox.Items56"),
				componentResourceManager.GetString("FirecomboBox.Items57"),
				componentResourceManager.GetString("FirecomboBox.Items58"),
				componentResourceManager.GetString("FirecomboBox.Items59"),
				componentResourceManager.GetString("FirecomboBox.Items60"),
				componentResourceManager.GetString("FirecomboBox.Items61"),
				componentResourceManager.GetString("FirecomboBox.Items62"),
				componentResourceManager.GetString("FirecomboBox.Items63"),
				componentResourceManager.GetString("FirecomboBox.Items64"),
				componentResourceManager.GetString("FirecomboBox.Items65"),
				componentResourceManager.GetString("FirecomboBox.Items66"),
				componentResourceManager.GetString("FirecomboBox.Items67"),
				componentResourceManager.GetString("FirecomboBox.Items68"),
				componentResourceManager.GetString("FirecomboBox.Items69"),
				componentResourceManager.GetString("FirecomboBox.Items70"),
				componentResourceManager.GetString("FirecomboBox.Items71"),
				componentResourceManager.GetString("FirecomboBox.Items72"),
				componentResourceManager.GetString("FirecomboBox.Items73"),
				componentResourceManager.GetString("FirecomboBox.Items74"),
				componentResourceManager.GetString("FirecomboBox.Items75"),
				componentResourceManager.GetString("FirecomboBox.Items76"),
				componentResourceManager.GetString("FirecomboBox.Items77"),
				componentResourceManager.GetString("FirecomboBox.Items78"),
				componentResourceManager.GetString("FirecomboBox.Items79"),
				componentResourceManager.GetString("FirecomboBox.Items80"),
				componentResourceManager.GetString("FirecomboBox.Items81"),
				componentResourceManager.GetString("FirecomboBox.Items82"),
				componentResourceManager.GetString("FirecomboBox.Items83"),
				componentResourceManager.GetString("FirecomboBox.Items84"),
				componentResourceManager.GetString("FirecomboBox.Items85"),
				componentResourceManager.GetString("FirecomboBox.Items86"),
				componentResourceManager.GetString("FirecomboBox.Items87"),
				componentResourceManager.GetString("FirecomboBox.Items88"),
				componentResourceManager.GetString("FirecomboBox.Items89"),
				componentResourceManager.GetString("FirecomboBox.Items90"),
				componentResourceManager.GetString("FirecomboBox.Items91"),
				componentResourceManager.GetString("FirecomboBox.Items92"),
				componentResourceManager.GetString("FirecomboBox.Items93"),
				componentResourceManager.GetString("FirecomboBox.Items94"),
				componentResourceManager.GetString("FirecomboBox.Items95"),
				componentResourceManager.GetString("FirecomboBox.Items96"),
				componentResourceManager.GetString("FirecomboBox.Items97"),
				componentResourceManager.GetString("FirecomboBox.Items98"),
				componentResourceManager.GetString("FirecomboBox.Items99"),
				componentResourceManager.GetString("FirecomboBox.Items100")
			});
			this.FirecomboBox.Name = "FirecomboBox";
			this.toolTip1.SetToolTip(this.FirecomboBox, componentResourceManager.GetString("FirecomboBox.ToolTip"));
			componentResourceManager.ApplyResources(this.groupBox18, "groupBox18");
			this.groupBox18.BackColor = global::System.Drawing.Color.Transparent;
			this.groupBox18.Controls.Add(this.checkBox1);
			this.groupBox18.ForeColor = global::System.Drawing.Color.Lime;
			this.groupBox18.Name = "groupBox18";
			this.groupBox18.TabStop = false;
			this.toolTip1.SetToolTip(this.groupBox18, componentResourceManager.GetString("groupBox18.ToolTip"));
			componentResourceManager.ApplyResources(this.checkBox1, "checkBox1");
			this.checkBox1.ForeColor = global::System.Drawing.Color.White;
			this.checkBox1.Name = "checkBox1";
			this.toolTip1.SetToolTip(this.checkBox1, componentResourceManager.GetString("checkBox1.ToolTip"));
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			componentResourceManager.ApplyResources(this.groupBox3, "groupBox3");
			this.groupBox3.BackColor = global::System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.JumpCrouchcomboBox);
			this.groupBox3.ForeColor = global::System.Drawing.Color.Lime;
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.TabStop = false;
			this.toolTip1.SetToolTip(this.groupBox3, componentResourceManager.GetString("groupBox3.ToolTip"));
			componentResourceManager.ApplyResources(this.JumpCrouchcomboBox, "JumpCrouchcomboBox");
			this.JumpCrouchcomboBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.JumpCrouchcomboBox.FormattingEnabled = true;
			this.JumpCrouchcomboBox.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("JumpCrouchcomboBox.Items"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items1"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items2"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items3"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items4"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items5"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items6"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items7"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items8"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items9"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items10"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items11"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items12"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items13"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items14"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items15"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items16"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items17"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items18"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items19"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items20"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items21"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items22"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items23"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items24"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items25"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items26"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items27"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items28"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items29"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items30"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items31"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items32"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items33"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items34"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items35"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items36"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items37"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items38"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items39"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items40"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items41"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items42"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items43"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items44"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items45"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items46"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items47"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items48"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items49"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items50"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items51"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items52"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items53"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items54"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items55"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items56"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items57"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items58"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items59"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items60"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items61"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items62"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items63"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items64"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items65"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items66"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items67"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items68"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items69"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items70"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items71"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items72"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items73"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items74"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items75"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items76"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items77"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items78"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items79"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items80"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items81"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items82"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items83"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items84"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items85"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items86"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items87"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items88"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items89"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items90"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items91"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items92"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items93"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items94"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items95"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items96"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items97"),
				componentResourceManager.GetString("JumpCrouchcomboBox.Items98")
			});
			this.JumpCrouchcomboBox.Name = "JumpCrouchcomboBox";
			this.toolTip1.SetToolTip(this.JumpCrouchcomboBox, componentResourceManager.GetString("JumpCrouchcomboBox.ToolTip"));
			componentResourceManager.ApplyResources(this.groupBox17, "groupBox17");
			this.groupBox17.BackColor = global::System.Drawing.Color.Transparent;
			this.groupBox17.Controls.Add(this.label14);
			this.groupBox17.Controls.Add(this.label13);
			this.groupBox17.Controls.Add(this.Dodge_comboBox2);
			this.groupBox17.Controls.Add(this.label12);
			this.groupBox17.Controls.Add(this.Dodge_Timer);
			this.groupBox17.Controls.Add(this.Dodge_comboBox1);
			this.groupBox17.ForeColor = global::System.Drawing.Color.Lime;
			this.groupBox17.Name = "groupBox17";
			this.groupBox17.TabStop = false;
			this.toolTip1.SetToolTip(this.groupBox17, componentResourceManager.GetString("groupBox17.ToolTip"));
			componentResourceManager.ApplyResources(this.label14, "label14");
			this.label14.ForeColor = global::System.Drawing.Color.FromArgb(128, 255, 255);
			this.label14.Name = "label14";
			this.toolTip1.SetToolTip(this.label14, componentResourceManager.GetString("label14.ToolTip"));
			componentResourceManager.ApplyResources(this.label13, "label13");
			this.label13.ForeColor = global::System.Drawing.Color.FromArgb(128, 255, 255);
			this.label13.Name = "label13";
			this.toolTip1.SetToolTip(this.label13, componentResourceManager.GetString("label13.ToolTip"));
			componentResourceManager.ApplyResources(this.Dodge_comboBox2, "Dodge_comboBox2");
			this.Dodge_comboBox2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Dodge_comboBox2.FormattingEnabled = true;
			this.Dodge_comboBox2.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("Dodge_comboBox2.Items"),
				componentResourceManager.GetString("Dodge_comboBox2.Items1"),
				componentResourceManager.GetString("Dodge_comboBox2.Items2"),
				componentResourceManager.GetString("Dodge_comboBox2.Items3"),
				componentResourceManager.GetString("Dodge_comboBox2.Items4"),
				componentResourceManager.GetString("Dodge_comboBox2.Items5"),
				componentResourceManager.GetString("Dodge_comboBox2.Items6"),
				componentResourceManager.GetString("Dodge_comboBox2.Items7"),
				componentResourceManager.GetString("Dodge_comboBox2.Items8"),
				componentResourceManager.GetString("Dodge_comboBox2.Items9"),
				componentResourceManager.GetString("Dodge_comboBox2.Items10"),
				componentResourceManager.GetString("Dodge_comboBox2.Items11"),
				componentResourceManager.GetString("Dodge_comboBox2.Items12"),
				componentResourceManager.GetString("Dodge_comboBox2.Items13"),
				componentResourceManager.GetString("Dodge_comboBox2.Items14"),
				componentResourceManager.GetString("Dodge_comboBox2.Items15"),
				componentResourceManager.GetString("Dodge_comboBox2.Items16"),
				componentResourceManager.GetString("Dodge_comboBox2.Items17"),
				componentResourceManager.GetString("Dodge_comboBox2.Items18"),
				componentResourceManager.GetString("Dodge_comboBox2.Items19"),
				componentResourceManager.GetString("Dodge_comboBox2.Items20"),
				componentResourceManager.GetString("Dodge_comboBox2.Items21"),
				componentResourceManager.GetString("Dodge_comboBox2.Items22"),
				componentResourceManager.GetString("Dodge_comboBox2.Items23"),
				componentResourceManager.GetString("Dodge_comboBox2.Items24"),
				componentResourceManager.GetString("Dodge_comboBox2.Items25"),
				componentResourceManager.GetString("Dodge_comboBox2.Items26"),
				componentResourceManager.GetString("Dodge_comboBox2.Items27"),
				componentResourceManager.GetString("Dodge_comboBox2.Items28"),
				componentResourceManager.GetString("Dodge_comboBox2.Items29"),
				componentResourceManager.GetString("Dodge_comboBox2.Items30"),
				componentResourceManager.GetString("Dodge_comboBox2.Items31"),
				componentResourceManager.GetString("Dodge_comboBox2.Items32"),
				componentResourceManager.GetString("Dodge_comboBox2.Items33"),
				componentResourceManager.GetString("Dodge_comboBox2.Items34"),
				componentResourceManager.GetString("Dodge_comboBox2.Items35"),
				componentResourceManager.GetString("Dodge_comboBox2.Items36"),
				componentResourceManager.GetString("Dodge_comboBox2.Items37"),
				componentResourceManager.GetString("Dodge_comboBox2.Items38"),
				componentResourceManager.GetString("Dodge_comboBox2.Items39"),
				componentResourceManager.GetString("Dodge_comboBox2.Items40"),
				componentResourceManager.GetString("Dodge_comboBox2.Items41"),
				componentResourceManager.GetString("Dodge_comboBox2.Items42"),
				componentResourceManager.GetString("Dodge_comboBox2.Items43"),
				componentResourceManager.GetString("Dodge_comboBox2.Items44"),
				componentResourceManager.GetString("Dodge_comboBox2.Items45"),
				componentResourceManager.GetString("Dodge_comboBox2.Items46"),
				componentResourceManager.GetString("Dodge_comboBox2.Items47"),
				componentResourceManager.GetString("Dodge_comboBox2.Items48"),
				componentResourceManager.GetString("Dodge_comboBox2.Items49"),
				componentResourceManager.GetString("Dodge_comboBox2.Items50"),
				componentResourceManager.GetString("Dodge_comboBox2.Items51"),
				componentResourceManager.GetString("Dodge_comboBox2.Items52"),
				componentResourceManager.GetString("Dodge_comboBox2.Items53"),
				componentResourceManager.GetString("Dodge_comboBox2.Items54"),
				componentResourceManager.GetString("Dodge_comboBox2.Items55"),
				componentResourceManager.GetString("Dodge_comboBox2.Items56"),
				componentResourceManager.GetString("Dodge_comboBox2.Items57"),
				componentResourceManager.GetString("Dodge_comboBox2.Items58"),
				componentResourceManager.GetString("Dodge_comboBox2.Items59"),
				componentResourceManager.GetString("Dodge_comboBox2.Items60"),
				componentResourceManager.GetString("Dodge_comboBox2.Items61"),
				componentResourceManager.GetString("Dodge_comboBox2.Items62"),
				componentResourceManager.GetString("Dodge_comboBox2.Items63"),
				componentResourceManager.GetString("Dodge_comboBox2.Items64"),
				componentResourceManager.GetString("Dodge_comboBox2.Items65"),
				componentResourceManager.GetString("Dodge_comboBox2.Items66"),
				componentResourceManager.GetString("Dodge_comboBox2.Items67"),
				componentResourceManager.GetString("Dodge_comboBox2.Items68"),
				componentResourceManager.GetString("Dodge_comboBox2.Items69"),
				componentResourceManager.GetString("Dodge_comboBox2.Items70"),
				componentResourceManager.GetString("Dodge_comboBox2.Items71"),
				componentResourceManager.GetString("Dodge_comboBox2.Items72"),
				componentResourceManager.GetString("Dodge_comboBox2.Items73"),
				componentResourceManager.GetString("Dodge_comboBox2.Items74"),
				componentResourceManager.GetString("Dodge_comboBox2.Items75"),
				componentResourceManager.GetString("Dodge_comboBox2.Items76"),
				componentResourceManager.GetString("Dodge_comboBox2.Items77"),
				componentResourceManager.GetString("Dodge_comboBox2.Items78"),
				componentResourceManager.GetString("Dodge_comboBox2.Items79"),
				componentResourceManager.GetString("Dodge_comboBox2.Items80"),
				componentResourceManager.GetString("Dodge_comboBox2.Items81"),
				componentResourceManager.GetString("Dodge_comboBox2.Items82"),
				componentResourceManager.GetString("Dodge_comboBox2.Items83"),
				componentResourceManager.GetString("Dodge_comboBox2.Items84"),
				componentResourceManager.GetString("Dodge_comboBox2.Items85"),
				componentResourceManager.GetString("Dodge_comboBox2.Items86"),
				componentResourceManager.GetString("Dodge_comboBox2.Items87"),
				componentResourceManager.GetString("Dodge_comboBox2.Items88"),
				componentResourceManager.GetString("Dodge_comboBox2.Items89"),
				componentResourceManager.GetString("Dodge_comboBox2.Items90"),
				componentResourceManager.GetString("Dodge_comboBox2.Items91"),
				componentResourceManager.GetString("Dodge_comboBox2.Items92"),
				componentResourceManager.GetString("Dodge_comboBox2.Items93"),
				componentResourceManager.GetString("Dodge_comboBox2.Items94"),
				componentResourceManager.GetString("Dodge_comboBox2.Items95"),
				componentResourceManager.GetString("Dodge_comboBox2.Items96"),
				componentResourceManager.GetString("Dodge_comboBox2.Items97"),
				componentResourceManager.GetString("Dodge_comboBox2.Items98")
			});
			this.Dodge_comboBox2.Name = "Dodge_comboBox2";
			this.toolTip1.SetToolTip(this.Dodge_comboBox2, componentResourceManager.GetString("Dodge_comboBox2.ToolTip"));
			componentResourceManager.ApplyResources(this.label12, "label12");
			this.label12.ForeColor = global::System.Drawing.Color.Black;
			this.label12.Name = "label12";
			this.toolTip1.SetToolTip(this.label12, componentResourceManager.GetString("label12.ToolTip"));
			componentResourceManager.ApplyResources(this.Dodge_Timer, "Dodge_Timer");
			this.Dodge_Timer.Name = "Dodge_Timer";
			this.toolTip1.SetToolTip(this.Dodge_Timer, componentResourceManager.GetString("Dodge_Timer.ToolTip"));
			componentResourceManager.ApplyResources(this.Dodge_comboBox1, "Dodge_comboBox1");
			this.Dodge_comboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Dodge_comboBox1.FormattingEnabled = true;
			this.Dodge_comboBox1.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("Dodge_comboBox1.Items"),
				componentResourceManager.GetString("Dodge_comboBox1.Items1"),
				componentResourceManager.GetString("Dodge_comboBox1.Items2"),
				componentResourceManager.GetString("Dodge_comboBox1.Items3"),
				componentResourceManager.GetString("Dodge_comboBox1.Items4"),
				componentResourceManager.GetString("Dodge_comboBox1.Items5"),
				componentResourceManager.GetString("Dodge_comboBox1.Items6"),
				componentResourceManager.GetString("Dodge_comboBox1.Items7"),
				componentResourceManager.GetString("Dodge_comboBox1.Items8"),
				componentResourceManager.GetString("Dodge_comboBox1.Items9"),
				componentResourceManager.GetString("Dodge_comboBox1.Items10"),
				componentResourceManager.GetString("Dodge_comboBox1.Items11"),
				componentResourceManager.GetString("Dodge_comboBox1.Items12"),
				componentResourceManager.GetString("Dodge_comboBox1.Items13"),
				componentResourceManager.GetString("Dodge_comboBox1.Items14"),
				componentResourceManager.GetString("Dodge_comboBox1.Items15"),
				componentResourceManager.GetString("Dodge_comboBox1.Items16"),
				componentResourceManager.GetString("Dodge_comboBox1.Items17"),
				componentResourceManager.GetString("Dodge_comboBox1.Items18"),
				componentResourceManager.GetString("Dodge_comboBox1.Items19"),
				componentResourceManager.GetString("Dodge_comboBox1.Items20"),
				componentResourceManager.GetString("Dodge_comboBox1.Items21"),
				componentResourceManager.GetString("Dodge_comboBox1.Items22"),
				componentResourceManager.GetString("Dodge_comboBox1.Items23"),
				componentResourceManager.GetString("Dodge_comboBox1.Items24"),
				componentResourceManager.GetString("Dodge_comboBox1.Items25"),
				componentResourceManager.GetString("Dodge_comboBox1.Items26"),
				componentResourceManager.GetString("Dodge_comboBox1.Items27"),
				componentResourceManager.GetString("Dodge_comboBox1.Items28"),
				componentResourceManager.GetString("Dodge_comboBox1.Items29"),
				componentResourceManager.GetString("Dodge_comboBox1.Items30"),
				componentResourceManager.GetString("Dodge_comboBox1.Items31"),
				componentResourceManager.GetString("Dodge_comboBox1.Items32"),
				componentResourceManager.GetString("Dodge_comboBox1.Items33"),
				componentResourceManager.GetString("Dodge_comboBox1.Items34"),
				componentResourceManager.GetString("Dodge_comboBox1.Items35"),
				componentResourceManager.GetString("Dodge_comboBox1.Items36"),
				componentResourceManager.GetString("Dodge_comboBox1.Items37"),
				componentResourceManager.GetString("Dodge_comboBox1.Items38"),
				componentResourceManager.GetString("Dodge_comboBox1.Items39"),
				componentResourceManager.GetString("Dodge_comboBox1.Items40"),
				componentResourceManager.GetString("Dodge_comboBox1.Items41"),
				componentResourceManager.GetString("Dodge_comboBox1.Items42"),
				componentResourceManager.GetString("Dodge_comboBox1.Items43"),
				componentResourceManager.GetString("Dodge_comboBox1.Items44"),
				componentResourceManager.GetString("Dodge_comboBox1.Items45"),
				componentResourceManager.GetString("Dodge_comboBox1.Items46"),
				componentResourceManager.GetString("Dodge_comboBox1.Items47"),
				componentResourceManager.GetString("Dodge_comboBox1.Items48"),
				componentResourceManager.GetString("Dodge_comboBox1.Items49"),
				componentResourceManager.GetString("Dodge_comboBox1.Items50"),
				componentResourceManager.GetString("Dodge_comboBox1.Items51"),
				componentResourceManager.GetString("Dodge_comboBox1.Items52"),
				componentResourceManager.GetString("Dodge_comboBox1.Items53"),
				componentResourceManager.GetString("Dodge_comboBox1.Items54"),
				componentResourceManager.GetString("Dodge_comboBox1.Items55"),
				componentResourceManager.GetString("Dodge_comboBox1.Items56"),
				componentResourceManager.GetString("Dodge_comboBox1.Items57"),
				componentResourceManager.GetString("Dodge_comboBox1.Items58"),
				componentResourceManager.GetString("Dodge_comboBox1.Items59"),
				componentResourceManager.GetString("Dodge_comboBox1.Items60"),
				componentResourceManager.GetString("Dodge_comboBox1.Items61"),
				componentResourceManager.GetString("Dodge_comboBox1.Items62"),
				componentResourceManager.GetString("Dodge_comboBox1.Items63"),
				componentResourceManager.GetString("Dodge_comboBox1.Items64"),
				componentResourceManager.GetString("Dodge_comboBox1.Items65"),
				componentResourceManager.GetString("Dodge_comboBox1.Items66"),
				componentResourceManager.GetString("Dodge_comboBox1.Items67"),
				componentResourceManager.GetString("Dodge_comboBox1.Items68"),
				componentResourceManager.GetString("Dodge_comboBox1.Items69"),
				componentResourceManager.GetString("Dodge_comboBox1.Items70"),
				componentResourceManager.GetString("Dodge_comboBox1.Items71"),
				componentResourceManager.GetString("Dodge_comboBox1.Items72"),
				componentResourceManager.GetString("Dodge_comboBox1.Items73"),
				componentResourceManager.GetString("Dodge_comboBox1.Items74"),
				componentResourceManager.GetString("Dodge_comboBox1.Items75"),
				componentResourceManager.GetString("Dodge_comboBox1.Items76"),
				componentResourceManager.GetString("Dodge_comboBox1.Items77"),
				componentResourceManager.GetString("Dodge_comboBox1.Items78"),
				componentResourceManager.GetString("Dodge_comboBox1.Items79"),
				componentResourceManager.GetString("Dodge_comboBox1.Items80"),
				componentResourceManager.GetString("Dodge_comboBox1.Items81"),
				componentResourceManager.GetString("Dodge_comboBox1.Items82"),
				componentResourceManager.GetString("Dodge_comboBox1.Items83"),
				componentResourceManager.GetString("Dodge_comboBox1.Items84"),
				componentResourceManager.GetString("Dodge_comboBox1.Items85"),
				componentResourceManager.GetString("Dodge_comboBox1.Items86"),
				componentResourceManager.GetString("Dodge_comboBox1.Items87"),
				componentResourceManager.GetString("Dodge_comboBox1.Items88"),
				componentResourceManager.GetString("Dodge_comboBox1.Items89"),
				componentResourceManager.GetString("Dodge_comboBox1.Items90"),
				componentResourceManager.GetString("Dodge_comboBox1.Items91"),
				componentResourceManager.GetString("Dodge_comboBox1.Items92"),
				componentResourceManager.GetString("Dodge_comboBox1.Items93"),
				componentResourceManager.GetString("Dodge_comboBox1.Items94"),
				componentResourceManager.GetString("Dodge_comboBox1.Items95"),
				componentResourceManager.GetString("Dodge_comboBox1.Items96"),
				componentResourceManager.GetString("Dodge_comboBox1.Items97"),
				componentResourceManager.GetString("Dodge_comboBox1.Items98")
			});
			this.Dodge_comboBox1.Name = "Dodge_comboBox1";
			this.toolTip1.SetToolTip(this.Dodge_comboBox1, componentResourceManager.GetString("Dodge_comboBox1.ToolTip"));
			componentResourceManager.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.QuickSitComboBox);
			this.groupBox1.ForeColor = global::System.Drawing.Color.Lime;
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			this.toolTip1.SetToolTip(this.groupBox1, componentResourceManager.GetString("groupBox1.ToolTip"));
			componentResourceManager.ApplyResources(this.QuickSitComboBox, "QuickSitComboBox");
			this.QuickSitComboBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.QuickSitComboBox.FormattingEnabled = true;
			this.QuickSitComboBox.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("QuickSitComboBox.Items"),
				componentResourceManager.GetString("QuickSitComboBox.Items1"),
				componentResourceManager.GetString("QuickSitComboBox.Items2"),
				componentResourceManager.GetString("QuickSitComboBox.Items3"),
				componentResourceManager.GetString("QuickSitComboBox.Items4"),
				componentResourceManager.GetString("QuickSitComboBox.Items5"),
				componentResourceManager.GetString("QuickSitComboBox.Items6"),
				componentResourceManager.GetString("QuickSitComboBox.Items7"),
				componentResourceManager.GetString("QuickSitComboBox.Items8"),
				componentResourceManager.GetString("QuickSitComboBox.Items9"),
				componentResourceManager.GetString("QuickSitComboBox.Items10"),
				componentResourceManager.GetString("QuickSitComboBox.Items11"),
				componentResourceManager.GetString("QuickSitComboBox.Items12"),
				componentResourceManager.GetString("QuickSitComboBox.Items13"),
				componentResourceManager.GetString("QuickSitComboBox.Items14"),
				componentResourceManager.GetString("QuickSitComboBox.Items15"),
				componentResourceManager.GetString("QuickSitComboBox.Items16"),
				componentResourceManager.GetString("QuickSitComboBox.Items17"),
				componentResourceManager.GetString("QuickSitComboBox.Items18"),
				componentResourceManager.GetString("QuickSitComboBox.Items19"),
				componentResourceManager.GetString("QuickSitComboBox.Items20"),
				componentResourceManager.GetString("QuickSitComboBox.Items21"),
				componentResourceManager.GetString("QuickSitComboBox.Items22"),
				componentResourceManager.GetString("QuickSitComboBox.Items23"),
				componentResourceManager.GetString("QuickSitComboBox.Items24"),
				componentResourceManager.GetString("QuickSitComboBox.Items25"),
				componentResourceManager.GetString("QuickSitComboBox.Items26"),
				componentResourceManager.GetString("QuickSitComboBox.Items27"),
				componentResourceManager.GetString("QuickSitComboBox.Items28"),
				componentResourceManager.GetString("QuickSitComboBox.Items29"),
				componentResourceManager.GetString("QuickSitComboBox.Items30"),
				componentResourceManager.GetString("QuickSitComboBox.Items31"),
				componentResourceManager.GetString("QuickSitComboBox.Items32"),
				componentResourceManager.GetString("QuickSitComboBox.Items33"),
				componentResourceManager.GetString("QuickSitComboBox.Items34"),
				componentResourceManager.GetString("QuickSitComboBox.Items35"),
				componentResourceManager.GetString("QuickSitComboBox.Items36"),
				componentResourceManager.GetString("QuickSitComboBox.Items37"),
				componentResourceManager.GetString("QuickSitComboBox.Items38"),
				componentResourceManager.GetString("QuickSitComboBox.Items39"),
				componentResourceManager.GetString("QuickSitComboBox.Items40"),
				componentResourceManager.GetString("QuickSitComboBox.Items41"),
				componentResourceManager.GetString("QuickSitComboBox.Items42"),
				componentResourceManager.GetString("QuickSitComboBox.Items43"),
				componentResourceManager.GetString("QuickSitComboBox.Items44"),
				componentResourceManager.GetString("QuickSitComboBox.Items45"),
				componentResourceManager.GetString("QuickSitComboBox.Items46"),
				componentResourceManager.GetString("QuickSitComboBox.Items47"),
				componentResourceManager.GetString("QuickSitComboBox.Items48"),
				componentResourceManager.GetString("QuickSitComboBox.Items49"),
				componentResourceManager.GetString("QuickSitComboBox.Items50"),
				componentResourceManager.GetString("QuickSitComboBox.Items51"),
				componentResourceManager.GetString("QuickSitComboBox.Items52"),
				componentResourceManager.GetString("QuickSitComboBox.Items53"),
				componentResourceManager.GetString("QuickSitComboBox.Items54"),
				componentResourceManager.GetString("QuickSitComboBox.Items55"),
				componentResourceManager.GetString("QuickSitComboBox.Items56"),
				componentResourceManager.GetString("QuickSitComboBox.Items57"),
				componentResourceManager.GetString("QuickSitComboBox.Items58"),
				componentResourceManager.GetString("QuickSitComboBox.Items59"),
				componentResourceManager.GetString("QuickSitComboBox.Items60"),
				componentResourceManager.GetString("QuickSitComboBox.Items61"),
				componentResourceManager.GetString("QuickSitComboBox.Items62"),
				componentResourceManager.GetString("QuickSitComboBox.Items63"),
				componentResourceManager.GetString("QuickSitComboBox.Items64"),
				componentResourceManager.GetString("QuickSitComboBox.Items65"),
				componentResourceManager.GetString("QuickSitComboBox.Items66"),
				componentResourceManager.GetString("QuickSitComboBox.Items67"),
				componentResourceManager.GetString("QuickSitComboBox.Items68"),
				componentResourceManager.GetString("QuickSitComboBox.Items69"),
				componentResourceManager.GetString("QuickSitComboBox.Items70"),
				componentResourceManager.GetString("QuickSitComboBox.Items71"),
				componentResourceManager.GetString("QuickSitComboBox.Items72"),
				componentResourceManager.GetString("QuickSitComboBox.Items73"),
				componentResourceManager.GetString("QuickSitComboBox.Items74"),
				componentResourceManager.GetString("QuickSitComboBox.Items75"),
				componentResourceManager.GetString("QuickSitComboBox.Items76"),
				componentResourceManager.GetString("QuickSitComboBox.Items77"),
				componentResourceManager.GetString("QuickSitComboBox.Items78"),
				componentResourceManager.GetString("QuickSitComboBox.Items79"),
				componentResourceManager.GetString("QuickSitComboBox.Items80"),
				componentResourceManager.GetString("QuickSitComboBox.Items81"),
				componentResourceManager.GetString("QuickSitComboBox.Items82"),
				componentResourceManager.GetString("QuickSitComboBox.Items83"),
				componentResourceManager.GetString("QuickSitComboBox.Items84"),
				componentResourceManager.GetString("QuickSitComboBox.Items85"),
				componentResourceManager.GetString("QuickSitComboBox.Items86"),
				componentResourceManager.GetString("QuickSitComboBox.Items87"),
				componentResourceManager.GetString("QuickSitComboBox.Items88"),
				componentResourceManager.GetString("QuickSitComboBox.Items89"),
				componentResourceManager.GetString("QuickSitComboBox.Items90"),
				componentResourceManager.GetString("QuickSitComboBox.Items91"),
				componentResourceManager.GetString("QuickSitComboBox.Items92"),
				componentResourceManager.GetString("QuickSitComboBox.Items93"),
				componentResourceManager.GetString("QuickSitComboBox.Items94"),
				componentResourceManager.GetString("QuickSitComboBox.Items95"),
				componentResourceManager.GetString("QuickSitComboBox.Items96"),
				componentResourceManager.GetString("QuickSitComboBox.Items97"),
				componentResourceManager.GetString("QuickSitComboBox.Items98")
			});
			this.QuickSitComboBox.Name = "QuickSitComboBox";
			this.toolTip1.SetToolTip(this.QuickSitComboBox, componentResourceManager.GetString("QuickSitComboBox.ToolTip"));
			componentResourceManager.ApplyResources(this.button2, "button2");
			this.button2.BackColor = global::System.Drawing.Color.White;
			this.button2.ForeColor = global::System.Drawing.Color.Black;
			this.button2.Name = "button2";
			this.toolTip1.SetToolTip(this.button2, componentResourceManager.GetString("button2.ToolTip"));
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			componentResourceManager.ApplyResources(this.groupBox2, "groupBox2");
			this.groupBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.slidingcomboBox);
			this.groupBox2.ForeColor = global::System.Drawing.Color.Lime;
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.TabStop = false;
			this.toolTip1.SetToolTip(this.groupBox2, componentResourceManager.GetString("groupBox2.ToolTip"));
			componentResourceManager.ApplyResources(this.slidingcomboBox, "slidingcomboBox");
			this.slidingcomboBox.FormattingEnabled = true;
			this.slidingcomboBox.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("slidingcomboBox.Items"),
				componentResourceManager.GetString("slidingcomboBox.Items1"),
				componentResourceManager.GetString("slidingcomboBox.Items2"),
				componentResourceManager.GetString("slidingcomboBox.Items3"),
				componentResourceManager.GetString("slidingcomboBox.Items4"),
				componentResourceManager.GetString("slidingcomboBox.Items5"),
				componentResourceManager.GetString("slidingcomboBox.Items6"),
				componentResourceManager.GetString("slidingcomboBox.Items7"),
				componentResourceManager.GetString("slidingcomboBox.Items8"),
				componentResourceManager.GetString("slidingcomboBox.Items9"),
				componentResourceManager.GetString("slidingcomboBox.Items10"),
				componentResourceManager.GetString("slidingcomboBox.Items11"),
				componentResourceManager.GetString("slidingcomboBox.Items12"),
				componentResourceManager.GetString("slidingcomboBox.Items13"),
				componentResourceManager.GetString("slidingcomboBox.Items14"),
				componentResourceManager.GetString("slidingcomboBox.Items15"),
				componentResourceManager.GetString("slidingcomboBox.Items16"),
				componentResourceManager.GetString("slidingcomboBox.Items17"),
				componentResourceManager.GetString("slidingcomboBox.Items18"),
				componentResourceManager.GetString("slidingcomboBox.Items19"),
				componentResourceManager.GetString("slidingcomboBox.Items20"),
				componentResourceManager.GetString("slidingcomboBox.Items21"),
				componentResourceManager.GetString("slidingcomboBox.Items22"),
				componentResourceManager.GetString("slidingcomboBox.Items23"),
				componentResourceManager.GetString("slidingcomboBox.Items24"),
				componentResourceManager.GetString("slidingcomboBox.Items25"),
				componentResourceManager.GetString("slidingcomboBox.Items26"),
				componentResourceManager.GetString("slidingcomboBox.Items27"),
				componentResourceManager.GetString("slidingcomboBox.Items28"),
				componentResourceManager.GetString("slidingcomboBox.Items29"),
				componentResourceManager.GetString("slidingcomboBox.Items30"),
				componentResourceManager.GetString("slidingcomboBox.Items31"),
				componentResourceManager.GetString("slidingcomboBox.Items32"),
				componentResourceManager.GetString("slidingcomboBox.Items33"),
				componentResourceManager.GetString("slidingcomboBox.Items34"),
				componentResourceManager.GetString("slidingcomboBox.Items35"),
				componentResourceManager.GetString("slidingcomboBox.Items36"),
				componentResourceManager.GetString("slidingcomboBox.Items37"),
				componentResourceManager.GetString("slidingcomboBox.Items38"),
				componentResourceManager.GetString("slidingcomboBox.Items39"),
				componentResourceManager.GetString("slidingcomboBox.Items40"),
				componentResourceManager.GetString("slidingcomboBox.Items41"),
				componentResourceManager.GetString("slidingcomboBox.Items42"),
				componentResourceManager.GetString("slidingcomboBox.Items43"),
				componentResourceManager.GetString("slidingcomboBox.Items44"),
				componentResourceManager.GetString("slidingcomboBox.Items45"),
				componentResourceManager.GetString("slidingcomboBox.Items46"),
				componentResourceManager.GetString("slidingcomboBox.Items47"),
				componentResourceManager.GetString("slidingcomboBox.Items48"),
				componentResourceManager.GetString("slidingcomboBox.Items49"),
				componentResourceManager.GetString("slidingcomboBox.Items50"),
				componentResourceManager.GetString("slidingcomboBox.Items51"),
				componentResourceManager.GetString("slidingcomboBox.Items52"),
				componentResourceManager.GetString("slidingcomboBox.Items53"),
				componentResourceManager.GetString("slidingcomboBox.Items54"),
				componentResourceManager.GetString("slidingcomboBox.Items55"),
				componentResourceManager.GetString("slidingcomboBox.Items56"),
				componentResourceManager.GetString("slidingcomboBox.Items57"),
				componentResourceManager.GetString("slidingcomboBox.Items58"),
				componentResourceManager.GetString("slidingcomboBox.Items59"),
				componentResourceManager.GetString("slidingcomboBox.Items60"),
				componentResourceManager.GetString("slidingcomboBox.Items61"),
				componentResourceManager.GetString("slidingcomboBox.Items62"),
				componentResourceManager.GetString("slidingcomboBox.Items63"),
				componentResourceManager.GetString("slidingcomboBox.Items64"),
				componentResourceManager.GetString("slidingcomboBox.Items65"),
				componentResourceManager.GetString("slidingcomboBox.Items66"),
				componentResourceManager.GetString("slidingcomboBox.Items67"),
				componentResourceManager.GetString("slidingcomboBox.Items68"),
				componentResourceManager.GetString("slidingcomboBox.Items69"),
				componentResourceManager.GetString("slidingcomboBox.Items70"),
				componentResourceManager.GetString("slidingcomboBox.Items71"),
				componentResourceManager.GetString("slidingcomboBox.Items72"),
				componentResourceManager.GetString("slidingcomboBox.Items73"),
				componentResourceManager.GetString("slidingcomboBox.Items74"),
				componentResourceManager.GetString("slidingcomboBox.Items75"),
				componentResourceManager.GetString("slidingcomboBox.Items76"),
				componentResourceManager.GetString("slidingcomboBox.Items77"),
				componentResourceManager.GetString("slidingcomboBox.Items78"),
				componentResourceManager.GetString("slidingcomboBox.Items79"),
				componentResourceManager.GetString("slidingcomboBox.Items80"),
				componentResourceManager.GetString("slidingcomboBox.Items81"),
				componentResourceManager.GetString("slidingcomboBox.Items82"),
				componentResourceManager.GetString("slidingcomboBox.Items83"),
				componentResourceManager.GetString("slidingcomboBox.Items84"),
				componentResourceManager.GetString("slidingcomboBox.Items85"),
				componentResourceManager.GetString("slidingcomboBox.Items86"),
				componentResourceManager.GetString("slidingcomboBox.Items87"),
				componentResourceManager.GetString("slidingcomboBox.Items88"),
				componentResourceManager.GetString("slidingcomboBox.Items89"),
				componentResourceManager.GetString("slidingcomboBox.Items90"),
				componentResourceManager.GetString("slidingcomboBox.Items91"),
				componentResourceManager.GetString("slidingcomboBox.Items92"),
				componentResourceManager.GetString("slidingcomboBox.Items93"),
				componentResourceManager.GetString("slidingcomboBox.Items94"),
				componentResourceManager.GetString("slidingcomboBox.Items95"),
				componentResourceManager.GetString("slidingcomboBox.Items96"),
				componentResourceManager.GetString("slidingcomboBox.Items97"),
				componentResourceManager.GetString("slidingcomboBox.Items98")
			});
			this.slidingcomboBox.Name = "slidingcomboBox";
			this.toolTip1.SetToolTip(this.slidingcomboBox, componentResourceManager.GetString("slidingcomboBox.ToolTip"));
			componentResourceManager.ApplyResources(this.startEmalutor, "startEmalutor");
			this.startEmalutor.BackColor = global::System.Drawing.Color.White;
			this.startEmalutor.ForeColor = global::System.Drawing.Color.Black;
			this.startEmalutor.Name = "startEmalutor";
			this.toolTip1.SetToolTip(this.startEmalutor, componentResourceManager.GetString("startEmalutor.ToolTip"));
			this.startEmalutor.UseVisualStyleBackColor = false;
			this.startEmalutor.Click += new global::System.EventHandler(this.startEmalutor_Click);
			componentResourceManager.ApplyResources(this.groupBox16, "groupBox16");
			this.groupBox16.BackColor = global::System.Drawing.Color.Transparent;
			this.groupBox16.Controls.Add(this.checkBox3);
			this.groupBox16.ForeColor = global::System.Drawing.Color.Lime;
			this.groupBox16.Name = "groupBox16";
			this.groupBox16.TabStop = false;
			this.toolTip1.SetToolTip(this.groupBox16, componentResourceManager.GetString("groupBox16.ToolTip"));
			componentResourceManager.ApplyResources(this.checkBox3, "checkBox3");
			this.checkBox3.ForeColor = global::System.Drawing.Color.White;
			this.checkBox3.Name = "checkBox3";
			this.toolTip1.SetToolTip(this.checkBox3, componentResourceManager.GetString("checkBox3.ToolTip"));
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox3.CheckedChanged += new global::System.EventHandler(this.checkBox3_CheckedChanged);
			componentResourceManager.ApplyResources(this.Active_button, "Active_button");
			this.Active_button.BackColor = global::System.Drawing.Color.White;
			this.Active_button.ForeColor = global::System.Drawing.Color.Black;
			this.Active_button.Name = "Active_button";
			this.toolTip1.SetToolTip(this.Active_button, componentResourceManager.GetString("Active_button.ToolTip"));
			this.Active_button.UseVisualStyleBackColor = false;
			this.Active_button.Click += new global::System.EventHandler(this.Active_button_Click);
			componentResourceManager.ApplyResources(this.groupBox4, "groupBox4");
			this.groupBox4.BackColor = global::System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.jump_prone_comboBox);
			this.groupBox4.ForeColor = global::System.Drawing.Color.Lime;
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.TabStop = false;
			this.toolTip1.SetToolTip(this.groupBox4, componentResourceManager.GetString("groupBox4.ToolTip"));
			componentResourceManager.ApplyResources(this.jump_prone_comboBox, "jump_prone_comboBox");
			this.jump_prone_comboBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.jump_prone_comboBox.FormattingEnabled = true;
			this.jump_prone_comboBox.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("jump_prone_comboBox.Items"),
				componentResourceManager.GetString("jump_prone_comboBox.Items1"),
				componentResourceManager.GetString("jump_prone_comboBox.Items2"),
				componentResourceManager.GetString("jump_prone_comboBox.Items3"),
				componentResourceManager.GetString("jump_prone_comboBox.Items4"),
				componentResourceManager.GetString("jump_prone_comboBox.Items5"),
				componentResourceManager.GetString("jump_prone_comboBox.Items6"),
				componentResourceManager.GetString("jump_prone_comboBox.Items7"),
				componentResourceManager.GetString("jump_prone_comboBox.Items8"),
				componentResourceManager.GetString("jump_prone_comboBox.Items9"),
				componentResourceManager.GetString("jump_prone_comboBox.Items10"),
				componentResourceManager.GetString("jump_prone_comboBox.Items11"),
				componentResourceManager.GetString("jump_prone_comboBox.Items12"),
				componentResourceManager.GetString("jump_prone_comboBox.Items13"),
				componentResourceManager.GetString("jump_prone_comboBox.Items14"),
				componentResourceManager.GetString("jump_prone_comboBox.Items15"),
				componentResourceManager.GetString("jump_prone_comboBox.Items16"),
				componentResourceManager.GetString("jump_prone_comboBox.Items17"),
				componentResourceManager.GetString("jump_prone_comboBox.Items18"),
				componentResourceManager.GetString("jump_prone_comboBox.Items19"),
				componentResourceManager.GetString("jump_prone_comboBox.Items20"),
				componentResourceManager.GetString("jump_prone_comboBox.Items21"),
				componentResourceManager.GetString("jump_prone_comboBox.Items22"),
				componentResourceManager.GetString("jump_prone_comboBox.Items23"),
				componentResourceManager.GetString("jump_prone_comboBox.Items24"),
				componentResourceManager.GetString("jump_prone_comboBox.Items25"),
				componentResourceManager.GetString("jump_prone_comboBox.Items26"),
				componentResourceManager.GetString("jump_prone_comboBox.Items27"),
				componentResourceManager.GetString("jump_prone_comboBox.Items28"),
				componentResourceManager.GetString("jump_prone_comboBox.Items29"),
				componentResourceManager.GetString("jump_prone_comboBox.Items30"),
				componentResourceManager.GetString("jump_prone_comboBox.Items31"),
				componentResourceManager.GetString("jump_prone_comboBox.Items32"),
				componentResourceManager.GetString("jump_prone_comboBox.Items33"),
				componentResourceManager.GetString("jump_prone_comboBox.Items34"),
				componentResourceManager.GetString("jump_prone_comboBox.Items35"),
				componentResourceManager.GetString("jump_prone_comboBox.Items36"),
				componentResourceManager.GetString("jump_prone_comboBox.Items37"),
				componentResourceManager.GetString("jump_prone_comboBox.Items38"),
				componentResourceManager.GetString("jump_prone_comboBox.Items39"),
				componentResourceManager.GetString("jump_prone_comboBox.Items40"),
				componentResourceManager.GetString("jump_prone_comboBox.Items41"),
				componentResourceManager.GetString("jump_prone_comboBox.Items42"),
				componentResourceManager.GetString("jump_prone_comboBox.Items43"),
				componentResourceManager.GetString("jump_prone_comboBox.Items44"),
				componentResourceManager.GetString("jump_prone_comboBox.Items45"),
				componentResourceManager.GetString("jump_prone_comboBox.Items46"),
				componentResourceManager.GetString("jump_prone_comboBox.Items47"),
				componentResourceManager.GetString("jump_prone_comboBox.Items48"),
				componentResourceManager.GetString("jump_prone_comboBox.Items49"),
				componentResourceManager.GetString("jump_prone_comboBox.Items50"),
				componentResourceManager.GetString("jump_prone_comboBox.Items51"),
				componentResourceManager.GetString("jump_prone_comboBox.Items52"),
				componentResourceManager.GetString("jump_prone_comboBox.Items53"),
				componentResourceManager.GetString("jump_prone_comboBox.Items54"),
				componentResourceManager.GetString("jump_prone_comboBox.Items55"),
				componentResourceManager.GetString("jump_prone_comboBox.Items56"),
				componentResourceManager.GetString("jump_prone_comboBox.Items57"),
				componentResourceManager.GetString("jump_prone_comboBox.Items58"),
				componentResourceManager.GetString("jump_prone_comboBox.Items59"),
				componentResourceManager.GetString("jump_prone_comboBox.Items60"),
				componentResourceManager.GetString("jump_prone_comboBox.Items61"),
				componentResourceManager.GetString("jump_prone_comboBox.Items62"),
				componentResourceManager.GetString("jump_prone_comboBox.Items63"),
				componentResourceManager.GetString("jump_prone_comboBox.Items64"),
				componentResourceManager.GetString("jump_prone_comboBox.Items65"),
				componentResourceManager.GetString("jump_prone_comboBox.Items66"),
				componentResourceManager.GetString("jump_prone_comboBox.Items67"),
				componentResourceManager.GetString("jump_prone_comboBox.Items68"),
				componentResourceManager.GetString("jump_prone_comboBox.Items69"),
				componentResourceManager.GetString("jump_prone_comboBox.Items70"),
				componentResourceManager.GetString("jump_prone_comboBox.Items71"),
				componentResourceManager.GetString("jump_prone_comboBox.Items72"),
				componentResourceManager.GetString("jump_prone_comboBox.Items73"),
				componentResourceManager.GetString("jump_prone_comboBox.Items74"),
				componentResourceManager.GetString("jump_prone_comboBox.Items75"),
				componentResourceManager.GetString("jump_prone_comboBox.Items76"),
				componentResourceManager.GetString("jump_prone_comboBox.Items77"),
				componentResourceManager.GetString("jump_prone_comboBox.Items78"),
				componentResourceManager.GetString("jump_prone_comboBox.Items79"),
				componentResourceManager.GetString("jump_prone_comboBox.Items80"),
				componentResourceManager.GetString("jump_prone_comboBox.Items81"),
				componentResourceManager.GetString("jump_prone_comboBox.Items82"),
				componentResourceManager.GetString("jump_prone_comboBox.Items83"),
				componentResourceManager.GetString("jump_prone_comboBox.Items84"),
				componentResourceManager.GetString("jump_prone_comboBox.Items85"),
				componentResourceManager.GetString("jump_prone_comboBox.Items86"),
				componentResourceManager.GetString("jump_prone_comboBox.Items87"),
				componentResourceManager.GetString("jump_prone_comboBox.Items88"),
				componentResourceManager.GetString("jump_prone_comboBox.Items89"),
				componentResourceManager.GetString("jump_prone_comboBox.Items90"),
				componentResourceManager.GetString("jump_prone_comboBox.Items91"),
				componentResourceManager.GetString("jump_prone_comboBox.Items92"),
				componentResourceManager.GetString("jump_prone_comboBox.Items93"),
				componentResourceManager.GetString("jump_prone_comboBox.Items94"),
				componentResourceManager.GetString("jump_prone_comboBox.Items95"),
				componentResourceManager.GetString("jump_prone_comboBox.Items96"),
				componentResourceManager.GetString("jump_prone_comboBox.Items97"),
				componentResourceManager.GetString("jump_prone_comboBox.Items98")
			});
			this.jump_prone_comboBox.Name = "jump_prone_comboBox";
			this.toolTip1.SetToolTip(this.jump_prone_comboBox, componentResourceManager.GetString("jump_prone_comboBox.ToolTip"));
			componentResourceManager.ApplyResources(this.groupBox15, "groupBox15");
			this.groupBox15.BackColor = global::System.Drawing.Color.Transparent;
			this.groupBox15.Controls.Add(this.checkBox2);
			this.groupBox15.ForeColor = global::System.Drawing.Color.Lime;
			this.groupBox15.Name = "groupBox15";
			this.groupBox15.TabStop = false;
			this.toolTip1.SetToolTip(this.groupBox15, componentResourceManager.GetString("groupBox15.ToolTip"));
			componentResourceManager.ApplyResources(this.checkBox2, "checkBox2");
			this.checkBox2.ForeColor = global::System.Drawing.Color.White;
			this.checkBox2.Name = "checkBox2";
			this.toolTip1.SetToolTip(this.checkBox2, componentResourceManager.GetString("checkBox2.ToolTip"));
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new global::System.EventHandler(this.checkBox2_CheckedChanged);
			componentResourceManager.ApplyResources(this.groupBox13, "groupBox13");
			this.groupBox13.BackColor = global::System.Drawing.Color.Transparent;
			this.groupBox13.Controls.Add(this.fixproneComboBox);
			this.groupBox13.ForeColor = global::System.Drawing.Color.Lime;
			this.groupBox13.Name = "groupBox13";
			this.groupBox13.TabStop = false;
			this.toolTip1.SetToolTip(this.groupBox13, componentResourceManager.GetString("groupBox13.ToolTip"));
			componentResourceManager.ApplyResources(this.fixproneComboBox, "fixproneComboBox");
			this.fixproneComboBox.FormattingEnabled = true;
			this.fixproneComboBox.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("fixproneComboBox.Items"),
				componentResourceManager.GetString("fixproneComboBox.Items1"),
				componentResourceManager.GetString("fixproneComboBox.Items2"),
				componentResourceManager.GetString("fixproneComboBox.Items3"),
				componentResourceManager.GetString("fixproneComboBox.Items4"),
				componentResourceManager.GetString("fixproneComboBox.Items5"),
				componentResourceManager.GetString("fixproneComboBox.Items6"),
				componentResourceManager.GetString("fixproneComboBox.Items7"),
				componentResourceManager.GetString("fixproneComboBox.Items8"),
				componentResourceManager.GetString("fixproneComboBox.Items9"),
				componentResourceManager.GetString("fixproneComboBox.Items10"),
				componentResourceManager.GetString("fixproneComboBox.Items11"),
				componentResourceManager.GetString("fixproneComboBox.Items12"),
				componentResourceManager.GetString("fixproneComboBox.Items13"),
				componentResourceManager.GetString("fixproneComboBox.Items14"),
				componentResourceManager.GetString("fixproneComboBox.Items15"),
				componentResourceManager.GetString("fixproneComboBox.Items16"),
				componentResourceManager.GetString("fixproneComboBox.Items17"),
				componentResourceManager.GetString("fixproneComboBox.Items18"),
				componentResourceManager.GetString("fixproneComboBox.Items19"),
				componentResourceManager.GetString("fixproneComboBox.Items20"),
				componentResourceManager.GetString("fixproneComboBox.Items21"),
				componentResourceManager.GetString("fixproneComboBox.Items22"),
				componentResourceManager.GetString("fixproneComboBox.Items23"),
				componentResourceManager.GetString("fixproneComboBox.Items24"),
				componentResourceManager.GetString("fixproneComboBox.Items25"),
				componentResourceManager.GetString("fixproneComboBox.Items26"),
				componentResourceManager.GetString("fixproneComboBox.Items27"),
				componentResourceManager.GetString("fixproneComboBox.Items28"),
				componentResourceManager.GetString("fixproneComboBox.Items29"),
				componentResourceManager.GetString("fixproneComboBox.Items30"),
				componentResourceManager.GetString("fixproneComboBox.Items31"),
				componentResourceManager.GetString("fixproneComboBox.Items32"),
				componentResourceManager.GetString("fixproneComboBox.Items33"),
				componentResourceManager.GetString("fixproneComboBox.Items34"),
				componentResourceManager.GetString("fixproneComboBox.Items35"),
				componentResourceManager.GetString("fixproneComboBox.Items36"),
				componentResourceManager.GetString("fixproneComboBox.Items37"),
				componentResourceManager.GetString("fixproneComboBox.Items38"),
				componentResourceManager.GetString("fixproneComboBox.Items39"),
				componentResourceManager.GetString("fixproneComboBox.Items40"),
				componentResourceManager.GetString("fixproneComboBox.Items41"),
				componentResourceManager.GetString("fixproneComboBox.Items42"),
				componentResourceManager.GetString("fixproneComboBox.Items43"),
				componentResourceManager.GetString("fixproneComboBox.Items44"),
				componentResourceManager.GetString("fixproneComboBox.Items45"),
				componentResourceManager.GetString("fixproneComboBox.Items46"),
				componentResourceManager.GetString("fixproneComboBox.Items47"),
				componentResourceManager.GetString("fixproneComboBox.Items48"),
				componentResourceManager.GetString("fixproneComboBox.Items49"),
				componentResourceManager.GetString("fixproneComboBox.Items50"),
				componentResourceManager.GetString("fixproneComboBox.Items51"),
				componentResourceManager.GetString("fixproneComboBox.Items52"),
				componentResourceManager.GetString("fixproneComboBox.Items53"),
				componentResourceManager.GetString("fixproneComboBox.Items54"),
				componentResourceManager.GetString("fixproneComboBox.Items55"),
				componentResourceManager.GetString("fixproneComboBox.Items56"),
				componentResourceManager.GetString("fixproneComboBox.Items57"),
				componentResourceManager.GetString("fixproneComboBox.Items58"),
				componentResourceManager.GetString("fixproneComboBox.Items59"),
				componentResourceManager.GetString("fixproneComboBox.Items60"),
				componentResourceManager.GetString("fixproneComboBox.Items61"),
				componentResourceManager.GetString("fixproneComboBox.Items62"),
				componentResourceManager.GetString("fixproneComboBox.Items63"),
				componentResourceManager.GetString("fixproneComboBox.Items64"),
				componentResourceManager.GetString("fixproneComboBox.Items65"),
				componentResourceManager.GetString("fixproneComboBox.Items66"),
				componentResourceManager.GetString("fixproneComboBox.Items67"),
				componentResourceManager.GetString("fixproneComboBox.Items68"),
				componentResourceManager.GetString("fixproneComboBox.Items69"),
				componentResourceManager.GetString("fixproneComboBox.Items70"),
				componentResourceManager.GetString("fixproneComboBox.Items71"),
				componentResourceManager.GetString("fixproneComboBox.Items72"),
				componentResourceManager.GetString("fixproneComboBox.Items73"),
				componentResourceManager.GetString("fixproneComboBox.Items74"),
				componentResourceManager.GetString("fixproneComboBox.Items75"),
				componentResourceManager.GetString("fixproneComboBox.Items76"),
				componentResourceManager.GetString("fixproneComboBox.Items77"),
				componentResourceManager.GetString("fixproneComboBox.Items78"),
				componentResourceManager.GetString("fixproneComboBox.Items79"),
				componentResourceManager.GetString("fixproneComboBox.Items80"),
				componentResourceManager.GetString("fixproneComboBox.Items81"),
				componentResourceManager.GetString("fixproneComboBox.Items82"),
				componentResourceManager.GetString("fixproneComboBox.Items83"),
				componentResourceManager.GetString("fixproneComboBox.Items84"),
				componentResourceManager.GetString("fixproneComboBox.Items85"),
				componentResourceManager.GetString("fixproneComboBox.Items86"),
				componentResourceManager.GetString("fixproneComboBox.Items87"),
				componentResourceManager.GetString("fixproneComboBox.Items88"),
				componentResourceManager.GetString("fixproneComboBox.Items89"),
				componentResourceManager.GetString("fixproneComboBox.Items90"),
				componentResourceManager.GetString("fixproneComboBox.Items91"),
				componentResourceManager.GetString("fixproneComboBox.Items92"),
				componentResourceManager.GetString("fixproneComboBox.Items93"),
				componentResourceManager.GetString("fixproneComboBox.Items94"),
				componentResourceManager.GetString("fixproneComboBox.Items95"),
				componentResourceManager.GetString("fixproneComboBox.Items96"),
				componentResourceManager.GetString("fixproneComboBox.Items97"),
				componentResourceManager.GetString("fixproneComboBox.Items98")
			});
			this.fixproneComboBox.Name = "fixproneComboBox";
			this.toolTip1.SetToolTip(this.fixproneComboBox, componentResourceManager.GetString("fixproneComboBox.ToolTip"));
			componentResourceManager.ApplyResources(this.groupBox14, "groupBox14");
			this.groupBox14.BackColor = global::System.Drawing.Color.Transparent;
			this.groupBox14.Controls.Add(this.SpacecomboBox);
			this.groupBox14.ForeColor = global::System.Drawing.Color.Lime;
			this.groupBox14.Name = "groupBox14";
			this.groupBox14.TabStop = false;
			this.toolTip1.SetToolTip(this.groupBox14, componentResourceManager.GetString("groupBox14.ToolTip"));
			componentResourceManager.ApplyResources(this.SpacecomboBox, "SpacecomboBox");
			this.SpacecomboBox.FormattingEnabled = true;
			this.SpacecomboBox.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("SpacecomboBox.Items"),
				componentResourceManager.GetString("SpacecomboBox.Items1"),
				componentResourceManager.GetString("SpacecomboBox.Items2"),
				componentResourceManager.GetString("SpacecomboBox.Items3"),
				componentResourceManager.GetString("SpacecomboBox.Items4"),
				componentResourceManager.GetString("SpacecomboBox.Items5"),
				componentResourceManager.GetString("SpacecomboBox.Items6"),
				componentResourceManager.GetString("SpacecomboBox.Items7"),
				componentResourceManager.GetString("SpacecomboBox.Items8"),
				componentResourceManager.GetString("SpacecomboBox.Items9"),
				componentResourceManager.GetString("SpacecomboBox.Items10"),
				componentResourceManager.GetString("SpacecomboBox.Items11"),
				componentResourceManager.GetString("SpacecomboBox.Items12"),
				componentResourceManager.GetString("SpacecomboBox.Items13"),
				componentResourceManager.GetString("SpacecomboBox.Items14"),
				componentResourceManager.GetString("SpacecomboBox.Items15"),
				componentResourceManager.GetString("SpacecomboBox.Items16"),
				componentResourceManager.GetString("SpacecomboBox.Items17"),
				componentResourceManager.GetString("SpacecomboBox.Items18"),
				componentResourceManager.GetString("SpacecomboBox.Items19"),
				componentResourceManager.GetString("SpacecomboBox.Items20"),
				componentResourceManager.GetString("SpacecomboBox.Items21"),
				componentResourceManager.GetString("SpacecomboBox.Items22"),
				componentResourceManager.GetString("SpacecomboBox.Items23"),
				componentResourceManager.GetString("SpacecomboBox.Items24"),
				componentResourceManager.GetString("SpacecomboBox.Items25"),
				componentResourceManager.GetString("SpacecomboBox.Items26"),
				componentResourceManager.GetString("SpacecomboBox.Items27"),
				componentResourceManager.GetString("SpacecomboBox.Items28"),
				componentResourceManager.GetString("SpacecomboBox.Items29"),
				componentResourceManager.GetString("SpacecomboBox.Items30"),
				componentResourceManager.GetString("SpacecomboBox.Items31"),
				componentResourceManager.GetString("SpacecomboBox.Items32"),
				componentResourceManager.GetString("SpacecomboBox.Items33"),
				componentResourceManager.GetString("SpacecomboBox.Items34"),
				componentResourceManager.GetString("SpacecomboBox.Items35"),
				componentResourceManager.GetString("SpacecomboBox.Items36"),
				componentResourceManager.GetString("SpacecomboBox.Items37"),
				componentResourceManager.GetString("SpacecomboBox.Items38"),
				componentResourceManager.GetString("SpacecomboBox.Items39"),
				componentResourceManager.GetString("SpacecomboBox.Items40"),
				componentResourceManager.GetString("SpacecomboBox.Items41"),
				componentResourceManager.GetString("SpacecomboBox.Items42"),
				componentResourceManager.GetString("SpacecomboBox.Items43"),
				componentResourceManager.GetString("SpacecomboBox.Items44"),
				componentResourceManager.GetString("SpacecomboBox.Items45"),
				componentResourceManager.GetString("SpacecomboBox.Items46"),
				componentResourceManager.GetString("SpacecomboBox.Items47"),
				componentResourceManager.GetString("SpacecomboBox.Items48"),
				componentResourceManager.GetString("SpacecomboBox.Items49"),
				componentResourceManager.GetString("SpacecomboBox.Items50"),
				componentResourceManager.GetString("SpacecomboBox.Items51"),
				componentResourceManager.GetString("SpacecomboBox.Items52"),
				componentResourceManager.GetString("SpacecomboBox.Items53"),
				componentResourceManager.GetString("SpacecomboBox.Items54"),
				componentResourceManager.GetString("SpacecomboBox.Items55"),
				componentResourceManager.GetString("SpacecomboBox.Items56"),
				componentResourceManager.GetString("SpacecomboBox.Items57"),
				componentResourceManager.GetString("SpacecomboBox.Items58"),
				componentResourceManager.GetString("SpacecomboBox.Items59"),
				componentResourceManager.GetString("SpacecomboBox.Items60"),
				componentResourceManager.GetString("SpacecomboBox.Items61"),
				componentResourceManager.GetString("SpacecomboBox.Items62"),
				componentResourceManager.GetString("SpacecomboBox.Items63"),
				componentResourceManager.GetString("SpacecomboBox.Items64"),
				componentResourceManager.GetString("SpacecomboBox.Items65"),
				componentResourceManager.GetString("SpacecomboBox.Items66"),
				componentResourceManager.GetString("SpacecomboBox.Items67"),
				componentResourceManager.GetString("SpacecomboBox.Items68"),
				componentResourceManager.GetString("SpacecomboBox.Items69"),
				componentResourceManager.GetString("SpacecomboBox.Items70"),
				componentResourceManager.GetString("SpacecomboBox.Items71"),
				componentResourceManager.GetString("SpacecomboBox.Items72"),
				componentResourceManager.GetString("SpacecomboBox.Items73"),
				componentResourceManager.GetString("SpacecomboBox.Items74"),
				componentResourceManager.GetString("SpacecomboBox.Items75"),
				componentResourceManager.GetString("SpacecomboBox.Items76"),
				componentResourceManager.GetString("SpacecomboBox.Items77"),
				componentResourceManager.GetString("SpacecomboBox.Items78"),
				componentResourceManager.GetString("SpacecomboBox.Items79"),
				componentResourceManager.GetString("SpacecomboBox.Items80"),
				componentResourceManager.GetString("SpacecomboBox.Items81"),
				componentResourceManager.GetString("SpacecomboBox.Items82"),
				componentResourceManager.GetString("SpacecomboBox.Items83"),
				componentResourceManager.GetString("SpacecomboBox.Items84"),
				componentResourceManager.GetString("SpacecomboBox.Items85"),
				componentResourceManager.GetString("SpacecomboBox.Items86"),
				componentResourceManager.GetString("SpacecomboBox.Items87"),
				componentResourceManager.GetString("SpacecomboBox.Items88"),
				componentResourceManager.GetString("SpacecomboBox.Items89"),
				componentResourceManager.GetString("SpacecomboBox.Items90"),
				componentResourceManager.GetString("SpacecomboBox.Items91"),
				componentResourceManager.GetString("SpacecomboBox.Items92"),
				componentResourceManager.GetString("SpacecomboBox.Items93"),
				componentResourceManager.GetString("SpacecomboBox.Items94"),
				componentResourceManager.GetString("SpacecomboBox.Items95"),
				componentResourceManager.GetString("SpacecomboBox.Items96"),
				componentResourceManager.GetString("SpacecomboBox.Items97"),
				componentResourceManager.GetString("SpacecomboBox.Items98")
			});
			this.SpacecomboBox.Name = "SpacecomboBox";
			this.toolTip1.SetToolTip(this.SpacecomboBox, componentResourceManager.GetString("SpacecomboBox.ToolTip"));
			componentResourceManager.ApplyResources(this.Show, "Show");
			this.Show.BackColor = global::System.Drawing.Color.Transparent;
			this.Show.BackgroundImage = global::Quickly_Helper.Properties.Resources.Down;
			this.Show.ForeColor = global::System.Drawing.Color.Black;
			this.Show.Name = "Show";
			this.toolTip1.SetToolTip(this.Show, componentResourceManager.GetString("Show.ToolTip"));
			this.Show.UseVisualStyleBackColor = false;
			this.Show.Click += new global::System.EventHandler(this.button1_Click);
			componentResourceManager.ApplyResources(this.groupBox5, "groupBox5");
			this.groupBox5.BackColor = global::System.Drawing.Color.Transparent;
			this.groupBox5.Controls.Add(this.Weapon_1);
			this.groupBox5.Controls.Add(this.Recoil_1);
			this.groupBox5.ForeColor = global::System.Drawing.Color.White;
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.TabStop = false;
			this.toolTip1.SetToolTip(this.groupBox5, componentResourceManager.GetString("groupBox5.ToolTip"));
			componentResourceManager.ApplyResources(this.Weapon_1, "Weapon_1");
			this.Weapon_1.ForeColor = global::System.Drawing.Color.Aqua;
			this.Weapon_1.Name = "Weapon_1";
			this.toolTip1.SetToolTip(this.Weapon_1, componentResourceManager.GetString("Weapon_1.ToolTip"));
			componentResourceManager.ApplyResources(this.Recoil_1, "Recoil_1");
			this.Recoil_1.Name = "Recoil_1";
			this.toolTip1.SetToolTip(this.Recoil_1, componentResourceManager.GetString("Recoil_1.ToolTip"));
			componentResourceManager.ApplyResources(this.Shot_Text_X, "Shot_Text_X");
			this.Shot_Text_X.Name = "Shot_Text_X";
			this.toolTip1.SetToolTip(this.Shot_Text_X, componentResourceManager.GetString("Shot_Text_X.ToolTip"));
			componentResourceManager.ApplyResources(this.FastProne, "FastProne");
			this.FastProne.Name = "FastProne";
			this.toolTip1.SetToolTip(this.FastProne, componentResourceManager.GetString("FastProne.ToolTip"));
			componentResourceManager.ApplyResources(this.RightLeft, "RightLeft");
			this.RightLeft.Name = "RightLeft";
			this.toolTip1.SetToolTip(this.RightLeft, componentResourceManager.GetString("RightLeft.ToolTip"));
			componentResourceManager.ApplyResources(this.Emulator, "Emulator");
			this.Emulator.Name = "Emulator";
			this.toolTip1.SetToolTip(this.Emulator, componentResourceManager.GetString("Emulator.ToolTip"));
			componentResourceManager.ApplyResources(this.panel2, "panel2");
			this.panel2.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.panel2.Controls.Add(this.Ready);
			this.panel2.Name = "panel2";
			this.toolTip1.SetToolTip(this.panel2, componentResourceManager.GetString("panel2.ToolTip"));
			componentResourceManager.ApplyResources(this.Ready, "Ready");
			this.Ready.BackColor = global::System.Drawing.Color.Transparent;
			this.Ready.ForeColor = global::System.Drawing.Color.Red;
			this.Ready.Name = "Ready";
			this.toolTip1.SetToolTip(this.Ready, componentResourceManager.GetString("Ready.ToolTip"));
			componentResourceManager.ApplyResources(this.LeftClick, "LeftClick");
			this.LeftClick.BackColor = global::System.Drawing.Color.Transparent;
			this.LeftClick.BackgroundImage = global::Quickly_Helper.Properties.Resources.LeftClickOff;
			this.LeftClick.Name = "LeftClick";
			this.LeftClick.TabStop = false;
			this.toolTip1.SetToolTip(this.LeftClick, componentResourceManager.GetString("LeftClick.ToolTip"));
			componentResourceManager.ApplyResources(this.trackBarRight, "trackBarRight");
			this.trackBarRight.Maximum = 100;
			this.trackBarRight.Name = "trackBarRight";
			this.trackBarRight.TickStyle = global::System.Windows.Forms.TickStyle.Both;
			this.toolTip1.SetToolTip(this.trackBarRight, componentResourceManager.GetString("trackBarRight.ToolTip"));
			this.trackBarRight.Value = 1;
			componentResourceManager.ApplyResources(this.trackBarleft, "trackBarleft");
			this.trackBarleft.Maximum = 100;
			this.trackBarleft.Name = "trackBarleft";
			this.trackBarleft.TickStyle = global::System.Windows.Forms.TickStyle.Both;
			this.toolTip1.SetToolTip(this.trackBarleft, componentResourceManager.GetString("trackBarleft.ToolTip"));
			this.trackBarleft.Value = 1;
			componentResourceManager.ApplyResources(this.label5, "label5");
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Name = "label5";
			this.toolTip1.SetToolTip(this.label5, componentResourceManager.GetString("label5.ToolTip"));
			componentResourceManager.ApplyResources(this.label2, "label2");
			this.label2.ForeColor = global::System.Drawing.Color.Red;
			this.label2.Name = "label2";
			this.toolTip1.SetToolTip(this.label2, componentResourceManager.GetString("label2.ToolTip"));
			componentResourceManager.ApplyResources(this.label4, "label4");
			this.label4.ForeColor = global::System.Drawing.Color.Red;
			this.label4.Name = "label4";
			this.toolTip1.SetToolTip(this.label4, componentResourceManager.GetString("label4.ToolTip"));
			componentResourceManager.ApplyResources(this.label1, "label1");
			this.label1.ForeColor = global::System.Drawing.Color.Red;
			this.label1.Name = "label1";
			this.toolTip1.SetToolTip(this.label1, componentResourceManager.GetString("label1.ToolTip"));
			componentResourceManager.ApplyResources(this.menuStrip1, "menuStrip1");
			this.menuStrip1.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.menuStrip1.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItemSaveAsPreset,
				this.toolStripMenuItemFireButton,
				this.toolStripMenuItemEdit,
				this.toolStripMenuItemPresets
			});
			this.menuStrip1.Name = "menuStrip1";
			this.toolTip1.SetToolTip(this.menuStrip1, componentResourceManager.GetString("menuStrip1.ToolTip"));
			componentResourceManager.ApplyResources(this.toolStripMenuItemSaveAsPreset, "toolStripMenuItemSaveAsPreset");
			this.toolStripMenuItemSaveAsPreset.Name = "toolStripMenuItemSaveAsPreset";
			this.toolStripMenuItemSaveAsPreset.Click += new global::System.EventHandler(this.toolStripMenuItemSaveAsPreset_Click);
			componentResourceManager.ApplyResources(this.toolStripMenuItemFireButton, "toolStripMenuItemFireButton");
			this.toolStripMenuItemFireButton.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripComboBoxFireButton
			});
			this.toolStripMenuItemFireButton.Name = "toolStripMenuItemFireButton";
			componentResourceManager.ApplyResources(this.toolStripComboBoxFireButton, "toolStripComboBoxFireButton");
			this.toolStripComboBoxFireButton.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("toolStripComboBoxFireButton.Items"),
				componentResourceManager.GetString("toolStripComboBoxFireButton.Items1"),
				componentResourceManager.GetString("toolStripComboBoxFireButton.Items2"),
				componentResourceManager.GetString("toolStripComboBoxFireButton.Items3")
			});
			this.toolStripComboBoxFireButton.Name = "toolStripComboBoxFireButton";
			componentResourceManager.ApplyResources(this.toolStripMenuItemEdit, "toolStripMenuItemEdit");
			this.toolStripMenuItemEdit.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItemEnableAntiRecoil,
				this.toolStripSeparator1,
				this.toolStripMenuItemActivate
			});
			this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
			componentResourceManager.ApplyResources(this.toolStripMenuItemEnableAntiRecoil, "toolStripMenuItemEnableAntiRecoil");
			this.toolStripMenuItemEnableAntiRecoil.CheckOnClick = true;
			this.toolStripMenuItemEnableAntiRecoil.ForeColor = global::System.Drawing.Color.Black;
			this.toolStripMenuItemEnableAntiRecoil.Name = "toolStripMenuItemEnableAntiRecoil";
			this.toolStripMenuItemEnableAntiRecoil.Click += new global::System.EventHandler(this.toolStripMenuItemEnableAntiRecoil_Click);
			componentResourceManager.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			componentResourceManager.ApplyResources(this.toolStripMenuItemActivate, "toolStripMenuItemActivate");
			this.toolStripMenuItemActivate.CheckOnClick = true;
			this.toolStripMenuItemActivate.ForeColor = global::System.Drawing.Color.Red;
			this.toolStripMenuItemActivate.Name = "toolStripMenuItemActivate";
			this.toolStripMenuItemActivate.Click += new global::System.EventHandler(this.toolStripMenuItemActivate_Click);
			componentResourceManager.ApplyResources(this.toolStripMenuItemPresets, "toolStripMenuItemPresets");
			this.toolStripMenuItemPresets.Name = "toolStripMenuItemPresets";
			componentResourceManager.ApplyResources(this.About, "About");
			this.About.BackColor = global::System.Drawing.Color.Transparent;
			this.About.BackgroundImage = global::Quickly_Helper.Properties.Resources.about;
			this.About.Name = "About";
			this.About.TabStop = false;
			this.toolTip1.SetToolTip(this.About, componentResourceManager.GetString("About.ToolTip"));
			this.About.Click += new global::System.EventHandler(this.About_Click_1);
			this.timer1.Enabled = true;
			this.timer1.Interval = 1;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			componentResourceManager.ApplyResources(this.notifyIcon1, "notifyIcon1");
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.DoubleClick += new global::System.EventHandler(this.notifyIcon1_DoubleClick);
			this.notifyIcon1.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			this.StartEmalutorTimer.Tick += new global::System.EventHandler(this.StartEmalutorTimer_Tick);
			this.JumpCrouchtimer.Tick += new global::System.EventHandler(this.JumpCrouchtimer_Tick);
			this.Jump_pronetimer.Tick += new global::System.EventHandler(this.Jump_pronetimer_Tick);
			this.Pronet.Interval = 1;
			this.Pronet.Tick += new global::System.EventHandler(this.Pronet_Tick);
			this.rightleftmove.Interval = 1000;
			this.rightleftmove.Tick += new global::System.EventHandler(this.rightleftmove_Tick);
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.IndianRed;
			base.Controls.Add(this.QuicklyPanel);
			base.Controls.Add(this.trackBarDy);
			base.Controls.Add(this.trackBarPullDelay);
			base.Controls.Add(this.trackBarShotInterval);
			base.Controls.Add(this.toolStripContainer1);
			this.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.ForeColor = global::System.Drawing.Color.LimeGreen;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.MainMenuStrip = this.menuStrip1;
			base.MaximizeBox = false;
			base.Name = "BackGround";
			base.ShowInTaskbar = false;
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			this.toolTip1.SetToolTip(this, componentResourceManager.GetString("$this.ToolTip"));
			base.TopMost = true;
			base.TransparencyKey = global::System.Drawing.Color.Gray;
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.BackGround_FormClosed);
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.Resize += new global::System.EventHandler(this.Form1_Resize);
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.trackBarDy).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBarShotInterval).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBarPullDelay).EndInit();
			this.QuicklyPanel.ResumeLayout(false);
			this.QuicklyPanel.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox23.ResumeLayout(false);
			this.groupBox18.ResumeLayout(false);
			this.groupBox18.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox17.ResumeLayout(false);
			this.groupBox17.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox16.ResumeLayout(false);
			this.groupBox16.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox15.ResumeLayout(false);
			this.groupBox15.PerformLayout();
			this.groupBox13.ResumeLayout(false);
			this.groupBox14.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.LeftClick).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBarRight).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBarleft).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.About).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400001F RID: 31
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.NotifyIcon notifyIcon1;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Button About_button;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.ToolStripContainer toolStripContainer1;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPresets;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Label Ready;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.TrackBar trackBarDy;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.TrackBar trackBarShotInterval;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.TrackBar trackBarPullDelay;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.MenuStrip menuStrip1;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFireButton;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.ToolStripComboBox toolStripComboBoxFireButton;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Panel QuicklyPanel;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.PictureBox LeftClick;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEnableAntiRecoil;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItemActivate;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.TrackBar trackBarRight;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.TrackBar trackBarleft;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.PictureBox About;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveAsPreset;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.TextBox Emulator;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.TextBox Shot_Text_X;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.TextBox FastProne;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.TextBox RightLeft;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Button Active_button;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.ComboBox QuickSitComboBox;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Button startEmalutor;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Timer StartEmalutorTimer;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.ComboBox jump_prone_comboBox;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.ComboBox JumpCrouchcomboBox;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.ComboBox slidingcomboBox;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.GroupBox groupBox5;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Label Weapon_1;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.TextBox Recoil_1;

		// Token: 0x04000051 RID: 81
		private new global::System.Windows.Forms.Button Show;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.GroupBox groupBox13;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.ComboBox fixproneComboBox;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.GroupBox groupBox14;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.ComboBox SpacecomboBox;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.GroupBox groupBox15;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.CheckBox checkBox2;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.GroupBox groupBox16;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.CheckBox checkBox3;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.GroupBox groupBox17;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.ComboBox Dodge_comboBox1;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.TextBox Dodge_Timer;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.Label label12;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.ComboBox Dodge_comboBox2;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.Timer JumpCrouchtimer;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.Timer Jump_pronetimer;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.Timer Pronet;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.GroupBox groupBox18;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.Timer rightleftmove;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.GroupBox groupBox23;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.ComboBox FirecomboBox;
	}
}
