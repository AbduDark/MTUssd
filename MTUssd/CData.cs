using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MTUssd;

public class CData
{
	private OleDbConnection objConnection;

	private DataTable objDataTable;

	public CData()
	{
		objConnection = new OleDbConnection();
		objDataTable = new DataTable();
	}

	public CData(string DBPath)
	{
		try
		{
			objConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBPath);
			objDataTable = new DataTable();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			MysqlConn.ErrorHappen = true;
			ProjectData.ClearProjectError();
		}
	}

	public DataTable QueryDatabase(string Query)
	{
		DataTable result;
		try
		{
			DataSet dataSet = new DataSet();
			DataTable dataTable = new DataTable();
			OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(Query, objConnection);
			oleDbDataAdapter.Fill(dataSet, "DefaultTable");
			dataTable = dataSet.Tables["DefaultTable"];
			objConnection.Close();
			result = dataTable;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MysqlConn.ErrorHappen = true;
			result = objDataTable;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void DatabaseCommand(string CommandString)
	{
		try
		{
			OleDbCommand oleDbCommand = new OleDbCommand();
			oleDbCommand.CommandText = CommandString;
			oleDbCommand.Connection = objConnection;
			oleDbCommand.Connection.Open();
			oleDbCommand.ExecuteNonQuery();
			objConnection.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			ProjectData.ClearProjectError();
		}
	}
}
