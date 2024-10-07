using System;
using System.Runtime.CompilerServices;
using LogRaamJousting.Equipments;
using TaleWorlds.Core;

namespace LogRaamJousting.Armors
{
	// Token: 0x02000046 RID: 70
	public class EmpireArmoury : BaseArmoury, IArmoury
	{
		// Token: 0x060001CE RID: 462 RVA: 0x0000A062 File Offset: 0x00008262
		public EmpireArmoury(IBaseArmoury baseArmoury)
		{
			this._baseArmoury = baseArmoury;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000A074 File Offset: 0x00008274
		[return: TupleElementNames(new string[] { "bodyArmor", "headArmor", "shoes" })]
		public ValueTuple<EquipmentElement, EquipmentElement, EquipmentElement> RequestArmorForLevel(ArmorTier level)
		{
			return base.RequestArmorForLevel("Empire", level);
		}

		// Token: 0x040000AD RID: 173
		private readonly IBaseArmoury _baseArmoury;
	}
}
