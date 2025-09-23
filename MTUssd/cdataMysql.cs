using System;
using System.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace MTUssd;

public class cdataMysql
{
	private DataTable objDataTable;

	public cdataMysql()
	{
		objDataTable = new DataTable();
	}

	public DataTable QueryDatabase(string Query)
	{
		DataSet dataSet = new DataSet();
		DataTable dataTable = new DataTable();
		int num = 0;
		int try000f_dispatch = -1;
		DataTable result;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try000f_dispatch)
				{
				default:
				{
					num = checked(num + 1);
					if (MysqlConn.MysqlConnX.State == ConnectionState.Closed)
					{
						MysqlConn.MysqlConnX.Open();
					}
					MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(Query, MysqlConn.MysqlConnX);
					mySqlDataAdapter.Fill(dataSet, "DefaultTable");
					dataTable = dataSet.Tables["DefaultTable"];
					result = dataTable;
					break;
				}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (num <= 3)
				{
					ProjectData.ClearProjectError();
					try000f_dispatch = 16;
					continue;
				}
				Interaction.MsgBox(ex2.Message, MsgBoxStyle.Critical, MysqlConn.Maintitletxt);
				result = dataTable;
				ProjectData.ClearProjectError();
			}
			break;
		}
		return result;
	}

	public void DatabaseCommandBal(string CommandString)
	{
		int num = 0;
		int try0003_dispatch = -1;
		MySqlCommand mySqlCommand = default(MySqlCommand);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0003_dispatch)
				{
				default:
					mySqlCommand = new MySqlCommand();
					break;
				case 10:
					break;
				}
				num = checked(num + 1);
				mySqlCommand.CommandText = CommandString;
				mySqlCommand.Connection = MysqlConn.MysqlConnX;
				if (mySqlCommand.Connection.State == ConnectionState.Closed)
				{
					mySqlCommand.Connection.Open();
				}
				mySqlCommand.EndExecuteNonQuery(mySqlCommand.BeginExecuteNonQuery());
				break;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (num <= 3)
				{
					ProjectData.ClearProjectError();
					try0003_dispatch = 10;
					continue;
				}
				ProjectData.ClearProjectError();
				break;
			}
		}
	}

	public void DatabaseCommand(string CommandString)
	{
		int num = 0;
		int try0003_dispatch = -1;
		MySqlCommand mySqlCommand = default(MySqlCommand);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0003_dispatch)
				{
				default:
					mySqlCommand = new MySqlCommand();
					break;
				case 10:
					break;
				}
				num = checked(num + 1);
				mySqlCommand.CommandText = CommandString;
				mySqlCommand.Connection = MysqlConn.MysqlConnX;
				if (mySqlCommand.Connection.State == ConnectionState.Closed)
				{
					mySqlCommand.Connection.Open();
				}
				mySqlCommand.EndExecuteNonQuery(mySqlCommand.BeginExecuteNonQuery());
				break;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (num <= 3)
				{
					ProjectData.ClearProjectError();
					try0003_dispatch = 10;
					continue;
				}
				ProjectData.ClearProjectError();
				break;
			}
		}
	}

	public void DatabaseCommandAddCount(string CommandString)
	{
		int num = 0;
		int try0003_dispatch = -1;
		MySqlCommand mySqlCommand = default(MySqlCommand);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0003_dispatch)
				{
				default:
					mySqlCommand = new MySqlCommand();
					break;
				case 10:
					break;
				}
				num = checked(num + 1);
				mySqlCommand.CommandText = CommandString;
				mySqlCommand.Connection = MysqlConn.MysqlConnX;
				if (mySqlCommand.Connection.State == ConnectionState.Closed)
				{
					mySqlCommand.Connection.Open();
				}
				mySqlCommand.EndExecuteNonQuery(mySqlCommand.BeginExecuteNonQuery());
				break;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (num <= 3)
				{
					ProjectData.ClearProjectError();
					try0003_dispatch = 10;
					continue;
				}
				ProjectData.ClearProjectError();
				break;
			}
		}
	}
}
