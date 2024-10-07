using System;

namespace LogRaamJousting.Options
{
	// Token: 0x02000029 RID: 41
	public class EmpireOptions : ICultureOption
	{
		// Token: 0x06000111 RID: 273 RVA: 0x0000746A File Offset: 0x0000566A
		public EmpireOptions(IOptions baseOptions)
		{
			this._options = baseOptions;
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000112 RID: 274 RVA: 0x0000747B File Offset: 0x0000567B
		public string Culture
		{
			get
			{
				return "EMPIRE";
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00007484 File Offset: 0x00005684
		public bool ParticipantShouldUseItsOwnEquipment(string[] options)
		{
			return this._options.ShouldUseTheirEquipment(options, "[X] Empire tournament's participants must bring their own equipment");
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000074A8 File Offset: 0x000056A8
		public bool ShouldBeNaked(string[] options)
		{
			return this._options.ShouldBeNaked(options, "[X] Undressed Empire");
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000074CC File Offset: 0x000056CC
		public bool ShouldBeNaked(string lineToFind)
		{
			return this._options.ShouldBeNaked(lineToFind);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000074EC File Offset: 0x000056EC
		public bool ShouldHappens(string[] options)
		{
			return this._options.ShouldHappens(options, "[X] Apply to Empire");
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00007510 File Offset: 0x00005710
		public bool ShouldProvideArmors(string[] options)
		{
			return this._options.ShouldProvideArmors(options, "[X] Empire tournament provides armors");
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00007534 File Offset: 0x00005734
		public bool ShouldProvideWeapons(string[] options)
		{
			return this._options.ShouldProvideWeapons(options, "[X] Empire tournament provides weapons");
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00007558 File Offset: 0x00005758
		public bool ShouldUseHostCulture(string[] options)
		{
			return this._options.ShouldUseHostCulture(options, "[X] Empire enforce its culture during tournaments");
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000757C File Offset: 0x0000577C
		public bool ShouldUseHostCulture(string lineToFind)
		{
			return this._options.ShouldUseHostCulture(lineToFind);
		}

		// Token: 0x04000044 RID: 68
		private const string ShouldBeNakedLineToFind = "[X] Undressed Empire";

		// Token: 0x04000045 RID: 69
		private const string ShouldHappensLineToFind = "[X] Apply to Empire";

		// Token: 0x04000046 RID: 70
		private const string ShouldProvideArmorsLineToFind = "[X] Empire tournament provides armors";

		// Token: 0x04000047 RID: 71
		private const string ShouldProvideWeaponsLineToFind = "[X] Empire tournament provides weapons";

		// Token: 0x04000048 RID: 72
		private const string ShouldUseHostCultureLineToFind = "[X] Empire enforce its culture during tournaments";

		// Token: 0x04000049 RID: 73
		private const string ShouldUseTheirEquipmentLineToFind = "[X] Empire tournament's participants must bring their own equipment";

		// Token: 0x0400004A RID: 74
		private readonly IOptions _options;
	}
}
