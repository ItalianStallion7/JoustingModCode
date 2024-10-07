using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TaleWorlds.CampaignSystem.Extensions;
using TaleWorlds.Core;

namespace LogRaamJousting.Stables
{
	// Token: 0x02000020 RID: 32
	public class VlandiaStable : IStable
	{
		// Token: 0x060000C1 RID: 193 RVA: 0x00006CA0 File Offset: 0x00004EA0
		public EquipmentElement RequestMount([TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })] ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> weaponry)
		{
			return this.RequestMount();
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00006CB8 File Offset: 0x00004EB8
		public EquipmentElement RequestMount()
		{
			EquipmentElement result;
			result..ctor(Items.All.First((ItemObject n) => n.StringId == "vlandia_horse_tournament"), null, null, false);
			return result;
		}
	}
}
