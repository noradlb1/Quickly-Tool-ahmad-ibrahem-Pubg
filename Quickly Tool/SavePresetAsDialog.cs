using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Quickly_Helper
{
	// Token: 0x02000015 RID: 21
	public partial class SavePresetAsDialog : Form
	{
		// Token: 0x0600010F RID: 271 RVA: 0x0000238A File Offset: 0x0000058A
		public SavePresetAsDialog(IOkButtonPressedInSavePresetDialog okButtonPressedPresetDialog)
		{
			this.okButtonPressed = okButtonPressedPresetDialog;
			this.InitializeComponent();
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000023A6 File Offset: 0x000005A6
		private void buttonOkSave_Click(object sender, EventArgs e)
		{
			this.okButtonPressed.OnOkButtonPressed(this.textBoxPresetName.Text);
			base.Close();
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002077 File Offset: 0x00000277
		private void buttonCancelSave_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000C8DC File Offset: 0x0000AADC
		private void textBoxPresetName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode.Equals(Keys.Return))
			{
				this.buttonOkSave.PerformClick();
			}
			else if (e.KeyCode.Equals(Keys.Escape))
			{
				this.buttonCancelSave.PerformClick();
			}
		}

		// Token: 0x040000A6 RID: 166
		private IOkButtonPressedInSavePresetDialog okButtonPressed;
	}
}
