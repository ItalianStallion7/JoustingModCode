using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TaleWorlds.CampaignSystem.Extensions;
using TaleWorlds.Core;

namespace LogRaamJousting.Stables
{
	// Token: 0x0200001E RID: 30
	public class KhuzaitStable : IStable
	{
		// Token: 0x060000BB RID: 187 RVA: 0x00006BD0 File Offset: 0x00004DD0
		public EquipmentElement RequestMount([TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })] ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> weaponry)
		{
			return this.RequestMount();
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00006BE8 File Offset: 0x00004DE8
		public EquipmentElement RequestMount()
		{
			EquipmentElement result;
			result..ctor(Items.All.First((ItemObject n) => n.StringId == "khuzait_horse_tournament"), null, null, false);
			return result;
		}
	}
}
