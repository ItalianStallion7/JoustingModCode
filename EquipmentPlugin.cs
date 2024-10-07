using System;
using System.Runtime.CompilerServices;
using LogRaamJousting.Armors;
using LogRaamJousting.Configuration;
using LogRaamJousting.Decoupling;
using LogRaamJousting.Factory;
using LogRaamJousting.Stables;
using LogRaamJousting.Weapons;
using TaleWorlds.CampaignSystem.TournamentGames;
using TaleWorlds.Core;

namespace LogRaamJousting.Equipments
{
	// Token: 0x02000034 RID: 52
	public class EquipmentPlugin
	{
		// Token: 0x06000156 RID: 342 RVA: 0x00007EA7 File Offset: 0x000060A7
		public EquipmentPlugin(ISetup setup, IConfig config, string tournamentCulture, Participant participant)
		{
			this._get = setup;
			this._config = config;
			this._tournamentCulture = tournamentCulture;
			this.Participant = participant;
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00007ECF File Offset: 0x000060CF
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00007ED7 File Offset: 0x000060D7
		public Participant Participant { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00007EE0 File Offset: 0x000060E0
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00007EE8 File Offset: 0x000060E8
		public TournamentTeam Team { get; set; }

		// Token: 0x0600015B RID: 347 RVA: 0x00007EF4 File Offset: 0x000060F4
		public ArmorTier ArmorQualityBonus()
		{
			bool isPlayer = this.Participant.IsPlayer;
			ArmorTier armorTier;
			if (isPlayer)
			{
				armorTier = ArmorTier.Wanderer;
			}
			else
			{
				bool isSoldier = this.Participant.IsSoldier;
				if (isSoldier)
				{
					armorTier = ArmorTier.Soldier;
				}
				else
				{
					bool isWanderer = this.Participant.IsWanderer;
					if (isWanderer)
					{
						armorTier = ArmorTier.Wanderer;
					}
					else
					{
						bool isLord = this.Participant.IsLord;
						if (isLord)
						{
							armorTier = ArmorTier.Lord;
						}
						else
						{
							bool isFactionLeader = this.Participant.IsFactionLeader;
							if (isFactionLeader)
							{
								armorTier = ArmorTier.FactionLeader;
							}
							else
							{
								armorTier = ArmorTier.Wanderer;
							}
						}
					}
				}
			}
			return armorTier;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00007F6C File Offset: 0x0000616C
		public Equipment EquipCulturalEvent(IWeaponry weaponry, IArmoury armoury, IStable stable)
		{
			Equipment result = new Equipment();
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> valueTuple = weaponry.RequestCulturalEventWeapon();
			EquipmentElement weapon0 = valueTuple.Item1;
			EquipmentElement? weapon = valueTuple.Item2;
			EquipmentElement? weapon2 = valueTuple.Item3;
			EquipmentElement? weapon3 = valueTuple.Item4;
			this.PrepareWeapons(weapon0, weapon, weapon2, weapon3, ref result);
			ValueTuple<EquipmentElement, EquipmentElement, EquipmentElement> valueTuple2 = armoury.RequestArmorForLevel(this.ArmorQualityBonus());
			EquipmentElement bodyArmor = valueTuple2.Item1;
			EquipmentElement headArmor = valueTuple2.Item2;
			EquipmentElement shoes = valueTuple2.Item3;
			this.PrepareProtectiveGears(bodyArmor, headArmor, shoes, ref result);
			EquipmentElement mount = stable.RequestMount();
			this.PrepareMount(mount, ref result);
			return result;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00007FFC File Offset: 0x000061FC
		public Equipment EquipFactionLeader(IConfigLoader configLoader, string culture, IWeaponry weaponry, IArmoury armoury, IStable stable)
		{
			Equipment result = new Equipment();
			ValueTuple<EquipmentElement, EquipmentElement, EquipmentElement, EquipmentElement> valueTuple = this.RetrieveParticipantWeapons();
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> weapons = new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(valueTuple.Item1, new EquipmentElement?(valueTuple.Item2), new EquipmentElement?(valueTuple.Item3), new EquipmentElement?(valueTuple.Item4));
			bool flag = this._get.Configuration.HostShouldProvideWeapons(culture);
			if (flag)
			{
				weapons = weaponry.RequestFactionLeaderWeapon();
			}
			this.PrepareWeapons(weapons.Item1, weapons.Item2, weapons.Item3, weapons.Item4, ref result);
			this.EquipArmor(configLoader, culture, armoury, ref result);
			EquipmentElement mount = stable.RequestMount(weapons);
			this.PrepareMount(mount, ref result);
			return result;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000080AC File Offset: 0x000062AC
		public Equipment EquipHero(IConfigLoader configLoader, string culture, IWeaponry weaponry, IArmoury armoury, IStable stable, int MountedChanceBonus)
		{
			Equipment result = new Equipment();
			ValueTuple<EquipmentElement, EquipmentElement, EquipmentElement, EquipmentElement> valueTuple = this.RetrieveParticipantWeapons();
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> weapons = new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(valueTuple.Item1, new EquipmentElement?(valueTuple.Item2), new EquipmentElement?(valueTuple.Item3), new EquipmentElement?(valueTuple.Item4));
			bool flag = this._get.Configuration.HostShouldProvideWeapons(culture);
			if (flag)
			{
				weapons = weaponry.RequestHeroWeapon();
			}
			this.PrepareWeapons(weapons.Item1, weapons.Item2, weapons.Item3, weapons.Item4, ref result);
			this.EquipArmor(configLoader, culture, armoury, ref result);
			bool flag2 = !LogRaamRandom.EvalPercentage((float)(20 + this.Participant.Level));
			Equipment equipment;
			if (flag2)
			{
				equipment = result;
			}
			else
			{
				bool flag3 = this.CannotBeUsedOnHorse(weapons.Item1, weapons.Item2, weapons.Item3, weapons.Item4);
				if (flag3)
				{
					equipment = result;
				}
				else
				{
					bool flag4 = !LogRaamRandom.EvalPercentage((float)(MountedChanceBonus + this.Participant.Level));
					if (flag4)
					{
						equipment = result;
					}
					else
					{
						EquipmentElement mount = stable.RequestMount(weapons);
						this.PrepareMount(mount, ref result);
						equipment = result;
					}
				}
			}
			return equipment;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000081C8 File Offset: 0x000063C8
		public Equipment EquipLord(IConfigLoader configLoader, string culture, IWeaponry weaponry, IArmoury armoury, IStable stable)
		{
			Equipment result = new Equipment();
			ValueTuple<EquipmentElement, EquipmentElement, EquipmentElement, EquipmentElement> valueTuple = this.RetrieveParticipantWeapons();
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> weapons = new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(valueTuple.Item1, new EquipmentElement?(valueTuple.Item2), new EquipmentElement?(valueTuple.Item3), new EquipmentElement?(valueTuple.Item4));
			bool flag = this._get.Configuration.HostShouldProvideWeapons(culture);
			if (flag)
			{
				weapons = weaponry.RequestFactionLeaderWeapon();
			}
			this.PrepareWeapons(weapons.Item1, weapons.Item2, weapons.Item3, weapons.Item4, ref result);
			this.EquipArmor(configLoader, culture, armoury, ref result);
			EquipmentElement mount = stable.RequestMount(weapons);
			this.PrepareMount(mount, ref result);
			return result;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00008278 File Offset: 0x00006478
		public Equipment EquipParticipant(IConfigLoader configLoader, string culture, IWeaponry weaponry, IArmoury armoury)
		{
			Equipment result = new Equipment();
			ValueTuple<EquipmentElement, EquipmentElement, EquipmentElement, EquipmentElement> valueTuple = this.RetrieveParticipantWeapons();
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> weapons = new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(valueTuple.Item1, new EquipmentElement?(valueTuple.Item2), new EquipmentElement?(valueTuple.Item3), new EquipmentElement?(valueTuple.Item4));
			bool flag = this._get.Configuration.HostShouldProvideWeapons(culture);
			if (flag)
			{
				weapons = weaponry.RequestParticipantWeapon();
			}
			this.PrepareWeapons(weapons.Item1, weapons.Item2, weapons.Item3, weapons.Item4, ref result);
			this.EquipArmor(configLoader, culture, armoury, ref result);
			return result;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00008314 File Offset: 0x00006514
		public Equipment EquipPlayer(IConfigLoader configLoader, string culture, IWeaponry weaponry, IArmoury armoury, IStable stable, int MountedChanceBonus)
		{
			Equipment result = new Equipment();
			ValueTuple<EquipmentElement, EquipmentElement, EquipmentElement, EquipmentElement> valueTuple = this.RetrieveParticipantWeapons();
			ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> weapons = new ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?>(valueTuple.Item1, new EquipmentElement?(valueTuple.Item2), new EquipmentElement?(valueTuple.Item3), new EquipmentElement?(valueTuple.Item4));
			bool flag = this._get.Configuration.HostShouldProvideWeapons(culture);
			if (flag)
			{
				weapons = weaponry.RequestPlayerWeapon();
			}
			this.PrepareWeapons(weapons.Item1, weapons.Item2, weapons.Item3, weapons.Item4, ref result);
			this.EquipArmor(configLoader, culture, armoury, ref result);
			bool flag2 = this.CannotBeUsedOnHorse(weapons.Item1, weapons.Item2, weapons.Item3, weapons.Item4);
			Equipment equipment;
			if (flag2)
			{
				equipment = result;
			}
			else
			{
				bool flag3 = !LogRaamRandom.EvalPercentage((float)(MountedChanceBonus + this.Participant.Level));
				if (flag3)
				{
					equipment = result;
				}
				else
				{
					EquipmentElement mount = stable.RequestMount(weapons);
					this.PrepareMount(mount, ref result);
					equipment = result;
				}
			}
			return equipment;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000840D File Offset: 0x0000660D
		public void PrepareMount(EquipmentElement mount, ref Equipment equipment)
		{
			equipment.AddEquipmentToSlotWithoutAgent(10, mount);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000841C File Offset: 0x0000661C
		public void PrepareProtectiveGears(EquipmentElement bodyArmor, EquipmentElement headArmor, EquipmentElement shoes, ref Equipment result)
		{
			bool flag = this._config.ShouldBeNaked(this._tournamentCulture);
			if (!flag)
			{
				result.AddEquipmentToSlotWithoutAgent(6, bodyArmor);
				result.AddEquipmentToSlotWithoutAgent(5, headArmor);
				result.AddEquipmentToSlotWithoutAgent(7, shoes);
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00008464 File Offset: 0x00006664
		public void PrepareWeapons(EquipmentElement weapon0, EquipmentElement? weapon1, EquipmentElement? weapon2, EquipmentElement? weapon3, ref Equipment result)
		{
			result.AddEquipmentToSlotWithoutAgent(0, weapon0);
			bool flag = weapon1 != null;
			if (flag)
			{
				result.AddEquipmentToSlotWithoutAgent(1, weapon1.Value);
			}
			bool flag2 = weapon2 != null;
			if (flag2)
			{
				result.AddEquipmentToSlotWithoutAgent(2, weapon2.Value);
			}
			bool flag3 = weapon3 != null;
			if (flag3)
			{
				result.AddEquipmentToSlotWithoutAgent(3, weapon3.Value);
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000084D4 File Offset: 0x000066D4
		[return: TupleElementNames(new string[] { "bodyArmor", "headArmor", "shoes" })]
		public ValueTuple<EquipmentElement, EquipmentElement, EquipmentElement> RetrieveParticipantArmors()
		{
			Equipment p = this.Participant.GetBattleEquipments();
			EquipmentElement body = p.GetEquipmentFromSlot(6);
			EquipmentElement head = p.GetEquipmentFromSlot(5);
			EquipmentElement shoes = p.GetEquipmentFromSlot(7);
			return new ValueTuple<EquipmentElement, EquipmentElement, EquipmentElement>(body, head, shoes);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00008514 File Offset: 0x00006714
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		public ValueTuple<EquipmentElement, EquipmentElement, EquipmentElement, EquipmentElement> RetrieveParticipantWeapons()
		{
			Equipment p = this.Participant.GetBattleEquipments();
			EquipmentElement w0 = p.GetEquipmentFromSlot(0);
			EquipmentElement w = p.GetEquipmentFromSlot(1);
			EquipmentElement w2 = p.GetEquipmentFromSlot(2);
			EquipmentElement w3 = p.GetEquipmentFromSlot(3);
			return new ValueTuple<EquipmentElement, EquipmentElement, EquipmentElement, EquipmentElement>(w0, w, w2, w3);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000855F File Offset: 0x0000675F
		public void SetSetup(ISetup setup)
		{
			this._get = setup;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000856C File Offset: 0x0000676C
		protected bool CannotBeUsedOnHorse(EquipmentElement weapon0, EquipmentElement? weapon1, EquipmentElement? weapon2, EquipmentElement? weapon3)
		{
			string[] weapons = new string[] { "military_fork_pike_t3", "peasant_hammer_2_t1", "sturgia_axe_2_t2_blunt" };
			string[] array = weapons;
			int i = 0;
			while (i < array.Length)
			{
				string weapon4 = array[i];
				ItemObject item = weapon0.Item;
				bool flag = ((item != null) ? item.StringId : null) == weapon4;
				bool flag2;
				if (flag)
				{
					flag2 = true;
				}
				else
				{
					bool flag3;
					if (weapon1 != null)
					{
						ItemObject item2 = weapon1.Value.Item;
						flag3 = ((item2 != null) ? item2.StringId : null) == weapon4;
					}
					else
					{
						flag3 = false;
					}
					bool flag4 = flag3;
					if (flag4)
					{
						flag2 = true;
					}
					else
					{
						bool flag5;
						if (weapon2 != null)
						{
							ItemObject item3 = weapon2.Value.Item;
							flag5 = ((item3 != null) ? item3.StringId : null) == weapon4;
						}
						else
						{
							flag5 = false;
						}
						bool flag6 = flag5;
						if (flag6)
						{
							flag2 = true;
						}
						else
						{
							bool flag7;
							if (weapon3 != null)
							{
								ItemObject item4 = weapon3.Value.Item;
								flag7 = ((item4 != null) ? item4.StringId : null) == weapon4;
							}
							else
							{
								flag7 = false;
							}
							bool flag8 = flag7;
							if (!flag8)
							{
								i++;
								continue;
							}
							flag2 = true;
						}
					}
				}
				return flag2;
			}
			return false;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00008694 File Offset: 0x00006894
		protected bool EvalIfMounted(int percent)
		{
			return LogRaamRandom.EvalPercentage((float)percent);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000086B0 File Offset: 0x000068B0
		protected Equipment PrepareEquipment(EquipmentElement weapon0, EquipmentElement? weapon1, EquipmentElement? weapon2, EquipmentElement? weapon3, EquipmentElement bodyArmor, EquipmentElement headArmor, EquipmentElement shoes, EquipmentElement? mount)
		{
			Equipment result = new Equipment();
			result.AddEquipmentToSlotWithoutAgent(0, weapon0);
			bool flag = weapon1 != null;
			if (flag)
			{
				result.AddEquipmentToSlotWithoutAgent(1, weapon1.Value);
			}
			bool flag2 = weapon2 != null;
			if (flag2)
			{
				result.AddEquipmentToSlotWithoutAgent(2, weapon2.Value);
			}
			bool flag3 = weapon3 != null;
			if (flag3)
			{
				result.AddEquipmentToSlotWithoutAgent(3, weapon3.Value);
			}
			string c = (this._config.IsHostEnforcingHisCulture(this._tournamentCulture) ? this._tournamentCulture : this.Participant.Culture);
			bool flag4 = !this._config.ShouldBeNaked(c);
			if (flag4)
			{
				this.AssignGears(bodyArmor, headArmor, shoes, ref result);
			}
			return result;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000876F File Offset: 0x0000696F
		private void AssignGears(EquipmentElement bodyArmor, EquipmentElement headArmor, EquipmentElement shoes, ref Equipment result)
		{
			result.AddEquipmentToSlotWithoutAgent(6, bodyArmor);
			result.AddEquipmentToSlotWithoutAgent(5, headArmor);
			result.AddEquipmentToSlotWithoutAgent(7, shoes);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00008794 File Offset: 0x00006994
		private Equipment EquipArmor(IConfigLoader configLoader, string culture, IArmoury armoury, ref Equipment result)
		{
			ValueTuple<EquipmentElement, EquipmentElement, EquipmentElement> armors = this.RetrieveParticipantArmors();
			bool flag = this._get.Configuration.HostShouldProvideArmors(culture);
			if (flag)
			{
				armors = armoury.RequestArmorForLevel(this.ArmorQualityBonus());
			}
			this.PrepareProtectiveGears(armors.Item1, armors.Item2, armors.Item3, ref result);
			return result;
		}

		// Token: 0x04000071 RID: 113
		private readonly IConfig _config;

		// Token: 0x04000072 RID: 114
		private readonly string _tournamentCulture;

		// Token: 0x04000073 RID: 115
		private ISetup _get;
	}
}
