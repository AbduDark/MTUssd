using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace MTUssd;

[DesignerGenerated]
public class frmSrvNums : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnDelOne")]
	private Button _btnDelOne;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dataViewGrid")]
	private DataGridView _dataViewGrid;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnAdd")]
	private Button _btnAdd;

	private CData objData;

	private DataTable objDataTabletemp;

	private bool AutoFlag;

	private int CurrIndex;

	private string CLICODE;

	private string FileNamePath;

	[field: AccessedThroughProperty("ODfile")]
	internal virtual OpenFileDialog ODfile
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnDelOne
	{
		[CompilerGenerated]
		get
		{
			return _btnDelOne;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnDelOne_Click;
			Button button = _btnDelOne;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnDelOne = value;
			button = _btnDelOne;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual DataGridView dataViewGrid
	{
		[CompilerGenerated]
		get
		{
			return _dataViewGrid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DataGridViewCellEventHandler value2 = dataViewGrid_CellContentClick;
			DataGridView dataGridView = _dataViewGrid;
			if (dataGridView != null)
			{
				dataGridView.CellContentClick -= value2;
			}
			_dataViewGrid = value;
			dataGridView = _dataViewGrid;
			if (dataGridView != null)
			{
				dataGridView.CellContentClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("txtDail")]
	internal virtual TextBox txtDail
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SFD")]
	internal virtual SaveFileDialog SFD
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTelNum")]
	internal virtual Label lblTelNum
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSrvName")]
	internal virtual TextBox txtSrvName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtEnote")]
	internal virtual TextBox txtEnote
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtMsg")]
	internal virtual TextBox txtMsg
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnAdd
	{
		[CompilerGenerated]
		get
		{
			return _btnAdd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnAdd_Click;
			Button button = _btnAdd;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnAdd = value;
			button = _btnAdd;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	public frmSrvNums()
	{
		base.Load += frmSrvNums_Load;
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		this.ODfile = new System.Windows.Forms.OpenFileDialog();
		this.btnDelOne = new System.Windows.Forms.Button();
		this.dataViewGrid = new System.Windows.Forms.DataGridView();
		this.txtDail = new System.Windows.Forms.TextBox();
		this.SFD = new System.Windows.Forms.SaveFileDialog();
		this.lblTelNum = new System.Windows.Forms.Label();
		this.txtSrvName = new System.Windows.Forms.TextBox();
		this.txtEnote = new System.Windows.Forms.TextBox();
		this.txtMsg = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.btnAdd = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.dataViewGrid).BeginInit();
		base.SuspendLayout();
		this.ODfile.FileName = "OFD";
		this.btnDelOne.Location = new System.Drawing.Point(707, 7);
		this.btnDelOne.Name = "btnDelOne";
		this.btnDelOne.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.btnDelOne.Size = new System.Drawing.Size(77, 30);
		this.btnDelOne.TabIndex = 992;
		this.btnDelOne.Text = "حذف رقم";
		this.btnDelOne.UseVisualStyleBackColor = true;
		this.dataViewGrid.AllowUserToAddRows = false;
		this.dataViewGrid.AllowUserToDeleteRows = false;
		this.dataViewGrid.BackgroundColor = System.Drawing.Color.FromArgb(192, 255, 255);
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dataViewGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.dataViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dataViewGrid.DefaultCellStyle = dataGridViewCellStyle2;
		this.dataViewGrid.Location = new System.Drawing.Point(2, 91);
		this.dataViewGrid.Name = "dataViewGrid";
		this.dataViewGrid.ReadOnly = true;
		this.dataViewGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.dataViewGrid.Size = new System.Drawing.Size(786, 317);
		this.dataViewGrid.TabIndex = 988;
		this.txtDail.Font = new System.Drawing.Font("Tahoma", 18f, System.Drawing.FontStyle.Bold);
		this.txtDail.Location = new System.Drawing.Point(387, 7);
		this.txtDail.MaxLength = 11;
		this.txtDail.Name = "txtDail";
		this.txtDail.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.txtDail.Size = new System.Drawing.Size(174, 36);
		this.txtDail.TabIndex = 985;
		this.txtDail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.SFD.DefaultExt = "*.jpg";
		this.lblTelNum.Font = new System.Drawing.Font("Tahoma", 8f, System.Drawing.FontStyle.Bold);
		this.lblTelNum.ForeColor = System.Drawing.Color.White;
		this.lblTelNum.Location = new System.Drawing.Point(655, 45);
		this.lblTelNum.Name = "lblTelNum";
		this.lblTelNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.lblTelNum.Size = new System.Drawing.Size(129, 19);
		this.lblTelNum.TabIndex = 991;
		this.lblTelNum.Text = "#";
		this.lblTelNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.txtSrvName.Font = new System.Drawing.Font("Tahoma", 18f, System.Drawing.FontStyle.Bold);
		this.txtSrvName.Location = new System.Drawing.Point(2, 7);
		this.txtSrvName.MaxLength = 100;
		this.txtSrvName.Name = "txtSrvName";
		this.txtSrvName.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.txtSrvName.Size = new System.Drawing.Size(280, 36);
		this.txtSrvName.TabIndex = 993;
		this.txtSrvName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.txtEnote.Font = new System.Drawing.Font("Tahoma", 18f, System.Drawing.FontStyle.Bold);
		this.txtEnote.Location = new System.Drawing.Point(2, 45);
		this.txtEnote.MaxLength = 100;
		this.txtEnote.Name = "txtEnote";
		this.txtEnote.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.txtEnote.Size = new System.Drawing.Size(280, 36);
		this.txtEnote.TabIndex = 994;
		this.txtEnote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.txtMsg.Font = new System.Drawing.Font("Tahoma", 18f, System.Drawing.FontStyle.Bold);
		this.txtMsg.Location = new System.Drawing.Point(387, 49);
		this.txtMsg.MaxLength = 100;
		this.txtMsg.Name = "txtMsg";
		this.txtMsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.txtMsg.Size = new System.Drawing.Size(174, 36);
		this.txtMsg.TabIndex = 995;
		this.txtMsg.Text = "ألغاء";
		this.txtMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.ForeColor = System.Drawing.Color.White;
		this.Label1.Location = new System.Drawing.Point(282, 18);
		this.Label1.Name = "Label1";
		this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.Label1.Size = new System.Drawing.Size(99, 19);
		this.Label1.TabIndex = 996;
		this.Label1.Text = "اسم الخدمة";
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.ForeColor = System.Drawing.Color.White;
		this.Label2.Location = new System.Drawing.Point(288, 59);
		this.Label2.Name = "Label2";
		this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.Label2.Size = new System.Drawing.Size(68, 19);
		this.Label2.TabIndex = 997;
		this.Label2.Text = "ملاحظة";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.ForeColor = System.Drawing.Color.White;
		this.Label3.Location = new System.Drawing.Point(564, 56);
		this.Label3.Name = "Label3";
		this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.Label3.Size = new System.Drawing.Size(65, 19);
		this.Label3.TabIndex = 998;
		this.Label3.Text = "الرسالة";
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.ForeColor = System.Drawing.Color.White;
		this.Label5.Location = new System.Drawing.Point(567, 17);
		this.Label5.Name = "Label5";
		this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.Label5.Size = new System.Drawing.Size(47, 19);
		this.Label5.TabIndex = 999;
		this.Label5.Text = "الرقم";
		this.btnAdd.Location = new System.Drawing.Point(624, 7);
		this.btnAdd.Name = "btnAdd";
		this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.btnAdd.Size = new System.Drawing.Size(77, 30);
		this.btnAdd.TabIndex = 1000;
		this.btnAdd.Text = "اضافة";
		this.btnAdd.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Teal;
		base.ClientSize = new System.Drawing.Size(796, 413);
		base.Controls.Add(this.btnAdd);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.txtMsg);
		base.Controls.Add(this.txtEnote);
		base.Controls.Add(this.txtSrvName);
		base.Controls.Add(this.btnDelOne);
		base.Controls.Add(this.lblTelNum);
		base.Controls.Add(this.dataViewGrid);
		base.Controls.Add(this.txtDail);
		base.MaximizeBox = false;
		base.Name = "frmSrvNums";
		this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "اضافة ارقام الخدمات";
		((System.ComponentModel.ISupportInitialize)this.dataViewGrid).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Reset()
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
					break;
				case 69:
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
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 3:
							goto end_IL_0001_3;
						}
						goto default;
					}
					end_IL_0001_2:
					break;
				}
				num2 = 2;
				objData = new CData(Application.StartupPath + "\\maindb.ngm");
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 69;
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

	private void AddTelNum()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num = default(int);
		int num2 = default(int);
		string text = default(string);
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
				case 340:
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
							goto IL_0013;
						case 4:
							goto IL_0021;
						case 5:
							goto IL_002f;
						case 6:
							goto IL_004d;
						case 7:
							goto IL_006b;
						case 8:
							goto IL_0089;
						case 9:
							goto IL_00a7;
						case 10:
							goto IL_00b7;
						case 11:
							goto IL_00cb;
						case 12:
							goto IL_00df;
						case 13:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 14:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_00b7:
					num2 = 10;
					txtDail.Text = "";
					goto IL_00cb;
					IL_00cb:
					num2 = 11;
					txtSrvName.Text = "";
					goto IL_00df;
					IL_00a7:
					num2 = 9;
					objData.DatabaseCommand(text);
					goto IL_00b7;
					IL_00df:
					num2 = 12;
					txtEnote.Text = "";
					break;
					IL_000b:
					num2 = 2;
					text = "Insert Into svrnums ";
					goto IL_0013;
					IL_0013:
					num2 = 3;
					text += "(mobnum,edscrp,enote,srvmsg)";
					goto IL_0021;
					IL_0021:
					num2 = 4;
					text += "Values (";
					goto IL_002f;
					IL_002f:
					num2 = 5;
					text = text + "'" + txtDail.Text + "' , ";
					goto IL_004d;
					IL_004d:
					num2 = 6;
					text = text + "'" + txtSrvName.Text + "' , ";
					goto IL_006b;
					IL_006b:
					num2 = 7;
					text = text + "'" + txtEnote.Text + "' , ";
					goto IL_0089;
					IL_0089:
					num2 = 8;
					text = text + "'" + txtMsg.Text + "') ";
					goto IL_00a7;
					end_IL_0001_2:
					break;
				}
				num2 = 13;
				txtMsg.Text = "";
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 340;
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

	private void GetAllSmsfromDB()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num = default(int);
		int num2 = default(int);
		DataTable dataTable = default(DataTable);
		int num6 = default(int);
		int num7 = default(int);
		DataRow dataRow = default(DataRow);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num5;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000b;
				case 683:
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
							goto IL_0019;
						case 4:
							goto IL_002d;
						case 5:
							goto IL_0041;
						case 6:
							goto IL_0055;
						case 7:
							goto IL_0069;
						case 8:
							goto IL_006e;
						case 9:
							goto IL_0086;
						case 10:
							goto IL_00a5;
						case 11:
							goto IL_00c3;
						case 12:
							goto IL_00cf;
						case 13:
							goto IL_00fb;
						case 14:
							goto IL_0127;
						case 15:
							goto IL_0153;
						case 16:
							goto IL_017f;
						case 17:
							goto IL_0191;
						case 18:
							goto IL_0197;
						case 19:
						case 20:
							goto IL_01a8;
						case 21:
							goto IL_01b9;
						case 22:
							goto IL_01d5;
						case 23:
							goto IL_01f4;
						case 24:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 25:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_01b9:
					num2 = 21;
					dataViewGrid.Columns[0].Width = 120;
					goto IL_01d5;
					IL_01d5:
					num2 = 22;
					dataViewGrid.Columns[1].Width = 200;
					goto IL_01f4;
					IL_01a8:
					num2 = 20;
					dataViewGrid.DataSource = dataTable;
					goto IL_01b9;
					IL_01f4:
					num2 = 23;
					dataViewGrid.Columns[2].Width = 250;
					break;
					IL_000b:
					num2 = 2;
					dataTable = new DataTable("temp");
					goto IL_0019;
					IL_0019:
					num2 = 3;
					dataTable.Columns.Add("الرقم");
					goto IL_002d;
					IL_002d:
					num2 = 4;
					dataTable.Columns.Add("اسم الخدمة");
					goto IL_0041;
					IL_0041:
					num2 = 5;
					dataTable.Columns.Add("نص الرسالة");
					goto IL_0055;
					IL_0055:
					num2 = 6;
					dataTable.Columns.Add("ملاحظة");
					goto IL_0069;
					IL_0069:
					num2 = 7;
					num5 = 0;
					goto IL_006e;
					IL_006e:
					num2 = 8;
					objDataTabletemp = objData.QueryDatabase("SELECT * FROM svrnums  order by mobnum");
					goto IL_0086;
					IL_0086:
					num2 = 9;
					if (objDataTabletemp.Rows.Count > 0)
					{
						goto IL_00a5;
					}
					goto IL_01a8;
					IL_00a5:
					num2 = 10;
					num6 = checked(objDataTabletemp.Rows.Count - 1);
					num7 = 0;
					goto IL_019e;
					IL_019e:
					if (num7 <= num6)
					{
						goto IL_00c3;
					}
					goto IL_01a8;
					IL_00c3:
					num2 = 11;
					dataRow = dataTable.NewRow();
					goto IL_00cf;
					IL_00cf:
					num2 = 12;
					dataRow[0] = RuntimeHelpers.GetObjectValue(objDataTabletemp.Rows[num7]["mobnum"]);
					goto IL_00fb;
					IL_00fb:
					num2 = 13;
					dataRow[1] = RuntimeHelpers.GetObjectValue(objDataTabletemp.Rows[num7]["edscrp"]);
					goto IL_0127;
					IL_0127:
					num2 = 14;
					dataRow[2] = RuntimeHelpers.GetObjectValue(objDataTabletemp.Rows[num7]["srvmsg"]);
					goto IL_0153;
					IL_0153:
					num2 = 15;
					dataRow[3] = RuntimeHelpers.GetObjectValue(objDataTabletemp.Rows[num7]["enote"]);
					goto IL_017f;
					IL_017f:
					num2 = 16;
					dataTable.Rows.Add(dataRow);
					goto IL_0191;
					IL_0191:
					num2 = 17;
					dataRow = null;
					goto IL_0197;
					IL_0197:
					num2 = 18;
					num7 = checked(num7 + 1);
					goto IL_019e;
					end_IL_0001_2:
					break;
				}
				num2 = 24;
				dataViewGrid.Columns[3].Width = 250;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 683;
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

	private void frmSrvNums_Load(object sender, EventArgs e)
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
				case 63:
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
					Reset();
					break;
					end_IL_0001_2:
					break;
				}
				num2 = 3;
				GetAllSmsfromDB();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 63;
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

	private void dataViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
					break;
				case 83:
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
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 3:
							goto end_IL_0001_3;
						}
						goto default;
					}
					end_IL_0001_2:
					break;
				}
				num2 = 2;
				lblTelNum.Text = Conversions.ToString(dataViewGrid[0, e.RowIndex].Value);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 83;
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

	private void btnAdd_Click(object sender, EventArgs e)
	{
		if (txtDail.Text.Trim().Length > 0)
		{
			AddTelNum();
			GetAllSmsfromDB();
		}
	}

	private void btnDelOne_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num = default(int);
		int num2 = default(int);
		int num5 = default(int);
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
				case 211:
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
							goto IL_002b;
						case 5:
							goto IL_0039;
						case 6:
							goto IL_0061;
						case 7:
							goto IL_0081;
						case 8:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 4:
						case 9:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0039:
					num2 = 5;
					objData.DatabaseCommand("Delete From svrnums WHERE mobnum = '" + lblTelNum.Text + "'");
					goto IL_0061;
					IL_0061:
					num2 = 6;
					Interaction.MsgBox("تم حذف الرقم" + lblTelNum.Text, MsgBoxStyle.Information);
					goto IL_0081;
					IL_002b:
					num2 = 3;
					if (num5 == 7)
					{
						goto end_IL_0001_3;
					}
					goto IL_0039;
					IL_0081:
					num2 = 7;
					GetAllSmsfromDB();
					break;
					IL_000b:
					num2 = 2;
					num5 = (int)Interaction.MsgBox("هل  تريد حذف الرقم" + lblTelNum.Text, MsgBoxStyle.YesNo | MsgBoxStyle.Question);
					goto IL_002b;
					end_IL_0001_2:
					break;
				}
				num2 = 8;
				lblTelNum.Text = "";
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 211;
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
