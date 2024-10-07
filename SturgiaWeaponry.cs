using System;
using System.Linq;
using System.Runtime.CompilerServices;
using LogRaamJousting.Decoupling;
using TaleWorlds.Core;

namespace LogRaamJousting.Weapons
{
	// Token: 0x02000018 RID: 24
	public class SturgiaWeaponry : IWeaponry
	{
		// Token: 0x0600008B RID: 139 RVA: 0x0000565C File Offset: 0x0000385C
		public SturgiaWeaponry(Items items)
		{
			this.Items = items;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0000566E File Offset: 0x0000386E
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00005676 File Offset: 0x00003876
		public Items Items { get; set; }

		// Token: 0x0600008E RID: 142 RVA: 0x00005680 File Offset: 0x00003880
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestCulturalEventWeapon()
		{
			return this.CulturalEventThrowingAxes();
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00005698 File Offset: 0x00003898
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestFactionLeaderWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 10;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.LordThrowingAxe();
			}
			else
			{
				bool flag2 = r <= 20;
				if (flag2)
				{
					valueTuple = this.LordAxe();
				}
				else
				{
					bool flag3 = r <= 40;
					if (flag3)
					{
						valueTuple = this.LordAxeAndShield();
					}
					else
					{
						bool flag4 = r <= 70;
						if (flag4)
						{
							valueTuple = this.LordSpearAndShield();
						}
						else
						{
							valueTuple = this.LordSwordAndShield();
						}
					}
				}
			}
			return valueTuple;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00005710 File Offset: 0x00003910
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestHeroWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 15;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.ThrowingAxe();
			}
			else
			{
				bool flag2 = r <= 40;
				if (flag2)
				{
					valueTuple = this.SwordAndShield();
				}
				else
				{
					bool flag3 = r <= 60;
					if (flag3)
					{
						valueTuple = this.AxeAndShield();
					}
					else
					{
						bool flag4 = r <= 80;
						if (flag4)
						{
							valueTuple = this.Axe();
						}
						else
						{
							valueTuple = this.SpearAndShield();
						}
					}
				}
			}
			return valueTuple;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00005788 File Offset: 0x00003988
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestLordWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 10;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.LordThrowingAxe();
			}
			else
			{
				bool flag2 = r <= 25;
				if (flag2)
				{
					valueTuple = this.LordAxe();
				}
				else
				{
					bool flag3 = r <= 50;
					if (flag3)
					{
						valueTuple = this.LordAxeAndShield();
					}
					else
					{
						bool flag4 = r <= 70;
						if (flag4)
						{
							valueTuple = this.LordSpearAndShield();
						}
						else
						{
							valueTuple = this.LordSwordAndShield();
						}
					}
				}
			}
			return valueTuple;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00005800 File Offset: 0x00003A00
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestParticipantWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 30;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.ThrowingAxe();
			}
			else
			{
				bool flag2 = r <= 60;
				if (flag2)
				{
					valueTuple = this.Axe();
				}
				else
				{
					bool flag3 = r <= 80;
					if (flag3)
					{
						valueTuple = this.AxeAndShield();
					}
					else
					{
						bool flag4 = r <= 90;
						if (flag4)
						{
							valueTuple = this.SwordAndShield();
						}
						else
						{
							valueTuple = this.SpearAndShield();
						}
					}
				}
			}
			return valueTuple;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00005878 File Offset: 0x00003A78
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestPlayerWeapon()
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			bool flag = r <= 20;
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple;
			if (flag)
			{
				valueTuple = this.ThrowingAxe();
			}
			else
			{
				bool flag2 = r <= 40;
				if (flag2)
				{
					valueTuple = this.SwordAndShield();
				}
				else
				{
					bool flag3 = r <= 60;
					if (flag3)
					{
						valueTuple = this.AxeAndShield();
					}
					else
					{
						bool flag4 = r <= 80;
						if (flag4)
						{
							valueTuple = this.Axe();
						}
						else
						{
							valueTuple = this.SpearAndShield();
						}
					}
				}
			}
			return valueTuple;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000058F0 File Offset: 0x00003AF0
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> Axe()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "sturgia_axe_2_t2_blunt").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, null, null, null);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00005964 File Offset: 0x00003B64
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> AxeAndShield()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "sturgia_axe_2_t2_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(this.Items.All.First((ItemObject n) => n.StringId == "sturgia_old_shield_b").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), null, null);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00005A10 File Offset: 0x00003C10
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> CulturalEventThrowingAxes()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "northern_throwing_axe_1_t1_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(this.Items.All.First((ItemObject n) => n.StringId == "northern_throwing_axe_1_t1_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon2;
			weapon2..ctor(this.Items.All.First((ItemObject n) => n.StringId == "northern_throwing_axe_1_t1_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon3;
			weapon3..ctor(this.Items.All.First((ItemObject n) => n.StringId == "northern_throwing_axe_1_t1_blunt").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), new EquipmentElement?(weapon2), new EquipmentElement?(weapon3));
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00005B34 File Offset: 0x00003D34
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> LordAxe()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "sturgia_axe_2_t2_blunt").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, null, null, null);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00005BA8 File Offset: 0x00003DA8
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> LordAxeAndShield()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "sturgia_axe_2_t2_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(this.Items.All.First((ItemObject n) => n.StringId == "northern_round_sparring_shield").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), null, null);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00005C54 File Offset: 0x00003E54
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> LordSpearAndShield()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "northern_spear_1_t2_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(this.Items.All.First((ItemObject n) => n.StringId == "northern_round_sparring_shield").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), null, null);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00005D00 File Offset: 0x00003F00
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> LordSwordAndShield()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "wooden_sword_t2").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(this.Items.All.First((ItemObject n) => n.StringId == "northern_round_sparring_shield").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), null, null);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00005DAC File Offset: 0x00003FAC
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> LordThrowingAxe()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "wooden_sword_t2").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(this.Items.All.First((ItemObject n) => n.StringId == "northern_throwing_axe_1_t1_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon2;
			weapon2..ctor(this.Items.All.First((ItemObject n) => n.StringId == "northern_throwing_axe_1_t1_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon3;
			weapon3..ctor(this.Items.All.First((ItemObject n) => n.StringId == "northern_throwing_axe_1_t1_blunt").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), new EquipmentElement?(weapon2), new EquipmentElement?(weapon3));
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00005ED0 File Offset: 0x000040D0
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> SpearAndShield()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "northern_spear_1_t2_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(this.Items.All.First((ItemObject n) => n.StringId == "sturgia_old_shield_b").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), null, null);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00005F7C File Offset: 0x0000417C
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> SwordAndShield()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "wooden_sword_t1").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(this.Items.All.First((ItemObject n) => n.StringId == "sturgia_old_shield_b").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), null, null);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00006028 File Offset: 0x00004228
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		private ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> ThrowingAxe()
		{
			EquipmentElement weapon0;
			weapon0..ctor(this.Items.All.First((ItemObject n) => n.StringId == "seax_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon;
			weapon..ctor(this.Items.All.First((ItemObject n) => n.StringId == "northern_throwing_axe_1_t1_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon2;
			weapon2..ctor(this.Items.All.First((ItemObject n) => n.StringId == "northern_throwing_axe_1_t1_blunt").ToEquipmentElement(), null, null, false);
			EquipmentElement weapon3;
			weapon3..ctor(this.Items.All.First((ItemObject n) => n.StringId == "northern_throwing_axe_1_t1_blunt").ToEquipmentElement(), null, null, false);
			return new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(weapon0, new EquipmentElement?(weapon), new EquipmentElement?(weapon2), new EquipmentElement?(weapon3));
		}
	}
}
