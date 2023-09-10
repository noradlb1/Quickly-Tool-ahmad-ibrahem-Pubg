using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Quickly_Helper
{
	// Token: 0x0200000A RID: 10
	public static class HelperFunctions
	{
		// Token: 0x0600007A RID: 122 RVA: 0x00009EC4 File Offset: 0x000080C4
		public static void WaitUntilTimeoutWhileTrue(Func<bool> condition, int timeoutMs)
		{
			int tickCount = Environment.TickCount;
			while (Environment.TickCount - tickCount < timeoutMs && condition())
			{
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00009EEC File Offset: 0x000080EC
		public static string GetApplicationName()
		{
			return "Ahmed Ibrahim Tool";
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00009F00 File Offset: 0x00008100
		public static List<ToolStripMenuItem> GetListOfAllPresetMenuItems(ToolStripMenuItem toolStripMenuItemPresets)
		{
			List<ToolStripMenuItem> list = new List<ToolStripMenuItem>();
			foreach (object obj in toolStripMenuItemPresets.DropDownItems)
			{
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)obj;
				if (!toolStripMenuItem.HasDropDownItems)
				{
					list.Add(toolStripMenuItem);
				}
				else
				{
					foreach (object obj2 in toolStripMenuItem.DropDownItems)
					{
						ToolStripMenuItem item = (ToolStripMenuItem)obj2;
						list.Add(item);
					}
				}
			}
			return list;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00009FCC File Offset: 0x000081CC
		public static Keys GetFireKeyFromString(string fireKeyString)
		{
			Keys result = Keys.F12;
			switch (fireKeyString)
			{
			case "XButton1":
				result = Keys.XButton1;
				break;
			case "XButton2":
				result = Keys.XButton2;
				break;
			case "Left Mouse":
				result = Keys.LButton;
				break;
			case "Right Mouse":
				result = Keys.RButton;
				break;
			case "Middle mouse":
				result = Keys.MButton;
				break;
			case "A":
				result = Keys.A;
				break;
			case "B":
				result = Keys.B;
				break;
			case "C":
				result = Keys.C;
				break;
			case "D":
				result = Keys.D;
				break;
			case "E":
				result = Keys.E;
				break;
			case "F":
				result = Keys.F;
				break;
			case "G":
				result = Keys.G;
				break;
			case "H":
				result = Keys.H;
				break;
			case "I":
				result = Keys.I;
				break;
			case "J":
				result = Keys.J;
				break;
			case "K":
				result = Keys.K;
				break;
			case "L":
				result = Keys.L;
				break;
			case "M":
				result = Keys.M;
				break;
			case "N":
				result = Keys.N;
				break;
			case "O":
				result = Keys.O;
				break;
			case "P":
				result = Keys.P;
				break;
			case "Q":
				result = Keys.Q;
				break;
			case "R":
				result = Keys.R;
				break;
			case "S":
				result = Keys.S;
				break;
			case "T":
				result = Keys.T;
				break;
			case "U":
				result = Keys.U;
				break;
			case "V":
				result = Keys.V;
				break;
			case "W":
				result = Keys.W;
				break;
			case "X":
				result = Keys.X;
				break;
			case "Y":
				result = Keys.Y;
				break;
			case "Z":
				result = Keys.Z;
				break;
			case "D1":
				result = Keys.D1;
				break;
			case "D2":
				result = Keys.D2;
				break;
			case "D3":
				result = Keys.D3;
				break;
			case "D4":
				result = Keys.D4;
				break;
			case "D5":
				result = Keys.D5;
				break;
			case "D6":
				result = Keys.D6;
				break;
			case "D7":
				result = Keys.D7;
				break;
			case "D8":
				result = Keys.D8;
				break;
			case "D9":
				result = Keys.D9;
				break;
			case "D0":
				result = Keys.D0;
				break;
			case "F1":
				result = Keys.F1;
				break;
			case "F2":
				result = Keys.F2;
				break;
			case "F3":
				result = Keys.F3;
				break;
			case "F4":
				result = Keys.F4;
				break;
			case "F5":
				result = Keys.F5;
				break;
			case "F6":
				result = Keys.F6;
				break;
			case "F7":
				result = Keys.F7;
				break;
			case "F8":
				result = Keys.F8;
				break;
			case "F9":
				result = Keys.F9;
				break;
			case "F10":
				result = Keys.F10;
				break;
			case "F11":
				result = Keys.F11;
				break;
			case "F12":
				result = Keys.F12;
				break;
			case "NumPad0":
				result = Keys.NumPad0;
				break;
			case "NumPad1":
				result = Keys.NumPad1;
				break;
			case "NumPad2":
				result = Keys.NumPad2;
				break;
			case "NumPad3":
				result = Keys.NumPad3;
				break;
			case "NumPad4":
				result = Keys.NumPad4;
				break;
			case "NumPad5":
				result = Keys.NumPad5;
				break;
			case "NumPad6":
				result = Keys.NumPad6;
				break;
			case "NumPad7":
				result = Keys.NumPad7;
				break;
			case "NumPad8":
				result = Keys.NumPad8;
				break;
			case "NumPad9":
				result = Keys.NumPad9;
				break;
			case "Space":
				result = Keys.Space;
				break;
			case "Tab":
				result = Keys.Tab;
				break;
			case "LControlKey":
				result = Keys.LControlKey;
				break;
			case "RControlKey":
				result = Keys.RControlKey;
				break;
			case "LMenu":
				result = Keys.LMenu;
				break;
			case "RMenu":
				result = Keys.RMenu;
				break;
			case "Capital":
				result = Keys.Capital;
				break;
			case "LShiftKey":
				result = Keys.LShiftKey;
				break;
			case "RShiftKey":
				result = Keys.RShiftKey;
				break;
			case "Up":
				result = Keys.Up;
				break;
			case "Down":
				result = Keys.Down;
				break;
			case "Left":
				result = Keys.Left;
				break;
			case "Right":
				result = Keys.Right;
				break;
			case "Return":
				result = Keys.Return;
				break;
			case "Oem5":
				result = Keys.OemPipe;
				break;
			case "OemQuestion":
				result = Keys.OemQuestion;
				break;
			case "OemPeriod":
				result = Keys.OemPeriod;
				break;
			case "Oemcomma":
				result = Keys.Oemcomma;
				break;
			case "Oem7":
				result = Keys.OemQuotes;
				break;
			case "Oemtilde":
				result = Keys.Oemtilde;
				break;
			case "Oem1":
				result = Keys.OemSemicolon;
				break;
			case "Oem6":
				result = Keys.OemCloseBrackets;
				break;
			case "OemOpenBrackets":
				result = Keys.OemOpenBrackets;
				break;
			case "Oemplus":
				result = Keys.Oemplus;
				break;
			case "OemMinus":
				result = Keys.OemMinus;
				break;
			case "Subtract":
				result = Keys.Subtract;
				break;
			case "Multiply":
				result = Keys.Multiply;
				break;
			}
			return result;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000A8D4 File Offset: 0x00008AD4
		public static ToolStripMenuItem GetToolStripMenuItemFromText(ToolStripMenuItem toolStripMenuItemPresets, string menuItemText)
		{
			try
			{
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)toolStripMenuItemPresets.DropDownItems[0];
				foreach (object obj in toolStripMenuItem.DropDownItems)
				{
					ToolStripMenuItem toolStripMenuItem2 = (ToolStripMenuItem)obj;
					if (toolStripMenuItem2.Text == menuItemText)
					{
						return toolStripMenuItem2;
					}
				}
			}
			catch (ArgumentOutOfRangeException)
			{
				throw new PresetMenuNotPopulatedException("قائمة الضبط المسبق غير مأهولة!");
			}
			throw new PresetNotFoundException("المعد مسبقا " + menuItemText + " غير موجود في قائمة الإعدادات المسبقة!");
		}
	}
}
