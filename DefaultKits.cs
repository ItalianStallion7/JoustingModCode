using System;
using LogRaamJousting.Armors;
using LogRaamJousting.Configuration;
using LogRaamJousting.Decoupling;
using LogRaamJousting.Equipments;
using LogRaamJousting.Stables;
using LogRaamJousting.Weapons;
using TaleWorlds.Core;

namespace LogRaamJousting.Factory
{
	// Token: 0x0200002E RID: 46
	public class DefaultKits : IKit
	{
		// Token: 0x0600013B RID: 315 RVA: 0x00007976 File Offset: 0x00005B76
		public DefaultKits(ISetup setup, IConfigLoader configLoader, IBaseArmoury baseArmoury)
		{
			this._get = setup;
			this._loader = configLoader;
			this._baseArmoury = baseArmoury;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00007998 File Offset: 0x00005B98
		public Equipment DefaultAseraiKit(Participant participant, string hostCulture)
		{
			return new AseraiKit(this._get, new EquipmentPlugin(new DefaultSetup(), new Config(), hostCulture, participant), this._loader)
			{
				ReferredParticipant = participant.RefToGameParticipant()
			}.Equip(new AseraiWeaponry(new Items()), new AseraiArmoury(this._baseArmoury), new AseraiStable());
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000079F8 File Offset: 0x00005BF8
		public Equipment DefaultAyyubidKit(Participant participant, string hostCulture)
		{
			return new AseraiKit(this._get, new EquipmentPlugin(new DefaultSetup(), new Config(), hostCulture, participant), this._loader)
			{
				ReferredParticipant = participant.RefToGameParticipant()
			}.Equip(new AseraiWeaponry(new Items()), new AseraiArmoury(this._baseArmoury), new AseraiStable());
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00007A58 File Offset: 0x00005C58
		public Equipment DefaultBattaniaKit(Participant participant, string hostCulture)
		{
			return new BattaniaKit(this._get, new EquipmentPlugin(new DefaultSetup(), new Config(), hostCulture, participant), this._loader)
			{
				ReferredParticipant = participant.RefToGameParticipant()
			}.Equip(new BattaniaWeaponry(new Items()), new BattaniaArmoury(this._baseArmoury), new BattaniaStable());
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00007AB8 File Offset: 0x00005CB8
		public Equipment DefaultByzantineKit(Participant participant, string hostCulture)
		{
			return new EmpireKit(this._get, new EquipmentPlugin(new DefaultSetup(), new Config(), hostCulture, participant), this._loader)
			{
				ReferredParticipant = participant.RefToGameParticipant()
			}.Equip(new EmpireWeaponry(new Items()), new EmpireArmoury(this._baseArmoury), new EmpireStable());
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00007B18 File Offset: 0x00005D18
		public Equipment DefaultEmpireKit(Participant participant, string hostCulture)
		{
			return new EmpireKit(this._get, new EquipmentPlugin(new DefaultSetup(), new Config(), hostCulture, participant), this._loader)
			{
				ReferredParticipant = participant.RefToGameParticipant()
			}.Equip(new EmpireWeaponry(new Items()), new EmpireArmoury(this._baseArmoury), new EmpireStable());
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00007B78 File Offset: 0x00005D78
		public Equipment DefaultKhuzaitKit(Participant participant, string hostCulture)
		{
			return new KhuzaitKit(this._get, new EquipmentPlugin(new DefaultSetup(), new Config(), hostCulture, participant), this._loader)
			{
				ReferredParticipant = participant.RefToGameParticipant()
			}.Equip(new KhuzaitWeaponry(new Items()), new KhuzaitArmoury(this._baseArmoury), new KhuzaitStable());
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00007BD8 File Offset: 0x00005DD8
		public Equipment DefaultSturgiaKit(Participant participant, string hostCulture)
		{
			return new SturgiaKit(this._get, new EquipmentPlugin(new DefaultSetup(), new Config(), hostCulture, participant), this._loader)
			{
				ReferredParticipant = participant.RefToGameParticipant()
			}.Equip(new SturgiaWeaponry(new Items()), new SturgiaArmoury(this._baseArmoury), new SturgiaStable());
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00007C38 File Offset: 0x00005E38
		public Equipment DefaultVlandiaKit(Participant participant, string hostCulture)
		{
			return new VlandiaKit(this._get, new EquipmentPlugin(new DefaultSetup(), new Config(), hostCulture, participant), this._loader)
			{
				ReferredParticipant = participant.RefToGameParticipant()
			}.Equip(new VlandiaWeaponry(new Items()), new VlandiaArmoury(this._baseArmoury), new VlandiaStable());
		}

		// Token: 0x04000060 RID: 96
		private readonly IBaseArmoury _baseArmoury;

		// Token: 0x04000061 RID: 97
		private readonly ISetup _get;

		// Token: 0x04000062 RID: 98
		private readonly IConfigLoader _loader;
	}
}
