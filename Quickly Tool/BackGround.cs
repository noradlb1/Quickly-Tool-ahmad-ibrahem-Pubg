using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Quickly_Helper.Properties;

namespace Quickly_Helper
{
	// Token: 0x02000008 RID: 8
	public partial class BackGround : Form, IOkButtonPressedInSavePresetDialog, IOnHotkeyPressed
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002DFC File Offset: 0x00000FFC
		// (set) Token: 0x0600002C RID: 44 RVA: 0x000020B7 File Offset: 0x000002B7
		private BackGround.Preset CurrentPreset
		{
			get
			{
				return this._currentPreset;
			}
			set
			{
				this._currentPreset = value;
				this.UpdateTrackbarValuesAndGUI();
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002E14 File Offset: 0x00001014
		public BackGround()
		{
			this.InitializeComponent();
			this.trackBarShotInterval.Scroll += this.OnTrackBarScroll;
			this.trackBarDy.Scroll += this.OnTrackBarScroll;
			this.trackBarPullDelay.Scroll += this.OnTrackBarScroll;
			this.trackBarleft.Scroll += this.OnTrackBarScroll;
			this.trackBarRight.Scroll += this.OnTrackBarScroll;
			this.poller = new Poller(this);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002F30 File Offset: 0x00001130
		public void OnOkButtonPressed(string presetName)
		{
			try
			{
				if (!Savefilehandler.SavePresets(presetName, this.trackBarDy.Value, this.trackBarShotInterval.Value, this.trackBarPullDelay.Value, this.trackBarleft.Value, this.trackBarRight.Value))
				{
					throw new Exception("إرجاع القيمة كاذبة");
				}
				this.Ready.Text = "الإعداد المسبق المحفوظ " + presetName;
				this.toolStripMenuItemPresets.DropDownItems.Remove(this.userPresetsMenuItem);
				this.LoadUserPresetsNames();
			}
			catch (Exception)
			{
				this.Ready.Text = "فشل حفظ الإعداد المسبق " + presetName;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002FE8 File Offset: 0x000011E8
		public void OnInsertHideMenu()
		{
			if (base.WindowState == FormWindowState.Normal)
			{
				base.Hide();
				base.WindowState = FormWindowState.Minimized;
				this.notifyIcon1.Visible = true;
				this.notifyIcon1.ShowBalloonTip(1000);
			}
			else
			{
				base.Show();
				base.WindowState = FormWindowState.Normal;
				this.notifyIcon1.Visible = false;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003048 File Offset: 0x00001248
		public void OnToggleRecoilCompensationHotkeyPressed()
		{
			if (!this.toolStripMenuItemEnableAntiRecoil.Checked)
			{
				this.label2.Text = "الارتداد مفعل";
				this.label2.ForeColor = Color.Green;
				this.toolStripMenuItemEnableAntiRecoil.PerformClick();
			}
			else
			{
				this.label2.Text = "الارتداد معطل";
				this.label2.ForeColor = Color.Red;
				this.toolStripMenuItemEnableAntiRecoil.PerformClick();
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000030BC File Offset: 0x000012BC
		public void OnToggleActivateProgramHotkeyPressed()
		{
			if (!this.toolStripMenuItemActivate.Checked)
			{
				this.label1.Text = "البرنامج مفعل";
				this.label1.ForeColor = Color.Green;
				this.toolStripMenuItemActivate.PerformClick();
			}
			else
			{
				this.label1.Text = "البرنامج معطل";
				this.label1.ForeColor = Color.Red;
				this.toolStripMenuItemActivate.PerformClick();
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003130 File Offset: 0x00001330
		public void OnWeaponSlotChangeHotkeyPressed(int slotNumber)
		{
			this.activeWeaponSlot = slotNumber;
			try
			{
				HelperFunctions.GetToolStripMenuItemFromText(this.toolStripMenuItemPresets, this.weaponSlotPresetNameDict[slotNumber]).PerformClick();
			}
			catch (PresetNotFoundException ex)
			{
				Debug.WriteLine(ex.Message);
			}
			catch (PresetMenuNotPopulatedException ex2)
			{
				Debug.WriteLine(ex2.Message);
			}
			finally
			{
				if (slotNumber == 1)
				{
					this.Recoil_1.BackColor = Color.Yellow;
					this.Weapon_1.BackColor = Color.Yellow;
				}
				else
				{
					this.Recoil_1.BackColor = Color.Red;
					this.Weapon_1.BackColor = Color.Red;
				}
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000031F4 File Offset: 0x000013F4
		private void UpdateTrackbarValuesAndGUI()
		{
			if (!this.CurrentPreset.IsEmpty())
			{
				this.Text = HelperFunctions.GetApplicationName() + " - " + this.CurrentPreset.PresetName;
				this.Ready.Text = "تم تحميله مسبقا " + this.CurrentPreset.PresetName;
				this.trackBarShotInterval.Value = this.CurrentPreset.ShotInterval;
				this.trackBarDy.Value = this.CurrentPreset.Dy;
				this.trackBarPullDelay.Value = this.CurrentPreset.PullDelay;
				this.trackBarleft.Value = this.CurrentPreset.Lefty;
				this.trackBarRight.Value = this.CurrentPreset.Righty;
			}
			else
			{
				this.Text = HelperFunctions.GetApplicationName();
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000032CC File Offset: 0x000014CC
		private void OnTrackBarScroll(object sender, EventArgs e)
		{
			TrackBar trackBar = (TrackBar)sender;
			this.toolTip1.SetToolTip(trackBar, string.Concat(trackBar.Value));
			this.CurrentPreset = new BackGround.Preset();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003308 File Offset: 0x00001508
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (this.toolStripMenuItemActivate.Checked)
			{
				this.Ready.Text = string.Format("(أسفل = {0}, سرعة الذخيرة ={1}, فوق ={2}, شمال ={3}, يمين ={4})", new object[]
				{
					this.trackBarDy.Value,
					this.trackBarShotInterval.Value,
					this.trackBarPullDelay.Value,
					this.trackBarleft.Value,
					this.trackBarRight.Value
				});
				this.notifyIcon1.Text = this.Ready.Text;
			}
			else
			{
				this.notifyIcon1.Text = HelperFunctions.GetApplicationName();
			}
			if (this.activeWeaponSlot == 1 || this.activeWeaponSlot == 2)
			{
				this.poller.Poll(this.trackBarDy.Value, this.trackBarShotInterval.Value, this.trackBarPullDelay.Value = (int)Convert.ToInt16(this.Recoil_1.Text), this.FirecomboBox.Text);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003430 File Offset: 0x00001630
		private void rightleftmove_Tick(object sender, EventArgs e)
		{
			if (this.poller.firemove && !this.poller.FixADS)
			{
				switch (this.Test_MoveMouse)
				{
				case 1:
					MouseHelperClass.MouseMoveRight(2);
					MouseHelperClass.MouseMoveLeft(2);
					break;
				case 2:
					MouseHelperClass.MouseMoveRight(2);
					MouseHelperClass.MouseMoveLeft(2);
					break;
				case 3:
					MouseHelperClass.MouseMoveRight(2);
					MouseHelperClass.MouseMoveLeft(2);
					this.Test_MoveMouse = 0;
					this.poller.firemove = false;
					break;
				}
				this.Test_MoveMouse++;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000020C6 File Offset: 0x000002C6
		private void trayToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.notifyIcon1.Visible = true;
			base.WindowState = FormWindowState.Minimized;
			base.Hide();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000020E1 File Offset: 0x000002E1
		private void notifyIcon1_DoubleClick(object sender, EventArgs e)
		{
			base.Show();
			base.WindowState = FormWindowState.Normal;
			this.notifyIcon1.Visible = false;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000020FC File Offset: 0x000002FC
		private void toolStripMenuItemSaveAsPreset_Click(object sender, EventArgs e)
		{
			new SavePresetAsDialog(this).Show();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000034C0 File Offset: 0x000016C0
		private void Form1_Load(object sender, EventArgs e)
		{
			this.notifyIcon1.BalloonTipTitle = "Ahmed_Ibrahim";
			this.notifyIcon1.BalloonTipText = "لإظهار أو إخفاء البرنامج مرة أخرى [Insert] انقر فوق زر";
			this.notifyIcon1.Text = "Ahmed_Ibrahim";
			this.Text = HelperFunctions.GetApplicationName();
			string path = "Quickly_Configuration/اعدادات.txt";
			string text = File.ReadAllText(path);
			this.Emulator.Text = text;
			this.Recoil_1.Text = Convert.ToString(Settings.Default.RecoilReal1);
			this.Weapon_1.Text = Convert.ToString(Settings.Default.WEAPON1);
			this.Dodge_Timer.Text = Convert.ToString(Settings.Default.DodgeDis);
			if (!this.toolStripMenuItemEnableAntiRecoil.Checked)
			{
				this.toolStripMenuItemEnableAntiRecoil.PerformClick();
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003588 File Offset: 0x00001788
		private void OnUserPresetClicked(object sender, EventArgs e)
		{
			try
			{
				string text = ((ToolStripItem)sender).Text;
				if (Savefilehandler.GetSavedPresetNamesList().Contains(text))
				{
					List<int> presetValuesFromName = Savefilehandler.GetPresetValuesFromName(text);
					if (presetValuesFromName.Count == 5)
					{
						this.CurrentPreset = new BackGround.Preset(true, text, presetValuesFromName[0], presetValuesFromName[1], presetValuesFromName[2], presetValuesFromName[3], presetValuesFromName[4]);
					}
					else if (!Savefilehandler.DeletePreset(text))
					{
						throw new Exception("لا يمكن حذف الإعداد المسبق " + text);
					}
				}
				else
				{
					this.Ready.Text = "المعد مسبقا " + text + " لم يتم العثور عليه";
				}
			}
			catch (Exception ex)
			{
				Debug.Print(ex.Message);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003650 File Offset: 0x00001850
		private void toolStripMenuItemDeletePreset_Click(object sender, EventArgs e)
		{
			if (!this.CurrentPreset.IsEmpty() && this.CurrentPreset.UserDefined)
			{
				try
				{
					if (!Savefilehandler.DeletePreset(this.CurrentPreset.PresetName))
					{
						throw new Exception("تعذر حذف الإعداد المسبق " + this.CurrentPreset.PresetName);
					}
					this.toolStripMenuItemPresets.DropDownItems.Remove(this.userPresetsMenuItem);
					this.LoadUserPresetsNames();
					this.Ready.Text = "تم حذف الإعداد المسبق " + this.CurrentPreset.PresetName;
				}
				catch (Exception ex)
				{
					this.Ready.Text = ex.Message;
				}
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003710 File Offset: 0x00001910
		private void LoadUserPresetsNames()
		{
			try
			{
				List<string> savedPresetNamesList = Savefilehandler.GetSavedPresetNamesList();
				if (savedPresetNamesList.Count > 0)
				{
					this.userPresetsMenuItem = new ToolStripMenuItem("User presets");
					this.toolStripMenuItemPresets.DropDownItems.Add(this.userPresetsMenuItem);
					foreach (string text in savedPresetNamesList)
					{
						ToolStripItem toolStripItem = new ToolStripMenuItem(text);
						toolStripItem.Click += this.OnUserPresetClicked;
						this.userPresetsMenuItem.DropDownItems.Add(toolStripItem);
					}
				}
			}
			catch (Exception)
			{
				Debug.Print("استثناء في تحميل الإعدادات المسبقة.");
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000037DC File Offset: 0x000019DC
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			return (!this.toolStripMenuItemActivate.Checked || keyData != Keys.F7) && keyData != Keys.F6 && base.ProcessCmdKey(ref msg, keyData);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002109 File Offset: 0x00000309
		private void toolStripMenuItemEnableAntiRecoil_Click(object sender, EventArgs e)
		{
			this.poller.PerformRecoilCompensation = this.toolStripMenuItemEnableAntiRecoil.Checked;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003820 File Offset: 0x00001A20
		private void toolStripMenuItemActivate_Click(object sender, EventArgs e)
		{
			if (this.toolStripMenuItemActivate.Checked)
			{
				this.poller.Activated = true;
				this.toolStripMenuItemSaveAsPreset.Enabled = true;
			}
			else
			{
				this.poller.Activated = false;
				this.Ready.Text = " ";
				this.notifyIcon1.Text = HelperFunctions.GetApplicationName();
				this.toolStripMenuItemSaveAsPreset.Enabled = false;
				if (this.CurrentPreset == null || !this.CurrentPreset.UserDefined)
				{
				}
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000020FC File Offset: 0x000002FC
		private void SaveAsPreset_button_Click(object sender, EventArgs e)
		{
			new SavePresetAsDialog(this).Show();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003650 File Offset: 0x00001850
		private void DeletePreset_button_Click(object sender, EventArgs e)
		{
			if (!this.CurrentPreset.IsEmpty() && this.CurrentPreset.UserDefined)
			{
				try
				{
					if (!Savefilehandler.DeletePreset(this.CurrentPreset.PresetName))
					{
						throw new Exception("تعذر حذف الإعداد المسبق " + this.CurrentPreset.PresetName);
					}
					this.toolStripMenuItemPresets.DropDownItems.Remove(this.userPresetsMenuItem);
					this.LoadUserPresetsNames();
					this.Ready.Text = "تم حذف الإعداد المسبق " + this.CurrentPreset.PresetName;
				}
				catch (Exception ex)
				{
					this.Ready.Text = ex.Message;
				}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002077 File Offset: 0x00000277
		private void Exit_button_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002121 File Offset: 0x00000321
		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			base.Show();
			this.notifyIcon1.Visible = false;
			base.WindowState = FormWindowState.Normal;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000038A8 File Offset: 0x00001AA8
		private void Form1_Resize(object sender, EventArgs e)
		{
			if (base.WindowState == FormWindowState.Minimized)
			{
				base.Hide();
				this.notifyIcon1.Visible = true;
				this.notifyIcon1.ShowBalloonTip(1000);
			}
			else if (FormWindowState.Normal == base.WindowState)
			{
				this.notifyIcon1.Visible = false;
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002077 File Offset: 0x00000277
		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003904 File Offset: 0x00001B04
		private void About_Click_1(object sender, EventArgs e)
		{
			About_us about_us = new About_us();
			about_us.Show();
			this.notifyIcon1.Visible = true;
			base.WindowState = FormWindowState.Minimized;
			base.Hide();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003938 File Offset: 0x00001B38
		private void Active_button_Click(object sender, EventArgs e)
		{
			if (!this.toolStripMenuItemActivate.Checked)
			{
				this.Active_button.ForeColor = Color.Green;
				this.toolStripMenuItemActivate.PerformClick();
			}
			else
			{
				this.Active_button.ForeColor = Color.Red;
				this.toolStripMenuItemActivate.PerformClick();
			}
		}

		// Token: 0x06000049 RID: 73
		[DllImport("user32.dll")]
		private static extern short GetAsyncKeyState(Keys vKey);

		// Token: 0x0600004A RID: 74 RVA: 0x0000398C File Offset: 0x00001B8C
		public void Prone()
		{
			if ((BackGround.GetAsyncKeyState(HelperFunctions.GetFireKeyFromString(this.QuickSitComboBox.Text)) & 1) > 0)
			{
				this.Pronet.Enabled = true;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000039C4 File Offset: 0x00001BC4
		private void Pronet_Tick(object sender, EventArgs e)
		{
			switch (this.prn)
			{
			case 2:
				if (this.activeWeaponSlot == 1)
				{
					KeyboardSimulator.KeyUp(Keys.NumPad2);
					SendKeys.Send("{2},{Z}");
					this.activeWeaponSlot = 2;
					this.Recoil_1.BackColor = Color.Red;
					this.Weapon_1.BackColor = Color.Red;
				}
				else if (this.activeWeaponSlot == 2)
				{
					KeyboardSimulator.KeyUp(Keys.NumPad1);
					SendKeys.Send("{Z},{1}");
					this.activeWeaponSlot = 1;
					this.Recoil_1.BackColor = Color.Yellow;
					this.Weapon_1.BackColor = Color.Yellow;
				}
				this.prn = 0;
				this.Pronet.Enabled = false;
				break;
			}
			this.prn++;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003A9C File Offset: 0x00001C9C
		public void Revive()
		{
			if (BackGround.GetAsyncKeyState(Keys.F) < 0)
			{
				HelperFunctions.WaitUntilTimeoutWhileTrue(() => (BackGround.GetAsyncKeyState(Keys.L) & 1) > 0, 100);
				KeyboardSimulator.KeyPress(Keys.L);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003AE4 File Offset: 0x00001CE4
		public void CarSpeed()
		{
			if (BackGround.GetAsyncKeyState(Keys.LShiftKey) < 0)
			{
				HelperFunctions.WaitUntilTimeoutWhileTrue(() => (BackGround.GetAsyncKeyState(Keys.K) & 1000) > 0, 1000);
				KeyboardSimulator.KeyPress(Keys.K);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003B34 File Offset: 0x00001D34
		public void NewNum_1()
		{
			if (BackGround.GetAsyncKeyState(Keys.LShiftKey) < 0)
			{
				KeyboardSimulator.KeyPress(Keys.OemSemicolon);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003B60 File Offset: 0x00001D60
		public void NewNum_2()
		{
			if (BackGround.GetAsyncKeyState(Keys.XButton2) < 0)
			{
				KeyboardSimulator.KeyPress(Keys.K);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003B84 File Offset: 0x00001D84
		public void Dodge_1()
		{
			if (BackGround.GetAsyncKeyState(HelperFunctions.GetFireKeyFromString(this.Dodge_comboBox1.Text)) < 0)
			{
				KeyboardSimulator.KeyDown(Keys.A);
				Thread.Sleep((int)Convert.ToInt16(this.Dodge_Timer.Text));
				KeyboardSimulator.KeyUp(Keys.A);
				KeyboardSimulator.KeyPress(Keys.C);
				KeyboardSimulator.KeyDown(Keys.D);
				Thread.Sleep((int)Convert.ToInt16(this.Dodge_Timer.Text));
				KeyboardSimulator.KeyUp(Keys.D);
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003BFC File Offset: 0x00001DFC
		public void Dodge_2()
		{
			if (BackGround.GetAsyncKeyState(HelperFunctions.GetFireKeyFromString(this.Dodge_comboBox2.Text)) < 0)
			{
				KeyboardSimulator.KeyDown(Keys.A);
				Thread.Sleep((int)Convert.ToInt16(this.Dodge_Timer.Text));
				KeyboardSimulator.KeyUp(Keys.A);
				KeyboardSimulator.KeyDown(Keys.D);
				Thread.Sleep((int)Convert.ToInt16(this.Dodge_Timer.Text));
				KeyboardSimulator.KeyUp(Keys.D);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003C6C File Offset: 0x00001E6C
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.AllowPick)
			{
				this.AllowPick = true;
			}
			else
			{
				this.AllowPick = false;
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003C94 File Offset: 0x00001E94
		public void Pick()
		{
			if (BackGround.GetAsyncKeyState(Keys.F) < 0 && this.AllowPick)
			{
				KeyboardSimulator.KeyPress(Keys.F);
				KeyboardSimulator.KeyPress(Keys.G);
				KeyboardSimulator.KeyPress(Keys.H);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003CD0 File Offset: 0x00001ED0
		public void Sliding()
		{
			if (BackGround.GetAsyncKeyState(HelperFunctions.GetFireKeyFromString(this.slidingcomboBox.Text)) < 0)
			{
				Thread.Sleep(50);
				KeyboardSimulator.KeyPress(Keys.C);
				Thread.Sleep(50);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003D10 File Offset: 0x00001F10
		public void JumpCrouch()
		{
			if (BackGround.GetAsyncKeyState(HelperFunctions.GetFireKeyFromString(this.JumpCrouchcomboBox.Text)) < 0)
			{
				this.JumpCrouchtimer.Enabled = true;
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003D48 File Offset: 0x00001F48
		private void JumpCrouchtimer_Tick(object sender, EventArgs e)
		{
			switch (this.cru)
			{
			case 2:
				SendKeys.Send("{N},{C 2}");
				this.cru = 0;
				this.JumpCrouchtimer.Enabled = false;
				KeyboardSimulator.KeyUp(Keys.N);
				KeyboardSimulator.KeyUp(Keys.C);
				break;
			}
			this.cru++;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003DA8 File Offset: 0x00001FA8
		public void Jump_prone()
		{
			if (BackGround.GetAsyncKeyState(HelperFunctions.GetFireKeyFromString(this.jump_prone_comboBox.Text)) < 0)
			{
				this.Jump_pronetimer.Enabled = true;
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003DE0 File Offset: 0x00001FE0
		private void Jump_pronetimer_Tick(object sender, EventArgs e)
		{
			switch (this.pro)
			{
			case 2:
				SendKeys.Send("{N},{Z 2}");
				this.pro = 0;
				this.Jump_pronetimer.Enabled = false;
				KeyboardSimulator.KeyUp(Keys.N);
				KeyboardSimulator.KeyUp(Keys.Z);
				break;
			}
			this.pro++;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003E40 File Offset: 0x00002040
		public void Fix_prone()
		{
			if (BackGround.GetAsyncKeyState(HelperFunctions.GetFireKeyFromString(this.fixproneComboBox.Text)) < 0)
			{
				KeyboardSimulator.KeyPress(Keys.Z);
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003E74 File Offset: 0x00002074
		public void Fix_Jump()
		{
			if (BackGround.GetAsyncKeyState(HelperFunctions.GetFireKeyFromString(this.SpacecomboBox.Text)) < 0)
			{
				Thread.Sleep(50);
				KeyboardSimulator.KeyPress(Keys.Space);
				Thread.Sleep(50);
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003EB4 File Offset: 0x000020B4
		private void BackGround_FormClosed(object sender, FormClosedEventArgs e)
		{
			foreach (Process process in Process.GetProcessesByName("Quickly_Rapid_Fire"))
			{
				process.Kill();
			}
			Settings.Default.RecoilReal1 = (int)Convert.ToInt16(this.Recoil_1.Text);
			Settings.Default.WEAPON1 = Convert.ToString(this.Weapon_1.Text);
			Settings.Default.DodgeDis = (int)Convert.ToInt16(this.Dodge_Timer.Text);
			Settings.Default.Save();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003F40 File Offset: 0x00002140
		private void button2_Click(object sender, EventArgs e)
		{
			if (!this.rapid_fire)
			{
				this.rapid_fire = true;
				this.button2.ForeColor = Color.Green;
				Process.Start("Quickly_Rapid_Fire.exe");
			}
			else
			{
				this.rapid_fire = false;
				this.button2.ForeColor = Color.Red;
				foreach (Process process in Process.GetProcessesByName("Quickly_Rapid_Fire"))
				{
					process.Kill();
				}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003FB8 File Offset: 0x000021B8
		private void startEmalutor_Click(object sender, EventArgs e)
		{
			foreach (Process process in Process.GetProcessesByName("AppMarket"))
			{
				process.Kill();
			}
			foreach (Process process in Process.GetProcessesByName("AndroidEmulator"))
			{
				process.Kill();
			}
			try
			{
				new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = this.Emulator.Text,
						WindowStyle = ProcessWindowStyle.Normal,
						Arguments = "-startpkg com.tencent.ig  -from DesktopLink"
					}
				}.Start();
			}
			catch (Exception)
			{
				MessageBox.Show("AppMarket.exe not exists", "Quickly", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Application.Exit();
			}
			this.StartEmalutorTimer.Enabled = true;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00004098 File Offset: 0x00002298
		private void StartEmalutorTimer_Tick(object sender, EventArgs e)
		{
			int ahmed = this.Ahmed;
			if (ahmed != 1)
			{
				if (ahmed != 10)
				{
					if (ahmed != 60)
					{
						goto IL_124;
					}
					foreach (Process process in Process.GetProcessesByName("AppMarket"))
					{
						process.Kill();
					}
					this.Ahmed = 0;
					this.StartEmalutorTimer.Enabled = false;
					goto IL_124;
				}
				else
				{
					try
					{
						new Process
						{
							StartInfo = new ProcessStartInfo
							{
								FileName = this.Emulator.Text,
								WindowStyle = ProcessWindowStyle.Normal,
								Arguments = "-startpkg com.tencent.ig  -from DesktopLink"
							}
						}.Start();
						goto IL_124;
					}
					catch (Exception)
					{
						MessageBox.Show("AppMarket.exe not exists", "Quickly", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						Application.Exit();
						goto IL_124;
					}
				}
			}
			try
			{
				new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = this.Emulator.Text,
						WindowStyle = ProcessWindowStyle.Normal,
						Arguments = "-startpkg com.tencent.ig  -from DesktopLink"
					}
				}.Start();
			}
			catch (Exception)
			{
				MessageBox.Show("AppMarket.exe not exists", "Quickly", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Application.Exit();
			}
			IL_124:
			this.Ahmed++;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000041F4 File Offset: 0x000023F4
		private void button1_Click(object sender, EventArgs e)
		{
			if (base.Height < 150)
			{
				base.ClientSize = new Size(795, 475);
			}
			else
			{
				base.ClientSize = new Size(234, 71);
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000213C File Offset: 0x0000033C
		public void Off()
		{
			this.LeftClick.Image = Resources.LeftClickOff;
			this.groupBox5.BackColor = Color.Red;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000215E File Offset: 0x0000035E
		public void On()
		{
			this.LeftClick.Image = Resources.LeftClickOn;
			this.groupBox5.BackColor = Color.Green;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000423C File Offset: 0x0000243C
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.poller.ipad)
			{
				this.poller.ipad = true;
			}
			else
			{
				this.poller.ipad = false;
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004270 File Offset: 0x00002470
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.poller.cross_on_off)
			{
				this.poller.cross_on_off = true;
			}
			else
			{
				this.poller.cross_on_off = false;
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000042A4 File Offset: 0x000024A4
		public void NormalAttack()
		{
			if (!this.Normal)
			{
				this.Normal = true;
				this.FirecomboBox.Text = "Left Mouse";
			}
			else
			{
				this.Normal = false;
				this.FirecomboBox.Text = "Right Mouse";
			}
		}

		// Token: 0x04000010 RID: 16
		private BackGround.Preset _currentPreset;

		// Token: 0x04000011 RID: 17
		private Poller poller;

		// Token: 0x04000012 RID: 18
		private WeaponSelectorForm weaponSelectorForm;

		// Token: 0x04000013 RID: 19
		private ToolStripMenuItem userPresetsMenuItem;

		// Token: 0x04000014 RID: 20
		private int activeWeaponSlot = 1;

		// Token: 0x04000015 RID: 21
		private Dictionary<int, string> weaponSlotPresetNameDict = new Dictionary<int, string>
		{
			{
				1,
				""
			},
			{
				2,
				""
			},
			{
				3,
				""
			}
		};

		// Token: 0x04000016 RID: 22
		private int Test_MoveMouse = 1;

		// Token: 0x04000017 RID: 23
		private SearchPixel SP = new SearchPixel();

		// Token: 0x04000018 RID: 24
		private int prn = 1;

		// Token: 0x04000019 RID: 25
		private bool AllowPick = false;

		// Token: 0x0400001A RID: 26
		private int cru = 1;

		// Token: 0x0400001B RID: 27
		private int pro = 1;

		// Token: 0x0400001C RID: 28
		private bool rapid_fire = false;

		// Token: 0x0400001D RID: 29
		private int Ahmed = 1;

		// Token: 0x0400001E RID: 30
		private bool Normal = false;

		// Token: 0x02000009 RID: 9
		private class Preset
		{
			// Token: 0x06000069 RID: 105 RVA: 0x00002180 File Offset: 0x00000380
			public Preset(bool isUserDefined, string presetName, int dy, int shotInterval, int pullDelay, int left, int right)
			{
				this.UserDefined = isUserDefined;
				this.PresetName = presetName;
				this.Dy = dy;
				this.ShotInterval = shotInterval;
				this.PullDelay = pullDelay;
				this.Lefty = left;
				this.Righty = right;
			}

			// Token: 0x0600006A RID: 106 RVA: 0x000021BD File Offset: 0x000003BD
			public Preset()
			{
			}

			// Token: 0x17000002 RID: 2
			// (get) Token: 0x0600006B RID: 107 RVA: 0x00009E08 File Offset: 0x00008008
			// (set) Token: 0x0600006C RID: 108 RVA: 0x000021C5 File Offset: 0x000003C5
			public string PresetName { get; set; }

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x0600006D RID: 109 RVA: 0x00009E20 File Offset: 0x00008020
			// (set) Token: 0x0600006E RID: 110 RVA: 0x000021CE File Offset: 0x000003CE
			public bool UserDefined { get; set; }

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x0600006F RID: 111 RVA: 0x00009E34 File Offset: 0x00008034
			// (set) Token: 0x06000070 RID: 112 RVA: 0x000021D7 File Offset: 0x000003D7
			public int Dy { get; set; }

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x06000071 RID: 113 RVA: 0x00009E4C File Offset: 0x0000804C
			// (set) Token: 0x06000072 RID: 114 RVA: 0x000021E0 File Offset: 0x000003E0
			public int PullDelay { get; set; }

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000073 RID: 115 RVA: 0x00009E64 File Offset: 0x00008064
			// (set) Token: 0x06000074 RID: 116 RVA: 0x000021E9 File Offset: 0x000003E9
			public int ShotInterval { get; set; }

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000075 RID: 117 RVA: 0x00009E7C File Offset: 0x0000807C
			// (set) Token: 0x06000076 RID: 118 RVA: 0x000021F2 File Offset: 0x000003F2
			public int Lefty { get; set; }

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000077 RID: 119 RVA: 0x00009E94 File Offset: 0x00008094
			// (set) Token: 0x06000078 RID: 120 RVA: 0x000021FB File Offset: 0x000003FB
			public int Righty { get; set; }

			// Token: 0x06000079 RID: 121 RVA: 0x00009EAC File Offset: 0x000080AC
			public bool IsEmpty()
			{
				return this.PresetName == null;
			}
		}
	}
}
