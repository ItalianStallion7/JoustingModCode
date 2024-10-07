using System;
using System.Runtime.CompilerServices;
using LogRaamJousting.Equipments;
using TaleWorlds.Core;

namespace LogRaamJousting.Armors
{
	// Token: 0x02000047 RID: 71
	public interface IArmoury
	{
		// Token: 0x060001D0 RID: 464
		[return: TupleElementNames(new string[] { "bodyArmor", "headArmor", "shoes" })]
		ValueTuple<EquipmentElement, EquipmentElement, EquipmentElement> RequestArmorForLevel(ArmorTier level);
	}
}
