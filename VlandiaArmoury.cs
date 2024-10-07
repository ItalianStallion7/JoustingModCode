using System;
using System.Runtime.CompilerServices;
using LogRaamJousting.Equipments;
using TaleWorlds.Core;

namespace LogRaamJousting.Armors
{
	// Token: 0x0200004B RID: 75
	public class VlandiaArmoury : BaseArmoury, IArmoury
	{
		// Token: 0x060001D6 RID: 470 RVA: 0x0000A10E File Offset: 0x0000830E
		public VlandiaArmoury(IBaseArmoury baseArmoury)
		{
			this._baseArmoury = baseArmoury;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000A120 File Offset: 0x00008320
		[return: TupleElementNames(new string[] { "bodyArmor", "headArmor", "shoes" })]
		public ValueTuple<EquipmentElement, EquipmentElement, EquipmentElement> RequestArmorForLevel(ArmorTier level)
		{
			return base.RequestArmorForLevel("Vlandia", level);
		}

		// Token: 0x040000B0 RID: 176
		private readonly IBaseArmoury _baseArmoury;
	}
}
