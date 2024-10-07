using System;
using System.Collections.Generic;
using System.Linq;
using HarmonyLib;
using LogRaamJousting.Armors;
using LogRaamJousting.Configuration;
using LogRaamJousting.Decoupling;
using LogRaamJousting.Factory;
using SandBox.Tournaments.MissionLogics;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.TournamentGames;

namespace LogRaamJousting
{
	// Token: 0x0200000C RID: 12
	[HarmonyPatch(typeof(TournamentFightMissionController), "PrepareForMatch")]
	public class PrefixPatch
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00002CA0 File Offset: 0x00000EA0
		private static bool Prefix(TournamentFightMissionController __instance, TournamentMatch ____match, CultureObject ____culture)
		{
			List<Participant> matchParticipants = new List<Participant>();
			for (int t = 0; t < ____match.Teams.Count<TournamentTeam>(); t++)
			{
				for (int i = 0; i < ____match.Teams.ToList<TournamentTeam>()[t].Participants.Count<TournamentParticipant>(); i++)
				{
					TournamentParticipant participant = ____match.Teams.ToList<TournamentTeam>()[t].Participants.ToList<TournamentParticipant>()[i];
					matchParticipants.Add(new Participant(ref participant));
				}
			}
			new JoustMatch(new GameNetwork(), ____culture.GetCultureCode().ToString(), LogRaamRandom.EvalPercentage(10f), ref matchParticipants, new DefaultSetup(), new DefaultKits(new DefaultSetup(), new ConfigLoader(), new BaseArmoury())).Start();
			return false;
		}
	}
}
