namespace Quickly_Helper
{
	// Token: 0x02000010 RID: 16
	public partial class Mouse_Position : global::System.Windows.Forms.Form
	{
		// Token: 0x06000093 RID: 147 RVA: 0x0000AEC0 File Offset: 0x000090C0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000AEF0 File Offset: 0x000090F0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Quickly_Helper.Mouse_Position));
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Poisiton = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.Poisiton.AutoSize = true;
			this.Poisiton.Location = new global::System.Drawing.Point(13, 13);
			this.Poisiton.Name = "Poisiton";
			this.Poisiton.Size = new global::System.Drawing.Size(35, 13);
			this.Poisiton.TabIndex = 0;
			this.Poisiton.Text = "label1";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(213, 31);
			base.Controls.Add(this.Poisiton);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Mouse_Position";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mouse_Position";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.Mouse_Position_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400008A RID: 138
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.Label Poisiton;
	}
}
