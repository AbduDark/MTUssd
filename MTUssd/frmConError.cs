using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MTUssd.My;
using MySql.Data.MySqlClient;

namespace MTUssd;

[DesignerGenerated]
public class frmConError : Form
{
	private IContainer components;

	private cdataMysql objDataRemote;

	public frmConError()
	{
		base.Load += frmConError_Load;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		base.SuspendLayout();
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(74, 39);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "frmConError";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		base.ResumeLayout(false);
	}

	private void DBconnRemote()
	{
		objDataRemote = new cdataMysql();
	}

	private void AddToRemoteDB(string cli_NAME, string Cli_mob, string order_desc, string period_req, string pay_meth, string pay_mob)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					objDataRemote.DatabaseCommand("INSERT INTO orders_data (ecode,cli_name,cli_mob,order_desc,cli_sn,period_req,pay_meth,pay_mob) Values ( 125 , '" + cli_NAME + "', '" + Cli_mob + "', '" + order_desc + "', '" + MysqlConn.Cli_sn + "' , '" + period_req + "' , '" + pay_meth + "' , '" + pay_mob + "' )");
					Interaction.MsgBox("Unkown file format", MsgBoxStyle.Critical);
					goto end_IL_0001;
				case 176:
					num = -1;
					switch (num2)
					{
					case 2:
						Interaction.MsgBox("Check Internet Connection", MsgBoxStyle.Critical, MysqlConn.Maintitletxt);
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 176;
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
	}

	private string GetComputerName()
	{
		return Dns.GetHostName();
	}

	private void SetHWareSn()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scripting.FileSystemObject"));
		object instance = objectValue;
		object[] array = new object[1];
		object instance2 = objectValue;
		object[] array2 = new object[1];
		object obj = (array2[0] = AppDomain.CurrentDomain.BaseDirectory);
		array[0] = NewLateBinding.LateGet(instance2, null, "GetDriveName", array2, null, null, null);
		object[] array3 = array;
		bool[] obj2 = new bool[1] { true };
		bool[] array4 = obj2;
		object obj3 = NewLateBinding.LateGet(instance, null, "GetDrive", array, null, null, obj2);
		if (array4[0])
		{
			NewLateBinding.LateSetComplex(instance2, null, "GetDriveName", new object[2]
			{
				obj,
				array3[0]
			}, null, null, OptimisticSet: true, RValueBase: false);
		}
		object objectValue2 = RuntimeHelpers.GetObjectValue(obj3);
		object instance3 = objectValue2;
		long number = ((!Conversions.ToBoolean(NewLateBinding.LateGet(instance3, null, "IsReady", new object[0], null, null, null))) ? (-1) : Conversions.ToLong(NewLateBinding.LateGet(instance3, null, "SerialNumber", new object[0], null, null, null)));
		instance3 = null;
		objectValue2 = null;
		objectValue = null;
		MysqlConn.Cli_sn = Conversion.Hex(number);
	}

	private bool chkLogin()
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
					MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select stats ,pay_money ,cli_name ,order_desc from lic_bs where cli_sn = '" + MysqlConn.Cli_sn + "' and ecode = 630 ", MysqlConn.MysqlConnX);
					DataTable dataTable = new DataTable();
					mySqlDataAdapter.Fill(dataTable);
					MysqlConn.MainProgLic = 0;
					if (dataTable.Rows.Count > 0)
					{
						if (Operators.ConditionalCompareObjectEqual(dataTable.Rows[0]["stats"], 1, TextCompare: false))
						{
							MysqlConn.MainProgLic = Conversions.ToInteger(dataTable.Rows[0]["pay_money"]);
							MysqlConn.Client_Reg_Name = Conversions.ToString(dataTable.Rows[0]["cli_name"]);
							MysqlConn.RD_name = Conversions.ToString(dataTable.Rows[0]["order_desc"]);
							result = true;
						}
						else
						{
							MysqlConn.Client_Reg_Name = Conversions.ToString(dataTable.Rows[0]["cli_name"]);
							AddToRemoteDB(GetComputerName(), "OLD", "Deactived", MysqlConn.Client_Reg_Name, "00", "00");
							result = false;
						}
					}
					else
					{
						AddToRemoteDB(GetComputerName(), "Mtussd", "New", "Mtu", "Client", "00");
						result = false;
					}
					goto end_IL_0001;
				}
				case 378:
					num = -1;
					switch (num2)
					{
					case 2:
						Interaction.MsgBox(Information.Err().Description);
						result = false;
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 378;
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

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void frmConError_Load(object sender, EventArgs e)
	{
		DBconnRemote();
		Application.DoEvents();
		SetHWareSn();
		if (!MysqlConn.SetConnctiontomySql("ngmmtu"))
		{
			Interaction.MsgBox("Check Internet Connection", MsgBoxStyle.Critical, MysqlConn.Maintitletxt);
			ProjectData.EndApp();
		}
		Application.DoEvents();
		if (chkLogin())
		{
			MyProject.Forms.frmUssd.Show();
			Close();
		}
		else
		{
			ProjectData.EndApp();
		}
	}
}
