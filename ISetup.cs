using System;
using LogRaamJousting.Configuration;
using LogRaamJousting.Options;

namespace LogRaamJousting.Factory
{
	// Token: 0x02000030 RID: 48
	public interface ISetup
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600014C RID: 332
		IConfigLoader ConfigLoader { get; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600014D RID: 333
		IConfig Configuration { get; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600014E RID: 334
		IOptions CultureOptions { get; }
	}
}
