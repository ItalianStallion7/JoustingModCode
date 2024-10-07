using System;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;

namespace LogRaamJousting
{
	// Token: 0x02000007 RID: 7
	public class Logger
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002788 File Offset: 0x00000988
		public void ShowMessage(string msg, Color? color = null)
		{
			bool flag = color == null;
			if (flag)
			{
				color = new Color?(Color.White);
			}
			InformationManager.DisplayMessage(new InformationMessage(msg, color.Value));
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000027C3 File Offset: 0x000009C3
		public void ShowNotification(TextObject message, int priority = 0, BasicCharacterObject charObj = null, string soundEventPath = "")
		{
			MBInformationManager.AddQuickInformation(message, 0, charObj, soundEventPath);
		}
	}
}
