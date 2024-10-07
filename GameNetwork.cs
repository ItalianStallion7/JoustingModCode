using System;
using TaleWorlds.MountAndBlade;

namespace LogRaamJousting.Decoupling
{
	// Token: 0x0200003B RID: 59
	public class GameNetwork
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0000903C File Offset: 0x0000723C
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00009071 File Offset: 0x00007271
		public bool IsClientOrReplay
		{
			get
			{
				CampaignState state = new CampaignState();
				return (state.GameStarted() || state.CampaignStarted()) ? GameNetwork.IsClientOrReplay : this._isClientOrReplay;
			}
			set
			{
				this._isClientOrReplay = value;
			}
		}

		// Token: 0x04000094 RID: 148
		private bool _isClientOrReplay;
	}
}
