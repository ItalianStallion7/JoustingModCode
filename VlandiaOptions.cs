using System;

namespace LogRaamJousting.Options
{
	// Token: 0x0200002D RID: 45
	public class VlandiaOptions : ICultureOption
	{
		// Token: 0x06000131 RID: 305 RVA: 0x00007846 File Offset: 0x00005A46
		public VlandiaOptions(IOptions baseOptions)
		{
			this._options = baseOptions;
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00007857 File Offset: 0x00005A57
		public string Culture
		{
			get
			{
				return "VLANDIA";
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00007860 File Offset: 0x00005A60
		public bool ParticipantShouldUseItsOwnEquipment(string[] options)
		{
			return this._options.ShouldUseTheirEquipment(options, "[X] Vlandia tournament's participants must bring their own equipment");
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00007884 File Offset: 0x00005A84
		public bool ShouldBeNaked(string[] options)
		{
			return this._options.ShouldBeNaked(options, "[X] Undressed Vlandia");
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000078A8 File Offset: 0x00005AA8
		public bool ShouldBeNaked(string lineToFind)
		{
			return this._options.ShouldBeNaked(lineToFind);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000078C8 File Offset: 0x00005AC8
		public bool ShouldHappens(string[] options)
		{
			return this._options.ShouldHappens(options, "[X] Apply to Vlandia");
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000078EC File Offset: 0x00005AEC
		public bool ShouldProvideArmors(string[] options)
		{
			return this._options.ShouldProvideArmors(options, "[X] Vlandia tournament provides armors");
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00007910 File Offset: 0x00005B10
		public bool ShouldProvideWeapons(string[] options)
		{
			return this._options.ShouldProvideWeapons(options, "[X] Vlandia tournament provides weapons");
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00007934 File Offset: 0x00005B34
		public bool ShouldUseHostCulture(string[] options)
		{
			return this._options.ShouldUseHostCulture(options, "[X] Vlandia enforce its culture during tournaments");
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00007958 File Offset: 0x00005B58
		public bool ShouldUseHostCulture(string lineToFind)
		{
			return this._options.ShouldUseHostCulture(lineToFind);
		}

		// Token: 0x04000059 RID: 89
		private const string ShouldBeNakedLineToFind = "[X] Undressed Vlandia";

		// Token: 0x0400005A RID: 90
		private const string ShouldHappensLineToFind = "[X] Apply to Vlandia";

		// Token: 0x0400005B RID: 91
		private const string ShouldProvideArmorsLineToFind = "[X] Vlandia tournament provides armors";

		// Token: 0x0400005C RID: 92
		private const string ShouldProvideWeaponsLineToFind = "[X] Vlandia tournament provides weapons";

		// Token: 0x0400005D RID: 93
		private const string ShouldUseHostCultureLineToFind = "[X] Vlandia enforce its culture during tournaments";

		// Token: 0x0400005E RID: 94
		private const string ShouldUseTheirEquipmentLineToFind = "[X] Vlandia tournament's participants must bring their own equipment";

		// Token: 0x0400005F RID: 95
		private readonly IOptions _options;
	}
}
