using System;

namespace LogRaamJousting.Options
{
	// Token: 0x0200002A RID: 42
	public class KhuzaitOptions : ICultureOption
	{
		// Token: 0x0600011B RID: 283 RVA: 0x0000759A File Offset: 0x0000579A
		public KhuzaitOptions(IOptions baseOptions)
		{
			this._options = baseOptions;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600011C RID: 284 RVA: 0x000075AB File Offset: 0x000057AB
		public string Culture
		{
			get
			{
				return "KHUZAIT";
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000075B4 File Offset: 0x000057B4
		public bool ParticipantShouldUseItsOwnEquipment(string[] options)
		{
			return this._options.ShouldUseTheirEquipment(options, "[X] Khuzait tournament's participants must bring their own equipment");
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000075D8 File Offset: 0x000057D8
		public bool ShouldBeNaked(string[] options)
		{
			return this._options.ShouldBeNaked(options, "[X] Undressed Khuzait");
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000075FC File Offset: 0x000057FC
		public bool ShouldBeNaked(string lineToFind)
		{
			return this._options.ShouldBeNaked(lineToFind);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000761C File Offset: 0x0000581C
		public bool ShouldHappens(string[] options)
		{
			return this._options.ShouldHappens(options, "[X] Apply to Khuzait");
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00007640 File Offset: 0x00005840
		public bool ShouldProvideArmors(string[] options)
		{
			return this._options.ShouldProvideArmors(options, "[X] Khuzait tournament provides armors");
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00007664 File Offset: 0x00005864
		public bool ShouldProvideWeapons(string[] options)
		{
			return this._options.ShouldProvideWeapons(options, "[X] Khuzait tournament provides weapons");
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00007688 File Offset: 0x00005888
		public bool ShouldUseHostCulture(string[] options)
		{
			return this._options.ShouldUseHostCulture(options, "[X] Khuzait enforce its culture during tournaments");
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000076AC File Offset: 0x000058AC
		public bool ShouldUseHostCulture(string lineToFind)
		{
			return this._options.ShouldUseHostCulture(lineToFind);
		}

		// Token: 0x0400004B RID: 75
		private const string ShouldBeNakedLineToFind = "[X] Undressed Khuzait";

		// Token: 0x0400004C RID: 76
		private const string ShouldHappensLineToFind = "[X] Apply to Khuzait";

		// Token: 0x0400004D RID: 77
		private const string ShouldProvideArmorsLineToFind = "[X] Khuzait tournament provides armors";

		// Token: 0x0400004E RID: 78
		private const string ShouldProvideWeaponsLineToFind = "[X] Khuzait tournament provides weapons";

		// Token: 0x0400004F RID: 79
		private const string ShouldUseHostCultureLineToFind = "[X] Khuzait enforce its culture during tournaments";

		// Token: 0x04000050 RID: 80
		private const string ShouldUseTheirEquipmentLineToFind = "[X] Khuzait tournament's participants must bring their own equipment";

		// Token: 0x04000051 RID: 81
		private readonly IOptions _options;
	}
}
