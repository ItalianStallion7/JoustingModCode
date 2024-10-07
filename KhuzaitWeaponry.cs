using System;
using System.Linq;
using System.Runtime.CompilerServices;
using LogRaamJousting.Decoupling;
using TaleWorlds.Core;

namespace LogRaamJousting.Weapons
{
	// Token: 0x02000017 RID: 23
	public class KhuzaitWeaponry : IWeaponry
	{
		// Token: 0x06000079 RID: 121 RVA: 0x00004DF6 File Offset: 0x00002FF6
		public KhuzaitWeaponry(Items items)
		{
			this.Items = items;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00004E08 File Offset: 0x00003008
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00004E10 File Offset: 0x00003010
		public Items Items { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00004E19 File Offset: 0x00003019
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00004E21 File Offset: 0x00003021
		public JoustLogger Logger { get; set; }

		// Token: 0x0600007E RID: 126 RVA: 0x00004E2C File Offset: 0x0000302C
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestCulturalEventWeapon()
		{
			return this.CulturalEventBow();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004E44 File Offset: 0x00003044
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestFactionLeaderWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 20;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.LordSwordAndDagger();
			}
			else
			{
				bool flag2 = r <= 60;
				if (flag2)
				{
					valueTuple = this.LordArcherWithSword();
				}
				else
				{
					valueTuple = this.LordSpear();
				}
			}
			return valueTuple;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004E90 File Offset: 0x00003090
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestHeroWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 33;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.ArcherWithSword();
			}
			else
			{
				bool flag2 = r <= 67;
				if (flag2)
				{
					valueTuple = this.Spear();
				}
				else
				{
					valueTuple = this.SwordAndDagger();
				}
			}
			return valueTuple;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004EDC File Offset: 0x000030DC
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestLordWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 20;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.LordSwordAndDagger();
			}
			else
			{
				bool flag2 = r <= 80;
				if (flag2)
				{
					valueTuple = this.LordArcherWithSword();
				}
				else
				{
					valueTuple = this.LordSpear();
				}
			}
			return valueTuple;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00004F28 File Offset: 0x00003128
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestParticipantWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 40;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.ArcherWithSword();
			}
			else
			{
				bool flag2 = r <= 70;
				if (flag2)
				{
					valueTuple = this.Spear();
				}
				else
				{
					valueTuple = this.SwordAndDagger();
				}
			}
			return valueTuple;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004F74 File Offset: 0x00003174
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestPlayerWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 40;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.ArcherWithSword();
			}
			else
			{
				bool flag2 = r <= 70;
				if (flag2)
				{
					valueTuple = this.Spear();
				}
				else
				{
					valueTuple = this.SwordAndDagger();
				}
			}
			return valueTuple;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00004FC0 File Offset: 0x000031C0
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> ArcherWithSword()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "training_bow").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(this.Items.All.First((ItemObject n) => n.StringId == "blunt_arrows").ToEquipmentElement(), null, null, false);
			EquipmentElement? weapon2 = new EquipmentElement?(new EquipmentElement(this.Items.All.First((ItemObject n) => n.StringId == "blunt_arrows").ToEquipmentElement(), null, null, false));
			EquipmentElement weapon3;
			weapon3..ctor(this.Items.All.First((ItemObject n) => n.StringId == "wooden_sword_t1").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), weapon2, new EquipmentElement?(weapon3));
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000050E4 File Offset: 0x000032E4
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> CulturalEventBow()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "training_bow").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(this.Items.All.First((ItemObject n) => n.StringId == "blunt_arrows").ToEquipmentElement(), null, null, false);
			EquipmentElement? weapon2 = new EquipmentElement?(new EquipmentElement(this.Items.All.First((ItemObject n) => n.StringId == "blunt_arrows").ToEquipmentElement(), null, null, false));
			EquipmentElement weapon3;
			weapon3..ctor(this.Items.All.First((ItemObject n) => n.StringId == "blunt_arrows").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), weapon2, new EquipmentElement?(weapon3));
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00005208 File Offset: 0x00003408
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> LordArcherWithSword()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "training_bow").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(this.Items.All.First((ItemObject n) => n.StringId == "blunt_arrows").ToEquipmentElement(), null, null, false);
			EquipmentElement? weapon2 = new EquipmentElement?(new EquipmentElement(this.Items.All.First((ItemObject n) => n.StringId == "blunt_arrows").ToEquipmentElement(), null, null, false));
			EquipmentElement weapon3;
			weapon3..ctor(this.Items.All.First((ItemObject n) => n.StringId == "wooden_sword_t2").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), weapon2, new EquipmentElement?(weapon3));
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000532C File Offset: 0x0000352C
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> LordSpear()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "khuzait_polearm_1_t4_blunt").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, null, null, null);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000053A0 File Offset: 0x000035A0
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> LordSwordAndDagger()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "wooden_sword_t2").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(this.Items.All.First((ItemObject n) => n.StringId == "leafblade_throwing_knife").ToEquipmentElement(), null, null, false);
			EquipmentElement? weapon2 = new EquipmentElement?(new EquipmentElement(this.Items.All.First((ItemObject n) => n.StringId == "leafblade_throwing_knife").ToEquipmentElement(), null, null, false));
			EquipmentElement? weapon3 = new EquipmentElement?(new EquipmentElement(this.Items.All.First((ItemObject n) => n.StringId == "leafblade_throwing_knife").ToEquipmentElement(), null, null, false));
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), weapon2, weapon3);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000054C4 File Offset: 0x000036C4
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> Spear()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "eastern_spear_1_t2_blunt").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, null, null, null);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00005538 File Offset: 0x00003738
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> SwordAndDagger()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "wooden_sword_t1").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(this.Items.All.First((ItemObject n) => n.StringId == "leafblade_throwing_knife").ToEquipmentElement(), null, null, false);
			EquipmentElement? weapon2 = new EquipmentElement?(new EquipmentElement(this.Items.All.First((ItemObject n) => n.StringId == "leafblade_throwing_knife").ToEquipmentElement(), null, null, false));
			EquipmentElement? weapon3 = new EquipmentElement?(new EquipmentElement(this.Items.All.First((ItemObject n) => n.StringId == "leafblade_throwing_knife").ToEquipmentElement(), null, null, false));
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), weapon2, weapon3);
		}
	}
}
