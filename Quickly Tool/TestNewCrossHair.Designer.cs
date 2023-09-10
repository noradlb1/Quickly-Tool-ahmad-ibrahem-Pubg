namespace Quickly_Helper
{
	// Token: 0x02000017 RID: 23
	public partial class TestNewCrossHair : global::System.Windows.Forms.Form
	{
		// Token: 0x06000121 RID: 289 RVA: 0x0000CD1C File Offset: 0x0000AF1C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000CD4C File Offset: 0x0000AF4C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			base.SuspendLayout();
			this.timer1.Enabled = true;
			this.timer1.Interval = 1;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(284, 262);
			base.Name = "TestNewCrossHair";
			this.Text = "TestNewCrossHair";
			base.Load += new global::System.EventHandler(this.TestNewCrossHair_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x040000AE RID: 174
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000AF RID: 175
		private global::System.Windows.Forms.Timer timer1;
	}
}
