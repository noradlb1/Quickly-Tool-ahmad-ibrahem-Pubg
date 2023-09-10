using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Quickly_Helper
{
	// Token: 0x02000018 RID: 24
	public partial class WeaponSelectorForm : Form
	{
		// Token: 0x06000123 RID: 291
		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		// Token: 0x06000124 RID: 292
		[DllImport("user32.dll")]
		private static extern bool SetForegroundWindow(IntPtr hWnd);

		// Token: 0x06000125 RID: 293
		[DllImport("user32.dll")]
		private static extern bool AttachThreadInput(uint idAttach, uint idAttachTo, bool fAttach);

		// Token: 0x06000126 RID: 294
		[DllImport("kernel32.dll")]
		private static extern uint GetCurrentThreadId();

		// Token: 0x06000127 RID: 295
		[DllImport("user32.dll")]
		private static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);

		// Token: 0x06000128 RID: 296 RVA: 0x0000CE0C File Offset: 0x0000B00C
		public WeaponSelectorForm(List<ToolStripMenuItem> presetMenuItemsList)
		{
			this.InitializeComponent();
			this.comboBoxPresets.Items.AddRange((from presetMenuItem in presetMenuItemsList
			select presetMenuItem.Text).ToArray<string>());
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000CE64 File Offset: 0x0000B064
		public string GetSelectedPresetName()
		{
			return this.comboBoxPresets.Text;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000CE80 File Offset: 0x0000B080
		private void WeaponSelectorForm_Shown(object sender, EventArgs e)
		{
			this.activeWindowhandle = WeaponSelectorForm.GetForegroundWindow();
			uint windowThreadProcessId = WeaponSelectorForm.GetWindowThreadProcessId(this.activeWindowhandle, IntPtr.Zero);
			uint currentThreadId = WeaponSelectorForm.GetCurrentThreadId();
			WeaponSelectorForm.AttachThreadInput(currentThreadId, windowThreadProcessId, true);
			WeaponSelectorForm.SetForegroundWindow(base.Handle);
			WeaponSelectorForm.AttachThreadInput(currentThreadId, windowThreadProcessId, false);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000240F File Offset: 0x0000060F
		private void WeaponSelectorForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			WeaponSelectorForm.SetForegroundWindow(this.activeWindowhandle);
		}

		// Token: 0x040000B0 RID: 176
		private IntPtr activeWindowhandle;
	}
}
