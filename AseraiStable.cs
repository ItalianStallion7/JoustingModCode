using System;
using System.Linq;
using System.Runtime.CompilerServices;
using LogRaamJousting.Decoupling;
using TaleWorlds.Core;

namespace LogRaamJousting.Stables
{
	// Token: 0x0200001A RID: 26
	public class AseraiStable : IStable
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x00006A10 File Offset: 0x00004C10
		public EquipmentElement RequestMount([TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })] ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> weaponry)
		{
			return this.RequestMount();
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00006A28 File Offset: 0x00004C28
		public EquipmentElement RequestMount()
		{
			EquipmentElement equipmentElement;
			if (!LogRaamRandom.EvalPercentage(70f))
			{
				ItemObject itemObject = new Items().All.FirstOrDefault((ItemObject n) => n.StringId == "aserai_horse_tournament");
				equipmentElement = new EquipmentElement((itemObject != null) ? itemObject.ToEquipmentElement() : null, null, null, false);
			}
			else
			{
				ItemObject itemObject2 = new Items().All.FirstOrDefault((ItemObject n) => n.StringId.Contains("camel_tournament"));
				equipmentElement = new EquipmentElement((itemObject2 != null) ? itemObject2.ToEquipmentElement() : null, null, null, false);
			}
			return equipmentElement;
		}
	}
}
