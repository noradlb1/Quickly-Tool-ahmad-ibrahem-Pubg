using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Quickly_Helper.Properties;

namespace Quickly_Helper
{
	// Token: 0x0200000E RID: 14
	public partial class MessageToast : Form
	{
		// Token: 0x06000085 RID: 133 RVA: 0x0000AB18 File Offset: 0x00008D18
		public MessageToast(string message)
		{
			this.InitializeComponent();
			this.labelMessage.Text = message;
			this.timerCloseForm.Enabled = true;
			base.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - base.Width / 2, 50);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002232 File Offset: 0x00000432
		public MessageToast(string message, int timerIntervalMs = 10) : this(message)
		{
			this.timerCloseForm.Interval = timerIntervalMs;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000AB7C File Offset: 0x00008D7C
		private void timerCloseForm_Tick(object sender, EventArgs e)
		{
			double num = base.Opacity - 0.02;
			if (num <= 0.0)
			{
				base.Close();
			}
			else
			{
				base.Opacity = num;
			}
		}
	}
}
