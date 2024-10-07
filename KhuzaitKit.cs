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
	// Token: 0x02000038 RID: 56
	public class KhuzaitKit : IPlugin
	{
		// Token: 0x06000173 RID: 371 RVA: 0x00008B1C File Offset: 0x00006D1C
		public KhuzaitKit(ISetup setup, EquipmentPlugin plugin, IConfigLoader configLoader)
		{
			this._get = setup;
			this._equipment = plugin;
			this._loader = configLoader;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00008B3B File Offset: 0x00006D3B
		public KhuzaitKit()
		{
			this._get = new DefaultSetup();
			this._equipment = new EquipmentPlugin(this._get, new Config(), "Khuzait", new Participant(ref this.ReferredParticipant));
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00008B78 File Offset: 0x00006D78
		public Equipment Equip(IWeaponry weaponry, IArmoury armoury, IStable stable)
		{
			bool isCulturalEvent = Runtime.IsCulturalEvent;
			if (isCulturalEvent)
			{
				this._equipment.EquipCulturalEvent(weaponry, armoury, stable);
			}
			bool flag = this._get.Configuration.ParticipantsUsesTheirOwnEquipments("Khuzait");
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
					equipment = this._equipment.EquipPlayer(this._get.ConfigLoader, "Khuzait", weaponry, armoury, stable, 30);
				}
				else
				{
					bool isFactionLeader = this._equipment.Participant.IsFactionLeader;
					if (isFactionLeader)
					{
						equipment = this._equipment.EquipFactionLeader(this._get.ConfigLoader, "Khuzait", weaponry, armoury, stable);
					}
					else
					{
						bool isLord = this._equipment.Participant.IsLord;
						if (isLord)
						{
							equipment = this._equipment.EquipLord(this._get.ConfigLoader, "Khuzait", weaponry, armoury, stable);
						}
						else
						{
							bool isHero = this._equipment.Participant.IsHero;
							if (isHero)
							{
								equipment = this._equipment.EquipHero(this._get.ConfigLoader, "Khuzait", weaponry, armoury, stable, 30);
							}
							else
							{
								equipment = this._equipment.EquipParticipant(this._get.ConfigLoader, "Khuzait", weaponry, armoury);
							}
						}
					}
				}
			}
			return equipment;
		}

		// Token: 0x04000082 RID: 130
		private const string Culture = "Khuzait";

		// Token: 0x04000083 RID: 131
		private const int MountedChanceBonus = 30;

		// Token: 0x04000084 RID: 132
		public TournamentParticipant ReferredParticipant;

		// Token: 0x04000085 RID: 133
		private readonly EquipmentPlugin _equipment;

		// Token: 0x04000086 RID: 134
		private readonly ISetup _get;

		// Token: 0x04000087 RID: 135
		private readonly IConfigLoader _loader;
	}
}
