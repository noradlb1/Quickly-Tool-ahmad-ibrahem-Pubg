using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Quickly_Helper
{
	// Token: 0x02000017 RID: 23
	public partial class TestNewCrossHair : Form
	{
		// Token: 0x0600011A RID: 282 RVA: 0x0000CC70 File Offset: 0x0000AE70
		public TestNewCrossHair()
		{
			this.InitializeComponent();
			base.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - base.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - base.Height / 2 + 15);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002048 File Offset: 0x00000248
		private void TestNewCrossHair_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600011C RID: 284
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		private static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, UIntPtr dwExtraInfo);

		// Token: 0x0600011D RID: 285
		[DllImport("user32.dll")]
		private static extern short GetAsyncKeyState(Keys vKey);

		// Token: 0x0600011E RID: 286 RVA: 0x000023ED File Offset: 0x000005ED
		public static void RightClickDown()
		{
			TestNewCrossHair.mouse_event(8U, 0, 0, 0U, UIntPtr.Zero);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000023FD File Offset: 0x000005FD
		public static void RightClickUp()
		{
			TestNewCrossHair.mouse_event(16U, 0, 0, 100U, UIntPtr.Zero);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000CCE0 File Offset: 0x0000AEE0
		private void timer1_Tick(object sender, EventArgs e)
		{
			if ((TestNewCrossHair.GetAsyncKeyState(Keys.RButton) & 1) > 0)
			{
				TestNewCrossHair.RightClickDown();
				TestNewCrossHair.RightClickUp();
				base.Close();
				this.Quick = false;
				Thread.Sleep(100);
			}
		}

		// Token: 0x040000AB RID: 171
		private const uint MOUSEEVENTF_RIGHTDOWN = 8U;

		// Token: 0x040000AC RID: 172
		private const uint MOUSEEVENTF_RIGHTUP = 16U;

		// Token: 0x040000AD RID: 173
		private bool Quick = true;
	}
}
