using System;
using System.Runtime.CompilerServices;
using LogRaamJousting.Equipments;
using TaleWorlds.Core;

namespace LogRaamJousting.Armors
{
	// Token: 0x02000045 RID: 69
	public class BattaniaArmoury : BaseArmoury, IArmoury
	{
		// Token: 0x060001CC RID: 460 RVA: 0x0000A030 File Offset: 0x00008230
		public BattaniaArmoury(IBaseArmoury baseArmoury)
		{
			this._baseArmoury = baseArmoury;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000A044 File Offset: 0x00008244
		[return: TupleElementNames(new string[] { "bodyArmor", "headArmor", "shoes" })]
		public ValueTuple<EquipmentElement, EquipmentElement, EquipmentElement> RequestArmorForLevel(ArmorTier level)
		{
			return base.RequestArmorForLevel("Battania", level);
		}

		// Token: 0x040000AC RID: 172
		private readonly IBaseArmoury _baseArmoury;
	}
}
