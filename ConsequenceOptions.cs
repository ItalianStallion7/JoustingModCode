using System;
using LogRaamJousting.Configuration;

namespace LogRaamJousting.Options
{
	// Token: 0x02000023 RID: 35
	public class ConsequenceOptions
	{
		// Token: 0x060000D8 RID: 216 RVA: 0x00006F66 File Offset: 0x00005166
		public ConsequenceOptions(IOptions baseOptions, IConfigLoader loader)
		{
			this._options = baseOptions;
			this._loader = loader;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00006F7E File Offset: 0x0000517E
		public ConsequenceOptions()
		{
			this._options = new CultureOptions(this._loader);
			this._loader = new ConfigLoader();
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00006FA4 File Offset: 0x000051A4
		public bool PlayerShouldGainExtraRenownPointsWhenNude(string[] options)
		{
			return this.ShouldGainExtraRenown(options, "[X] The player gains even more renown points if he wins a tournament while nude.");
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00006FC4 File Offset: 0x000051C4
		public bool PlayerShouldGainRenownPoints(string[] options)
		{
			return this.ShouldGainRenown(options, "[X] The player gains renown points when he wins a tournament.");
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00006FE4 File Offset: 0x000051E4
		public bool PlayerShouldLosesRenownPoints(string[] options)
		{
			return this.ShouldLosesRenown(options, "[X] The player loses renown points when he loses a tournament.");
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00007004 File Offset: 0x00005204
		private bool ShouldGainExtraRenown(string[] options, string lineToFind)
		{
			return this._loader.IsLineExistInStruct(options, lineToFind);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00007024 File Offset: 0x00005224
		private bool ShouldGainRenown(string[] options, string lineToFind)
		{
			return this._loader.IsLineExistInStruct(options, lineToFind);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00007044 File Offset: 0x00005244
		private bool ShouldLosesRenown(string[] options, string lineToFind)
		{
			return this._loader.IsLineExistInStruct(options, lineToFind);
		}

		// Token: 0x04000030 RID: 48
		private const string PlayerGainExtraRenownPointsWhenNudeLineToFind = "[X] The player gains even more renown points if he wins a tournament while nude.";

		// Token: 0x04000031 RID: 49
		private const string PlayerGainRenownPointsLineToFind = "[X] The player gains renown points when he wins a tournament.";

		// Token: 0x04000032 RID: 50
		private const string PlayerLosesRenownPointsLineToFind = "[X] The player loses renown points when he loses a tournament.";

		// Token: 0x04000033 RID: 51
		private readonly IConfigLoader _loader;

		// Token: 0x04000034 RID: 52
		private readonly IOptions _options;
	}
}
