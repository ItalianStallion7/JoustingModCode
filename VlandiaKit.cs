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
	// Token: 0x0200003A RID: 58
	public class VlandiaKit : IPlugin
	{
		// Token: 0x06000179 RID: 377 RVA: 0x00008E86 File Offset: 0x00007086
		public VlandiaKit(ISetup setup, EquipmentPlugin plugin, IConfigLoader configLoader)
		{
			this._get = setup;
			this._equipment = plugin;
			this._loader = configLoader;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00008EA5 File Offset: 0x000070A5
		public VlandiaKit()
		{
			this._get = new DefaultSetup();
			this._equipment = new EquipmentPlugin(this._get, new Config(), "Vlandia", new Participant(ref this.ReferredParticipant));
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00008EE0 File Offset: 0x000070E0
		public Equipment Equip(IWeaponry weaponry, IArmoury armoury, IStable stable)
		{
			bool isCulturalEvent = Runtime.IsCulturalEvent;
			if (isCulturalEvent)
			{
				this._equipment.EquipCulturalEvent(weaponry, armoury, stable);
			}
			bool flag = this._get.Configuration.ParticipantsUsesTheirOwnEquipments("Vlandia");
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
					equipment = this._equipment.EquipPlayer(this._get.ConfigLoader, "Vlandia", weaponry, armoury, stable, 10);
				}
				else
				{
					bool isFactionLeader = this._equipment.Participant.IsFactionLeader;
					if (isFactionLeader)
					{
						equipment = this._equipment.EquipFactionLeader(this._get.ConfigLoader, "Vlandia", weaponry, armoury, stable);
					}
					else
					{
						bool isLord = this._equipment.Participant.IsLord;
						if (isLord)
						{
							equipment = this._equipment.EquipLord(this._get.ConfigLoader, "Vlandia", weaponry, armoury, stable);
						}
						else
						{
							bool isHero = this._equipment.Participant.IsHero;
							if (isHero)
							{
								equipment = this._equipment.EquipHero(this._get.ConfigLoader, "Vlandia", weaponry, armoury, stable, 10);
							}
							else
							{
								equipment = this._equipment.EquipParticipant(this._get.ConfigLoader, "Vlandia", weaponry, armoury);
							}
						}
					}
				}
			}
			return equipment;
		}

		// Token: 0x0400008E RID: 142
		private const string Culture = "Vlandia";

		// Token: 0x0400008F RID: 143
		private const int MountedChanceBonus = 10;

		// Token: 0x04000090 RID: 144
		public TournamentParticipant ReferredParticipant;

		// Token: 0x04000091 RID: 145
		private readonly EquipmentPlugin _equipment;

		// Token: 0x04000092 RID: 146
		private readonly ISetup _get;

		// Token: 0x04000093 RID: 147
		private readonly IConfigLoader _loader;
	}
}
