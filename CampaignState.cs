using System;
using TaleWorlds.CampaignSystem;
using TaleWorlds.MountAndBlade;

namespace LogRaamJousting
{
	// Token: 0x02000012 RID: 18
	public class CampaignState
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00003164 File Offset: 0x00001364
		public bool CampaignStarted()
		{
			return Campaign.Current != null && (Campaign.Current.GameStarted || Campaign.Current.CampaignGameLoadingType == 1);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000319C File Offset: 0x0000139C
		public bool GameStarted()
		{
			return MBGameManager.Current != null && MBGameManager.Current.IsLoaded;
		}
	}
}
