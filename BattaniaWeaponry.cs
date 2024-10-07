using System;
using System.Linq;
using System.Runtime.CompilerServices;
using LogRaamJousting.Decoupling;
using TaleWorlds.Core;

namespace LogRaamJousting.Weapons
{
	// Token: 0x02000014 RID: 20
	public class BattaniaWeaponry : IWeaponry
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00003EE0 File Offset: 0x000020E0
		public BattaniaWeaponry(Items items)
		{
			this.Items = items;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00003EF2 File Offset: 0x000020F2
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00003EFA File Offset: 0x000020FA
		public Items Items { get; set; }

		// Token: 0x06000053 RID: 83 RVA: 0x00003F04 File Offset: 0x00002104
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestCulturalEventWeapon()
		{
			return this.Lord2hMaul();
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003F1C File Offset: 0x0000211C
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestFactionLeaderWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 40;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.Lord2hSword();
			}
			else
			{
				bool flag2 = r <= 80;
				if (flag2)
				{
					valueTuple = this.LordArcherWithSwordAndTarge();
				}
				else
				{
					valueTuple = this.Lord2hMaul();
				}
			}
			return valueTuple;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003F68 File Offset: 0x00002168
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestHeroWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 35;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.TwoHandedSword();
			}
			else
			{
				bool flag2 = r <= 70;
				if (flag2)
				{
					valueTuple = this.ArcherWithSwordAndTarge();
				}
				else
				{
					valueTuple = this.TwoHandedMaul();
				}
			}
			return valueTuple;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003FB4 File Offset: 0x000021B4
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestLordWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 30;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.Lord2hSword();
			}
			else
			{
				bool flag2 = r <= 70;
				if (flag2)
				{
					valueTuple = this.LordArcherWithSwordAndTarge();
				}
				else
				{
					valueTuple = this.Lord2hMaul();
				}
			}
			return valueTuple;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004000 File Offset: 0x00002200
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestParticipantWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 25;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.TwoHandedSword();
			}
			else
			{
				bool flag2 = r <= 70;
				if (flag2)
				{
					valueTuple = this.ArcherWithSwordAndTarge();
				}
				else
				{
					valueTuple = this.TwoHandedMaul();
				}
			}
			return valueTuple;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000404C File Offset: 0x0000224C
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestPlayerWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 40;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.TwoHandedSword();
			}
			else
			{
				bool flag2 = r <= 70;
				if (flag2)
				{
					valueTuple = this.ArcherWithSwordAndTarge();
				}
				else
				{
					valueTuple = this.TwoHandedMaul();
				}
			}
			return valueTuple;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004098 File Offset: 0x00002298
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> ArcherWithSwordAndTarge()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "wooden_sword_t1").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(this.Items.All.First((ItemObject n) => n.StringId == "battania_targe_b_sparring").ToEquipmentElement(), null, null, false);
			EquipmentElement? weapon2 = new EquipmentElement?(new EquipmentElement(this.Items.All.First((ItemObject n) => n.StringId == "hunting_bow").ToEquipmentElement(), null, null, false));
			EquipmentElement? weapon3 = new EquipmentElement?(new EquipmentElement(this.Items.All.First((ItemObject n) => n.StringId == "blunt_arrows").ToEquipmentElement(), null, null, false));
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), weapon2, weapon3);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000041BC File Offset: 0x000023BC
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> Lord2hMaul()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "peasant_maul_t1_2").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, null, null, null);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00004230 File Offset: 0x00002430
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> Lord2hSword()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "battania_2hsword_1_t2_blunt").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, null, null, null);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000042A4 File Offset: 0x000024A4
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> LordArcherWithSwordAndTarge()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "wooden_sword_t2").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(this.Items.All.First((ItemObject n) => n.StringId == "battania_targe_b_sparring").ToEquipmentElement(), null, null, false);
			EquipmentElement? weapon2 = new EquipmentElement?(new EquipmentElement(this.Items.All.First((ItemObject n) => n.StringId == "hunting_bow").ToEquipmentElement(), null, null, false));
			EquipmentElement? weapon3 = new EquipmentElement?(new EquipmentElement(this.Items.All.First((ItemObject n) => n.StringId == "blunt_arrows").ToEquipmentElement(), null, null, false));
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), weapon2, weapon3);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000043C8 File Offset: 0x000025C8
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> TwoHandedMaul()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "peasant_maul_t1").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, null, null, null);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000443C File Offset: 0x0000263C
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> TwoHandedSword()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "wooden_2hsword_t1").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, null, null, null);
		}
	}
}
