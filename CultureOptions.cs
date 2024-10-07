using System;
using LogRaamJousting.Configuration;

namespace LogRaamJousting.Options
{
	// Token: 0x02000024 RID: 36
	public class CultureOptions : IOptions
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x00007063 File Offset: 0x00005263
		public CultureOptions(IConfigLoader loader)
		{
			this._loader = loader;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00007074 File Offset: 0x00005274
		public string[] GetOptionsDetail
		{
			get
			{
				return this._loader.RetrieveConfigDetails();
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00007084 File Offset: 0x00005284
		public bool ShouldBeNaked(string[] options, string lineToFind)
		{
			return this.ShouldUseHostCulture(options, lineToFind);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000070A0 File Offset: 0x000052A0
		public bool ShouldBeNaked(string lineToFind)
		{
			return this.ShouldBeNaked(this.GetOptionsDetail, lineToFind);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000070C0 File Offset: 0x000052C0
		public bool ShouldHappens(string[] options, string lineToFind)
		{
			foreach (string option in options)
			{
				bool flag = !option.Contains(lineToFind);
				if (!flag)
				{
					int percentageSymbolIndex = option.IndexOf('%');
					bool flag2 = percentageSymbolIndex == -1;
					if (!flag2)
					{
						string percentageString = option.Substring(percentageSymbolIndex - 3, 3).Trim();
						int percentage;
						bool flag3 = !int.TryParse(percentageString, out percentage);
						if (!flag3)
						{
							bool flag4 = LogRaamRandom.EvalPercentage((float)percentage);
							if (flag4)
							{
								return true;
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000714C File Offset: 0x0000534C
		public bool ShouldHappens(string lineToFind)
		{
			return this.ShouldHappens(this.GetOptionsDetail, lineToFind);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000716C File Offset: 0x0000536C
		public bool ShouldProvideArmors(string[] options, string lineToFind)
		{
			return this._loader.IsLineExistInStruct(options, lineToFind);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000718C File Offset: 0x0000538C
		public bool ShouldProvideWeapons(string[] options, string lineToFind)
		{
			return this._loader.IsLineExistInStruct(options, lineToFind);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000071AC File Offset: 0x000053AC
		public bool ShouldUseHostCulture(string[] options, string lineToFind)
		{
			return new OptionFinder().IsLineExistInStruct(options, lineToFind);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000071CC File Offset: 0x000053CC
		public bool ShouldUseHostCulture(string lineToFind)
		{
			return this.ShouldUseHostCulture(this.GetOptionsDetail, lineToFind);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000071EC File Offset: 0x000053EC
		public bool ShouldUseTheirEquipment(string[] options, string lineToFind)
		{
			return this._loader.IsLineExistInStruct(options, lineToFind);
		}

		// Token: 0x04000035 RID: 53
		private readonly IConfigLoader _loader;
	}
}
