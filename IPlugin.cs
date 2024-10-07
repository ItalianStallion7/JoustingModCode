using System;
using LogRaamJousting.Armors;
using LogRaamJousting.Stables;
using LogRaamJousting.Weapons;
using TaleWorlds.Core;

namespace LogRaamJousting.Equipments
{
	// Token: 0x02000037 RID: 55
	public interface IPlugin
	{
		// Token: 0x06000172 RID: 370
		Equipment Equip(IWeaponry weaponry, IArmoury armoury, IStable stable);
	}
}
