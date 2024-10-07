using System;

namespace LogRaamJousting.Options
{
	// Token: 0x02000021 RID: 33
	public class AyyubidOptions : ICultureOption
	{
		// Token: 0x060000C4 RID: 196 RVA: 0x00006D07 File Offset: 0x00004F07
		public AyyubidOptions(IOptions baseOptions)
		{
			this._options = baseOptions;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00006D18 File Offset: 0x00004F18
		public string Culture
		{
			get
			{
				return "AYYUBID";
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00006D20 File Offset: 0x00004F20
		public bool ParticipantShouldUseItsOwnEquipment(string[] options)
		{
			return this._options.ShouldUseTheirEquipment(options, "[X] Ayyubid tournament's participants must bring their own equipment");
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00006D44 File Offset: 0x00004F44
		public bool ShouldBeNaked(string[] options)
		{
			return this._options.ShouldBeNaked(options, "[X] Undressed Ayyubid");
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00006D68 File Offset: 0x00004F68
		public bool ShouldBeNaked(string lineToFind)
		{
			return this._options.ShouldBeNaked(lineToFind);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00006D88 File Offset: 0x00004F88
		public bool ShouldHappens(string[] options)
		{
			return this._options.ShouldHappens(options, "[X] Apply to Ayyubid");
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00006DAC File Offset: 0x00004FAC
		public bool ShouldProvideArmors(string[] options)
		{
			return this._options.ShouldProvideArmors(options, "[X] Ayyubid tournament provides armors");
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00006DD0 File Offset: 0x00004FD0
		public bool ShouldProvideWeapons(string[] options)
		{
			return this._options.ShouldProvideWeapons(options, "[X] Ayyubid tournament provides weapons");
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00006DF4 File Offset: 0x00004FF4
		public bool ShouldUseHostCulture(string[] options)
		{
			return this._options.ShouldUseHostCulture(options, "[X] Ayyubid enforce its culture during tournaments");
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00006E18 File Offset: 0x00005018
		public bool ShouldUseHostCulture(string lineToFind)
		{
			return this._options.ShouldUseHostCulture(lineToFind);
		}

		// Token: 0x04000022 RID: 34
		private const string ShouldBeNakedLineToFind = "[X] Undressed Ayyubid";

		// Token: 0x04000023 RID: 35
		private const string ShouldHappensLineToFind = "[X] Apply to Ayyubid";

		// Token: 0x04000024 RID: 36
		private const string ShouldProvideArmorsLineToFind = "[X] Ayyubid tournament provides armors";

		// Token: 0x04000025 RID: 37
		private const string ShouldProvideWeaponsLineToFind = "[X] Ayyubid tournament provides weapons";

		// Token: 0x04000026 RID: 38
		private const string ShouldUseHostCultureLineToFind = "[X] Ayyubid enforce its culture during tournaments";

		// Token: 0x04000027 RID: 39
		private const string ShouldUseTheirEquipmentLineToFind = "[X] Ayyubid tournament's participants must bring their own equipment";

		// Token: 0x04000028 RID: 40
		private readonly IOptions _options;
	}
}
