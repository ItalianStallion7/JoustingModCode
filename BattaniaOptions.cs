using System;

namespace LogRaamJousting.Options
{
	// Token: 0x02000028 RID: 40
	public class BattaniaOptions : ICultureOption
	{
		// Token: 0x06000107 RID: 263 RVA: 0x0000733A File Offset: 0x0000553A
		public BattaniaOptions(IOptions baseOptions)
		{
			this._options = baseOptions;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000108 RID: 264 RVA: 0x0000734B File Offset: 0x0000554B
		public string Culture
		{
			get
			{
				return "BATTANIA";
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00007354 File Offset: 0x00005554
		public bool ParticipantShouldUseItsOwnEquipment(string[] options)
		{
			return this._options.ShouldUseTheirEquipment(options, "[X] Battania tournament's participants must bring their own equipment");
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00007378 File Offset: 0x00005578
		public bool ShouldBeNaked(string[] options)
		{
			return this._options.ShouldBeNaked(options, "[X] Undressed Battania");
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000739C File Offset: 0x0000559C
		public bool ShouldBeNaked(string lineToFind)
		{
			return this._options.ShouldBeNaked(lineToFind);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000073BC File Offset: 0x000055BC
		public bool ShouldHappens(string[] options)
		{
			return this._options.ShouldHappens(options, "[X] Apply to Battania");
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000073E0 File Offset: 0x000055E0
		public bool ShouldProvideArmors(string[] options)
		{
			return this._options.ShouldProvideArmors(options, "[X] Battania tournament provides armors");
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00007404 File Offset: 0x00005604
		public bool ShouldProvideWeapons(string[] options)
		{
			return this._options.ShouldProvideWeapons(options, "[X] Battania tournament provides weapons");
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00007428 File Offset: 0x00005628
		public bool ShouldUseHostCulture(string[] options)
		{
			return this._options.ShouldUseHostCulture(options, "[X] Battania enforce its culture during tournaments");
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000744C File Offset: 0x0000564C
		public bool ShouldUseHostCulture(string lineToFind)
		{
			return this._options.ShouldUseHostCulture(lineToFind);
		}

		// Token: 0x0400003D RID: 61
		private const string ShouldBeNakedLineToFind = "[X] Undressed Battania";

		// Token: 0x0400003E RID: 62
		private const string ShouldHappensLineToFind = "[X] Apply to Battania";

		// Token: 0x0400003F RID: 63
		private const string ShouldProvideArmorsLineToFind = "[X] Battania tournament provides armors";

		// Token: 0x04000040 RID: 64
		private const string ShouldProvideWeaponsLineToFind = "[X] Battania tournament provides weapons";

		// Token: 0x04000041 RID: 65
		private const string ShouldUseHostCultureLineToFind = "[X] Battania enforce its culture during tournaments";

		// Token: 0x04000042 RID: 66
		private const string ShouldUseTheirEquipmentLineToFind = "[X] Battania tournament's participants must bring their own equipment";

		// Token: 0x04000043 RID: 67
		private readonly IOptions _options;
	}
}
