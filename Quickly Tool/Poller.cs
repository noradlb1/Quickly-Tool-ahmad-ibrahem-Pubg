using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace Quickly_Helper
{
	// Token: 0x02000011 RID: 17
	public class Poller
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000095 RID: 149 RVA: 0x0000B058 File Offset: 0x00009258
		// (set) Token: 0x06000096 RID: 150 RVA: 0x0000229C File Offset: 0x0000049C
		public bool PerformRecoilCompensation { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0000B06C File Offset: 0x0000926C
		// (set) Token: 0x06000098 RID: 152 RVA: 0x000022A5 File Offset: 0x000004A5
		public bool Activated { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0000B080 File Offset: 0x00009280
		// (set) Token: 0x0600009A RID: 154 RVA: 0x000022AE File Offset: 0x000004AE
		public bool PollKeyboardKeysForConfigChange { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0000B094 File Offset: 0x00009294
		// (set) Token: 0x0600009C RID: 156 RVA: 0x000022B7 File Offset: 0x000004B7
		public bool NormalClickActive { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0000B0A8 File Offset: 0x000092A8
		// (set) Token: 0x0600009E RID: 158 RVA: 0x000022C0 File Offset: 0x000004C0
		public bool Macro { get; set; }

		// Token: 0x0600009F RID: 159
		[DllImport("user32.dll")]
		private static extern short GetAsyncKeyState(Keys vKey);

		// Token: 0x060000A0 RID: 160 RVA: 0x0000B0BC File Offset: 0x000092BC
		public Poller(IOnHotkeyPressed onHotkeyPressed)
		{
			this.onHotkeyPressed = onHotkeyPressed;
			this.shootTimer = new System.Timers.Timer();
			System.Timers.Timer timer = this.shootTimer;
			ElapsedEventHandler value = delegate(object sender, ElapsedEventArgs e)
			{
				this.PollFireButton();
			};
			timer.Elapsed += value;
			this.shootTimer.Interval = 1.0;
			this.pullDownMouseTimer = new System.Timers.Timer();
			System.Timers.Timer timer2 = this.pullDownMouseTimer;
			ElapsedEventHandler value2 = delegate(object sender, ElapsedEventArgs e)
			{
				this.PullDownMouse();
			};
			timer2.Elapsed += value2;
			this.pullDownMouseTimer.AutoReset = false;
			this.pullDownMouseTimer.Interval = 1.0;
			this.pullDownMouseTimer.Start();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000B194 File Offset: 0x00009394
		public void Poll(int dy, int shotInterval, int pullDelay, string fireButton)
		{
			this._dy = dy;
			this._shotInterval = shotInterval;
			this._pullDelay = pullDelay;
			this._fireButton = fireButton;
			if (this.Activated)
			{
				if (!this.firingState)
				{
					this.shootTimer.Interval = 10.0;
				}
				this.shootTimer.Enabled = true;
				this.PollWeaponSlotChangeHotkey();
				this.LeftClickFix();
			}
			else
			{
				this.shootTimer.Enabled = false;
			}
			this.HideMenu();
			this.FastProne();
			this.FastSliding();
			this.FastJumpCrouch();
			this.FastJump_Prone();
			this.FastFix_prone();
			this.FastFix_Jump();
			this.FastPick();
			this.Num_1();
			this.Num_2();
			this.Num_3();
			this.Num_4();
			this.Num_5();
			this.Num_6();
			this.Num_7();
			this.FastDodge_1();
			this.FastDodge_2();
			this.NormalAttack();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000B278 File Offset: 0x00009478
		private void PollWeaponSlotChangeHotkey()
		{
			short num = 0;
			if ((Poller.GetAsyncKeyState(Keys.D1) & 1) > 0)
			{
				HelperFunctions.WaitUntilTimeoutWhileTrue(() => (Poller.GetAsyncKeyState(Keys.D1) & 1) > 0, 100);
				num = 1;
				if (!this.FixADS && this.NormalClickActive)
				{
					this.onHotkeyPressed.Off();
					this.FixADS = true;
					if (this.cross_on_off)
					{
						CrossHair crossHair = new CrossHair();
						crossHair.Show();
						Thread.Sleep(100);
					}
					Thread.Sleep(100);
				}
			}
			if ((Poller.GetAsyncKeyState(Keys.D2) & 1) > 0)
			{
				HelperFunctions.WaitUntilTimeoutWhileTrue(() => (Poller.GetAsyncKeyState(Keys.D2) & 1) > 0, 100);
				num = 2;
				if (!this.FixADS && this.NormalClickActive)
				{
					this.onHotkeyPressed.Off();
					this.FixADS = true;
					if (this.cross_on_off)
					{
						CrossHair crossHair = new CrossHair();
						crossHair.Show();
						Thread.Sleep(100);
					}
					Thread.Sleep(100);
				}
			}
			if (num > 0)
			{
				this.onHotkeyPressed.OnWeaponSlotChangeHotkeyPressed((int)num);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000B3A0 File Offset: 0x000095A0
		private void HideMenu()
		{
			if ((Poller.GetAsyncKeyState(Keys.Insert) & 1) > 0)
			{
				HelperFunctions.WaitUntilTimeoutWhileTrue(() => (Poller.GetAsyncKeyState(Keys.Insert) & 1) > 0, 100);
				this.onHotkeyPressed.OnInsertHideMenu();
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000B3F0 File Offset: 0x000095F0
		private void Num_1()
		{
			if (Poller.GetAsyncKeyState(Keys.NumPad1) < 0 && this.ipad)
			{
				KeyboardSimulator.KeyPress(Keys.NumPad0);
				Thread.Sleep(50);
				KeyboardSimulator.KeyPress(Keys.NumPad1);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000B428 File Offset: 0x00009628
		private void Num_2()
		{
			if (Poller.GetAsyncKeyState(Keys.NumPad2) < 0 && this.ipad)
			{
				KeyboardSimulator.KeyPress(Keys.NumPad0);
				Thread.Sleep(50);
				KeyboardSimulator.KeyPress(Keys.NumPad2);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000B460 File Offset: 0x00009660
		private void Num_3()
		{
			if (Poller.GetAsyncKeyState(Keys.NumPad3) < 0 && this.ipad)
			{
				KeyboardSimulator.KeyPress(Keys.NumPad0);
				Thread.Sleep(50);
				KeyboardSimulator.KeyPress(Keys.NumPad3);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000B498 File Offset: 0x00009698
		private void Num_4()
		{
			if (Poller.GetAsyncKeyState(Keys.NumPad4) < 0 && this.ipad)
			{
				KeyboardSimulator.KeyPress(Keys.NumPad0);
				Thread.Sleep(50);
				KeyboardSimulator.KeyPress(Keys.NumPad4);
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000B4D0 File Offset: 0x000096D0
		private void Num_5()
		{
			if (Poller.GetAsyncKeyState(Keys.NumPad5) < 0 && this.ipad)
			{
				KeyboardSimulator.KeyPress(Keys.NumPad0);
				Thread.Sleep(50);
				KeyboardSimulator.KeyPress(Keys.NumPad5);
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000B508 File Offset: 0x00009708
		private void Num_6()
		{
			if (Poller.GetAsyncKeyState(Keys.NumPad6) < 0 && this.ipad)
			{
				KeyboardSimulator.KeyPress(Keys.NumPad0);
				Thread.Sleep(50);
				KeyboardSimulator.KeyPress(Keys.NumPad6);
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000B540 File Offset: 0x00009740
		private void Num_7()
		{
			if (Poller.GetAsyncKeyState(Keys.NumPad7) < 0 && this.ipad)
			{
				KeyboardSimulator.KeyPress(Keys.NumPad0);
				Thread.Sleep(50);
				KeyboardSimulator.KeyPress(Keys.NumPad7);
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000022C9 File Offset: 0x000004C9
		private void FixRevive()
		{
			this.onHotkeyPressed.Revive();
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000022D6 File Offset: 0x000004D6
		private void FixCarSpeed()
		{
			this.onHotkeyPressed.CarSpeed();
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000022E3 File Offset: 0x000004E3
		private void FastNum_1()
		{
			this.onHotkeyPressed.NewNum_1();
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000022F0 File Offset: 0x000004F0
		private void FastNum_2()
		{
			this.onHotkeyPressed.NewNum_2();
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000022FD File Offset: 0x000004FD
		private void FastDodge_1()
		{
			this.onHotkeyPressed.Dodge_1();
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000230A File Offset: 0x0000050A
		private void FastDodge_2()
		{
			this.onHotkeyPressed.Dodge_2();
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002317 File Offset: 0x00000517
		private void FastPick()
		{
			this.onHotkeyPressed.Pick();
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002324 File Offset: 0x00000524
		private void FastProne()
		{
			this.onHotkeyPressed.Prone();
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002331 File Offset: 0x00000531
		private void FastSliding()
		{
			this.onHotkeyPressed.Sliding();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000233E File Offset: 0x0000053E
		private void FastJumpCrouch()
		{
			this.onHotkeyPressed.JumpCrouch();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000234B File Offset: 0x0000054B
		private void FastJump_Prone()
		{
			this.onHotkeyPressed.Jump_prone();
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002358 File Offset: 0x00000558
		private void FastFix_prone()
		{
			this.onHotkeyPressed.Fix_prone();
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002365 File Offset: 0x00000565
		private void FastFix_Jump()
		{
			this.onHotkeyPressed.Fix_Jump();
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000B578 File Offset: 0x00009778
		private void LeftClickFix()
		{
			if ((Poller.GetAsyncKeyState(Keys.RButton) & 1) > 0 && this.NormalClickActive)
			{
				if (!this.FixADS)
				{
					this.onHotkeyPressed.Off();
					this.FixADS = true;
					if (this.cross_on_off)
					{
						CrossHair crossHair = new CrossHair();
						crossHair.Show();
						Thread.Sleep(100);
					}
					Thread.Sleep(100);
				}
				else
				{
					this.onHotkeyPressed.On();
					this.FixADS = false;
				}
			}
			else if ((Poller.GetAsyncKeyState(Keys.R) & 1) > 0 && this.NormalClickActive)
			{
				if (!this.FixADS)
				{
					this.onHotkeyPressed.Off();
					this.FixADS = true;
					if (this.cross_on_off)
					{
						CrossHair crossHair = new CrossHair();
						crossHair.Show();
						Thread.Sleep(100);
					}
					Thread.Sleep(100);
				}
			}
			else if ((Poller.GetAsyncKeyState(Keys.LControlKey) & 1) > 0 && this.NormalClickActive && !this.FixADS)
			{
				this.onHotkeyPressed.Off();
				this.FixADS = true;
				if (this.cross_on_off)
				{
					CrossHair crossHair = new CrossHair();
					crossHair.Show();
					Thread.Sleep(100);
				}
				Thread.Sleep(100);
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000B6AC File Offset: 0x000098AC
		private void NormalAttack()
		{
			if ((Poller.GetAsyncKeyState(Keys.Add) & 1) > 0)
			{
				HelperFunctions.WaitUntilTimeoutWhileTrue(() => (Poller.GetAsyncKeyState(Keys.Add) & 1) > 0, 100);
				this.onHotkeyPressed.NormalAttack();
				if (!this.NormalClickActive)
				{
					this.FixADS = true;
					this.NormalClickActive = true;
				}
				else
				{
					this.FixADS = false;
					this.NormalClickActive = false;
				}
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000B720 File Offset: 0x00009920
		private void PollFireButton()
		{
			this.shootTimer.Interval = (double)this._shotInterval;
			if (this.NormalClickActive)
			{
				if ((Poller.GetAsyncKeyState(HelperFunctions.GetFireKeyFromString(this._fireButton)) & 128) > 0)
				{
					this.firingState = true;
				}
				else
				{
					this.firingState = false;
				}
			}
			else if (!this.NormalClickActive && !this.Macro)
			{
				if (((long)Poller.GetAsyncKeyState(HelperFunctions.GetFireKeyFromString(this._fireButton)) & 999999999999999999L) > 0L)
				{
					MouseHelperClass.LeftClickDown();
					MouseHelperClass.LeftClickUp();
					this.firingState = true;
				}
				else
				{
					this.firingState = false;
				}
			}
			else if (this.Macro)
			{
				if ((Poller.GetAsyncKeyState(HelperFunctions.GetFireKeyFromString(this._fireButton)) & 1) == 0)
				{
					MouseHelperClass.LeftClickDown();
					MouseHelperClass.LeftClickUp();
					this.firingState = true;
				}
				else
				{
					this.firingState = false;
				}
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000B818 File Offset: 0x00009A18
		private void PullDownMouse()
		{
			Keys fireKeyFromString = HelperFunctions.GetFireKeyFromString(this._fireButton);
			short asyncKeyState = Poller.GetAsyncKeyState(fireKeyFromString);
			bool flag = ((long)asyncKeyState & 999999999999999999L) > 0L;
			while (this.Activated && this.PerformRecoilCompensation && flag && !this.FixADS)
			{
				MouseHelperClass.MouseMove(this._dy, this._pullDelay);
				fireKeyFromString = HelperFunctions.GetFireKeyFromString(this._fireButton);
				asyncKeyState = Poller.GetAsyncKeyState(fireKeyFromString);
				flag = (((long)asyncKeyState & 999999999999999999L) > 0L);
				this.firemove = true;
			}
			this.pullDownMouseTimer.Start();
		}

		// Token: 0x0400008D RID: 141
		public bool FixADS = true;

		// Token: 0x0400008E RID: 142
		public bool rightleft = true;

		// Token: 0x0400008F RID: 143
		public bool firemove = false;

		// Token: 0x04000090 RID: 144
		public bool cross_on_off = false;

		// Token: 0x04000091 RID: 145
		private bool firingState = false;

		// Token: 0x04000092 RID: 146
		public bool ipad = false;

		// Token: 0x04000093 RID: 147
		private int _dy;

		// Token: 0x04000094 RID: 148
		private int _shotInterval = 1;

		// Token: 0x04000095 RID: 149
		private int _pullDelay;

		// Token: 0x04000096 RID: 150
		private string _fireButton;

		// Token: 0x04000097 RID: 151
		private IOnHotkeyPressed onHotkeyPressed;

		// Token: 0x04000098 RID: 152
		private System.Timers.Timer shootTimer;

		// Token: 0x04000099 RID: 153
		private System.Timers.Timer pullDownMouseTimer;
	}
}
