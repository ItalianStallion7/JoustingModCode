using System;
using System.Linq;
using System.Runtime.CompilerServices;
using LogRaamJousting.Decoupling;
using TaleWorlds.Core;

namespace LogRaamJousting.Weapons
{
	// Token: 0x02000015 RID: 21
	public class EmpireWeaponry : IWeaponry
	{
		// Token: 0x0600005F RID: 95 RVA: 0x000044AD File Offset: 0x000026AD
		public EmpireWeaponry(Items items)
		{
			this.Items = items;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000044BF File Offset: 0x000026BF
		// (set) Token: 0x06000061 RID: 97 RVA: 0x000044C7 File Offset: 0x000026C7
		public Items Items { get; set; }

		// Token: 0x06000062 RID: 98 RVA: 0x000044D0 File Offset: 0x000026D0
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestCulturalEventWeapon()
		{
			return this.CulturalEventJavelin();
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000044E8 File Offset: 0x000026E8
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestFactionLeaderWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 10;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.LordJavelinThrower();
			}
			else
			{
				bool flag2 = r <= 20;
				if (flag2)
				{
					valueTuple = this.LordFork();
				}
				else
				{
					bool flag3 = r <= 50;
					if (flag3)
					{
						valueTuple = this.LordSpearAndShield();
					}
					else
					{
						valueTuple = this.LordSwordAndShield();
					}
				}
			}
			return valueTuple;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000454C File Offset: 0x0000274C
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestHeroWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 25;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.Fork();
			}
			else
			{
				bool flag2 = r <= 50;
				if (flag2)
				{
					valueTuple = this.JavelinThrower();
				}
				else
				{
					bool flag3 = r <= 75;
					if (flag3)
					{
						valueTuple = this.SpearAndShield();
					}
					else
					{
						valueTuple = this.SwordAndShield();
					}
				}
			}
			return valueTuple;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000045B0 File Offset: 0x000027B0
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestLordWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 10;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.LordJavelinThrower();
			}
			else
			{
				bool flag2 = r <= 20;
				if (flag2)
				{
					valueTuple = this.LordFork();
				}
				else
				{
					bool flag3 = r <= 60;
					if (flag3)
					{
						valueTuple = this.LordSpearAndShield();
					}
					else
					{
						valueTuple = this.LordSwordAndShield();
					}
				}
			}
			return valueTuple;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00004614 File Offset: 0x00002814
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestParticipantWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 33;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.Fork();
			}
			else
			{
				bool flag2 = r <= 66;
				if (flag2)
				{
					valueTuple = this.JavelinThrower();
				}
				else
				{
					valueTuple = this.SpearAndShield();
				}
			}
			return valueTuple;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00004660 File Offset: 0x00002860
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestPlayerWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 25;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.Fork();
			}
			else
			{
				bool flag2 = r <= 50;
				if (flag2)
				{
					valueTuple = this.JavelinThrower();
				}
				else
				{
					bool flag3 = r <= 75;
					if (flag3)
					{
						valueTuple = this.SpearAndShield();
					}
					else
					{
						valueTuple = this.SwordAndShield();
					}
				}
			}
			return valueTuple;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000046C4 File Offset: 0x000028C4
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> CulturalEventJavelin()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "western_javelin_1_t2_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(this.Items.All.First((ItemObject n) => n.StringId == "western_javelin_1_t2_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon2;
			weapon2..ctor(this.Items.All.First((ItemObject n) => n.StringId == "western_javelin_1_t2_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon3;
			weapon3..ctor(this.Items.All.First((ItemObject n) => n.StringId == "western_javelin_1_t2_blunt").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), new EquipmentElement?(weapon2), new EquipmentElement?(weapon3));
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000047E8 File Offset: 0x000029E8
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> Fork()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "military_fork_t2").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, null, null, null);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000485C File Offset: 0x00002A5C
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> JavelinThrower()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "western_javelin_1_t2_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(this.Items.All.First((ItemObject n) => n.StringId == "western_javelin_1_t2_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon2;
			weapon2..ctor(this.Items.All.First((ItemObject n) => n.StringId == "western_javelin_1_t2_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon3;
			weapon3..ctor(this.Items.All.First((ItemObject n) => n.StringId == "wooden_sword_t1").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), new EquipmentElement?(weapon2), new EquipmentElement?(weapon3));
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004980 File Offset: 0x00002B80
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> LordFork()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "military_fork_pike_t3").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, null, null, null);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000049F4 File Offset: 0x00002BF4
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> LordJavelinThrower()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "western_javelin_1_t2_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(this.Items.All.First((ItemObject n) => n.StringId == "western_javelin_1_t2_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon2;
			weapon2..ctor(this.Items.All.First((ItemObject n) => n.StringId == "western_javelin_1_t2_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon3;
			weapon3..ctor(this.Items.All.First((ItemObject n) => n.StringId == "wooden_sword_t2").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), new EquipmentElement?(weapon2), new EquipmentElement?(weapon3));
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00004B18 File Offset: 0x00002D18
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> LordSpearAndShield()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "empire_lance_1_t3_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(Extensions.GetRandomElement<ItemObject>(this.Items.All.Where((ItemObject n) => n.StringId == "simple_horsemans_kite_shield" || n.StringId == "simple_kite_shield" || n.StringId == "worn_kite_shield").ToList<ItemObject>()).ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), null, null);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004BD0 File Offset: 0x00002DD0
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> LordSwordAndShield()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "wooden_sword_t2").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(Extensions.GetRandomElement<ItemObject>(this.Items.All.Where((ItemObject n) => n.StringId == "simple_kite_shield" || n.StringId == "worn_kite_shield").ToList<ItemObject>()).ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), null, null);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004C88 File Offset: 0x00002E88
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> SpearAndShield()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "empire_lance_1_t3_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(Extensions.GetRandomElement<ItemObject>(this.Items.All.Where((ItemObject n) => n.StringId == "simple_horsemans_kite_shield" || n.StringId == "simple_kite_shield" || n.StringId == "worn_kite_shield").ToList<ItemObject>()).ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), null, null);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00004D40 File Offset: 0x00002F40
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> SwordAndShield()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "wooden_sword_t1").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(Extensions.GetRandomElement<ItemObject>(this.Items.All.Where((ItemObject n) => n.StringId == "simple_kite_shield" || n.StringId == "worn_kite_shield").ToList<ItemObject>()).ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), null, null);
		}
	}
}
