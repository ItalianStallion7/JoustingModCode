using System;

namespace LogRaamJousting.Options
{
	// Token: 0x0200002B RID: 43
	public class OptionFinder
	{
		// Token: 0x06000125 RID: 293 RVA: 0x000076CC File Offset: 0x000058CC
		public bool IsLineExistInStruct(string[] options, string lineToFind)
		{
			foreach (string option in options)
			{
				bool flag = !option.Contains(lineToFind);
				if (!flag)
				{
					return true;
				}
			}
			return false;
		}
	}
}
