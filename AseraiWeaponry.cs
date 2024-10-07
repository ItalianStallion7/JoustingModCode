using System;
using System.Linq;
using System.Runtime.CompilerServices;
using LogRaamJousting.Decoupling;
using TaleWorlds.Core;

namespace LogRaamJousting.Weapons
{
	// Token: 0x02000013 RID: 19
	public class AseraiWeaponry : IWeaponry
	{
		// Token: 0x0600003A RID: 58 RVA: 0x000031CB File Offset: 0x000013CB
		public AseraiWeaponry(Items items)
		{
			this.Items = items;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000031DD File Offset: 0x000013DD
		// (set) Token: 0x0600003C RID: 60 RVA: 0x000031E5 File Offset: 0x000013E5
		public Items Items { get; set; }

		// Token: 0x0600003D RID: 61 RVA: 0x000031F0 File Offset: 0x000013F0
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestCulturalEventWeapon()
		{
			return this.CulturalEventThrowingKnives();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003208 File Offset: 0x00001408
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestFactionLeaderWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 10;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.SingleSwordForFactionLeader();
			}
			else
			{
				bool flag2 = r <= 20;
				if (flag2)
				{
					valueTuple = this.ThrowingKnivesAndSwordForFactionLeader();
				}
				else
				{
					bool flag3 = r <= 50;
					if (flag3)
					{
						valueTuple = this.SwordAndShieldForFactionLeader();
					}
					else
					{
						valueTuple = this.LongSpearAndShieldForFactionLeader();
					}
				}
			}
			return valueTuple;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000326C File Offset: 0x0000146C
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestHeroWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 25;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.SingleSword();
			}
			else
			{
				bool flag2 = r <= 50;
				if (flag2)
				{
					valueTuple = this.ThrowingKnivesAndSword();
				}
				else
				{
					bool flag3 = r <= 75;
					if (flag3)
					{
						valueTuple = this.LongSpearAndShield();
					}
					else
					{
						valueTuple = this.SwordAndShield();
					}
				}
			}
			return valueTuple;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000032D0 File Offset: 0x000014D0
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestLordWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 10;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.SingleSwordForLord();
			}
			else
			{
				bool flag2 = r <= 20;
				if (flag2)
				{
					valueTuple = this.ThrowingKnivesAndSwordForLord();
				}
				else
				{
					bool flag3 = r <= 50;
					if (flag3)
					{
						valueTuple = this.LongSpearAndShieldForLord();
					}
					else
					{
						valueTuple = this.SwordAndShieldForLord();
					}
				}
			}
			return valueTuple;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003334 File Offset: 0x00001534
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestParticipantWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 25;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.SingleSword();
			}
			else
			{
				bool flag2 = r <= 75;
				if (flag2)
				{
					valueTuple = this.ThrowingKnivesAndSword();
				}
				else
				{
					valueTuple = this.SwordAndShield();
				}
			}
			return valueTuple;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003380 File Offset: 0x00001580
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestPlayerWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 25;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.SingleSword();
			}
			else
			{
				bool flag2 = r <= 50;
				if (flag2)
				{
					valueTuple = this.LongSpearAndShield();
				}
				else
				{
					bool flag3 = r <= 75;
					if (flag3)
					{
						valueTuple = this.ThrowingKnivesAndSword();
					}
					else
					{
						valueTuple = this.SwordAndShield();
					}
				}
			}
			return valueTuple;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000033E4 File Offset: 0x000015E4
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> CulturalEventThrowingKnives()
		{
			ItemObject itemObject = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "desert_throwing_knife_blunt");
			EquipmentElement weapon0;
			weapon0..ctor((itemObject != null) ? itemObject.ToEquipmentElement() : null, null, null, false);
			ItemObject itemObject2 = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "desert_throwing_knife_blunt");
			EquipmentElement weapon;
			weapon..ctor((itemObject2 != null) ? itemObject2.ToEquipmentElement() : null, null, null, false);
			ItemObject itemObject3 = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "desert_throwing_knife_blunt");
			EquipmentElement? weapon2 = new EquipmentElement?(new EquipmentElement((itemObject3 != null) ? itemObject3.ToEquipmentElement() : null, null, null, false));
			ItemObject itemObject4 = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "desert_throwing_knife_blunt");
			EquipmentElement weapon3;
			weapon3..ctor((itemObject4 != null) ? itemObject4.ToEquipmentElement() : null, null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), weapon2, new EquipmentElement?(weapon3));
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003524 File Offset: 0x00001724
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> LongSpearAndShield()
		{
			ItemObject itemObject = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "eastern_spear_1_t2_blunt");
			EquipmentElement weapon0;
			weapon0..ctor((itemObject != null) ? itemObject.ToEquipmentElement() : null, null, null, false);
			EquipmentElement weapon;
			weapon..ctor(Extensions.GetRandomElement<ItemObject>(this.Items.All.Where((ItemObject n) => n.StringId == "Bound_desert_round_sparring_shield" || n.StringId == "bound_adarga").ToList<ItemObject>()).ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), null, null);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000035E4 File Offset: 0x000017E4
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> LongSpearAndShieldForFactionLeader()
		{
			ItemObject itemObject = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "eastern_spear_1_t2_blunt");
			EquipmentElement weapon0;
			weapon0..ctor((itemObject != null) ? itemObject.ToEquipmentElement() : null, null, null, false);
			ItemObject randomElement = Extensions.GetRandomElement<ItemObject>(this.Items.All.Where((ItemObject n) => n.StringId == "curved_round_shield").ToList<ItemObject>());
			EquipmentElement weapon;
			weapon..ctor((randomElement != null) ? randomElement.ToEquipmentElement() : null, null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), null, null);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000036A8 File Offset: 0x000018A8
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> LongSpearAndShieldForLord()
		{
			ItemObject itemObject = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "eastern_spear_1_t2_blunt");
			EquipmentElement weapon0;
			weapon0..ctor((itemObject != null) ? itemObject.ToEquipmentElement() : null, null, null, false);
			ItemObject randomElement = Extensions.GetRandomElement<ItemObject>(this.Items.All.Where((ItemObject n) => n.StringId == "curved_round_shield").ToList<ItemObject>());
			EquipmentElement weapon;
			weapon..ctor((randomElement != null) ? randomElement.ToEquipmentElement() : null, null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), null, null);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000376C File Offset: 0x0000196C
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> SingleSword()
		{
			ItemObject itemObject = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "wooden_sword_t1");
			EquipmentElement weapon0;
			weapon0..ctor((itemObject != null) ? itemObject.ToEquipmentElement() : null, null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, null, null, null);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000037E4 File Offset: 0x000019E4
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> SingleSwordForFactionLeader()
		{
			ItemObject itemObject = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "wooden_sword_t2");
			EquipmentElement weapon0;
			weapon0..ctor((itemObject != null) ? itemObject.ToEquipmentElement() : null, null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, null, null, null);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000385C File Offset: 0x00001A5C
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> SingleSwordForLord()
		{
			ItemObject itemObject = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "wooden_sword_t2");
			EquipmentElement weapon0;
			weapon0..ctor((itemObject != null) ? itemObject.ToEquipmentElement() : null, null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, null, null, null);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000038D4 File Offset: 0x00001AD4
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> SwordAndShield()
		{
			ItemObject itemObject = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "wooden_sword_t1");
			EquipmentElement weapon0;
			weapon0..ctor((itemObject != null) ? itemObject.ToEquipmentElement() : null, null, null, false);
			ItemObject randomElement = Extensions.GetRandomElement<ItemObject>(this.Items.All.Where((ItemObject n) => n.StringId == "Bound_desert_round_sparring_shield" || n.StringId == "bound_adarga").ToList<ItemObject>());
			EquipmentElement weapon;
			weapon..ctor((randomElement != null) ? randomElement.ToEquipmentElement() : null, null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), null, null);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003998 File Offset: 0x00001B98
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> SwordAndShieldForFactionLeader()
		{
			ItemObject itemObject = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "wooden_sword_t2");
			EquipmentElement weapon0;
			weapon0..ctor((itemObject != null) ? itemObject.ToEquipmentElement() : null, null, null, false);
			ItemObject randomElement = Extensions.GetRandomElement<ItemObject>(this.Items.All.Where((ItemObject n) => n.StringId == "curved_round_shield").ToList<ItemObject>());
			EquipmentElement weapon;
			weapon..ctor((randomElement != null) ? randomElement.ToEquipmentElement() : null, null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), null, null);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003A5C File Offset: 0x00001C5C
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> SwordAndShieldForLord()
		{
			ItemObject itemObject = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "wooden_sword_t2");
			EquipmentElement weapon0;
			weapon0..ctor((itemObject != null) ? itemObject.ToEquipmentElement() : null, null, null, false);
			ItemObject randomElement = Extensions.GetRandomElement<ItemObject>(this.Items.All.Where((ItemObject n) => n.StringId == "curved_round_shield").ToList<ItemObject>());
			EquipmentElement weapon;
			weapon..ctor((randomElement != null) ? randomElement.ToEquipmentElement() : null, null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), null, null);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003B20 File Offset: 0x00001D20
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> ThrowingKnivesAndSword()
		{
			ItemObject itemObject = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "wooden_sword_t1");
			EquipmentElement weapon0;
			weapon0..ctor((itemObject != null) ? itemObject.ToEquipmentElement() : null, null, null, false);
			ItemObject itemObject2 = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "desert_throwing_knife_blunt");
			EquipmentElement weapon;
			weapon..ctor((itemObject2 != null) ? itemObject2.ToEquipmentElement() : null, null, null, false);
			ItemObject itemObject3 = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "desert_throwing_knife_blunt");
			EquipmentElement? weapon2 = new EquipmentElement?(new EquipmentElement((itemObject3 != null) ? itemObject3.ToEquipmentElement() : null, null, null, false));
			ItemObject itemObject4 = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "desert_throwing_knife_blunt");
			EquipmentElement weapon3;
			weapon3..ctor((itemObject4 != null) ? itemObject4.ToEquipmentElement() : null, null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), weapon2, new EquipmentElement?(weapon3));
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003C60 File Offset: 0x00001E60
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> ThrowingKnivesAndSwordForFactionLeader()
		{
			ItemObject itemObject = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "wooden_sword_t2");
			EquipmentElement weapon0;
			weapon0..ctor((itemObject != null) ? itemObject.ToEquipmentElement() : null, null, null, false);
			ItemObject itemObject2 = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "desert_throwing_knife_blunt");
			EquipmentElement weapon;
			weapon..ctor((itemObject2 != null) ? itemObject2.ToEquipmentElement() : null, null, null, false);
			ItemObject itemObject3 = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "desert_throwing_knife_blunt");
			EquipmentElement? weapon2 = new EquipmentElement?(new EquipmentElement((itemObject3 != null) ? itemObject3.ToEquipmentElement() : null, null, null, false));
			ItemObject itemObject4 = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "desert_throwing_knife_blunt");
			EquipmentElement weapon3;
			weapon3..ctor((itemObject4 != null) ? itemObject4.ToEquipmentElement() : null, null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), weapon2, new EquipmentElement?(weapon3));
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003DA0 File Offset: 0x00001FA0
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> ThrowingKnivesAndSwordForLord()
		{
			ItemObject itemObject = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "wooden_sword_t2");
			EquipmentElement weapon0;
			weapon0..ctor((itemObject != null) ? itemObject.ToEquipmentElement() : null, null, null, false);
			ItemObject itemObject2 = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "desert_throwing_knife_blunt");
			EquipmentElement weapon;
			weapon..ctor((itemObject2 != null) ? itemObject2.ToEquipmentElement() : null, null, null, false);
			ItemObject itemObject3 = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "desert_throwing_knife_blunt");
			EquipmentElement? weapon2 = new EquipmentElement?(new EquipmentElement((itemObject3 != null) ? itemObject3.ToEquipmentElement() : null, null, null, false));
			ItemObject itemObject4 = this.Items.All.FirstOrDefault((ItemObject n) => n.StringId == "desert_throwing_knife_blunt");
			EquipmentElement weapon3;
			weapon3..ctor((itemObject4 != null) ? itemObject4.ToEquipmentElement() : null, null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), weapon2, new EquipmentElement?(weapon3));
		}
	}
}
