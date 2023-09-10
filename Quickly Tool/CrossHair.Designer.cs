namespace Quickly_Helper
{
	// Token: 0x02000003 RID: 3
	public partial class CrossHair : global::System.Windows.Forms.Form
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002BD0 File Offset: 0x00000DD0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002C00 File Offset: 0x00000E00
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.CrossTimer = new global::System.Windows.Forms.Timer(this.components);
			base.SuspendLayout();
			this.textBox1.Location = new global::System.Drawing.Point(394, 211);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 0;
			this.textBox2.Location = new global::System.Drawing.Point(394, 237);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 0;
			this.CrossTimer.Enabled = true;
			this.CrossTimer.Interval = 1;
			this.CrossTimer.Tick += new global::System.EventHandler(this.CrossTimer_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			this.BackgroundImage = global::Quickly_Helper.Properties.Resources.crosshair;
			base.ClientSize = new global::System.Drawing.Size(150, 55);
			base.ControlBox = false;
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.textBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "CrossHair";
			base.Opacity = 0.6;
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "CrossHair";
			base.TopMost = true;
			base.TransparencyKey = global::System.Drawing.Color.Black;
			base.Load += new global::System.EventHandler(this.CrossHair_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400000C RID: 12
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Timer CrossTimer;
	}
}
