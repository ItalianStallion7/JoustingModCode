using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LogRaamJousting.Decoupling;
using LogRaamJousting.Equipments;
using TaleWorlds.Core;

namespace LogRaamJousting.Armors
{
	// Token: 0x02000044 RID: 68
	public class BaseArmoury : IBaseArmoury
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x00009C23 File Offset: 0x00007E23
		public BaseArmoury()
		{
			this._bodyArmor = new Items();
			this._headArmor = new Items();
			this._legArmor = new Items();
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00009C4E File Offset: 0x00007E4E
		public BaseArmoury(Items bodyArmor, Items headArmor, Items legArmor)
		{
			this._bodyArmor = bodyArmor;
			this._headArmor = headArmor;
			this._legArmor = legArmor;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00009C70 File Offset: 0x00007E70
		[return: TupleElementNames(new string[] { "bodyArmor", "headArmor", "shoes" })]
		public ValueTuple<EquipmentElement, EquipmentElement, EquipmentElement> RequestArmorForLevel(string culture, ArmorTier occupation)
		{
			EquipmentElement bodyArmor = this.GetBodyArmorFor(culture, occupation);
			EquipmentElement headArmor = this.GetHeadArmorFor(culture, occupation);
			EquipmentElement legArmor = this.GetLegArmorFor(culture, occupation);
			return new ValueTuple<EquipmentElement, EquipmentElement, EquipmentElement>(bodyArmor, headArmor, legArmor);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00009CA8 File Offset: 0x00007EA8
		protected List<ItemObject> FilterByCulture(string culture, List<ItemObject> items)
		{
			List<ItemObject> result = new List<ItemObject>();
			foreach (ItemObject item in items)
			{
				bool flag = item.Culture == null;
				if (!flag)
				{
					string t = item.Culture.Name.ToString().ToUpper();
					bool flag2 = t == culture.ToUpper();
					if (flag2)
					{
						result.Add(item.ToEquipmentElement());
					}
				}
			}
			return result;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00009D48 File Offset: 0x00007F48
		protected ItemObject.ItemTiers GetTierForLevel(ArmorTier occupation)
		{
			ItemObject.ItemTiers itemTiers;
			switch (occupation)
			{
			case ArmorTier.Soldier:
				itemTiers = (LogRaamRandom.EvalPercentage(50f) ? 0 : 1);
				break;
			case ArmorTier.Wanderer:
				itemTiers = (LogRaamRandom.EvalPercentage(50f) ? 0 : 1);
				break;
			case ArmorTier.Lord:
				itemTiers = (LogRaamRandom.EvalPercentage(50f) ? 1 : 2);
				break;
			case ArmorTier.FactionLeader:
				itemTiers = 3;
				break;
			default:
				itemTiers = 0;
				break;
			}
			return itemTiers;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00009DB8 File Offset: 0x00007FB8
		private EquipmentElement GetBodyArmorFor(string culture, ArmorTier occupation)
		{
			Items bodyItems = new Items();
			foreach (ItemObject item in this._bodyArmor.All)
			{
				bool flag = item.ItemType != 13;
				if (!flag)
				{
					bool flag2 = item.StringId.Contains("dress");
					if (!flag2)
					{
						bool flag3 = item.Tier != this.GetTierForLevel(occupation);
						if (!flag3)
						{
							bodyItems.AddItemToSelectedList(item);
						}
					}
				}
			}
			List<ItemObject> items = this.FilterByCulture(culture, bodyItems.SelectedItems);
			bool flag4 = items.Count == 0;
			EquipmentElement equipmentElement;
			if (flag4)
			{
				equipmentElement = default(EquipmentElement);
			}
			else
			{
				ItemObject selectedItem = ((items.Count > 1) ? items[LogRaamRandom.GenerateRandomNumber(items.Count)] : items[0]);
				equipmentElement = new EquipmentElement(selectedItem, null, null, false);
			}
			return equipmentElement;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00009EC8 File Offset: 0x000080C8
		private EquipmentElement GetHeadArmorFor(string culture, ArmorTier occupation)
		{
			Items headItems = new Items();
			foreach (ItemObject item in this._headArmor.All)
			{
				bool flag = item.ItemType != 12;
				if (!flag)
				{
					bool flag2 = item.Tier != this.GetTierForLevel(occupation);
					if (!flag2)
					{
						headItems.AddItemToSelectedList(item);
					}
				}
			}
			return new EquipmentElement(Extensions.GetRandomElement<ItemObject>(this.FilterByCulture(culture, headItems.SelectedItems)), null, null, false);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00009F7C File Offset: 0x0000817C
		private EquipmentElement GetLegArmorFor(string culture, ArmorTier occupation)
		{
			Items bodyItems = new Items();
			foreach (ItemObject item in this._legArmor.All)
			{
				bool flag = item.ItemType != 14;
				if (!flag)
				{
					bool flag2 = item.Tier != this.GetTierForLevel(occupation);
					if (!flag2)
					{
						bodyItems.AddItemToSelectedList(item);
					}
				}
			}
			return new EquipmentElement(Extensions.GetRandomElement<ItemObject>(this.FilterByCulture(culture, bodyItems.SelectedItems)), null, null, false);
		}

		// Token: 0x040000A9 RID: 169
		private readonly Items _bodyArmor;

		// Token: 0x040000AA RID: 170
		private readonly Items _headArmor;

		// Token: 0x040000AB RID: 171
		private readonly Items _legArmor;
	}
}
