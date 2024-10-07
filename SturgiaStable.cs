using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TaleWorlds.CampaignSystem.Extensions;
using TaleWorlds.Core;

namespace LogRaamJousting.Stables
{
	// Token: 0x0200001F RID: 31
	public class SturgiaStable : IStable
	{
		// Token: 0x060000BE RID: 190 RVA: 0x00006C38 File Offset: 0x00004E38
		public EquipmentElement RequestMount([TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })] ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> weaponry)
		{
			return this.RequestMount();
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00006C50 File Offset: 0x00004E50
		public EquipmentElement RequestMount()
		{
			EquipmentElement result;
			result..ctor(Items.All.First((ItemObject n) => n.StringId == "sturgia_horse_tournament"), null, null, false);
			return result;
		}
	}
}
