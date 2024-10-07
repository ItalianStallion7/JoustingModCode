using System;
using System.Runtime.CompilerServices;
using LogRaamJousting.Equipments;
using TaleWorlds.Core;

namespace LogRaamJousting.Armors
{
	// Token: 0x02000043 RID: 67
	public class AseraiArmoury : IArmoury
	{
		// Token: 0x060001C2 RID: 450 RVA: 0x00009BED File Offset: 0x00007DED
		public AseraiArmoury(IBaseArmoury baseArmoury)
		{
			this._base = baseArmoury;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00009C00 File Offset: 0x00007E00
		[return: TupleElementNames(new string[] { "bodyArmor", "headArmor", "shoes" })]
		public ValueTuple<EquipmentElement, EquipmentElement, EquipmentElement> RequestArmorForLevel(ArmorTier level)
		{
			return this._base.RequestArmorForLevel("Aserai", level);
		}

		// Token: 0x040000A8 RID: 168
		private readonly IBaseArmoury _base;
	}
}
