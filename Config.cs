using System;
using LogRaamJousting.Options;

namespace LogRaamJousting.Configuration
{
	// Token: 0x02000042 RID: 66
	public class Config : IConfig
	{
		// Token: 0x060001B6 RID: 438 RVA: 0x0000984B File Offset: 0x00007A4B
		public Config(IOptions cultureOptions, IConfigLoader loader)
		{
			this._options = cultureOptions;
			this._loader = loader;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00009863 File Offset: 0x00007A63
		public Config()
		{
			this._loader = new ConfigLoader();
			this._options = new CultureOptions(this._loader);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000988C File Offset: 0x00007A8C
		public ICultureOption GetSpecificOptionsFor(string culture)
		{
			string text = culture.ToUpper();
			if (!true)
			{
			}
			ICultureOption cultureOption;
			if (text != null)
			{
				switch (text.Length)
				{
				case 6:
				{
					char c = text[0];
					if (c != 'A')
					{
						if (c == 'E')
						{
							if (text == "EMPIRE")
							{
								cultureOption = new EmpireOptions(this._options);
								goto IL_018F;
							}
						}
					}
					else if (text == "ASERAI")
					{
						cultureOption = new AseraiOptions(this._options);
						goto IL_018F;
					}
					break;
				}
				case 7:
				{
					char c = text[0];
					if (c <= 'K')
					{
						if (c != 'A')
						{
							if (c == 'K')
							{
								if (text == "KHUZAIT")
								{
									cultureOption = new KhuzaitOptions(this._options);
									goto IL_018F;
								}
							}
						}
						else if (text == "AYYUBID")
						{
							cultureOption = new AyyubidOptions(this._options);
							goto IL_018F;
						}
					}
					else if (c != 'S')
					{
						if (c == 'V')
						{
							if (text == "VLANDIA")
							{
								cultureOption = new VlandiaOptions(this._options);
								goto IL_018F;
							}
						}
					}
					else if (text == "STURGIA")
					{
						cultureOption = new SturgiaOptions(this._options);
						goto IL_018F;
					}
					break;
				}
				case 8:
					if (text == "BATTANIA")
					{
						cultureOption = new BattaniaOptions(this._options);
						goto IL_018F;
					}
					break;
				case 9:
					if (text == "BYZANTINE")
					{
						cultureOption = new ByzantineOptions(this._options);
						goto IL_018F;
					}
					break;
				}
			}
			cultureOption = new EmpireOptions(this._options);
			IL_018F:
			if (!true)
			{
			}
			return cultureOption;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00009A34 File Offset: 0x00007C34
		public bool HostShouldProvideArmors(string hostCulture)
		{
			return this.GetSpecificOptionsFor(hostCulture).ShouldProvideArmors(this._loader.RetrieveConfigDetails());
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00009A60 File Offset: 0x00007C60
		public bool HostShouldProvideWeapons(string hostCulture)
		{
			return this.GetSpecificOptionsFor(hostCulture).ShouldProvideWeapons(this._loader.RetrieveConfigDetails());
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00009A8C File Offset: 0x00007C8C
		public bool IsHostEnforcingHisCulture(string hostCulture)
		{
			bool a = this.ShouldApplyModForThisMatch(hostCulture);
			bool b = this.GetSpecificOptionsFor(hostCulture).ShouldUseHostCulture(this._loader.RetrieveConfigDetails());
			return a && b;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00009AC4 File Offset: 0x00007CC4
		public bool IsPlayerMayShouldGainRenownWhenWinningTournament()
		{
			return new ConsequenceOptions(this._options, this._loader).PlayerShouldGainRenownPoints(this._loader.RetrieveConfigDetails());
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00009AF8 File Offset: 0x00007CF8
		public bool IsPlayerShouldGainExtraRenownWhenNaked()
		{
			return new ConsequenceOptions(this._options, this._loader).PlayerShouldGainExtraRenownPointsWhenNude(this._loader.RetrieveConfigDetails());
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00009B2C File Offset: 0x00007D2C
		public bool IsPlayerShouldLosesRenownWhenLosingTournament()
		{
			return new ConsequenceOptions(this._options, this._loader).PlayerShouldLosesRenownPoints(this._loader.RetrieveConfigDetails());
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00009B60 File Offset: 0x00007D60
		public bool ParticipantsUsesTheirOwnEquipments(string hostCulture)
		{
			return this.GetSpecificOptionsFor(hostCulture).ParticipantShouldUseItsOwnEquipment(this._loader.RetrieveConfigDetails());
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00009B8C File Offset: 0x00007D8C
		public bool ShouldApplyModForThisMatch(string hostCulture)
		{
			return this.GetSpecificOptionsFor(hostCulture).ShouldHappens(this._loader.RetrieveConfigDetails());
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00009BB8 File Offset: 0x00007DB8
		public bool ShouldBeNaked(string hostCulture)
		{
			return this.ShouldApplyModForThisMatch(hostCulture) && this.GetSpecificOptionsFor(hostCulture).ShouldBeNaked(this._loader.RetrieveConfigDetails());
		}

		// Token: 0x040000A6 RID: 166
		private readonly IConfigLoader _loader;

		// Token: 0x040000A7 RID: 167
		private readonly IOptions _options;
	}
}
