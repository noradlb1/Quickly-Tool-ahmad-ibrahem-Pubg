namespace Quickly_Helper
{
	// Token: 0x0200000E RID: 14
	public partial class MessageToast : global::System.Windows.Forms.Form
	{
		// Token: 0x06000088 RID: 136 RVA: 0x0000ABB8 File Offset: 0x00008DB8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000ABE8 File Offset: 0x00008DE8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.timerCloseForm = new global::System.Windows.Forms.Timer(this.components);
			this.labelMessage = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.timerCloseForm.Interval = 10;
			this.timerCloseForm.Tick += new global::System.EventHandler(this.timerCloseForm_Tick);
			this.labelMessage.AutoSize = true;
			this.labelMessage.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.labelMessage.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelMessage.ForeColor = global::System.Drawing.Color.White;
			this.labelMessage.Image = global::Quickly_Helper.Properties.Resources.Toast;
			this.labelMessage.Location = new global::System.Drawing.Point(0, -1);
			this.labelMessage.Name = "labelMessage";
			this.labelMessage.Padding = new global::System.Windows.Forms.Padding(10);
			this.labelMessage.Size = new global::System.Drawing.Size(246, 45);
			this.labelMessage.TabIndex = 0;
			this.labelMessage.Text = "Some message here";
			this.labelMessage.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			base.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.BackgroundImage = global::Quickly_Helper.Properties.Resources.Toast;
			base.ClientSize = new global::System.Drawing.Size(246, 42);
			base.Controls.Add(this.labelMessage);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "MessageToast";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "MessageToast";
			base.TopMost = true;
			base.TransparencyKey = global::System.Drawing.SystemColors.ActiveCaption;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000080 RID: 128
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Forms.Label labelMessage;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.Timer timerCloseForm;
	}
}
