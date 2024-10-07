using System;
using System.Reflection;
using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;

namespace LogRaamJousting
{
	// Token: 0x0200000E RID: 14
	public class IntegratedLoaderSubModule : MBSubModuleBase
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00002D93 File Offset: 0x00000F93
		protected override void OnBeforeInitialModuleScreenSetAsRoot()
		{
			base.OnBeforeInitialModuleScreenSetAsRoot();
			InformationManager.DisplayMessage(new InformationMessage("Jousting activated!", Colors.Green));
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002DB4 File Offset: 0x00000FB4
		protected override void OnGameStart(Game game, IGameStarter gameStarter)
		{
			CampaignGameStarter starter = (CampaignGameStarter)gameStarter;
			starter.AddBehavior(new JoustingBehavior());
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002DD5 File Offset: 0x00000FD5
		protected override void OnSubModuleLoad()
		{
			base.OnSubModuleLoad();
			this._harmony.PatchAll(Assembly.GetExecutingAssembly());
		}

		// Token: 0x04000015 RID: 21
		private readonly Harmony _harmony = new Harmony("LogRaamJousting");
	}
}
