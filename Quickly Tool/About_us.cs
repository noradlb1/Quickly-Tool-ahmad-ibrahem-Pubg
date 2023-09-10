using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Quickly_Helper.Properties;

namespace Quickly_Helper
{
	// Token: 0x02000002 RID: 2
	public partial class About_us : Form
	{
		// Token: 0x06000002 RID: 2 RVA: 0x0000204A File Offset: 0x0000024A
		public About_us()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002470 File Offset: 0x00000670
		private void YouTube_Button_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCgwmd7QNeQuEdLL13W3xlIw");
			Thread.Sleep(1000);
			this.SP.Search("#D94242");
			Thread.Sleep(1000);
			this.SP.Search("#D94242");
			Thread.Sleep(1000);
			this.SP.Search("#CC0000");
			Thread.Sleep(1000);
			this.SP.Search("#CC0000");
			Thread.Sleep(1000);
			this.SP.Search("#CC0000");
			Thread.Sleep(1000);
			this.SP.Search("#CC0000");
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000206A File Offset: 0x0000026A
		private void Discord_Click(object sender, EventArgs e)
		{
			MessageBox.Show("غير متوفر حاليا");
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002077 File Offset: 0x00000277
		private void Close_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000207F File Offset: 0x0000027F
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("MY Name [ツQúićklyツ]\n MY ID [5709265470]");
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000206A File Offset: 0x0000026A
		private void FaceBook_Click(object sender, EventArgs e)
		{
			MessageBox.Show("غير متوفر حاليا");
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000206A File Offset: 0x0000026A
		private void instagram_Click(object sender, EventArgs e)
		{
			MessageBox.Show("غير متوفر حاليا");
		}

		// Token: 0x04000001 RID: 1
		private SearchPixel SP = new SearchPixel();
	}
}
