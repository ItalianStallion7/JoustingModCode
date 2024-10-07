using System;
using System.Runtime.CompilerServices;
using LogRaamJousting.Equipments;
using TaleWorlds.Core;

namespace LogRaamJousting.Armors
{
	// Token: 0x0200004A RID: 74
	public class SturgiaArmoury : BaseArmoury, IArmoury
	{
		// Token: 0x060001D4 RID: 468 RVA: 0x0000A0DE File Offset: 0x000082DE
		public SturgiaArmoury(IBaseArmoury baseArmoury)
		{
			this._baseArmoury = baseArmoury;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000A0F0 File Offset: 0x000082F0
		[return: TupleElementNames(new string[] { "bodyArmor", "headArmor", "shoes" })]
		public ValueTuple<EquipmentElement, EquipmentElement, EquipmentElement> RequestArmorForLevel(ArmorTier level)
		{
			return base.RequestArmorForLevel("Sturgia", level);
		}

		// Token: 0x040000AF RID: 175
		private readonly IBaseArmoury _baseArmoury;
	}
}
