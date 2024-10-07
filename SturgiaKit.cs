using System;
using LogRaamJousting.Armors;
using LogRaamJousting.Configuration;
using LogRaamJousting.Decoupling;
using LogRaamJousting.Factory;
using LogRaamJousting.Stables;
using LogRaamJousting.Weapons;
using TaleWorlds.CampaignSystem.TournamentGames;
using TaleWorlds.Core;

namespace LogRaamJousting.Equipments
{
	// Token: 0x02000039 RID: 57
	public class SturgiaKit : IPlugin
	{
		// Token: 0x06000176 RID: 374 RVA: 0x00008CD2 File Offset: 0x00006ED2
		public SturgiaKit(ISetup setup, EquipmentPlugin plugin, IConfigLoader configLoader)
		{
			this._get = setup;
			this._equipment = plugin;
			this._loader = configLoader;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00008CF1 File Offset: 0x00006EF1
		public SturgiaKit()
		{
			this._get = new DefaultSetup();
			this._equipment = new EquipmentPlugin(this._get, new Config(), "Sturgia", new Participant(ref this.ReferredParticipant));
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00008D2C File Offset: 0x00006F2C
		public Equipment Equip(IWeaponry weaponry, IArmoury armoury, IStable stable)
		{
			bool isCulturalEvent = Runtime.IsCulturalEvent;
			if (isCulturalEvent)
			{
				this._equipment.EquipCulturalEvent(weaponry, armoury, stable);
			}
			bool flag = this._get.Configuration.ParticipantsUsesTheirOwnEquipments("Sturgia");
			Equipment equipment;
			if (flag)
			{
				equipment = this._equipment.Participant.GetBattleEquipments();
			}
			else
			{
				bool isPlayer = this._equipment.Participant.IsPlayer;
				if (isPlayer)
				{
					equipment = this._equipment.EquipPlayer(this._get.ConfigLoader, "Sturgia", weaponry, armoury, stable, -10);
				}
				else
				{
					bool isFactionLeader = this._equipment.Participant.IsFactionLeader;
					if (isFactionLeader)
					{
						equipment = this._equipment.EquipFactionLeader(this._get.ConfigLoader, "Sturgia", weaponry, armoury, stable);
					}
					else
					{
						bool isLord = this._equipment.Participant.IsLord;
						if (isLord)
						{
							equipment = this._equipment.EquipLord(this._get.ConfigLoader, "Sturgia", weaponry, armoury, stable);
						}
						else
						{
							bool isHero = this._equipment.Participant.IsHero;
							if (isHero)
							{
								equipment = this._equipment.EquipHero(this._get.ConfigLoader, "Sturgia", weaponry, armoury, stable, -10);
							}
							else
							{
								equipment = this._equipment.EquipParticipant(this._get.ConfigLoader, "Sturgia", weaponry, armoury);
							}
						}
					}
				}
			}
			return equipment;
		}

		// Token: 0x04000088 RID: 136
		private const string Culture = "Sturgia";

		// Token: 0x04000089 RID: 137
		private const int MountedChanceBonus = -10;

		// Token: 0x0400008A RID: 138
		public TournamentParticipant ReferredParticipant;

		// Token: 0x0400008B RID: 139
		private readonly EquipmentPlugin _equipment;

		// Token: 0x0400008C RID: 140
		private readonly ISetup _get;

		// Token: 0x0400008D RID: 141
		private readonly IConfigLoader _loader;
	}
}
