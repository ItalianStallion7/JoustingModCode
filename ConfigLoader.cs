using System;
using System.IO;

namespace LogRaamJousting.Configuration
{
	// Token: 0x0200003F RID: 63
	public class ConfigLoader : IConfigLoader
	{
		// Token: 0x060001A7 RID: 423 RVA: 0x000097B0 File Offset: 0x000079B0
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

		// Token: 0x060001A8 RID: 424 RVA: 0x000097F0 File Offset: 0x000079F0
		public string[] RetrieveConfigDetails()
		{
			DirectoryInfo directoryInfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
			bool flag = directoryInfo == null;
			string[] array;
			if (flag)
			{
				array = new string[] { "" };
			}
			else
			{
				string str = directoryInfo.FullName + "\\Modules\\LogRaamJousting\\JOUSTING_OPTIONS.txt";
				array = File.ReadAllLines(str);
			}
			return array;
		}
	}
}
