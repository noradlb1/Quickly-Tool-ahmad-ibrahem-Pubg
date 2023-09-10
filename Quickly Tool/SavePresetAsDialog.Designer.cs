namespace Quickly_Helper
{
	// Token: 0x02000015 RID: 21
	public partial class SavePresetAsDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x06000113 RID: 275 RVA: 0x0000C93C File Offset: 0x0000AB3C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000C96C File Offset: 0x0000AB6C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Quickly_Helper.SavePresetAsDialog));
			this.textBoxPresetName = new global::System.Windows.Forms.TextBox();
			this.buttonOkSave = new global::System.Windows.Forms.Button();
			this.buttonCancelSave = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.textBoxPresetName.Location = new global::System.Drawing.Point(12, 12);
			this.textBoxPresetName.Name = "textBoxPresetName";
			this.textBoxPresetName.Size = new global::System.Drawing.Size(243, 20);
			this.textBoxPresetName.TabIndex = 0;
			this.textBoxPresetName.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.textBoxPresetName_KeyDown);
			this.buttonOkSave.Location = new global::System.Drawing.Point(44, 38);
			this.buttonOkSave.Name = "buttonOkSave";
			this.buttonOkSave.Size = new global::System.Drawing.Size(75, 23);
			this.buttonOkSave.TabIndex = 1;
			this.buttonOkSave.Text = "حسنا";
			this.buttonOkSave.UseVisualStyleBackColor = true;
			this.buttonOkSave.Click += new global::System.EventHandler(this.buttonOkSave_Click);
			this.buttonCancelSave.Location = new global::System.Drawing.Point(151, 38);
			this.buttonCancelSave.Name = "buttonCancelSave";
			this.buttonCancelSave.Size = new global::System.Drawing.Size(75, 23);
			this.buttonCancelSave.TabIndex = 2;
			this.buttonCancelSave.Text = "إلغاء";
			this.buttonCancelSave.UseVisualStyleBackColor = true;
			this.buttonCancelSave.Click += new global::System.EventHandler(this.buttonCancelSave_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Maroon;
			base.ClientSize = new global::System.Drawing.Size(269, 73);
			base.Controls.Add(this.buttonCancelSave);
			base.Controls.Add(this.buttonOkSave);
			base.Controls.Add(this.textBoxPresetName);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "SavePresetAsDialog";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "أدخل اسم الإعداد المسبق";
			base.TopMost = true;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000A7 RID: 167
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000A8 RID: 168
		private global::System.Windows.Forms.TextBox textBoxPresetName;

		// Token: 0x040000A9 RID: 169
		private global::System.Windows.Forms.Button buttonOkSave;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Forms.Button buttonCancelSave;
	}
}
