using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace MTUssd;

[DesignerGenerated]
public class frmfawrysms : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnClear")]
	private Button _btnClear;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnExport")]
	private Button _btnExport;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSaveAS")]
	private Button _btnSaveAS;

	[field: AccessedThroughProperty("lstNumbers")]
	internal virtual ListBox lstNumbers
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lstCodes")]
	internal virtual ListBox lstCodes
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnClear
	{
		[CompilerGenerated]
		get
		{
			return _btnClear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnClear_Click;
			Button button = _btnClear;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnClear = value;
			button = _btnClear;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnExport
	{
		[CompilerGenerated]
		get
		{
			return _btnExport;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnExport_Click;
			Button button = _btnExport;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnExport = value;
			button = _btnExport;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnSaveAS
	{
		[CompilerGenerated]
		get
		{
			return _btnSaveAS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnSaveAS_Click;
			Button button = _btnSaveAS;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnSaveAS = value;
			button = _btnSaveAS;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("lblSavePath")]
	internal virtual Label lblSavePath
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

	public frmfawrysms()
	{
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
		this.lstNumbers = new System.Windows.Forms.ListBox();
		this.lstCodes = new System.Windows.Forms.ListBox();
		this.btnClear = new System.Windows.Forms.Button();
		this.btnExport = new System.Windows.Forms.Button();
		this.btnSaveAS = new System.Windows.Forms.Button();
		this.lblSavePath = new System.Windows.Forms.Label();
		this.SFD = new System.Windows.Forms.SaveFileDialog();
		base.SuspendLayout();
		this.lstNumbers.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lstNumbers.FormattingEnabled = true;
		this.lstNumbers.ItemHeight = 16;
		this.lstNumbers.Location = new System.Drawing.Point(12, 12);
		this.lstNumbers.Name = "lstNumbers";
		this.lstNumbers.Size = new System.Drawing.Size(175, 388);
		this.lstNumbers.TabIndex = 8;
		this.lstCodes.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lstCodes.FormattingEnabled = true;
		this.lstCodes.ItemHeight = 16;
		this.lstCodes.Location = new System.Drawing.Point(193, 12);
		this.lstCodes.Name = "lstCodes";
		this.lstCodes.Size = new System.Drawing.Size(175, 388);
		this.lstCodes.TabIndex = 9;
		this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.btnClear.Font = new System.Drawing.Font("Tahoma", 10f, System.Drawing.FontStyle.Bold);
		this.btnClear.ForeColor = System.Drawing.Color.Black;
		this.btnClear.Location = new System.Drawing.Point(667, 372);
		this.btnClear.Name = "btnClear";
		this.btnClear.Size = new System.Drawing.Size(131, 27);
		this.btnClear.TabIndex = 872;
		this.btnClear.Text = "مسح";
		this.btnClear.UseVisualStyleBackColor = false;
		this.btnExport.Location = new System.Drawing.Point(667, 210);
		this.btnExport.Name = "btnExport";
		this.btnExport.Size = new System.Drawing.Size(131, 34);
		this.btnExport.TabIndex = 873;
		this.btnExport.Text = "تصدير";
		this.btnExport.UseVisualStyleBackColor = true;
		this.btnSaveAS.Location = new System.Drawing.Point(667, 11);
		this.btnSaveAS.Name = "btnSaveAS";
		this.btnSaveAS.Size = new System.Drawing.Size(105, 34);
		this.btnSaveAS.TabIndex = 874;
		this.btnSaveAS.Text = "مكان الحفظ";
		this.btnSaveAS.UseVisualStyleBackColor = true;
		this.lblSavePath.BackColor = System.Drawing.Color.Teal;
		this.lblSavePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.lblSavePath.Font = new System.Drawing.Font("Tahoma", 8f, System.Drawing.FontStyle.Bold);
		this.lblSavePath.ForeColor = System.Drawing.Color.Black;
		this.lblSavePath.Location = new System.Drawing.Point(667, 48);
		this.lblSavePath.Name = "lblSavePath";
		this.lblSavePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.lblSavePath.Size = new System.Drawing.Size(131, 159);
		this.lblSavePath.TabIndex = 875;
		this.lblSavePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.SFD.DefaultExt = "*.jpg";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(810, 411);
		base.Controls.Add(this.lblSavePath);
		base.Controls.Add(this.btnSaveAS);
		base.Controls.Add(this.btnExport);
		base.Controls.Add(this.btnClear);
		base.Controls.Add(this.lstCodes);
		base.Controls.Add(this.lstNumbers);
		base.Name = "frmfawrysms";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "تصدير تحليل الرسائل";
		base.ResumeLayout(false);
	}

	private string OpensaveAs(string tempFilename)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num = default(int);
		int num2 = default(int);
		string result = default(string);
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
				case 234:
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
							goto IL_001e;
						case 4:
							goto IL_0031;
						case 5:
							goto IL_0040;
						case 6:
							goto IL_004f;
						case 7:
							goto IL_0065;
						case 8:
							goto IL_0080;
						case 10:
						case 11:
						case 12:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 9:
						case 13:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_004f:
					num2 = 6;
					if (SFD.ShowDialog() != DialogResult.OK)
					{
						break;
					}
					goto IL_0065;
					IL_0065:
					num2 = 7;
					if (Strings.Len(SFD.FileName) <= 2)
					{
						break;
					}
					goto IL_0080;
					IL_0040:
					num2 = 5;
					SFD.FileName = tempFilename;
					goto IL_004f;
					IL_0080:
					num2 = 8;
					result = SFD.FileName;
					goto end_IL_0001_3;
					IL_000b:
					num2 = 2;
					SFD.Title = "Save File AS";
					goto IL_001e;
					IL_001e:
					num2 = 3;
					SFD.Filter = "Excel - (*.xls)|*.xls";
					goto IL_0031;
					IL_0031:
					num2 = 4;
					SFD.FilterIndex = 1;
					goto IL_0040;
					end_IL_0001_2:
					break;
				}
				num2 = 12;
				result = "";
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 234;
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
		return result;
	}

	private void releaseObject(object obj)
	{
		try
		{
			Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(obj));
			obj = null;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			obj = null;
			MessageBox.Show("Clean Up Memory Error\\n" + ex2.ToString());
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (obj != null)
			{
				int generation = GC.GetGeneration(RuntimeHelpers.GetObjectValue(obj));
				GC.Collect(generation);
			}
			else
			{
				GC.Collect();
				GC.WaitForPendingFinalizers();
			}
		}
	}

	private void btnSaveAS_Click(object sender, EventArgs e)
	{
		string text = "";
		string text2 = "X_" + DateAndTime.Today.Month + "_" + DateAndTime.Today.Day;
		if (Strings.Len(text2) > 2)
		{
			text = OpensaveAs(text2);
			if (Operators.CompareString(text, "", TextCompare: false) != 0)
			{
				lblSavePath.Text = text.Trim('s').Trim('l').Trim('x')
					.Trim('.');
			}
		}
	}

	private void btnExport_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						string text = "";
						double num3 = 0.0;
						double num4 = 0.0;
						double num5 = 1.0;
						if (lblSavePath.Text.Length > 1)
						{
							Cursor = Cursors.WaitCursor;
							object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("EXCEL.APPLICATION"));
							object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Workbooks", new object[0], null, null, null), null, "Open", new object[1] { Application.StartupPath + "\\reports\\xyz.xls" }, null, null, null));
							NewLateBinding.LateSet(objectValue, null, "DisplayAlerts", new object[1] { false }, null, null);
							object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, null, "Worksheets", new object[1] { "Sheet1" }, null, null, null));
							for (num3 = 0.0; !(num3 > (double)(lstNumbers.Items.Count - 1)); num3 += 1.0)
							{
								NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Range", new object[1] { "A" + num5 }, null, null, null), null, "Value", new object[1] { lstNumbers.Items[(int)Math.Round(num3)] }, null, null, OptimisticSet: false, RValueBase: true);
								NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Range", new object[1] { "B" + num5 }, null, null, null), null, "Value", new object[1] { lstCodes.Items[(int)Math.Round(num3)] }, null, null, OptimisticSet: false, RValueBase: true);
								num5 += 1.0;
							}
							if (num5 > 1.0)
							{
								NewLateBinding.LateCall(objectValue2, null, "SaveAs", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(lblSavePath.Text + "_", lstNumbers.Items[0]), ".xls") }, null, null, null, IgnoreReturn: true);
							}
							else
							{
								Interaction.MsgBox("لا توجد اى خطوط ", MsgBoxStyle.Critical);
							}
							NewLateBinding.LateCall(objectValue2, null, "Close", new object[0], null, null, null, IgnoreReturn: true);
							releaseObject(RuntimeHelpers.GetObjectValue(objectValue));
							releaseObject(RuntimeHelpers.GetObjectValue(objectValue2));
							releaseObject(RuntimeHelpers.GetObjectValue(objectValue3));
							objectValue = null;
							Cursor = Cursors.Default;
							if (num5 > 3.0)
							{
								Interaction.MsgBox("تم تصدير جميع البيانات بنجاح", MsgBoxStyle.Information);
							}
						}
						goto end_IL_0001;
					}
					case 773:
						num = -1;
						switch (num2)
						{
						case 2:
							Cursor = Cursors.Default;
							Interaction.MsgBox("حدث خطء", MsgBoxStyle.Critical);
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 773;
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

	private void btnClear_Click(object sender, EventArgs e)
	{
		int num = (int)Interaction.MsgBox("هل تريد مسح كل البيانات", MsgBoxStyle.YesNo | MsgBoxStyle.Question);
		if (num == 6)
		{
			lstNumbers.Items.Clear();
			lstCodes.Items.Clear();
		}
	}
}
