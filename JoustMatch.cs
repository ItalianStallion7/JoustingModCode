using System;
using System.Collections.Generic;
using LogRaamJousting.Decoupling;
using LogRaamJousting.Factory;

namespace LogRaamJousting
{
	// Token: 0x02000006 RID: 6
	public class JoustMatch
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000024B8 File Offset: 0x000006B8
		public JoustMatch(GameNetwork gameNetwork, string hostCulture, bool isCulturalEvent, ref List<Participant> participants, ISetup setup, IKit kits)
		{
			this._gameNetwork = gameNetwork;
			this._hostCulture = hostCulture.ToUpper();
			Runtime.IsCulturalEvent = isCulturalEvent;
			this._participants = participants;
			this._get = setup;
			this._equip = kits;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000024F8 File Offset: 0x000006F8
		public void Start()
		{
			bool isClientOrReplay = this._gameNetwork.IsClientOrReplay;
			if (!isClientOrReplay)
			{
				bool flag = !this._get.Configuration.ShouldApplyModForThisMatch(this._hostCulture);
				if (!flag)
				{
					foreach (Participant participant in this._participants)
					{
						string tournamentCulture = this.DefineTournamentCulture(this._hostCulture, participant);
						bool flag2 = tournamentCulture == "INVALID";
						if (!flag2)
						{
							bool flag3 = tournamentCulture == "ANYOTHERCULTURE";
							if (!flag3)
							{
								bool flag4 = tournamentCulture == "ASERAI";
								if (flag4)
								{
									participant.RefToGameParticipant().MatchEquipment = this._equip.DefaultAseraiKit(participant, this._hostCulture);
								}
								bool flag5 = tournamentCulture == "EMPIRE";
								if (flag5)
								{
									participant.RefToGameParticipant().MatchEquipment = this._equip.DefaultEmpireKit(participant, this._hostCulture);
								}
								bool flag6 = tournamentCulture == "STURGIA";
								if (flag6)
								{
									participant.RefToGameParticipant().MatchEquipment = this._equip.DefaultSturgiaKit(participant, this._hostCulture);
								}
								bool flag7 = tournamentCulture == "VLANDIA";
								if (flag7)
								{
									participant.RefToGameParticipant().MatchEquipment = this._equip.DefaultVlandiaKit(participant, this._hostCulture);
								}
								bool flag8 = tournamentCulture == "KHUZAIT";
								if (flag8)
								{
									participant.RefToGameParticipant().MatchEquipment = this._equip.DefaultKhuzaitKit(participant, this._hostCulture);
								}
								bool flag9 = tournamentCulture == "BATTANIA";
								if (flag9)
								{
									participant.RefToGameParticipant().MatchEquipment = this._equip.DefaultBattaniaKit(participant, this._hostCulture);
								}
								bool flag10 = tournamentCulture == "BYZANTINE";
								if (flag10)
								{
									participant.RefToGameParticipant().MatchEquipment = this._equip.DefaultByzantineKit(participant, this._hostCulture);
								}
								bool flag11 = tournamentCulture == "AYYUBID";
								if (flag11)
								{
									participant.RefToGameParticipant().MatchEquipment = this._equip.DefaultAyyubidKit(participant, this._hostCulture);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002750 File Offset: 0x00000950
		private string DefineTournamentCulture(string hostCulture, Participant participant)
		{
			return this._get.Configuration.IsHostEnforcingHisCulture(hostCulture) ? hostCulture : participant.Culture.ToUpper();
		}

		// Token: 0x04000004 RID: 4
		private readonly IKit _equip;

		// Token: 0x04000005 RID: 5
		private readonly GameNetwork _gameNetwork;

		// Token: 0x04000006 RID: 6
		private readonly ISetup _get;

		// Token: 0x04000007 RID: 7
		private readonly string _hostCulture;

		// Token: 0x04000008 RID: 8
		private readonly List<Participant> _participants;
	}
}
