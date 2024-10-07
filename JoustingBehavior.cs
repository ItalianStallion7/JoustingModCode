using System;
using System.Linq;
using LogRaamJousting.Factory;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Library;

namespace LogRaamJousting
{
	// Token: 0x02000004 RID: 4
	public class JoustingBehavior : CampaignBehaviorBase
	{
		// Token: 0x06000003 RID: 3 RVA: 0x0000206C File Offset: 0x0000026C
		public void OnTournamentFinished(CharacterObject winner, MBReadOnlyList<CharacterObject> participants, Town town, ItemObject arg4)
		{
			bool flag = !participants.Exists((CharacterObject n) => n.IsPlayerCharacter);
			if (!flag)
			{
				bool flag2 = !winner.IsHero;
				if (!flag2)
				{
					this.ApplyRenownConsequence(winner, participants, town);
				}
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020C1 File Offset: 0x000002C1
		public override void RegisterEvents()
		{
			CampaignEvents.TournamentFinished.AddNonSerializedListener(this, new Action<CharacterObject, MBReadOnlyList<CharacterObject>, Town, ItemObject>(this.OnTournamentFinished));
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020DC File Offset: 0x000002DC
		public override void SyncData(IDataStore dataStore)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020E0 File Offset: 0x000002E0
		private void ApplyRenownConsequence(CharacterObject winner, MBReadOnlyList<CharacterObject> participants, Town town)
		{
			CultureCode c = (this._get.Configuration.IsHostEnforcingHisCulture(town.Culture.GetCultureCode().ToString()) ? town.Culture.GetCultureCode() : winner.Culture.GetCultureCode());
			bool flag = !winner.IsPlayerCharacter;
			if (flag)
			{
				bool flag2 = this._get.Configuration.IsPlayerShouldLosesRenownWhenLosingTournament();
				if (flag2)
				{
					CharacterObject player = participants.FirstOrDefault((CharacterObject n) => n.IsPlayerCharacter);
					bool flag3 = player == null;
					if (flag3)
					{
						return;
					}
					this.LosesRenown(player);
				}
			}
			bool flag4 = this._get.Configuration.ShouldBeNaked(c.ToString());
			if (flag4)
			{
				bool flag5 = this._get.Configuration.IsPlayerShouldGainExtraRenownWhenNaked();
				if (flag5)
				{
					this.GainsExtraRenown(winner);
				}
			}
			else
			{
				this.MayGainRenown(winner);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000021E0 File Offset: 0x000003E0
		private void GainsExtraRenown(CharacterObject winner)
		{
			int bonus = 1 + LogRaamRandom.GenerateRandomNumber(1, 3);
			new Renown().GiveBonusRenown(winner.HeroObject, (float)bonus);
			InformationManager.DisplayMessage(new InformationMessage(string.Format("{0} gains {1} renown for fighting naked in the tournament.", winner.HeroObject.Name, bonus), Colors.Green));
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002238 File Offset: 0x00000438
		private void LosesRenown(CharacterObject player)
		{
			int bonus = -LogRaamRandom.GenerateRandomNumber(1, 3);
			new Renown().GiveBonusRenown(player.HeroObject, (float)bonus);
			InformationManager.DisplayMessage(new InformationMessage(string.Format("{0} loses {1} renown for losing at the tournament.", player.Name, bonus), Colors.Red));
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002288 File Offset: 0x00000488
		private void MayGainRenown(CharacterObject winner)
		{
			bool flag = !this._get.Configuration.IsPlayerMayShouldGainRenownWhenWinningTournament();
			if (!flag)
			{
				int bonus = LogRaamRandom.GenerateRandomNumber(0, 1);
				bool flag2 = bonus <= 0;
				if (!flag2)
				{
					new Renown().GiveBonusRenown(winner.HeroObject, (float)bonus);
					InformationManager.DisplayMessage(new InformationMessage(string.Format("{0} gains {1} renown for winning at the tournament.", winner.HeroObject.Name, bonus), Colors.White));
				}
			}
		}

		// Token: 0x04000002 RID: 2
		private readonly ISetup _get = new DefaultSetup();
	}
}
