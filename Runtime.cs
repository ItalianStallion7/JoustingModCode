using System;
using TaleWorlds.Core;

namespace LogRaamJousting
{
	// Token: 0x02000011 RID: 17
	public static class Runtime
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000032 RID: 50 RVA: 0x0000313A File Offset: 0x0000133A
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00003141 File Offset: 0x00001341
		public static CultureCode HostCulture { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00003149 File Offset: 0x00001349
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00003150 File Offset: 0x00001350
		public static bool IsCulturalEvent { get; set; }

		// Token: 0x04000018 RID: 24
		public static readonly JoustParticipant Participant = new JoustParticipant();
	}
}
