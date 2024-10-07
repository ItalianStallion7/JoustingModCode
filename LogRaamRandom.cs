using System;

namespace LogRaamJousting
{
	// Token: 0x0200000F RID: 15
	public static class LogRaamRandom
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00002E0C File Offset: 0x0000100C
		public static bool EvalPercentage(float value)
		{
			int r = LogRaamRandom.GenerateRandomNumber(100);
			return (float)r < value;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002E2C File Offset: 0x0000102C
		public static bool EvalPercentageRange(int min, int max)
		{
			return LogRaamRandom.EvalPercentage((float)LogRaamRandom.GenerateRandomNumber(min, max));
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002E4C File Offset: 0x0000104C
		public static int GenerateRandomNumber(int max)
		{
			LogRaamRandom.InitRandomNumber(Guid.NewGuid().GetHashCode());
			int i = max;
			bool flag = i < 0;
			if (flag)
			{
				i = -i;
			}
			object syncObj = LogRaamRandom.SyncObj;
			int num;
			lock (syncObj)
			{
				if (LogRaamRandom._random == null)
				{
					LogRaamRandom._random = new Random();
				}
				num = ((max < 0) ? (-LogRaamRandom._random.Next(i)) : LogRaamRandom._random.Next(i));
			}
			return num;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002EE4 File Offset: 0x000010E4
		public static decimal GenerateRandomNumber(decimal max)
		{
			LogRaamRandom.InitRandomNumber(Guid.NewGuid().GetHashCode());
			int count = (int)BitConverter.GetBytes(decimal.GetBits(max)[3])[2];
			bool flag = count == 0;
			decimal num;
			if (flag)
			{
				num = LogRaamRandom.GenerateRandomNumber((int)max);
			}
			else
			{
				int i = (int)(max * count);
				bool flag2 = i < 0;
				if (flag2)
				{
					i = -i;
				}
				object syncObj = LogRaamRandom.SyncObj;
				lock (syncObj)
				{
					if (LogRaamRandom._random == null)
					{
						LogRaamRandom._random = new Random();
					}
					decimal result = ((max < 0m) ? (-LogRaamRandom._random.Next(i)) : LogRaamRandom._random.Next(i));
					num = result / count;
				}
			}
			return num;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002FDC File Offset: 0x000011DC
		public static int GenerateRandomNumber(int min, int max)
		{
			int i = min;
			int j = max;
			bool flag = i < 0 && j >= 0;
			if (flag)
			{
				throw new ApplicationException("Error trying to generate random number; min and max must be either negatives or positives.  This mod doesn't support randomize between negative min and positive max.");
			}
			bool flag2 = i < 0;
			if (flag2)
			{
				i = -i;
			}
			bool flag3 = j < 0;
			if (flag3)
			{
				j = -j;
			}
			bool flag4 = i > j;
			if (flag4)
			{
				int t = j;
				j = i;
				i = t;
			}
			object syncObj = LogRaamRandom.SyncObj;
			int num;
			lock (syncObj)
			{
				if (LogRaamRandom._random == null)
				{
					LogRaamRandom._random = new Random();
				}
				num = ((max < 0) ? (-LogRaamRandom._random.Next(i, j)) : LogRaamRandom._random.Next(i, j));
			}
			return num;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000030A0 File Offset: 0x000012A0
		private static void InitRandomNumber(int seed)
		{
			object syncObj = LogRaamRandom.SyncObj;
			lock (syncObj)
			{
				LogRaamRandom._random = new Random(seed);
			}
		}

		// Token: 0x04000016 RID: 22
		private static readonly object SyncObj = new object();

		// Token: 0x04000017 RID: 23
		private static Random _random;
	}
}
