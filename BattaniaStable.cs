using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TaleWorlds.CampaignSystem.Extensions;
using TaleWorlds.Core;

namespace LogRaamJousting.Stables
{
	// Token: 0x0200001B RID: 27
	public class BattaniaStable : IStable
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x00006AD8 File Offset: 0x00004CD8
		public EquipmentElement RequestMount([TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })] ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> weaponry)
		{
			return this.RequestMount();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00006AF0 File Offset: 0x00004CF0
		public EquipmentElement RequestMount()
		{
			EquipmentElement result;
			result..ctor(Items.All.First((ItemObject n) => n.StringId == "battania_horse_tournament"), null, null, false);
			return result;
		}
	}
}
