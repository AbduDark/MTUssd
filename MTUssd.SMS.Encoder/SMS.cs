using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace MTUssd.SMS.Encoder;

public class SMS
{
	public enum ENUM_TP_VPF
	{
		Relative_Format = 0x10
	}

	public enum ENUM_TP_SRI
	{
		Request_SMS_Report = 32,
		No_SMS_Report = 0
	}

	public enum ENUM_TP_DCS
	{
		DefaultAlphabet = 0,
		UCS2 = 8
	}

	public enum ENUM_TP_VALID_PERIOD
	{
		OneHour = 11,
		ThreeHours = 29,
		SixHours = 71,
		TwelveHours = 143,
		OneDay = 167,
		OneWeek = 196,
		Maximum = 255
	}

	protected string SC_Number;

	protected byte TP_MTI;

	protected byte TP_RD;

	protected byte TP_VPF;

	protected byte TP_UDHI;

	protected byte TP_SRR;

	protected int TP_MR;

	protected string TP_DA;

	protected byte TP_PID;

	protected byte TP_DCS;

	protected byte TP_VP;

	protected int TP_UDL;

	protected string TP_UD;

	public string ServiceCenterNumber
	{
		get
		{
			return SC_Number;
		}
		set
		{
			if (Strings.InStr(value, "+") != 0)
			{
				SC_Number = "91";
			}
			else
			{
				SC_Number = "81";
			}
			value = Strings.Mid(value, 2);
			if (value.Length % 2 == 1)
			{
				value += "F";
			}
			int length = value.Length;
			checked
			{
				for (int i = 1; i <= length; i += 2)
				{
					ref string sC_Number = ref SC_Number;
					string obj = sC_Number;
					string TwoBitStr = Strings.Mid(value, i, 2);
					sC_Number = obj + Swap(ref TwoBitStr);
				}
				SC_Number = ByteToHex((byte)Math.Round((double)(SC_Number.Length - 2) / 2.0 + 1.0)) + SC_Number;
			}
		}
	}

	public ENUM_TP_SRI TP_Status_Report_Request
	{
		get
		{
			return (ENUM_TP_SRI)TP_SRR;
		}
		set
		{
			TP_SRR = checked((byte)value);
		}
	}

	public int TP_Message_Reference
	{
		get
		{
			return TP_MR;
		}
		set
		{
			TP_MR = value;
		}
	}

	public string TP_Destination_Address
	{
		get
		{
			return TP_DA;
		}
		set
		{
			TP_DA = "";
			if (Strings.InStr(value, "+") != 0)
			{
				TP_DA += "91";
			}
			else
			{
				TP_DA += "81";
			}
			value = value.Replace("+", "");
			TP_DA = Strings.Format(value.Length, "X2") + TP_DA;
			if (value.Length % 2 == 1)
			{
				value += "F";
			}
			int length = value.Length;
			for (int i = 1; i <= length; i = checked(i + 2))
			{
				ref string tP_DA = ref TP_DA;
				string obj = tP_DA;
				string TwoBitStr = Strings.Mid(value, i, 2);
				tP_DA = obj + Swap(ref TwoBitStr);
			}
		}
	}

	public ENUM_TP_DCS TP_Data_Coding_Scheme
	{
		get
		{
			return (ENUM_TP_DCS)TP_DCS;
		}
		set
		{
			TP_DCS = checked((byte)value);
		}
	}

	public ENUM_TP_VALID_PERIOD TP_Validity_Period
	{
		get
		{
			return (ENUM_TP_VALID_PERIOD)TP_VP;
		}
		set
		{
			TP_VP = checked((byte)value);
		}
	}

	public virtual string TP_User_Data
	{
		get
		{
			return TP_UD;
		}
		set
		{
			switch (TP_DCS)
			{
			case 0:
				TP_UDL = value.Length;
				TP_UD = Encode7Bit(value);
				break;
			case 8:
				TP_UDL = checked(value.Length * 2);
				TP_UD = EncodeUCS2(value);
				break;
			default:
				TP_UD = value;
				break;
			}
		}
	}

	public SMS()
	{
		TP_MTI = 1;
		TP_RD = 0;
		TP_VPF = 16;
	}

	public static ENUM_TP_DCS CheckForEncoding(string Content)
	{
		int length = Content.Length;
		for (int i = 1; i <= length; i = checked(i + 1))
		{
			if (Strings.Asc(Strings.Mid(Content, i, 1)) < 0)
			{
				return ENUM_TP_DCS.UCS2;
			}
		}
		return ENUM_TP_DCS.DefaultAlphabet;
	}

	public virtual string GetSMSPDUCode()
	{
		if (TP_DCS == 0 && TP_UD.Length > 280)
		{
			throw new Exception("User Data is TOO LONG for SMS");
		}
		if (TP_DCS == 8 && TP_UD.Length > 280)
		{
			throw new Exception("User Data is TOO LONG for SMS");
		}
		string sC_Number = SC_Number;
		sC_Number += FirstOctet();
		sC_Number += Strings.Format(TP_MR, "X2");
		sC_Number += TP_DA;
		sC_Number += Strings.Format(TP_PID, "X2");
		sC_Number += Strings.Format(TP_DCS, "X2");
		sC_Number += Strings.Format(TP_VP, "X2");
		sC_Number += Strings.Format(TP_UDL, "X2");
		return sC_Number + TP_UD;
	}

	public virtual string FirstOctet()
	{
		checked
		{
			return ByteToHex((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(TP_MTI + TP_VPF))) + TP_SRR))) + TP_UDHI)));
		}
	}

	public static string ByteToHex(byte aByte)
	{
		return Strings.Format(aByte, "X2");
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

	public static string BitsToHex(string Bits)
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

	public static string CharTo7Bits(char c)
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

	public static string EncodeUCS2(string Content)
	{
		int length = Content.Length;
		string text2 = default(string);
		for (int i = 1; i <= length; i = checked(i + 1))
		{
			int num = Strings.AscW(Strings.Mid(Content, i, 4));
			string text = Strings.Format(num, "X4");
			text2 += text;
		}
		return text2;
	}

	public static string Swap(ref string TwoBitStr)
	{
		char[] array = TwoBitStr.ToCharArray();
		char c = array[0];
		array[0] = array[1];
		array[1] = c;
		return (Conversions.ToString(array[0]) + Conversions.ToString(array[1])).ToString();
	}
}
