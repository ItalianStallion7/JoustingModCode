using System;
using System.Reflection;

namespace LogRaamJousting
{
	// Token: 0x02000008 RID: 8
	public static class LogRaamReflexion
	{
		// Token: 0x06000015 RID: 21 RVA: 0x000027DC File Offset: 0x000009DC
		public static T GetPrivateFieldValue<T>(this object obj, string propName)
		{
			bool flag = obj == null;
			if (flag)
			{
				throw new ArgumentNullException("obj");
			}
			Type t = obj.GetType();
			FieldInfo fi = null;
			while (fi == null && t != null)
			{
				fi = t.GetField(propName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				t = t.BaseType;
			}
			bool flag2 = fi == null;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("propName", string.Format("Field {0} was not found in Type {1}", propName, obj.GetType().FullName));
			}
			return (T)((object)fi.GetValue(obj));
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002874 File Offset: 0x00000A74
		public static T GetPrivatePropertyValue<T>(this object obj, string propName)
		{
			bool flag = obj == null;
			if (flag)
			{
				throw new ArgumentNullException("obj");
			}
			PropertyInfo pi = obj.GetType().GetProperty(propName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			bool flag2 = pi == null;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("propName", string.Format("Property {0} was not found in Type {1}", propName, obj.GetType().FullName));
			}
			return (T)((object)pi.GetValue(obj, null));
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000028E4 File Offset: 0x00000AE4
		public static void SetPrivateFieldValue<T>(this object obj, string propName, T val)
		{
			bool flag = obj == null;
			if (flag)
			{
				throw new ArgumentNullException("obj");
			}
			Type t = obj.GetType();
			FieldInfo fi = null;
			while (fi == null && t != null)
			{
				fi = t.GetField(propName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				t = t.BaseType;
			}
			bool flag2 = fi == null;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("propName", string.Format("Field {0} was not found in Type {1}", propName, obj.GetType().FullName));
			}
			fi.SetValue(obj, val);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002978 File Offset: 0x00000B78
		public static void SetPrivatePropertyValue<T>(this object obj, string propName, BindingFlags bindingFlag, T val)
		{
			bool flag = obj == null;
			if (flag)
			{
				throw new ArgumentNullException("obj");
			}
			Type t = obj.GetType();
			PropertyInfo fi = null;
			while (fi == null && t != null)
			{
				fi = t.GetProperty(propName, bindingFlag);
				t = t.BaseType;
			}
			bool flag2 = fi == null;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("propName", string.Format("Field {0} was not found in Type {1}", propName, obj.GetType().FullName));
			}
			fi.SetValue(obj, val);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002A0C File Offset: 0x00000C0C
		public static void SetPrivatePropertyValue<T>(this object obj, string propName, T val)
		{
			Type t = obj.GetType();
			bool flag = t.GetProperty(propName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic) == null;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("propName", string.Format("Property {0} was not found in Type {1}", propName, obj.GetType().FullName));
			}
			t.InvokeMember(propName, BindingFlags.Instance | BindingFlags.SetProperty, null, obj, new object[] { val });
		}
	}
}
