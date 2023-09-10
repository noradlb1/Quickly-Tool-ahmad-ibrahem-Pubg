namespace Quickly_Helper
{
	// Token: 0x02000018 RID: 24
	public partial class WeaponSelectorForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600012C RID: 300 RVA: 0x0000CED0 File Offset: 0x0000B0D0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000CF00 File Offset: 0x0000B100
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Quickly_Helper.WeaponSelectorForm));
			this.comboBoxPresets = new global::System.Windows.Forms.ComboBox();
			base.SuspendLayout();
			componentResourceManager.ApplyResources(this.comboBoxPresets, "comboBoxPresets");
			this.comboBoxPresets.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboBoxPresets.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBoxPresets.BackColor = global::System.Drawing.Color.Maroon;
			this.comboBoxPresets.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPresets.FormattingEnabled = true;
			this.comboBoxPresets.Name = "comboBoxPresets";
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			base.Controls.Add(this.comboBoxPresets);
			this.ForeColor = global::System.Drawing.SystemColors.ControlText;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "WeaponSelectorForm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.TopMost = true;
			base.TransparencyKey = global::System.Drawing.SystemColors.ActiveCaption;
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.WeaponSelectorForm_FormClosed);
			base.Shown += new global::System.EventHandler(this.WeaponSelectorForm_Shown);
			base.ResumeLayout(false);
		}

		// Token: 0x040000B1 RID: 177
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.ComboBox comboBoxPresets;
	}
}
