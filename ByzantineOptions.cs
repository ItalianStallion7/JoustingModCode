using System;

namespace LogRaamJousting.Options
{
	// Token: 0x02000022 RID: 34
	public class ByzantineOptions : ICultureOption
	{
		// Token: 0x060000CE RID: 206 RVA: 0x00006E36 File Offset: 0x00005036
		public ByzantineOptions(IOptions baseOptions)
		{
			this._options = baseOptions;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00006E47 File Offset: 0x00005047
		public string Culture
		{
			get
			{
				return "BYZANTINE";
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00006E50 File Offset: 0x00005050
		public bool ParticipantShouldUseItsOwnEquipment(string[] options)
		{
			return this._options.ShouldUseTheirEquipment(options, "[X] Byzantine tournament's participants must bring their own equipment");
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00006E74 File Offset: 0x00005074
		public bool ShouldBeNaked(string[] options)
		{
			return this._options.ShouldBeNaked(options, "[X] Undressed Byzantine");
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00006E98 File Offset: 0x00005098
		public bool ShouldBeNaked(string lineToFind)
		{
			return this._options.ShouldBeNaked(lineToFind);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00006EB8 File Offset: 0x000050B8
		public bool ShouldHappens(string[] options)
		{
			return this._options.ShouldHappens(options, "[X] Apply to Byzantine");
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00006EDC File Offset: 0x000050DC
		public bool ShouldProvideArmors(string[] options)
		{
			return this._options.ShouldProvideArmors(options, "[X] Byzantine tournament provides armors");
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00006F00 File Offset: 0x00005100
		public bool ShouldProvideWeapons(string[] options)
		{
			return this._options.ShouldProvideWeapons(options, "[X] Byzantine tournament provides weapons");
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00006F24 File Offset: 0x00005124
		public bool ShouldUseHostCulture(string[] options)
		{
			return this._options.ShouldUseHostCulture(options, "[X] Byzantine enforce its culture during tournaments");
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00006F48 File Offset: 0x00005148
		public bool ShouldUseHostCulture(string lineToFind)
		{
			return this._options.ShouldUseHostCulture(lineToFind);
		}

		// Token: 0x04000029 RID: 41
		private const string ShouldBeNakedLineToFind = "[X] Undressed Byzantine";

		// Token: 0x0400002A RID: 42
		private const string ShouldHappensLineToFind = "[X] Apply to Byzantine";

		// Token: 0x0400002B RID: 43
		private const string ShouldProvideArmorsLineToFind = "[X] Byzantine tournament provides armors";

		// Token: 0x0400002C RID: 44
		private const string ShouldProvideWeaponsLineToFind = "[X] Byzantine tournament provides weapons";

		// Token: 0x0400002D RID: 45
		private const string ShouldUseHostCultureLineToFind = "[X] Byzantine enforce its culture during tournaments";

		// Token: 0x0400002E RID: 46
		private const string ShouldUseTheirEquipmentLineToFind = "[X] Byzantine tournament's participants must bring their own equipment";

		// Token: 0x0400002F RID: 47
		private readonly IOptions _options;
	}
}
