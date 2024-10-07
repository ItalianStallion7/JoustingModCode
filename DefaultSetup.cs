using System;
using LogRaamJousting.Configuration;
using LogRaamJousting.Options;

namespace LogRaamJousting.Factory
{
	// Token: 0x02000031 RID: 49
	internal class DefaultSetup : ISetup
	{
		// Token: 0x0600014F RID: 335 RVA: 0x00007C97 File Offset: 0x00005E97
		public DefaultSetup()
		{
			this.ConfigLoader = new ConfigLoader();
			this.Configuration = new Config();
			this.CultureOptions = new CultureOptions(this.ConfigLoader);
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00007CC8 File Offset: 0x00005EC8
		public IConfigLoader ConfigLoader { get; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00007CD0 File Offset: 0x00005ED0
		public IConfig Configuration { get; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00007CD8 File Offset: 0x00005ED8
		public IOptions CultureOptions { get; }
	}
}
