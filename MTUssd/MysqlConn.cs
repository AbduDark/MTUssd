using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace MTUssd;

[StandardModule]
internal sealed class MysqlConn
{
	public static MySqlConnection MysqlConnX;

	public static string CompnameEXAr;

	public static string CompnameEXEn;

	public static string compCode;

	public static string compDB;

	public static string CurrUser;

	public static bool ErrorHappen;

	public static string IMStand;

	public static string Cli_sn;

	public static string Client_Reg_Name;

	public const string sysDbPath = "\\maindb.ngm";

	public const string sysDbPathChg = "\\Data\\mainvalue.ngm";

	public static int MainProgLic;

	public static DateTime OpenDate;

	public static string Maintitletxt = "Mtussd GDxserver V46.00";

	public const string FlashType = "ZTE";

	public const string GlobEdbname = "ngmmtu";

	public static string RD_name;

	public static bool SetConnctiontomySql(string Edbname)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool result;
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					MysqlConnX = new MySqlConnection();
					string text = "localhost";
					string text2 = "root";
					string text3 = "123456";
					string connectionString = "SERVER=" + text + "; PORT = 3306 ;DATABASE=" + Edbname + ";UID=" + text2 + ";PASSWORD=" + text3 + ";Character Set=utf8;";
					MysqlConnX.ConnectionString = connectionString;
					MysqlConnX.Open();
					Application.DoEvents();
					result = true;
					goto end_IL_0001;
				}
				case 175:
					num = -1;
					switch (num2)
					{
					case 2:
						Interaction.MsgBox("Check Internet Connection", MsgBoxStyle.Critical, Maintitletxt);
						result = false;
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 175;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void CloseConn()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num = default(int);
		int num2 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000b;
				case 71:
					{
						num = num2;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num + 1;
						num = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000b;
						case 3:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 4:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_000b:
					num2 = 2;
					MysqlConnX.Close();
					break;
					end_IL_0001_2:
					break;
				}
				num2 = 3;
				MysqlConnX.Dispose();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 71;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
