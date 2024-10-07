using System;

namespace LogRaamJousting.Options
{
	// Token: 0x02000025 RID: 37
	public interface ICultureOption
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000EB RID: 235
		string Culture { get; }

		// Token: 0x060000EC RID: 236
		bool ParticipantShouldUseItsOwnEquipment(string[] options);

		// Token: 0x060000ED RID: 237
		bool ShouldBeNaked(string[] options);

		// Token: 0x060000EE RID: 238
		bool ShouldBeNaked(string lineToFind);

		// Token: 0x060000EF RID: 239
		bool ShouldHappens(string[] options);

		// Token: 0x060000F0 RID: 240
		bool ShouldProvideArmors(string[] retrieveConfigDetails);

		// Token: 0x060000F1 RID: 241
		bool ShouldProvideWeapons(string[] retrieveConfigDetails);

		// Token: 0x060000F2 RID: 242
		bool ShouldUseHostCulture(string[] options);

		// Token: 0x060000F3 RID: 243
		bool ShouldUseHostCulture(string lineToFind);
	}
}
