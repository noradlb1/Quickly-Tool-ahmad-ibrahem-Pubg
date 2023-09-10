using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Quickly_Helper
{
	// Token: 0x0200000F RID: 15
	public static class MouseHelperClass
	{
		// Token: 0x0600008A RID: 138
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		private static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, UIntPtr dwExtraInfo);

		// Token: 0x0600008B RID: 139 RVA: 0x0000ADC0 File Offset: 0x00008FC0
		public static void LeftClickDown()
		{
			for (int i = 1; i < 100; i++)
			{
				MouseHelperClass.mouse_event(2U, 0, 0, 0U, UIntPtr.Zero);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002247 File Offset: 0x00000447
		public static void LeftClickUp()
		{
			MouseHelperClass.mouse_event(4U, 0, 0, 100U, UIntPtr.Zero);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002258 File Offset: 0x00000458
		public static void MouseMove(int dy, int delay)
		{
			MouseHelperClass.mouse_event(1U, 0, dy, 0U, UIntPtr.Zero);
			Thread.Sleep(delay);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000ADEC File Offset: 0x00008FEC
		public static void MouseMoveLeft(int dx)
		{
			int dx2 = (dx > 0) ? -1 : 1;
			for (int i = 1; i <= Math.Abs(dx); i++)
			{
				MouseHelperClass.mouse_event(1U, dx2, 0, 0U, UIntPtr.Zero);
				Thread.Sleep(0);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000AE2C File Offset: 0x0000902C
		public static void MouseMoveRight(int dx)
		{
			int dx2 = (dx < 0) ? -1 : 1;
			for (int i = 1; i <= Math.Abs(dx); i++)
			{
				MouseHelperClass.mouse_event(1U, dx2, 0, 0U, UIntPtr.Zero);
				Thread.Sleep(0);
			}
		}

		// Token: 0x04000083 RID: 131
		private const uint MOUSEEVENTF_LEFTDOWN = 2U;

		// Token: 0x04000084 RID: 132
		private const uint MOUSEEVENTF_LEFTUP = 4U;

		// Token: 0x04000085 RID: 133
		private const uint MOUSEEVENTF_RIGHTDOWN = 8U;

		// Token: 0x04000086 RID: 134
		private const uint MOUSEEVENTF_RIGHTUP = 16U;

		// Token: 0x04000087 RID: 135
		private const uint MOUSEEVENTF_MIDDLEDOWN = 32U;

		// Token: 0x04000088 RID: 136
		private const uint MOUSEEVENTF_MIDDLEUP = 64U;

		// Token: 0x04000089 RID: 137
		private const uint MOUSEEVENTF_MOVE = 1U;
	}
}
