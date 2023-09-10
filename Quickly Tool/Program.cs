using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Quickly_Helper
{
	// Token: 0x02000012 RID: 18
	internal static class Program
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x0000B930 File Offset: 0x00009B30
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			string name = "ar";
			CultureInfo cultureInfo = new CultureInfo(name);
			Thread.CurrentThread.CurrentCulture = cultureInfo;
			Thread.CurrentThread.CurrentUICulture = cultureInfo;
			Application.Run(new BackGround());
		}
	}
}
