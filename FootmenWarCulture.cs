using System;
using TaleWorlds.Core;

namespace LogRaamJousting
{
	// Token: 0x0200000A RID: 10
	public class FootmenWarCulture
	{
		// Token: 0x06000020 RID: 32 RVA: 0x00002B1C File Offset: 0x00000D1C
		public FootmenWarCulture(CultureCode culture)
		{
			BuildType[] orderByPreference = this.GetOrderResultFor(culture);
			for (int i = 0; i < orderByPreference.Length; i++)
			{
				switch (orderByPreference[i])
				{
				case BuildType.ONEHANDER:
					this.OneHanderPercentage = this._values[i];
					break;
				case BuildType.TWOHANDER:
					this.TwoHanderPercentage = this._values[i];
					break;
				case BuildType.POLEARM:
					this.PolearmPercentage = this._values[i];
					break;
				case BuildType.ARCHER:
					this.ArcherPercentage = this._values[i];
					break;
				case BuildType.THROWER:
					this.ThrowerPercentage = this._values[i];
					break;
				default:
					throw new ArgumentOutOfRangeException();
				}
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002BE0 File Offset: 0x00000DE0
		private BuildType[] GetOrderResultFor(CultureCode culture)
		{
			BuildType[] array;
			switch (culture)
			{
			case 0:
				array = new BuildType[]
				{
					BuildType.POLEARM,
					BuildType.ONEHANDER,
					BuildType.THROWER,
					BuildType.ARCHER,
					BuildType.TWOHANDER
				};
				break;
			case 1:
				array = new BuildType[]
				{
					BuildType.ONEHANDER,
					BuildType.POLEARM,
					BuildType.TWOHANDER,
					BuildType.THROWER,
					BuildType.ARCHER
				};
				break;
			case 2:
				array = new BuildType[]
				{
					BuildType.ONEHANDER,
					BuildType.THROWER,
					BuildType.ARCHER,
					BuildType.TWOHANDER,
					BuildType.POLEARM
				};
				break;
			case 3:
				array = new BuildType[]
				{
					BuildType.POLEARM,
					BuildType.ONEHANDER,
					BuildType.ARCHER,
					BuildType.TWOHANDER,
					BuildType.THROWER
				};
				break;
			case 4:
				array = new BuildType[]
				{
					BuildType.ARCHER,
					BuildType.POLEARM,
					BuildType.ONEHANDER,
					BuildType.THROWER,
					BuildType.TWOHANDER
				};
				break;
			case 5:
				array = new BuildType[]
				{
					BuildType.TWOHANDER,
					BuildType.ARCHER,
					BuildType.POLEARM,
					BuildType.ARCHER,
					BuildType.ONEHANDER
				};
				break;
			default:
				array = new BuildType[]
				{
					BuildType.THROWER,
					BuildType.TWOHANDER,
					BuildType.POLEARM,
					BuildType.ARCHER,
					BuildType.ONEHANDER
				};
				break;
			}
			return array;
		}

		// Token: 0x04000009 RID: 9
		public readonly int ArcherPercentage;

		// Token: 0x0400000A RID: 10
		public readonly int OneHanderPercentage;

		// Token: 0x0400000B RID: 11
		public readonly int PolearmPercentage;

		// Token: 0x0400000C RID: 12
		public readonly int ThrowerPercentage;

		// Token: 0x0400000D RID: 13
		public readonly int TwoHanderPercentage;

		// Token: 0x0400000E RID: 14
		private readonly int[] _values = new int[] { 50, 27, 15, 6, 2 };
	}
}
