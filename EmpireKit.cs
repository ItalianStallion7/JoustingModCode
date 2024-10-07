using System;
using LogRaamJousting.Armors;
using LogRaamJousting.Configuration;
using LogRaamJousting.Factory;
using LogRaamJousting.Stables;
using LogRaamJousting.Weapons;
using TaleWorlds.CampaignSystem.TournamentGames;
using TaleWorlds.Core;

namespace LogRaamJousting.Equipments
{
	// Token: 0x02000036 RID: 54
	public class EmpireKit : IPlugin
	{
		// Token: 0x06000170 RID: 368 RVA: 0x000089A2 File Offset: 0x00006BA2
		public EmpireKit(ISetup setup, EquipmentPlugin plugin, IConfigLoader configLoader)
		{
			this._get = setup;
			this._equipment = plugin;
			this._loader = configLoader;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000089C4 File Offset: 0x00006BC4
		public Equipment Equip(IWeaponry weaponry, IArmoury armoury, IStable stable)
		{
			bool isCulturalEvent = Runtime.IsCulturalEvent;
			if (isCulturalEvent)
			{
				this._equipment.EquipCulturalEvent(weaponry, armoury, stable);
			}
			bool flag = this._get.Configuration.ParticipantsUsesTheirOwnEquipments("Empire");
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
					equipment = this._equipment.EquipPlayer(this._get.ConfigLoader, "Empire", weaponry, armoury, stable, 0);
				}
				else
				{
					bool isFactionLeader = this._equipment.Participant.IsFactionLeader;
					if (isFactionLeader)
					{
						equipment = this._equipment.EquipFactionLeader(this._get.ConfigLoader, "Empire", weaponry, armoury, stable);
					}
					else
					{
						bool isLord = this._equipment.Participant.IsLord;
						if (isLord)
						{
							equipment = this._equipment.EquipLord(this._get.ConfigLoader, "Empire", weaponry, armoury, stable);
						}
						else
						{
							bool isHero = this._equipment.Participant.IsHero;
							if (isHero)
							{
								equipment = this._equipment.EquipHero(this._get.ConfigLoader, "Empire", weaponry, armoury, stable, 0);
							}
							else
							{
								equipment = this._equipment.EquipParticipant(this._get.ConfigLoader, "Empire", weaponry, armoury);
							}
						}
					}
				}
			}
			return equipment;
		}

		// Token: 0x0400007C RID: 124
		private const string Culture = "Empire";

		// Token: 0x0400007D RID: 125
		private const int MountedChanceBonus = 0;

		// Token: 0x0400007E RID: 126
		public TournamentParticipant ReferredParticipant;

		// Token: 0x0400007F RID: 127
		private readonly EquipmentPlugin _equipment;

		// Token: 0x04000080 RID: 128
		private readonly ISetup _get;

		// Token: 0x04000081 RID: 129
		private readonly IConfigLoader _loader;
	}
}
