using System;
using System.Runtime.CompilerServices;
using LogRaamJousting.Equipments;
using TaleWorlds.Core;

namespace LogRaamJousting.Armors
{
	// Token: 0x02000049 RID: 73
	public class KhuzaitArmoury : BaseArmoury, IArmoury
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x0000A092 File Offset: 0x00008292
		public KhuzaitArmoury(IBaseArmoury baseArmoury)
		{
			this._baseArmoury = baseArmoury;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000A0A4 File Offset: 0x000082A4
		[return: TupleElementNames(new string[] { "bodyArmor", "headArmor", "shoes" })]
		public ValueTuple<EquipmentElement, EquipmentElement, EquipmentElement> RequestArmorForLevel(ArmorTier level)
		{
			ValueTuple<EquipmentElement, EquipmentElement, EquipmentElement> valueTuple = base.RequestArmorForLevel("Khuzait", level);
			EquipmentElement body = valueTuple.Item1;
			EquipmentElement head = valueTuple.Item2;
			EquipmentElement legs = valueTuple.Item3;
			return new ValueTuple<EquipmentElement, EquipmentElement, EquipmentElement>(body, head, legs);
		}

		// Token: 0x040000AE RID: 174
		private readonly IBaseArmoury _baseArmoury;
	}
}
