using System;

namespace Quickly_Helper
{
	// Token: 0x02000007 RID: 7
	public interface IOnHotkeyPressed
	{
		// Token: 0x06000017 RID: 23
		void OnToggleRecoilCompensationHotkeyPressed();

		// Token: 0x06000018 RID: 24
		void OnToggleActivateProgramHotkeyPressed();

		// Token: 0x06000019 RID: 25
		void OnWeaponSlotChangeHotkeyPressed(int slotNumber);

		// Token: 0x0600001A RID: 26
		void OnInsertHideMenu();

		// Token: 0x0600001B RID: 27
		void Prone();

		// Token: 0x0600001C RID: 28
		void Sliding();

		// Token: 0x0600001D RID: 29
		void JumpCrouch();

		// Token: 0x0600001E RID: 30
		void Jump_prone();

		// Token: 0x0600001F RID: 31
		void Off();

		// Token: 0x06000020 RID: 32
		void On();

		// Token: 0x06000021 RID: 33
		void Fix_prone();

		// Token: 0x06000022 RID: 34
		void Fix_Jump();

		// Token: 0x06000023 RID: 35
		void Pick();

		// Token: 0x06000024 RID: 36
		void Dodge_1();

		// Token: 0x06000025 RID: 37
		void Dodge_2();

		// Token: 0x06000026 RID: 38
		void NewNum_1();

		// Token: 0x06000027 RID: 39
		void NewNum_2();

		// Token: 0x06000028 RID: 40
		void Revive();

		// Token: 0x06000029 RID: 41
		void CarSpeed();

		// Token: 0x0600002A RID: 42
		void NormalAttack();
	}
}
