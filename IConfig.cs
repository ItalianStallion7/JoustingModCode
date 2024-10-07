using System;
using LogRaamJousting.Options;

namespace LogRaamJousting.Configuration
{
	// Token: 0x02000040 RID: 64
	public interface IConfig
	{
		// Token: 0x060001AA RID: 426
		ICultureOption GetSpecificOptionsFor(string culture);

		// Token: 0x060001AB RID: 427
		bool HostShouldProvideArmors(string hostCulture);

		// Token: 0x060001AC RID: 428
		bool HostShouldProvideWeapons(string hostCulture);

		// Token: 0x060001AD RID: 429
		bool IsHostEnforcingHisCulture(string hostCulture);

		// Token: 0x060001AE RID: 430
		bool IsPlayerMayShouldGainRenownWhenWinningTournament();

		// Token: 0x060001AF RID: 431
		bool IsPlayerShouldGainExtraRenownWhenNaked();

		// Token: 0x060001B0 RID: 432
		bool IsPlayerShouldLosesRenownWhenLosingTournament();

		// Token: 0x060001B1 RID: 433
		bool ParticipantsUsesTheirOwnEquipments(string hostCulture);

		// Token: 0x060001B2 RID: 434
		bool ShouldApplyModForThisMatch(string hostCulture);

		// Token: 0x060001B3 RID: 435
		bool ShouldBeNaked(string hostCulture);
	}
}
