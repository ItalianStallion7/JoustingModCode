using System;

namespace LogRaamJousting.Options
{
	// Token: 0x02000026 RID: 38
	public interface IOptions
	{
		// Token: 0x060000F4 RID: 244
		bool ShouldBeNaked(string[] options, string lineToFind);

		// Token: 0x060000F5 RID: 245
		bool ShouldBeNaked(string lineToFind);

		// Token: 0x060000F6 RID: 246
		bool ShouldHappens(string[] options, string lineToFind);

		// Token: 0x060000F7 RID: 247
		bool ShouldHappens(string lineToFind);

		// Token: 0x060000F8 RID: 248
		bool ShouldProvideArmors(string[] options, string shouldProvideArmorsLineToFind);

		// Token: 0x060000F9 RID: 249
		bool ShouldProvideWeapons(string[] options, string shouldProvideWeaponsLineToFind);

		// Token: 0x060000FA RID: 250
		bool ShouldUseHostCulture(string[] options, string lineToFind);

		// Token: 0x060000FB RID: 251
		bool ShouldUseHostCulture(string lineToFind);

		// Token: 0x060000FC RID: 252
		bool ShouldUseTheirEquipment(string[] options, string xAseraiTournamentSParticipantsMustBringTheirOwnEquipment);
	}
}
