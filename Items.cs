using System;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem.Extensions;
using TaleWorlds.Core;
using TaleWorlds.Library;

namespace LogRaamJousting.Decoupling
{
	// Token: 0x0200003D RID: 61
	public class Items
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00009250 File Offset: 0x00007450
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00009291 File Offset: 0x00007491
		public List<ItemObject> All
		{
			get
			{
				CampaignState state = new CampaignState();
				bool flag = state.GameStarted() || state.CampaignStarted();
				List<ItemObject> list;
				if (flag)
				{
					list = this.ToJoustItemList(Items.All);
				}
				else
				{
					list = this._all;
				}
				return list;
			}
			set
			{
				this._all = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600018C RID: 396 RVA: 0x0000929A File Offset: 0x0000749A
		// (set) Token: 0x0600018D RID: 397 RVA: 0x000092A2 File Offset: 0x000074A2
		public List<ItemObject> SelectedItems { get; set; } = new List<ItemObject>();

		// Token: 0x0600018E RID: 398 RVA: 0x000092AB File Offset: 0x000074AB
		public void AddItemToSelectedList(ItemObject item)
		{
			this.SelectedItems.Add(item);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000092BC File Offset: 0x000074BC
		private List<ItemObject> ToJoustItemList(MBReadOnlyList<ItemObject> items)
		{
			List<ItemObject> result = new List<ItemObject>();
			foreach (ItemObject item in items)
			{
				result.Add(new ItemObject(item));
			}
			return result;
		}

		// Token: 0x0400009A RID: 154
		private List<ItemObject> _all = new List<ItemObject>();
	}
}
