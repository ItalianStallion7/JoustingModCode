using System;
using TaleWorlds.Core;

namespace LogRaamJousting
{
	// Token: 0x02000009 RID: 9
	public class FootmanCulturalPreferencesDistribution
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00002A74 File Offset: 0x00000C74
		public int Archer(CultureCode culture)
		{
			return new FootmenWarCulture(culture).ArcherPercentage;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002A94 File Offset: 0x00000C94
		public int OneHander(CultureCode culture)
		{
			return new FootmenWarCulture(culture).OneHanderPercentage;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002AB4 File Offset: 0x00000CB4
		public int Polearm(CultureCode culture)
		{
			return new FootmenWarCulture(culture).PolearmPercentage;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002AD4 File Offset: 0x00000CD4
		public int Thrower(CultureCode culture)
		{
			return new FootmenWarCulture(culture).ThrowerPercentage;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002AF4 File Offset: 0x00000CF4
		public int TwoHander(CultureCode culture)
		{
			return new FootmenWarCulture(culture).TwoHanderPercentage;
		}
	}
}
