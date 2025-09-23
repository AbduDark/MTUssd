using System;
using Microsoft.VisualBasic;

namespace MTUssd.SMS.Encoder;

public class ConcatenatedShortMessage : SMS
{
	private int TotalMessages;

	public string[] GetEMSPDUCode()
	{
		checked
		{
			switch (TP_DCS)
			{
			case 8:
				TotalMessages = (int)(unchecked(checked((long)Math.Round((double)TP_UD.Length / 4.0)) / 66) + unchecked(0 - (((double)TP_UD.Length / 4.0 % 66.0 == 0.0) ? 1 : 0)));
				break;
			case 0:
				TotalMessages = unchecked(TP_UD.Length / 266) - unchecked(0 - ((TP_UD.Length % 266 == 0) ? 1 : 0));
				break;
			}
			string[] array = new string[TotalMessages + 1];
			TP_UDHI = 64;
			int num = (int)Math.Round(VBMath.Rnd(1f) * 65536f);
			int totalMessages = TotalMessages;
			string text = default(string);
			for (int i = 0; i <= totalMessages; i++)
			{
				switch (TP_DCS)
				{
				case 8:
					text = Strings.Mid(TP_UD, i * 66 * 4 + 1, 264);
					break;
				case 0:
					text = Strings.Mid(TP_UD, i * 133 * 2 + 1, 266);
					break;
				}
				array[i] = SC_Number;
				array[i] += FirstOctet();
				array[i] += Strings.Format(TP_MR, "X2");
				array[i] += TP_DA;
				array[i] += Strings.Format(TP_PID, "X2");
				array[i] += Strings.Format(TP_DCS, "X2");
				array[i] += Strings.Format(TP_VP, "X2");
				if (TP_DCS == 8)
				{
					TP_UDL = (int)Math.Round((double)text.Length / 2.0 + 6.0 + 1.0);
				}
				if (TP_DCS == 0)
				{
					TP_UDL = (int)((double)((text.Length + 14) * 4) / 7.0);
				}
				array[i] += Strings.Format(TP_UDL, "X2");
				array[i] += "060804";
				array[i] += Strings.Format(num, "X4");
				array[i] += Strings.Format(TotalMessages + 1, "X2");
				array[i] += Strings.Format(i + 1, "X2");
				array[i] += text;
			}
			return array;
		}
	}

	public override string FirstOctet()
	{
		checked
		{
			return SMS.ByteToHex((byte)unchecked((uint)(checked((byte)unchecked((uint)(checked((byte)unchecked((uint)(TP_MTI + TP_VPF))) + TP_SRR))) + TP_UDHI)));
		}
	}
}
