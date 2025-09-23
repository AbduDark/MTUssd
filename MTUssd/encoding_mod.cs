using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace MTUssd;

[StandardModule]
internal sealed class encoding_mod
{
	public static ReaderWriterLock DataFileLock = new ReaderWriterLock();

	public static void writeFileStrData(object MyData, string filePath, string transType = "", string dataEncoding = "")
	{
		byte[] array = null;
		if (Operators.CompareString(transType, "", TextCompare: false) == 0)
		{
			transType = "Append";
		}
		if (Operators.CompareString(dataEncoding, "", TextCompare: false) == 0)
		{
			dataEncoding = "ANSI";
		}
		try
		{
			string s = Conversions.ToString(MyData);
			if (Operators.CompareString(dataEncoding, "ANSI", TextCompare: false) == 0)
			{
				array = Encoding.Default.GetBytes(s);
			}
			else if (Operators.CompareString(dataEncoding, "Unicode", TextCompare: false) == 0)
			{
				array = Encoding.Unicode.GetBytes(s);
			}
			FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
			if (Operators.CompareString(transType, "Append", TextCompare: false) == 0)
			{
				fileStream.Seek(0L, SeekOrigin.End);
			}
			else if (Operators.CompareString(transType, "Overwrite", TextCompare: false) == 0)
			{
				fileStream.Seek(0L, SeekOrigin.Begin);
			}
			fileStream.Write(array, 0, array.Length);
			fileStream.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message + "\r\n" + ex2.StackTrace);
			ProjectData.ClearProjectError();
		}
	}

	public static void writeFileStrData2(object MyData, string filePath, string transType = "")
	{
		if (Operators.CompareString(transType, "", TextCompare: false) == 0)
		{
			transType = "Append";
		}
		try
		{
			string value = Conversions.ToString(MyData);
			FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
			StreamWriter streamWriter = new StreamWriter(fileStream);
			if (Operators.CompareString(transType, "Append", TextCompare: false) == 0)
			{
				streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
			}
			else if (Operators.CompareString(transType, "Overwrite", TextCompare: false) == 0)
			{
				streamWriter.BaseStream.Seek(0L, SeekOrigin.Begin);
			}
			streamWriter.WriteLine(value);
			streamWriter.Flush();
			streamWriter.Close();
			fileStream.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message + "\r\n" + ex2.StackTrace);
			ProjectData.ClearProjectError();
		}
	}

	public static void writeFileStrData_Threadsafe(object MyData, string filePath, string transType = "")
	{
		FileStream fileStream = null;
		StreamWriter streamWriter = null;
		string text = "";
		if (Operators.CompareString(transType, "", TextCompare: false) == 0)
		{
			transType = "Append";
		}
		if (DataFileLock == null)
		{
			return;
		}
		int num = default(int);
		do
		{
			try
			{
				DataFileLock.AcquireWriterLock(10000);
			}
			catch (ApplicationException ex)
			{
				ProjectData.SetProjectError(ex);
				ApplicationException ex2 = ex;
				ProjectData.ClearProjectError();
			}
			num = checked(num + 1);
		}
		while (!DataFileLock.IsWriterLockHeld && num < 10);
		if (!DataFileLock.IsWriterLockHeld)
		{
			return;
		}
		try
		{
			string value = Conversions.ToString(MyData);
			fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
			streamWriter = new StreamWriter(fileStream);
			if (Operators.CompareString(transType, "Append", TextCompare: false) == 0)
			{
				streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
			}
			else if (Operators.CompareString(transType, "Overwrite", TextCompare: false) == 0)
			{
				streamWriter.BaseStream.Seek(0L, SeekOrigin.Begin);
			}
			streamWriter.WriteLine(value);
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			Interaction.MsgBox(ex4.Message + "\r\n" + ex4.StackTrace);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (streamWriter != null)
			{
				streamWriter.Flush();
				streamWriter.Close();
				fileStream.Close();
			}
		}
		DataFileLock.ReleaseWriterLock();
	}

	public static void writeFileBinaryData1(byte[] MyData, string filePath, string transType = "")
	{
		if (Operators.CompareString(transType, "", TextCompare: false) == 0)
		{
			transType = "Append";
		}
		try
		{
			long num = Information.UBound(MyData);
			FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
			if (Operators.CompareString(transType, "Append", TextCompare: false) == 0)
			{
				fileStream.Seek(0L, SeekOrigin.End);
			}
			else if (Operators.CompareString(transType, "Overwrite", TextCompare: false) == 0)
			{
				fileStream.Seek(0L, SeekOrigin.Begin);
			}
			fileStream.Write(MyData, 0, checked((int)num));
			fileStream.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message + "\r\n" + ex2.StackTrace);
			ProjectData.ClearProjectError();
		}
	}

	public static void writeFileBinaryData2(byte[] MyData, string filePath, string transType = "")
	{
		if (Operators.CompareString(transType, "", TextCompare: false) == 0)
		{
			transType = "Append";
		}
		try
		{
			long num = Information.UBound(MyData);
			FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			if (Operators.CompareString(transType, "Append", TextCompare: false) == 0)
			{
				binaryWriter.BaseStream.Seek(0L, SeekOrigin.End);
			}
			else if (Operators.CompareString(transType, "Overwrite", TextCompare: false) == 0)
			{
				binaryWriter.BaseStream.Seek(0L, SeekOrigin.Begin);
			}
			binaryWriter.Write(MyData, 0, checked((int)num));
			binaryWriter.Close();
			fileStream.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message + "\r\n" + ex2.StackTrace);
			ProjectData.ClearProjectError();
		}
	}

	public static void CreatregKeyinReg()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software", writable: true);
		registryKey.CreateSubKey("SYS1250");
		registryKey = Registry.CurrentUser.OpenSubKey("Software\\SYS1250", writable: true);
		registryKey.CreateSubKey("TC");
		registryKey.Close();
	}

	public static string GetChecksum(string sentence)
	{
		int num = default(int);
		foreach (char c in sentence)
		{
			switch (c)
			{
			default:
				num = ((num != 0) ? (num ^ Convert.ToByte(c)) : Convert.ToByte(c));
				continue;
			case '$':
				continue;
			case '*':
				break;
			}
			break;
		}
		return num.ToString("X2");
	}

	public static bool chkMsgCode(string str)
	{
		checked
		{
			int num = str.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Strings.Asc(str.Substring(i, 1).ToUpper()) > 70)
				{
					return false;
				}
			}
			return true;
		}
	}

	public static void savedataToReg(string EEkey, string EEdata)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\SYS1250\\TC", writable: true);
		registryKey.SetValue(EEkey, EEdata);
		registryKey.Close();
	}

	public static string getdataFromReg(string EEkey)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\SYS1250\\TC", writable: true);
		if (Information.IsNothing(registryKey))
		{
			CreatregKeyinReg();
			return "";
		}
		string result = Conversions.ToString(registryKey.GetValue(EEkey, ""));
		registryKey.Close();
		return result;
	}

	public static string GetCommandCode(string UssdCommandFull)
	{
		bool flag = true;
		return "AT+CUSD=1," + UssdCommandFull + ",15";
	}

	public static string Encode7Bit(string Content)
	{
		char[] array = Content.ToCharArray();
		char[] array2 = array;
		string text = default(string);
		foreach (char c in array2)
		{
			text = CharTo7Bits(c) + text;
		}
		checked
		{
			if (unchecked(text.Length % 8) != 0)
			{
				int num = 8 - unchecked(text.Length % 8);
				for (int j = 1; j <= num; j++)
				{
					text = "0" + text;
				}
			}
			int num2 = text.Length - 8;
			string text2 = default(string);
			for (int j = num2; j >= 0; j += -8)
			{
				text2 += BitsToHex(Strings.Mid(text, j + 1, 8));
			}
			return text2;
		}
	}

	private static string InvertHexString(string HexString)
	{
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			int num = HexString.Length - 2;
			for (int i = num; i >= 0; i += -2)
			{
				stringBuilder.Append(HexString.Substring(i, 2));
			}
			return stringBuilder.ToString();
		}
	}

	private static byte GetByte(ref string PDUCode)
	{
		byte result = checked((byte)Math.Round(Conversion.Val("&H" + Strings.Mid(PDUCode, 1, 2))));
		PDUCode = Strings.Mid(PDUCode, 3);
		return result;
	}

	private static string ByteToBinary(byte Dec)
	{
		byte b = Dec;
		string text = default(string);
		while (true)
		{
			text = Conversions.ToString(b % 2) + text;
			if (b == 1 || b == 0)
			{
				break;
			}
			checked
			{
				b = (byte)unchecked(b / 2);
			}
		}
		return text.PadLeft(8, '0');
	}

	private static int BinaryToInt(string Binary)
	{
		checked
		{
			int num = Binary.Length - 1;
			int num2 = default(int);
			for (int i = 0; i <= num; i++)
			{
				num2 = (int)Math.Round((double)num2 + Conversion.Val(Binary.Substring(Binary.Length - i - 1, 1)) * Math.Pow(2.0, i));
			}
			return num2;
		}
	}

	public static string Decode7Bit(string str7BitCode)
	{
		string text = InvertHexString(str7BitCode);
		checked
		{
			int num = text.Length - 1;
			string text2 = default(string);
			for (int i = 0; i <= num; i += 2)
			{
				text2 += ByteToBinary((byte)Math.Round(Conversion.Val("&H" + text.Substring(i, 2))));
			}
			int num2 = (int)Math.Round((double)text2.Length / 7.0);
			int num3 = num2 - 1;
			string text3 = default(string);
			for (int i = 1; i <= num3; i++)
			{
				int num4 = BinaryToInt(text2.Substring(text2.Length - i * 7, 7));
				if (num4 == 0)
				{
					num4 = 64;
				}
				text3 += Conversions.ToString(Strings.ChrW(num4));
			}
			return text3;
		}
	}

	private static string BitsToHex(string Bits)
	{
		checked
		{
			int num = Bits.Length - 1;
			int num2 = default(int);
			for (int i = 0; i <= num; i++)
			{
				num2 = (int)Math.Round((double)num2 + Conversion.Val(Strings.Mid(Bits, i + 1, 1)) * Math.Pow(2.0, 7 - i));
			}
			return Strings.Format(num2, "X2");
		}
	}

	private static string CharTo7Bits(char c)
	{
		if (Operators.CompareString(Conversions.ToString(c), "@", TextCompare: false) == 0)
		{
			return "0000000";
		}
		int num = 0;
		checked
		{
			string text = default(string);
			do
			{
				text = (((Strings.Asc(c) & (long)Math.Round(Math.Pow(2.0, num))) <= 0) ? ("0" + text) : ("1" + text));
				num++;
			}
			while (num <= 6);
			return text;
		}
	}

	public static byte[] StrToByteArray(string str)
	{
		byte[] array = new byte[10001];
		checked
		{
			array = new byte[(int)Math.Round((double)(str.Length - 1) / 2.0) + 1];
			int num = str.Length - 1;
			for (int i = 0; i <= num; i += 2)
			{
				array[(int)Math.Round((double)i / 2.0)] = byte.Parse(str.Substring(i, 2), NumberStyles.HexNumber);
			}
			return array;
		}
	}

	public static string InvertHexString3(string HexString)
	{
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			int num = HexString.Length - 1;
			for (int i = num; i >= 0; i += -1)
			{
				stringBuilder.Append(HexString.Substring(i, 1));
			}
			return stringBuilder.ToString();
		}
	}
}
