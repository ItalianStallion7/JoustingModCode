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
	// Token: 0x02000033 RID: 51
	public class AseraiKit : IPlugin
	{
		// Token: 0x06000153 RID: 339 RVA: 0x00007CE0 File Offset: 0x00005EE0
		public AseraiKit(ISetup setup, EquipmentPlugin plugin, IConfigLoader configLoader)
		{
			this._get = setup;
			plugin.SetSetup(this._get);
			this._equipment = plugin;
			this._loader = configLoader;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00007D0C File Offset: 0x00005F0C
		public AseraiKit()
		{
			this._get = new DefaultSetup();
			this._equipment = new EquipmentPlugin(this._get, new Config(), "Aserai", new Participant(ref this.ReferredParticipant));
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00007D48 File Offset: 0x00005F48
		public Equipment Equip(IWeaponry weaponry, IArmoury armoury, IStable stable)
		{
			bool isCulturalEvent = Runtime.IsCulturalEvent;
			Equipment equipment;
			if (isCulturalEvent)
			{
				equipment = this._equipment.EquipCulturalEvent(weaponry, armoury, stable);
			}
			else
			{
				bool flag = this._get.Configuration.ParticipantsUsesTheirOwnEquipments("Aserai");
				if (flag)
				{
					equipment = this._equipment.Participant.GetBattleEquipments();
				}
				else
				{
					bool isPlayer = this._equipment.Participant.IsPlayer;
					if (isPlayer)
					{
						equipment = this._equipment.EquipPlayer(this._get.ConfigLoader, "Aserai", weaponry, armoury, stable, 20);
					}
					else
					{
						bool isFactionLeader = this._equipment.Participant.IsFactionLeader;
						if (isFactionLeader)
						{
							equipment = this._equipment.EquipFactionLeader(this._get.ConfigLoader, "Aserai", weaponry, armoury, stable);
						}
						else
						{
							bool isLord = this._equipment.Participant.IsLord;
							if (isLord)
							{
								equipment = this._equipment.EquipLord(this._get.ConfigLoader, "Aserai", weaponry, armoury, stable);
							}
							else
							{
								bool isHero = this._equipment.Participant.IsHero;
								if (isHero)
								{
									equipment = this._equipment.EquipHero(this._get.ConfigLoader, "Aserai", weaponry, armoury, stable, 20);
								}
								else
								{
									equipment = this._equipment.EquipParticipant(this._get.ConfigLoader, "Aserai", weaponry, armoury);
								}
							}
						}
					}
				}
			}
			return equipment;
		}

		// Token: 0x0400006B RID: 107
		private const string Culture = "Aserai";

		// Token: 0x0400006C RID: 108
		private const int MountedChanceBonus = 20;

		// Token: 0x0400006D RID: 109
		public TournamentParticipant ReferredParticipant;

		// Token: 0x0400006E RID: 110
		private readonly EquipmentPlugin _equipment;

		// Token: 0x0400006F RID: 111
		private readonly ISetup _get;

		// Token: 0x04000070 RID: 112
		private readonly IConfigLoader _loader;
	}
}
