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
	// Token: 0x02000035 RID: 53
	public class BattaniaKit : IPlugin
	{
		// Token: 0x0600016D RID: 365 RVA: 0x000087ED File Offset: 0x000069ED
		public BattaniaKit(ISetup setup, EquipmentPlugin equipment, IConfigLoader configLoader)
		{
			this._get = setup;
			this._equipment = equipment;
			this._loader = configLoader;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000880C File Offset: 0x00006A0C
		public BattaniaKit()
		{
			this._get = new DefaultSetup();
			this._equipment = new EquipmentPlugin(this._get, new Config(), "Battania", new Participant(ref this.ReferredParticipant));
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00008848 File Offset: 0x00006A48
		public Equipment Equip(IWeaponry weaponry, IArmoury armoury, IStable stable)
		{
			bool isCulturalEvent = Runtime.IsCulturalEvent;
			if (isCulturalEvent)
			{
				this._equipment.EquipCulturalEvent(weaponry, armoury, stable);
			}
			bool flag = this._get.Configuration.ParticipantsUsesTheirOwnEquipments("Battania");
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
					equipment = this._equipment.EquipPlayer(this._get.ConfigLoader, "Battania", weaponry, armoury, stable, -20);
				}
				else
				{
					bool isFactionLeader = this._equipment.Participant.IsFactionLeader;
					if (isFactionLeader)
					{
						equipment = this._equipment.EquipFactionLeader(this._get.ConfigLoader, "Battania", weaponry, armoury, stable);
					}
					else
					{
						bool isLord = this._equipment.Participant.IsLord;
						if (isLord)
						{
							equipment = this._equipment.EquipLord(this._get.ConfigLoader, "Battania", weaponry, armoury, stable);
						}
						else
						{
							bool isHero = this._equipment.Participant.IsHero;
							if (isHero)
							{
								equipment = this._equipment.EquipHero(this._get.ConfigLoader, "Battania", weaponry, armoury, stable, -20);
							}
							else
							{
								equipment = this._equipment.EquipParticipant(this._get.ConfigLoader, "Battania", weaponry, armoury);
							}
						}
					}
				}
			}
			return equipment;
		}

		// Token: 0x04000076 RID: 118
		private const string Culture = "Battania";

		// Token: 0x04000077 RID: 119
		private const int MountedChanceBonus = -20;

		// Token: 0x04000078 RID: 120
		public TournamentParticipant ReferredParticipant;

		// Token: 0x04000079 RID: 121
		private readonly EquipmentPlugin _equipment;

		// Token: 0x0400007A RID: 122
		private readonly ISetup _get;

		// Token: 0x0400007B RID: 123
		private readonly IConfigLoader _loader;
	}
}
