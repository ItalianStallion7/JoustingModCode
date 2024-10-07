using System;
using System.Runtime.CompilerServices;
using LogRaamJousting.Equipments;
using TaleWorlds.Core;

namespace LogRaamJousting.Armors
{
	// Token: 0x02000048 RID: 72
	public interface IBaseArmoury
	{
		// Token: 0x060001D1 RID: 465
		[return: TupleElementNames(new string[] { "bodyArmor", "headArmor", "shoes" })]
		ValueTuple<EquipmentElement, EquipmentElement, EquipmentElement> RequestArmorForLevel(string culture, ArmorTier occupation);
	}
}
