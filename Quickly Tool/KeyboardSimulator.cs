using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Quickly_Helper
{
	// Token: 0x0200000C RID: 12
	public static class KeyboardSimulator
	{
		// Token: 0x0600007F RID: 127
		[DllImport("user32.dll")]
		private static extern void keybd_event(byte key, byte scan, int flags, int extraInfo);

		// Token: 0x06000080 RID: 128 RVA: 0x00002204 File Offset: 0x00000404
		public static void KeyDown(Keys key)
		{
			KeyboardSimulator.keybd_event(KeyboardSimulator.ParseKey(key), 0, 0, 0);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002214 File Offset: 0x00000414
		public static void KeyUp(Keys key)
		{
			KeyboardSimulator.keybd_event(KeyboardSimulator.ParseKey(key), 0, 2, 0);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002224 File Offset: 0x00000424
		public static void KeyPress(Keys key)
		{
			KeyboardSimulator.KeyDown(key);
			KeyboardSimulator.KeyUp(key);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000A98C File Offset: 0x00008B8C
		public static void SimulateStandardShortcut(StandardShortcut shortcut)
		{
			switch (shortcut)
			{
			case StandardShortcut.Copy:
				KeyboardSimulator.KeyDown(Keys.Control);
				KeyboardSimulator.KeyPress(Keys.C);
				KeyboardSimulator.KeyUp(Keys.Control);
				break;
			case StandardShortcut.Cut:
				KeyboardSimulator.KeyDown(Keys.Control);
				KeyboardSimulator.KeyPress(Keys.X);
				KeyboardSimulator.KeyUp(Keys.Control);
				break;
			case StandardShortcut.Paste:
				KeyboardSimulator.KeyDown(Keys.Control);
				KeyboardSimulator.KeyPress(Keys.V);
				KeyboardSimulator.KeyUp(Keys.Control);
				break;
			case StandardShortcut.SelectAll:
				KeyboardSimulator.KeyDown(Keys.Control);
				KeyboardSimulator.KeyPress(Keys.A);
				KeyboardSimulator.KeyUp(Keys.Control);
				break;
			case StandardShortcut.Save:
				KeyboardSimulator.KeyDown(Keys.Control);
				KeyboardSimulator.KeyPress(Keys.S);
				KeyboardSimulator.KeyUp(Keys.Control);
				break;
			case StandardShortcut.Open:
				KeyboardSimulator.KeyDown(Keys.Control);
				KeyboardSimulator.KeyPress(Keys.O);
				KeyboardSimulator.KeyUp(Keys.Control);
				break;
			case StandardShortcut.New:
				KeyboardSimulator.KeyDown(Keys.Control);
				KeyboardSimulator.KeyPress(Keys.N);
				KeyboardSimulator.KeyUp(Keys.Control);
				break;
			case StandardShortcut.Close:
				KeyboardSimulator.KeyDown(Keys.Alt);
				KeyboardSimulator.KeyPress(Keys.F4);
				KeyboardSimulator.KeyUp(Keys.Alt);
				break;
			case StandardShortcut.Print:
				KeyboardSimulator.KeyDown(Keys.Control);
				KeyboardSimulator.KeyPress(Keys.P);
				KeyboardSimulator.KeyUp(Keys.Control);
				break;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000AADC File Offset: 0x00008CDC
		private static byte ParseKey(Keys key)
		{
			byte result;
			if (key != Keys.Shift)
			{
				if (key != Keys.Control)
				{
					if (key != Keys.Alt)
					{
						result = (byte)key;
					}
					else
					{
						result = 18;
					}
				}
				else
				{
					result = 17;
				}
			}
			else
			{
				result = 16;
			}
			return result;
		}

		// Token: 0x0400007E RID: 126
		private const int KEYEVENTF_EXTENDEDKEY = 1;

		// Token: 0x0400007F RID: 127
		private const int KEYEVENTF_KEYUP = 2;
	}
}
