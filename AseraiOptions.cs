using System;

namespace LogRaamJousting.Options
{
	// Token: 0x02000027 RID: 39
	public class AseraiOptions : ICultureOption
	{
		// Token: 0x060000FD RID: 253 RVA: 0x0000720B File Offset: 0x0000540B
		public AseraiOptions(IOptions baseOptions)
		{
			this._options = baseOptions;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000FE RID: 254 RVA: 0x0000721C File Offset: 0x0000541C
		public string Culture
		{
			get
			{
				return "ASERAI";
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00007224 File Offset: 0x00005424
		public bool ParticipantShouldUseItsOwnEquipment(string[] options)
		{
			return this._options.ShouldUseTheirEquipment(options, "[X] Aserai tournament's participants must bring their own equipment");
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00007248 File Offset: 0x00005448
		public bool ShouldBeNaked(string[] options)
		{
			return this._options.ShouldBeNaked(options, "[X] Undressed Aserai");
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000726C File Offset: 0x0000546C
		public bool ShouldBeNaked(string lineToFind)
		{
			return this._options.ShouldBeNaked(lineToFind);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000728C File Offset: 0x0000548C
		public bool ShouldHappens(string[] options)
		{
			return this._options.ShouldHappens(options, "[X] Apply to Aserai");
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000072B0 File Offset: 0x000054B0
		public bool ShouldProvideArmors(string[] options)
		{
			return this._options.ShouldProvideArmors(options, "[X] Aserai tournament provides armors");
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000072D4 File Offset: 0x000054D4
		public bool ShouldProvideWeapons(string[] options)
		{
			return this._options.ShouldProvideWeapons(options, "[X] Aserai tournament provides weapons");
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000072F8 File Offset: 0x000054F8
		public bool ShouldUseHostCulture(string[] options)
		{
			return this._options.ShouldUseHostCulture(options, "[X] Aserai enforce its culture during tournaments");
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000731C File Offset: 0x0000551C
		public bool ShouldUseHostCulture(string lineToFind)
		{
			return this._options.ShouldUseHostCulture(lineToFind);
		}

		// Token: 0x04000036 RID: 54
		private const string ShouldBeNakedLineToFind = "[X] Undressed Aserai";

		// Token: 0x04000037 RID: 55
		private const string ShouldHappensLineToFind = "[X] Apply to Aserai";

		// Token: 0x04000038 RID: 56
		private const string ShouldProvideArmorsLineToFind = "[X] Aserai tournament provides armors";

		// Token: 0x04000039 RID: 57
		private const string ShouldProvideWeaponsLineToFind = "[X] Aserai tournament provides weapons";

		// Token: 0x0400003A RID: 58
		private const string ShouldUseHostCultureLineToFind = "[X] Aserai enforce its culture during tournaments";

		// Token: 0x0400003B RID: 59
		private const string ShouldUseTheirEquipmentLineToFind = "[X] Aserai tournament's participants must bring their own equipment";

		// Token: 0x0400003C RID: 60
		private readonly IOptions _options;
	}
}
