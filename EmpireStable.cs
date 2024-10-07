using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TaleWorlds.CampaignSystem.Extensions;
using TaleWorlds.Core;

namespace LogRaamJousting.Stables
{
	// Token: 0x0200001C RID: 28
	public class EmpireStable : IStable
	{
		// Token: 0x060000B6 RID: 182 RVA: 0x00006B40 File Offset: 0x00004D40
		public EquipmentElement RequestMount([TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })] ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> weapons)
		{
			return (weapons.Item1.Item.StringId == "military_fork_pike_t3") ? default(EquipmentElement) : this.RequestMount();
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00006B80 File Offset: 0x00004D80
		public EquipmentElement RequestMount()
		{
			EquipmentElement result;
			result..ctor(Items.All.First((ItemObject n) => n.StringId == "empire_horse_tournament"), null, null, false);
			return result;
		}
	}
}
