using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Quickly_Helper
{
	// Token: 0x02000016 RID: 22
	internal class SearchPixel
	{
		// Token: 0x06000115 RID: 277
		[DllImport("user32.dll")]
		private static extern bool SetCursorPos(int x, int y);

		// Token: 0x06000116 RID: 278 RVA: 0x0000CBBC File Offset: 0x0000ADBC
		public bool Search(string hexcode)
		{
			Bitmap bitmap = new Bitmap(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
			Color left = ColorTranslator.FromHtml(hexcode);
			for (int i = 0; i < SystemInformation.VirtualScreen.Width; i++)
			{
				for (int j = 0; j < SystemInformation.VirtualScreen.Height; j++)
				{
					Color pixel = bitmap.GetPixel(i, j);
					if (left == pixel)
					{
						this.DoubleClickAtPosition(i, j);
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000023C4 File Offset: 0x000005C4
		private void DoubleClickAtPosition(int posX, int posY)
		{
			SearchPixel.SetCursorPos(posX, posY);
			this.click();
			Thread.Sleep(10);
			this.click();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000023E1 File Offset: 0x000005E1
		private void click()
		{
			MouseHelperClass.LeftClickDown();
			MouseHelperClass.LeftClickUp();
		}
	}
}
