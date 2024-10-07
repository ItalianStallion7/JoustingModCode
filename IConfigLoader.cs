using System;

namespace LogRaamJousting.Configuration
{
	// Token: 0x02000041 RID: 65
	public interface IConfigLoader
	{
		// Token: 0x060001B4 RID: 436
		bool IsLineExistInStruct(string[] options, string lineToFind);

		// Token: 0x060001B5 RID: 437
		string[] RetrieveConfigDetails();
	}
}
