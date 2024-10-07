using System;
using System.Runtime.CompilerServices;
using LogRaamJousting.Decoupling;
using TaleWorlds.Core;

namespace LogRaamJousting.Weapons
{
	// Token: 0x02000016 RID: 22
	public interface IWeaponry
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000071 RID: 113
		// (set) Token: 0x06000072 RID: 114
		Items Items { get; set; }

		// Token: 0x06000073 RID: 115
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestCulturalEventWeapon();

		// Token: 0x06000074 RID: 116
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestFactionLeaderWeapon();

		// Token: 0x06000075 RID: 117
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestHeroWeapon();

		// Token: 0x06000076 RID: 118
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestLordWeapon();

		// Token: 0x06000077 RID: 119
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestParticipantWeapon();

		// Token: 0x06000078 RID: 120
		[return: TupleElementNames(new string[] { "weapon0", "weapon1", "weapon2", "weapon3" })]
		ValueTuple<EquipmentElement, EquipmentElement?, EquipmentElement?, EquipmentElement?> RequestPlayerWeapon();
	}
}
