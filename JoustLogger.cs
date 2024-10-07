using System;
using System.IO;
using TaleWorlds.CampaignSystem.TournamentGames;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace LogRaamJousting
{
	// Token: 0x02000005 RID: 5
	public class JoustLogger
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002316 File Offset: 0x00000516
		public JoustLogger(DirectoryInfo logPath)
		{
			this.LogPath = logPath;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002328 File Offset: 0x00000528
		public void LogEquipmentToFile(ItemObject a, ItemObject b, ItemObject c)
		{
			File.AppendAllText(this.LogPath.FullName, "--- EQUIPMENT ---" + Environment.NewLine);
			string fullName = this.LogPath.FullName;
			TextObject name = a.Name;
			File.AppendAllText(fullName, ((name != null) ? name.ToString() : null) + Environment.NewLine);
			string fullName2 = this.LogPath.FullName;
			TextObject name2 = b.Name;
			File.AppendAllText(fullName2, ((name2 != null) ? name2.ToString() : null) + Environment.NewLine);
			string fullName3 = this.LogPath.FullName;
			TextObject name3 = c.Name;
			File.AppendAllText(fullName3, ((name3 != null) ? name3.ToString() : null) + Environment.NewLine);
			File.AppendAllText(this.LogPath.FullName, "-----------------" + Environment.NewLine);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002400 File Offset: 0x00000600
		public void LogHeaderInfoToFile(CultureCode tournamentCulture, TournamentParticipant participant)
		{
			File.AppendAllText(this.LogPath.FullName, "+++" + Environment.NewLine);
			File.AppendAllText(this.LogPath.FullName, "Host culture = " + tournamentCulture.ToString() + Environment.NewLine);
			File.AppendAllText(this.LogPath.FullName, "Participant culture = " + participant.Character.Culture.GetCultureCode().ToString() + Environment.NewLine);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002499 File Offset: 0x00000699
		public void LogToFile(string message)
		{
			File.AppendAllText(this.LogPath.FullName, message + Environment.NewLine);
		}

		// Token: 0x04000003 RID: 3
		public DirectoryInfo LogPath;
	}
}
