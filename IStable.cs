using System;
using System.Runtime.CompilerServices;
using TaleWorlds.Core;

namespace LogRaamJousting.Stables
{
	// Token: 0x0200001D RID: 29
	public interface IStable
	{
		// Token: 0x060000B9 RID: 185
		EquipmentElement RequestMount([TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })] ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> weaponry);

		// Token: 0x060000BA RID: 186
		EquipmentElement RequestMount();
	}
}
