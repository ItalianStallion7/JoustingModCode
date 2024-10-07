using System;
using System.Linq;
using System.Runtime.CompilerServices;
using LogRaamJousting.Decoupling;
using TaleWorlds.Core;

namespace LogRaamJousting.Weapons
{
	// Token: 0x02000019 RID: 25
	public class VlandiaWeaponry : IWeaponry
	{
		// Token: 0x0600009F RID: 159 RVA: 0x0000614C File Offset: 0x0000434C
		public VlandiaWeaponry(Items items)
		{
			this.Items = items;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0000615E File Offset: 0x0000435E
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00006166 File Offset: 0x00004366
		public Items Items { get; set; }

		// Token: 0x060000A2 RID: 162 RVA: 0x00006170 File Offset: 0x00004370
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestCulturalEventWeapon()
		{
			return this.CulturalEventCrossbow();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00006188 File Offset: 0x00004388
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestFactionLeaderWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 33;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.LordSwordAndShield();
			}
			else
			{
				bool flag2 = r <= 67;
				if (flag2)
				{
					valueTuple = this.LordLanceAndShield();
				}
				else
				{
					valueTuple = this.LordCrossbowAndSword();
				}
			}
			return valueTuple;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000061D4 File Offset: 0x000043D4
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestHeroWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 33;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.SwordAndShield();
			}
			else
			{
				bool flag2 = r <= 67;
				if (flag2)
				{
					valueTuple = this.LanceAndShield();
				}
				else
				{
					valueTuple = this.CrossbowAndSword();
				}
			}
			return valueTuple;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00006220 File Offset: 0x00004420
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestLordWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 40;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.LordSwordAndShield();
			}
			else
			{
				bool flag2 = r <= 70;
				if (flag2)
				{
					valueTuple = this.LordLanceAndShield();
				}
				else
				{
					valueTuple = this.LordCrossbowAndSword();
				}
			}
			return valueTuple;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000626C File Offset: 0x0000446C
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestParticipantWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 50;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.BillhookPolearm();
			}
			else
			{
				valueTuple = this.LanceAndShield();
			}
			return valueTuple;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000062A4 File Offset: 0x000044A4
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestPlayerWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 33;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.SwordAndShield();
			}
			else
			{
				bool flag2 = r <= 67;
				if (flag2)
				{
					valueTuple = this.LanceAndShield();
				}
				else
				{
					bool flag3 = r <= 100;
					if (flag3)
					{
						valueTuple = this.CrossbowAndSword();
					}
					else
					{
						EquipmentElement weapon0;
						weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "wooden_sword_t2").ToEquipmentElement(), null, null, false);
						valueTuple = new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, null, null, null);
					}
				}
			}
			return valueTuple;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00006368 File Offset: 0x00004568
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> BillhookPolearm()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "billhook_polearm_t2_blunt").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, null, null, null);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000063DC File Offset: 0x000045DC
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> CrossbowAndSword()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "crossbow_a_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(this.Items.All.First((ItemObject n) => n.StringId == "tournament_bolts").ToEquipmentElement(), null, null, false);
			EquipmentElement? weapon2 = new EquipmentElement?(new EquipmentElement(this.Items.All.First((ItemObject n) => n.StringId == "tournament_bolts").ToEquipmentElement(), null, null, false));
			EquipmentElement weapon3;
			weapon3..ctor(this.Items.All.First((ItemObject n) => n.StringId == "wooden_sword_t1").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), weapon2, new EquipmentElement?(weapon3));
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00006500 File Offset: 0x00004700
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> CulturalEventCrossbow()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "crossbow_a_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(this.Items.All.First((ItemObject n) => n.StringId == "tournament_bolts").ToEquipmentElement(), null, null, false);
			EquipmentElement? weapon2 = new EquipmentElement?(new EquipmentElement(this.Items.All.First((ItemObject n) => n.StringId == "tournament_bolts").ToEquipmentElement(), null, null, false));
			EquipmentElement weapon3;
			weapon3..ctor(this.Items.All.First((ItemObject n) => n.StringId == "tournament_bolts").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), weapon2, new EquipmentElement?(weapon3));
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00006624 File Offset: 0x00004824
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> LanceAndShield()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "vlandia_lance_1_t3_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(Extensions.GetRandomElement<ItemObject>(this.Items.All.Where((ItemObject n) => n.StringId == "western_kite_sparring_shield" || n.StringId == "western_riders_kite_sparring_shield").ToList<ItemObject>()).ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), null, null);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000066DC File Offset: 0x000048DC
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> LordCrossbowAndSword()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "crossbow_a_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(this.Items.All.First((ItemObject n) => n.StringId == "tournament_bolts").ToEquipmentElement(), null, null, false);
			EquipmentElement? weapon2 = new EquipmentElement?(new EquipmentElement(this.Items.All.First((ItemObject n) => n.StringId == "tournament_bolts").ToEquipmentElement(), null, null, false));
			EquipmentElement weapon3;
			weapon3..ctor(this.Items.All.First((ItemObject n) => n.StringId == "wooden_sword_t2").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), weapon2, new EquipmentElement?(weapon3));
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00006800 File Offset: 0x00004A00
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> LordLanceAndShield()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "vlandia_lance_1_t3_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(this.Items.All.First((ItemObject n) => n.StringId == "jousting_shield").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), null, null);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000068AC File Offset: 0x00004AAC
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> LordSwordAndShield()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "wooden_sword_t2").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(this.Items.All.First((ItemObject n) => n.StringId == "jousting_shield").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), null, null);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00006958 File Offset: 0x00004B58
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> SwordAndShield()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "wooden_sword_t1").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(Extensions.GetRandomElement<ItemObject>(this.Items.All.Where((ItemObject n) => n.StringId == "western_kite_sparring_shield" || n.StringId == "western_riders_kite_sparring_shield").ToList<ItemObject>()).ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), null, null);
		}
	}
}
