using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Quickly_Helper.Properties;

namespace Quickly_Helper
{
	// Token: 0x02000003 RID: 3
	public partial class CrossHair : Form
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002B38 File Offset: 0x00000D38
		public CrossHair()
		{
			this.InitializeComponent();
			base.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - base.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - base.Height / 2 + 14);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002048 File Offset: 0x00000248
		private void CrossHair_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000D RID: 13
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		private static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, UIntPtr dwExtraInfo);

		// Token: 0x0600000E RID: 14
		[DllImport("user32.dll")]
		private static extern short GetAsyncKeyState(Keys vKey);

		// Token: 0x0600000F RID: 15 RVA: 0x0000208C File Offset: 0x0000028C
		public static void RightClickDown()
		{
			CrossHair.mouse_event(8U, 0, 0, 0U, UIntPtr.Zero);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000209C File Offset: 0x0000029C
		public static void RightClickUp()
		{
			CrossHair.mouse_event(16U, 0, 0, 100U, UIntPtr.Zero);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002BA0 File Offset: 0x00000DA0
		private void CrossTimer_Tick(object sender, EventArgs e)
		{
			if ((CrossHair.GetAsyncKeyState(Keys.RButton) & 1) > 0)
			{
				CrossHair.RightClickDown();
				CrossHair.RightClickUp();
				base.Close();
			}
		}

		// Token: 0x0400000A RID: 10
		private const uint MOUSEEVENTF_RIGHTDOWN = 8U;

		// Token: 0x0400000B RID: 11
		private const uint MOUSEEVENTF_RIGHTUP = 16U;
	}
}
