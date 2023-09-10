using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Quickly_Helper
{
	// Token: 0x02000014 RID: 20
	public static class Savefilehandler
	{
		// Token: 0x0600010B RID: 267 RVA: 0x0000C580 File Offset: 0x0000A780
		public static List<string> GetSavedPresetNamesList()
		{
			List<string> list = new List<string>();
			if (File.Exists("Quickly_Configuration/Quickly.txt"))
			{
				try
				{
					int num = 0;
					foreach (string item in File.ReadLines("Quickly_Configuration/Quickly.txt"))
					{
						num++;
						if (num % 2 == 1)
						{
							list.Add(item);
						}
					}
				}
				catch (Exception ex)
				{
					Debug.Print(ex.Message);
				}
			}
			return list;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000C624 File Offset: 0x0000A824
		public static List<int> GetPresetValuesFromName(string presetName)
		{
			List<int> list = new List<int>();
			if (File.Exists("Quickly_Configuration/Quickly.txt"))
			{
				try
				{
					int num = 0;
					bool flag = false;
					foreach (string text in File.ReadLines("Quickly_Configuration/Quickly.txt"))
					{
						num++;
						if (num % 2 == 1 && text.Equals(presetName))
						{
							flag = true;
						}
						else if (flag)
						{
							string[] array = text.Split(new char[]
							{
								';'
							}, StringSplitOptions.RemoveEmptyEntries);
							if (array.Length == 5)
							{
								list.Add(int.Parse(array[0]));
								list.Add(int.Parse(array[1]));
								list.Add(int.Parse(array[2]));
								list.Add(int.Parse(array[3]));
								list.Add(int.Parse(array[4]));
								break;
							}
							throw new Exception("Wrong number of preset parameters!");
						}
					}
				}
				catch (Exception ex)
				{
					Debug.Print(ex.Message);
				}
			}
			return list;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000C75C File Offset: 0x0000A95C
		public static bool SavePresets(string presetName, int dx, int dy, int delayms, int left, int right)
		{
			string text = "";
			if (File.Exists("Quickly_Configuration/Quickly.txt"))
			{
				text = File.ReadAllText("Quickly_Configuration/Quickly.txt");
				File.Delete("Quickly_Configuration/Quickly.txt");
			}
			string contents = string.Concat(new string[]
			{
				text,
				presetName,
				"\r\n",
				dx.ToString(),
				";",
				dy.ToString(),
				";",
				delayms.ToString(),
				";",
				left.ToString(),
				";",
				right.ToString(),
				"\r\n"
			});
			File.WriteAllText("Quickly_Configuration/Quickly.txt", contents);
			return true;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000C82C File Offset: 0x0000AA2C
		public static bool DeletePreset(string presetName)
		{
			bool result = false;
			if (File.Exists("Quickly_Configuration/Quickly.txt"))
			{
				if (!Savefilehandler.GetSavedPresetNamesList().Contains(presetName))
				{
					throw new Exception("Preset " + presetName + " not found");
				}
				bool flag = false;
				string text = "";
				foreach (string text2 in File.ReadAllLines("Quickly_Configuration/Quickly.txt"))
				{
					if (text2.Equals(presetName))
					{
						flag = true;
					}
					else if (flag)
					{
						flag = false;
					}
					else
					{
						text = text + text2 + "\r\n";
					}
				}
				File.WriteAllText("Quickly_Configuration/Quickly.txt", text);
				result = true;
			}
			return result;
		}

		// Token: 0x040000A5 RID: 165
		private const string saveFileName = "Quickly_Configuration/Quickly.txt";
	}
}
