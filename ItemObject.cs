using System;
using TaleWorlds.Core;
using TaleWorlds.ObjectSystem;

namespace LogRaamJousting.Decoupling
{
	// Token: 0x0200003C RID: 60
	public class ItemObject : MBObjectBase
	{
		// Token: 0x0600017F RID: 383 RVA: 0x00009084 File Offset: 0x00007284
		public ItemObject(ItemObject itemObject)
		{
			this._itemObject = itemObject;
			bool flag = this._itemObject.Culture != null;
			if (flag)
			{
				this._culture = this._itemObject.Culture;
			}
			this._tier = this._itemObject.Tier;
			this._stringId = itemObject.StringId;
			this._itemType = this._itemObject.ItemType;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000090F1 File Offset: 0x000072F1
		public ItemObject(MBObjectBase itemObject)
		{
			this._itemObject = (ItemObject)itemObject;
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00009108 File Offset: 0x00007308
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00009149 File Offset: 0x00007349
		public BasicCultureObject Culture
		{
			get
			{
				CampaignState state = new CampaignState();
				bool flag = state.GameStarted() || state.CampaignStarted();
				BasicCultureObject basicCultureObject;
				if (flag)
				{
					basicCultureObject = this._itemObject.Culture;
				}
				else
				{
					basicCultureObject = this._culture;
				}
				return basicCultureObject;
			}
			set
			{
				this._culture = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00009154 File Offset: 0x00007354
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00009195 File Offset: 0x00007395
		public ItemObject.ItemTypeEnum ItemType
		{
			get
			{
				CampaignState state = new CampaignState();
				bool flag = state.GameStarted() || state.CampaignStarted();
				ItemObject.ItemTypeEnum itemTypeEnum;
				if (flag)
				{
					itemTypeEnum = this._itemObject.ItemType;
				}
				else
				{
					itemTypeEnum = this._itemType;
				}
				return itemTypeEnum;
			}
			set
			{
				this._itemType = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000185 RID: 389 RVA: 0x000091A0 File Offset: 0x000073A0
		// (set) Token: 0x06000186 RID: 390 RVA: 0x000091E1 File Offset: 0x000073E1
		public string StringId
		{
			get
			{
				CampaignState state = new CampaignState();
				bool flag = state.GameStarted() || state.CampaignStarted();
				string text;
				if (flag)
				{
					text = this._itemObject.StringId;
				}
				else
				{
					text = this._stringId;
				}
				return text;
			}
			set
			{
				this._stringId = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000187 RID: 391 RVA: 0x000091EC File Offset: 0x000073EC
		// (set) Token: 0x06000188 RID: 392 RVA: 0x0000922D File Offset: 0x0000742D
		public ItemObject.ItemTiers Tier
		{
			get
			{
				CampaignState state = new CampaignState();
				bool flag = state.GameStarted() || state.CampaignStarted();
				ItemObject.ItemTiers itemTiers;
				if (flag)
				{
					itemTiers = this._itemObject.Tier;
				}
				else
				{
					itemTiers = this._tier;
				}
				return itemTiers;
			}
			set
			{
				this._tier = value;
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00009238 File Offset: 0x00007438
		public ItemObject ToEquipmentElement()
		{
			return this._itemObject;
		}

		// Token: 0x04000095 RID: 149
		private readonly ItemObject _itemObject;

		// Token: 0x04000096 RID: 150
		private BasicCultureObject _culture;

		// Token: 0x04000097 RID: 151
		private ItemObject.ItemTypeEnum _itemType;

		// Token: 0x04000098 RID: 152
		private string _stringId;

		// Token: 0x04000099 RID: 153
		private ItemObject.ItemTiers _tier;
	}
}
