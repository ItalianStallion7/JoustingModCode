using System;
using LogRaamJousting.Decoupling;
using TaleWorlds.Core;

namespace LogRaamJousting.Factory
{
	// Token: 0x0200002F RID: 47
	public interface IKit
	{
		// Token: 0x06000144 RID: 324
		Equipment DefaultAseraiKit(Participant participant, string hostCulture);

		// Token: 0x06000145 RID: 325
		Equipment DefaultAyyubidKit(Participant participant, string hostCulture);

		// Token: 0x06000146 RID: 326
		Equipment DefaultBattaniaKit(Participant participant, string hostCulture);

		// Token: 0x06000147 RID: 327
		Equipment DefaultByzantineKit(Participant participant, string hostCulture);

		// Token: 0x06000148 RID: 328
		Equipment DefaultEmpireKit(Participant participant, string hostCulture);

		// Token: 0x06000149 RID: 329
		Equipment DefaultKhuzaitKit(Participant participant, string hostCulture);

		// Token: 0x0600014A RID: 330
		Equipment DefaultSturgiaKit(Participant participant, string hostCulture);

		// Token: 0x0600014B RID: 331
		Equipment DefaultVlandiaKit(Participant participant, string hostCulture);
	}
}
