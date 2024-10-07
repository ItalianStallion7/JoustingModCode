using System;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Library;

namespace LogRaamJousting
{
	// Token: 0x02000010 RID: 16
	public class Renown
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000030F8 File Offset: 0x000012F8
		public void GiveBonusRenown(Hero hero, float renown)
		{
			bool flag = hero.Clan == null;
			if (!flag)
			{
				Clan clan = hero.Clan;
				clan.Renown += (float)MathF.Round(renown);
			}
		}
	}
}
