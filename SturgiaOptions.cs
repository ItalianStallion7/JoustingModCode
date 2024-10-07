using System;

namespace LogRaamJousting.Options
{
	// Token: 0x0200002C RID: 44
	public class SturgiaOptions : ICultureOption
	{
		// Token: 0x06000127 RID: 295 RVA: 0x00007715 File Offset: 0x00005915
		public SturgiaOptions(IOptions baseOptions)
		{
			this._options = baseOptions;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00007726 File Offset: 0x00005926
		public string Culture
		{
			get
			{
				return "STURGIA";
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00007730 File Offset: 0x00005930
		public bool ParticipantShouldUseItsOwnEquipment(string[] options)
		{
			return this._options.ShouldUseTheirEquipment(options, "[X] Sturgia tournament's participants must bring their own equipment");
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00007754 File Offset: 0x00005954
		public bool ShouldBeNaked(string[] options)
		{
			return this._options.ShouldBeNaked(options, "[X] Undressed Sturgia");
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00007778 File Offset: 0x00005978
		public bool ShouldBeNaked(string lineToFind)
		{
			return this._options.ShouldBeNaked(lineToFind);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00007798 File Offset: 0x00005998
		public bool ShouldHappens(string[] options)
		{
			return this._options.ShouldHappens(options, "[X] Apply to Sturgia");
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000077BC File Offset: 0x000059BC
		public bool ShouldProvideArmors(string[] options)
		{
			return this._options.ShouldProvideArmors(options, "[X] Sturgia tournament provides armors");
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000077E0 File Offset: 0x000059E0
		public bool ShouldProvideWeapons(string[] options)
		{
			return this._options.ShouldProvideWeapons(options, "[X] Sturgia tournament provides weapons");
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00007804 File Offset: 0x00005A04
		public bool ShouldUseHostCulture(string[] options)
		{
			return this._options.ShouldUseHostCulture(options, "[X] Sturgia enforce its culture during tournaments");
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00007828 File Offset: 0x00005A28
		public bool ShouldUseHostCulture(string lineToFind)
		{
			return this._options.ShouldUseHostCulture(lineToFind);
		}

		// Token: 0x04000052 RID: 82
		private const string ShouldBeNakedLineToFind = "[X] Undressed Sturgia";

		// Token: 0x04000053 RID: 83
		private const string ShouldHappensLineToFind = "[X] Apply to Sturgia";

		// Token: 0x04000054 RID: 84
		private const string ShouldProvideArmorsLineToFind = "[X] Sturgia tournament provides armors";

		// Token: 0x04000055 RID: 85
		private const string ShouldProvideWeaponsLineToFind = "[X] Sturgia tournament provides weapons";

		// Token: 0x04000056 RID: 86
		private const string ShouldUseHostCultureLineToFind = "[X] Sturgia enforce its culture during tournaments";

		// Token: 0x04000057 RID: 87
		private const string ShouldUseTheirEquipmentLineToFind = "[X] Sturgia tournament's participants must bring their own equipment";

		// Token: 0x04000058 RID: 88
		private readonly IOptions _options;
	}
}
