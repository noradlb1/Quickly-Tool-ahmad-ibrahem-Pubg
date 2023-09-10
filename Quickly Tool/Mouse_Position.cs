using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Quickly_Helper
{
	// Token: 0x02000010 RID: 16
	public partial class Mouse_Position : Form
	{
		// Token: 0x06000090 RID: 144 RVA: 0x0000226E File Offset: 0x0000046E
		public Mouse_Position()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000AE6C File Offset: 0x0000906C
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.Poisiton.Text = "Position X = " + Cursor.Position.X.ToString() + "    Position Y = " + Cursor.Position.Y.ToString();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002283 File Offset: 0x00000483
		private void Mouse_Position_Load(object sender, EventArgs e)
		{
			this.timer1.Start();
			this.timer1.Interval = 1;
		}
	}
}
