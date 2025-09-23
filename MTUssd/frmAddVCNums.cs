using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MTUssd.My;

namespace MTUssd;

[DesignerGenerated]
public class frmAddVCNums : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnAddFF")]
	private Button _btnAddFF;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSaveAS")]
	private Button _btnSaveAS;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnExport2")]
	private Button _btnExport2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("cmbPaste")]
	private Button _cmbPaste;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnClear")]
	private Button _btnClear;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnDelOnePre")]
	private Button _btnDelOnePre;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtCardNew")]
	private TextBox _txtCardNew;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnDel")]
	private Button _btnDel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lstB1")]
	private ListBox _lstB1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lstB2")]
	private ListBox _lstB2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnExport")]
	private Button _btnExport;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnOpen")]
	private Button _btnOpen;

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
	[AccessedThroughProperty("btnDelNums")]
	private Button _btnDelNums;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnNewnums")]
	private Button _btnNewnums;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtDail")]
	private TextBox _txtDail;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtEnumSH")]
	private TextBox _txtEnumSH;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnADDAuto")]
	private Button _btnADDAuto;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSaveFromOut")]
	private Button _btnSaveFromOut;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnTransfer")]
	private Button _btnTransfer;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnAddFromWebServer")]
	private Button _btnAddFromWebServer;

	private CData objData;

	private DataTable objDataTabletemp;

	private bool AutoFlag;

	private int CurrIndex;

	private string CLICODE;

	private string FileNamePath;

	internal virtual Button btnAddFF
	{
		[CompilerGenerated]
		get
		{
			return _btnAddFF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnAddFF_Click;
			Button button = _btnAddFF;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnAddFF = value;
			button = _btnAddFF;
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

	internal virtual Button btnExport2
	{
		[CompilerGenerated]
		get
		{
			return _btnExport2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnExport2_Click;
			Button button = _btnExport2;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnExport2 = value;
			button = _btnExport2;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button cmbPaste
	{
		[CompilerGenerated]
		get
		{
			return _cmbPaste;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = cmbPaste_Click;
			Button button = _cmbPaste;
			if (button != null)
			{
				button.Click -= value2;
			}
			_cmbPaste = value;
			button = _cmbPaste;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("lblCountPre")]
	internal virtual Label lblCountPre
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

	internal virtual Button btnDelOnePre
	{
		[CompilerGenerated]
		get
		{
			return _btnDelOnePre;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnDelOnePre_Click;
			Button button = _btnDelOnePre;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnDelOnePre = value;
			button = _btnDelOnePre;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual TextBox txtCardNew
	{
		[CompilerGenerated]
		get
		{
			return _txtCardNew;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyPressEventHandler value2 = txtCardNew_KeyPress;
			EventHandler value3 = txtCardNew_TextChanged;
			TextBox textBox = _txtCardNew;
			if (textBox != null)
			{
				textBox.KeyPress -= value2;
				textBox.TextChanged -= value3;
			}
			_txtCardNew = value;
			textBox = _txtCardNew;
			if (textBox != null)
			{
				textBox.KeyPress += value2;
				textBox.TextChanged += value3;
			}
		}
	}

	[field: AccessedThroughProperty("cmbColom")]
	internal virtual ComboBox cmbColom
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnDel
	{
		[CompilerGenerated]
		get
		{
			return _btnDel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnDel_Click;
			Button button = _btnDel;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnDel = value;
			button = _btnDel;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual ListBox lstB1
	{
		[CompilerGenerated]
		get
		{
			return _lstB1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = lstB1_SelectedIndexChanged;
			ListBox listBox = _lstB1;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged -= value2;
			}
			_lstB1 = value;
			listBox = _lstB1;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged += value2;
			}
		}
	}

	internal virtual ListBox lstB2
	{
		[CompilerGenerated]
		get
		{
			return _lstB2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = lstB2_SelectedIndexChanged;
			ListBox listBox = _lstB2;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged -= value2;
			}
			_lstB2 = value;
			listBox = _lstB2;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("lblC")]
	internal virtual Label lblC
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label18")]
	internal virtual Label Label18
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lstNumbers")]
	internal virtual ListBox lstNumbers
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PB1")]
	internal virtual ProgressBar PB1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	internal virtual Button btnOpen
	{
		[CompilerGenerated]
		get
		{
			return _btnOpen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnOpen_Click;
			Button button = _btnOpen;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnOpen = value;
			button = _btnOpen;
			if (button != null)
			{
				button.Click += value2;
			}
		}
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

	[field: AccessedThroughProperty("lblTelNum")]
	internal virtual Label lblTelNum
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCount")]
	internal virtual Label lblCount
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	internal virtual Button btnDelNums
	{
		[CompilerGenerated]
		get
		{
			return _btnDelNums;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnDelNums_Click;
			Button button = _btnDelNums;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnDelNums = value;
			button = _btnDelNums;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnNewnums
	{
		[CompilerGenerated]
		get
		{
			return _btnNewnums;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnNewnums_Click;
			Button button = _btnNewnums;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnNewnums = value;
			button = _btnNewnums;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual TextBox txtDail
	{
		[CompilerGenerated]
		get
		{
			return _txtDail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyPressEventHandler value2 = txtDail_KeyPress;
			EventHandler value3 = txtDail_TextChanged;
			TextBox textBox = _txtDail;
			if (textBox != null)
			{
				textBox.KeyPress -= value2;
				textBox.TextChanged -= value3;
			}
			_txtDail = value;
			textBox = _txtDail;
			if (textBox != null)
			{
				textBox.KeyPress += value2;
				textBox.TextChanged += value3;
			}
		}
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox txtEnumSH
	{
		[CompilerGenerated]
		get
		{
			return _txtEnumSH;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyPressEventHandler value2 = txtEnumSH_KeyPress;
			EventHandler value3 = txtEnumSH_TextChanged;
			TextBox textBox = _txtEnumSH;
			if (textBox != null)
			{
				textBox.KeyPress -= value2;
				textBox.TextChanged -= value3;
			}
			_txtEnumSH = value;
			textBox = _txtEnumSH;
			if (textBox != null)
			{
				textBox.KeyPress += value2;
				textBox.TextChanged += value3;
			}
		}
	}

	[field: AccessedThroughProperty("ODfile")]
	internal virtual OpenFileDialog ODfile
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnADDAuto
	{
		[CompilerGenerated]
		get
		{
			return _btnADDAuto;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnADDAuto_Click;
			Button button = _btnADDAuto;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnADDAuto = value;
			button = _btnADDAuto;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnSaveFromOut
	{
		[CompilerGenerated]
		get
		{
			return _btnSaveFromOut;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnSaveFromOut_Click;
			Button button = _btnSaveFromOut;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnSaveFromOut = value;
			button = _btnSaveFromOut;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnTransfer
	{
		[CompilerGenerated]
		get
		{
			return _btnTransfer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnTransfer_Click;
			Button button = _btnTransfer;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnTransfer = value;
			button = _btnTransfer;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("txtGroupQty")]
	internal virtual TextBox txtGroupQty
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

	internal virtual Button btnAddFromWebServer
	{
		[CompilerGenerated]
		get
		{
			return _btnAddFromWebServer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnAddFromWebServer_Click;
			Button button = _btnAddFromWebServer;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnAddFromWebServer = value;
			button = _btnAddFromWebServer;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	public frmAddVCNums()
	{
		base.Load += frmAddVCNums_Load;
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
		this.btnAddFF = new System.Windows.Forms.Button();
		this.lblSavePath = new System.Windows.Forms.Label();
		this.btnSaveAS = new System.Windows.Forms.Button();
		this.btnExport2 = new System.Windows.Forms.Button();
		this.cmbPaste = new System.Windows.Forms.Button();
		this.lblCountPre = new System.Windows.Forms.Label();
		this.btnClear = new System.Windows.Forms.Button();
		this.btnDelOnePre = new System.Windows.Forms.Button();
		this.txtCardNew = new System.Windows.Forms.TextBox();
		this.cmbColom = new System.Windows.Forms.ComboBox();
		this.btnDel = new System.Windows.Forms.Button();
		this.lstB1 = new System.Windows.Forms.ListBox();
		this.lstB2 = new System.Windows.Forms.ListBox();
		this.lblC = new System.Windows.Forms.Label();
		this.Label18 = new System.Windows.Forms.Label();
		this.SFD = new System.Windows.Forms.SaveFileDialog();
		this.Label3 = new System.Windows.Forms.Label();
		this.lstNumbers = new System.Windows.Forms.ListBox();
		this.PB1 = new System.Windows.Forms.ProgressBar();
		this.btnExport = new System.Windows.Forms.Button();
		this.btnOpen = new System.Windows.Forms.Button();
		this.btnDelOne = new System.Windows.Forms.Button();
		this.lblTelNum = new System.Windows.Forms.Label();
		this.lblCount = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.dataViewGrid = new System.Windows.Forms.DataGridView();
		this.btnDelNums = new System.Windows.Forms.Button();
		this.btnNewnums = new System.Windows.Forms.Button();
		this.txtDail = new System.Windows.Forms.TextBox();
		this.Label10 = new System.Windows.Forms.Label();
		this.txtEnumSH = new System.Windows.Forms.TextBox();
		this.ODfile = new System.Windows.Forms.OpenFileDialog();
		this.btnADDAuto = new System.Windows.Forms.Button();
		this.btnSaveFromOut = new System.Windows.Forms.Button();
		this.btnTransfer = new System.Windows.Forms.Button();
		this.txtGroupQty = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.btnAddFromWebServer = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.dataViewGrid).BeginInit();
		base.SuspendLayout();
		this.btnAddFF.Location = new System.Drawing.Point(171, 529);
		this.btnAddFF.Name = "btnAddFF";
		this.btnAddFF.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.btnAddFF.Size = new System.Drawing.Size(143, 30);
		this.btnAddFF.TabIndex = 982;
		this.btnAddFF.Text = "اضافة الارقام الى التصدير";
		this.btnAddFF.UseVisualStyleBackColor = true;
		this.lblSavePath.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
		this.lblSavePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.lblSavePath.Font = new System.Drawing.Font("Tahoma", 6.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblSavePath.ForeColor = System.Drawing.Color.Black;
		this.lblSavePath.Location = new System.Drawing.Point(700, 515);
		this.lblSavePath.Name = "lblSavePath";
		this.lblSavePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.lblSavePath.Size = new System.Drawing.Size(142, 38);
		this.lblSavePath.TabIndex = 981;
		this.lblSavePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnSaveAS.Location = new System.Drawing.Point(588, 518);
		this.btnSaveAS.Name = "btnSaveAS";
		this.btnSaveAS.Size = new System.Drawing.Size(79, 30);
		this.btnSaveAS.TabIndex = 980;
		this.btnSaveAS.Text = "مكان الحفظ";
		this.btnSaveAS.UseVisualStyleBackColor = true;
		this.btnExport2.Location = new System.Drawing.Point(588, 549);
		this.btnExport2.Name = "btnExport2";
		this.btnExport2.Size = new System.Drawing.Size(77, 30);
		this.btnExport2.TabIndex = 979;
		this.btnExport2.Text = "تصدير";
		this.btnExport2.UseVisualStyleBackColor = true;
		this.cmbPaste.Location = new System.Drawing.Point(252, 86);
		this.cmbPaste.Name = "cmbPaste";
		this.cmbPaste.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.cmbPaste.Size = new System.Drawing.Size(62, 30);
		this.cmbPaste.TabIndex = 974;
		this.cmbPaste.Text = "Paste";
		this.cmbPaste.UseVisualStyleBackColor = true;
		this.lblCountPre.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblCountPre.ForeColor = System.Drawing.Color.White;
		this.lblCountPre.Location = new System.Drawing.Point(596, 181);
		this.lblCountPre.Name = "lblCountPre";
		this.lblCountPre.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.lblCountPre.Size = new System.Drawing.Size(93, 19);
		this.lblCountPre.TabIndex = 973;
		this.lblCountPre.Text = "#";
		this.lblCountPre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.btnClear.Location = new System.Drawing.Point(771, 488);
		this.btnClear.Name = "btnClear";
		this.btnClear.Size = new System.Drawing.Size(72, 24);
		this.btnClear.TabIndex = 972;
		this.btnClear.Text = "مسح الكل";
		this.btnClear.UseVisualStyleBackColor = true;
		this.btnDelOnePre.Location = new System.Drawing.Point(700, 488);
		this.btnDelOnePre.Name = "btnDelOnePre";
		this.btnDelOnePre.Size = new System.Drawing.Size(72, 24);
		this.btnDelOnePre.TabIndex = 971;
		this.btnDelOnePre.Text = "حذف محدد";
		this.btnDelOnePre.UseVisualStyleBackColor = true;
		this.txtCardNew.Font = new System.Drawing.Font("Tahoma", 18f, System.Drawing.FontStyle.Bold);
		this.txtCardNew.Location = new System.Drawing.Point(588, 142);
		this.txtCardNew.MaxLength = 11;
		this.txtCardNew.Name = "txtCardNew";
		this.txtCardNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.txtCardNew.Size = new System.Drawing.Size(254, 36);
		this.txtCardNew.TabIndex = 970;
		this.cmbColom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cmbColom.Font = new System.Drawing.Font("Tahoma", 12f);
		this.cmbColom.FormattingEnabled = true;
		this.cmbColom.Items.AddRange(new object[13]
		{
			"A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
			"K", "L", "M"
		});
		this.cmbColom.Location = new System.Drawing.Point(752, 13);
		this.cmbColom.Name = "cmbColom";
		this.cmbColom.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.cmbColom.Size = new System.Drawing.Size(90, 27);
		this.cmbColom.Sorted = true;
		this.cmbColom.TabIndex = 966;
		this.btnDel.ForeColor = System.Drawing.Color.Black;
		this.btnDel.Location = new System.Drawing.Point(822, 46);
		this.btnDel.Name = "btnDel";
		this.btnDel.Size = new System.Drawing.Size(20, 27);
		this.btnDel.TabIndex = 965;
		this.btnDel.Text = "D";
		this.btnDel.UseVisualStyleBackColor = true;
		this.lstB1.FormattingEnabled = true;
		this.lstB1.Location = new System.Drawing.Point(588, 15);
		this.lstB1.Name = "lstB1";
		this.lstB1.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.lstB1.Size = new System.Drawing.Size(77, 56);
		this.lstB1.TabIndex = 964;
		this.lstB2.FormattingEnabled = true;
		this.lstB2.Location = new System.Drawing.Point(669, 16);
		this.lstB2.Name = "lstB2";
		this.lstB2.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.lstB2.Size = new System.Drawing.Size(77, 56);
		this.lstB2.TabIndex = 963;
		this.lblC.AutoSize = true;
		this.lblC.Location = new System.Drawing.Point(652, 113);
		this.lblC.Name = "lblC";
		this.lblC.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.lblC.Size = new System.Drawing.Size(13, 13);
		this.lblC.TabIndex = 962;
		this.lblC.Text = "0";
		this.Label18.AutoSize = true;
		this.Label18.Location = new System.Drawing.Point(606, 92);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(94, 13);
		this.Label18.TabIndex = 961;
		this.Label18.Text = "عدد الخطوط بالملف";
		this.SFD.DefaultExt = "*.jpg";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(707, 181);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(139, 16);
		this.Label3.TabIndex = 969;
		this.Label3.Text = "الخطوط المراد تخزينها";
		this.lstNumbers.Font = new System.Drawing.Font("Tahoma", 14f, System.Drawing.FontStyle.Bold);
		this.lstNumbers.FormattingEnabled = true;
		this.lstNumbers.ItemHeight = 23;
		this.lstNumbers.Location = new System.Drawing.Point(588, 203);
		this.lstNumbers.Name = "lstNumbers";
		this.lstNumbers.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.lstNumbers.Size = new System.Drawing.Size(254, 280);
		this.lstNumbers.TabIndex = 968;
		this.PB1.Location = new System.Drawing.Point(591, 489);
		this.PB1.Name = "PB1";
		this.PB1.Size = new System.Drawing.Size(103, 18);
		this.PB1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
		this.PB1.TabIndex = 967;
		this.btnExport.Location = new System.Drawing.Point(728, 107);
		this.btnExport.Name = "btnExport";
		this.btnExport.Size = new System.Drawing.Size(114, 29);
		this.btnExport.TabIndex = 960;
		this.btnExport.Text = "استيراد";
		this.btnExport.UseVisualStyleBackColor = true;
		this.btnOpen.Location = new System.Drawing.Point(728, 79);
		this.btnOpen.Name = "btnOpen";
		this.btnOpen.Size = new System.Drawing.Size(114, 29);
		this.btnOpen.TabIndex = 959;
		this.btnOpen.Text = "فتح الملف";
		this.btnOpen.UseVisualStyleBackColor = true;
		this.btnDelOne.Location = new System.Drawing.Point(237, 159);
		this.btnDelOne.Name = "btnDelOne";
		this.btnDelOne.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.btnDelOne.Size = new System.Drawing.Size(77, 30);
		this.btnDelOne.TabIndex = 955;
		this.btnDelOne.Text = "حذف رقم";
		this.btnDelOne.UseVisualStyleBackColor = true;
		this.lblTelNum.Font = new System.Drawing.Font("Tahoma", 8f, System.Drawing.FontStyle.Bold);
		this.lblTelNum.ForeColor = System.Drawing.Color.White;
		this.lblTelNum.Location = new System.Drawing.Point(119, 129);
		this.lblTelNum.Name = "lblTelNum";
		this.lblTelNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.lblTelNum.Size = new System.Drawing.Size(195, 19);
		this.lblTelNum.TabIndex = 954;
		this.lblTelNum.Text = "#";
		this.lblTelNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.lblCount.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblCount.ForeColor = System.Drawing.Color.White;
		this.lblCount.Location = new System.Drawing.Point(23, 115);
		this.lblCount.Name = "lblCount";
		this.lblCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.lblCount.Size = new System.Drawing.Size(58, 19);
		this.lblCount.TabIndex = 953;
		this.lblCount.Text = "#";
		this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.ForeColor = System.Drawing.Color.White;
		this.Label4.Location = new System.Drawing.Point(36, 93);
		this.Label4.Name = "Label4";
		this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.Label4.Size = new System.Drawing.Size(45, 19);
		this.Label4.TabIndex = 952;
		this.Label4.Text = "العدد";
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
		this.dataViewGrid.Location = new System.Drawing.Point(23, 195);
		this.dataViewGrid.Name = "dataViewGrid";
		this.dataViewGrid.ReadOnly = true;
		this.dataViewGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.dataViewGrid.Size = new System.Drawing.Size(291, 328);
		this.dataViewGrid.TabIndex = 951;
		this.btnDelNums.Location = new System.Drawing.Point(14, 11);
		this.btnDelNums.Name = "btnDelNums";
		this.btnDelNums.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.btnDelNums.Size = new System.Drawing.Size(51, 30);
		this.btnDelNums.TabIndex = 950;
		this.btnDelNums.Text = "حذف";
		this.btnDelNums.UseVisualStyleBackColor = true;
		this.btnNewnums.Location = new System.Drawing.Point(71, 11);
		this.btnNewnums.Name = "btnNewnums";
		this.btnNewnums.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.btnNewnums.Size = new System.Drawing.Size(85, 30);
		this.btnNewnums.TabIndex = 949;
		this.btnNewnums.Text = "رقم حركة جديد";
		this.btnNewnums.UseVisualStyleBackColor = true;
		this.txtDail.Font = new System.Drawing.Font("Tahoma", 18f, System.Drawing.FontStyle.Bold);
		this.txtDail.Location = new System.Drawing.Point(14, 47);
		this.txtDail.MaxLength = 11;
		this.txtDail.Name = "txtDail";
		this.txtDail.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.txtDail.Size = new System.Drawing.Size(300, 36);
		this.txtDail.TabIndex = 948;
		this.Label10.AutoSize = true;
		this.Label10.Font = new System.Drawing.Font("Tahoma", 10f, System.Drawing.FontStyle.Bold);
		this.Label10.ForeColor = System.Drawing.Color.White;
		this.Label10.Location = new System.Drawing.Point(243, 18);
		this.Label10.Name = "Label10";
		this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.Label10.Size = new System.Drawing.Size(71, 17);
		this.Label10.TabIndex = 947;
		this.Label10.Text = "رقم حركة";
		this.txtEnumSH.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
		this.txtEnumSH.Font = new System.Drawing.Font("Tahoma", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.txtEnumSH.Location = new System.Drawing.Point(160, 10);
		this.txtEnumSH.Name = "txtEnumSH";
		this.txtEnumSH.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.txtEnumSH.Size = new System.Drawing.Size(76, 33);
		this.txtEnumSH.TabIndex = 946;
		this.txtEnumSH.Text = "0";
		this.txtEnumSH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.ODfile.FileName = "OFD";
		this.btnADDAuto.Location = new System.Drawing.Point(23, 151);
		this.btnADDAuto.Name = "btnADDAuto";
		this.btnADDAuto.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.btnADDAuto.Size = new System.Drawing.Size(166, 38);
		this.btnADDAuto.TabIndex = 956;
		this.btnADDAuto.Text = "التسجيل أليا من الارقام المحددة";
		this.btnADDAuto.UseVisualStyleBackColor = true;
		this.btnSaveFromOut.Location = new System.Drawing.Point(23, 529);
		this.btnSaveFromOut.Name = "btnSaveFromOut";
		this.btnSaveFromOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.btnSaveFromOut.Size = new System.Drawing.Size(129, 29);
		this.btnSaveFromOut.TabIndex = 983;
		this.btnSaveFromOut.Text = "التسجيل من الرئيسية";
		this.btnSaveFromOut.UseVisualStyleBackColor = true;
		this.btnTransfer.Location = new System.Drawing.Point(178, 87);
		this.btnTransfer.Name = "btnTransfer";
		this.btnTransfer.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.btnTransfer.Size = new System.Drawing.Size(68, 28);
		this.btnTransfer.TabIndex = 984;
		this.btnTransfer.Text = ">>";
		this.btnTransfer.UseVisualStyleBackColor = true;
		this.txtGroupQty.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
		this.txtGroupQty.Font = new System.Drawing.Font("Tahoma", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.txtGroupQty.Location = new System.Drawing.Point(429, 11);
		this.txtGroupQty.Name = "txtGroupQty";
		this.txtGroupQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.txtGroupQty.Size = new System.Drawing.Size(76, 33);
		this.txtGroupQty.TabIndex = 985;
		this.txtGroupQty.Text = "300";
		this.txtGroupQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Tahoma", 10f, System.Drawing.FontStyle.Bold);
		this.Label1.ForeColor = System.Drawing.Color.White;
		this.Label1.Location = new System.Drawing.Point(351, 22);
		this.Label1.Name = "Label1";
		this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.Label1.Size = new System.Drawing.Size(62, 17);
		this.Label1.TabIndex = 986;
		this.Label1.Text = "Grp Qty";
		this.btnAddFromWebServer.Location = new System.Drawing.Point(343, 50);
		this.btnAddFromWebServer.Name = "btnAddFromWebServer";
		this.btnAddFromWebServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.btnAddFromWebServer.Size = new System.Drawing.Size(206, 38);
		this.btnAddFromWebServer.TabIndex = 987;
		this.btnAddFromWebServer.Text = "Add From Web Server";
		this.btnAddFromWebServer.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Olive;
		base.ClientSize = new System.Drawing.Size(853, 580);
		base.Controls.Add(this.btnAddFromWebServer);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.txtGroupQty);
		base.Controls.Add(this.btnTransfer);
		base.Controls.Add(this.btnSaveFromOut);
		base.Controls.Add(this.btnAddFF);
		base.Controls.Add(this.lblSavePath);
		base.Controls.Add(this.btnSaveAS);
		base.Controls.Add(this.btnExport2);
		base.Controls.Add(this.cmbPaste);
		base.Controls.Add(this.lblCountPre);
		base.Controls.Add(this.btnClear);
		base.Controls.Add(this.btnDelOnePre);
		base.Controls.Add(this.txtCardNew);
		base.Controls.Add(this.cmbColom);
		base.Controls.Add(this.btnDel);
		base.Controls.Add(this.lstB1);
		base.Controls.Add(this.lstB2);
		base.Controls.Add(this.lblC);
		base.Controls.Add(this.Label18);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.lstNumbers);
		base.Controls.Add(this.PB1);
		base.Controls.Add(this.btnExport);
		base.Controls.Add(this.btnOpen);
		base.Controls.Add(this.btnDelOne);
		base.Controls.Add(this.lblTelNum);
		base.Controls.Add(this.lblCount);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.dataViewGrid);
		base.Controls.Add(this.btnDelNums);
		base.Controls.Add(this.btnNewnums);
		base.Controls.Add(this.txtDail);
		base.Controls.Add(this.Label10);
		base.Controls.Add(this.txtEnumSH);
		base.Controls.Add(this.btnADDAuto);
		base.Name = "frmAddVCNums";
		this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "اضافة خطوط ";
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

	private int GetNextenums()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num = default(int);
		int num2 = default(int);
		int num5 = default(int);
		int result = default(int);
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
				case 197:
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
							goto IL_0023;
						case 4:
							goto IL_0039;
						case 5:
							goto IL_0049;
						case 7:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 6:
						case 8:
						case 9:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0023:
					num2 = 3;
					num5 = checked(objDataTabletemp.Rows.Count - 1);
					goto IL_0039;
					IL_0039:
					num2 = 4;
					if (num5 < 0)
					{
						break;
					}
					goto IL_0049;
					IL_000b:
					num2 = 2;
					objDataTabletemp = objData.QueryDatabase("SELECT distinct enums FROM vcnums order by enums");
					goto IL_0023;
					IL_0049:
					num2 = 5;
					result = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(objDataTabletemp.Rows[num5]["enums"])) + 1.0));
					goto end_IL_0001_3;
					end_IL_0001_2:
					break;
				}
				num2 = 7;
				result = 1;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 197;
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

	private void AddTelNum(string cardIDx)
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
				case 190:
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
							goto IL_0057;
						case 7:
							goto IL_0065;
						case 8:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 9:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_002f:
					num2 = 5;
					text = text + " " + Conversions.ToString(Conversion.Val(txtEnumSH.Text)) + " , ";
					goto IL_0057;
					IL_0057:
					num2 = 6;
					text += " 0 , ";
					goto IL_0065;
					IL_0021:
					num2 = 4;
					text += "Values (";
					goto IL_002f;
					IL_0065:
					num2 = 7;
					text = text + "'" + cardIDx + "') ";
					break;
					IL_000b:
					num2 = 2;
					text = "Insert Into vcnums ";
					goto IL_0013;
					IL_0013:
					num2 = 3;
					text += "(enums,evalue,mobnum)";
					goto IL_0021;
					end_IL_0001_2:
					break;
				}
				num2 = 8;
				objData.DatabaseCommand(text);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 190;
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

	private void Addtelnumber()
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
				case 486:
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
							goto IL_0042;
						case 5:
							goto IL_0052;
						case 7:
						case 8:
							goto IL_006c;
						case 9:
							goto IL_009b;
						case 10:
							goto IL_00ac;
						case 12:
						case 13:
							goto IL_00c7;
						case 14:
							goto IL_00db;
						case 15:
							goto IL_00fa;
						case 17:
						case 18:
						case 19:
							goto IL_0114;
						case 20:
							goto IL_012e;
						case 21:
							goto IL_0142;
						case 22:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 6:
						case 11:
						case 16:
						case 23:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0114:
					num2 = 19;
					AddTelNum(txtDail.Text.Trim());
					goto IL_012e;
					IL_012e:
					num2 = 20;
					if (!btnADDAuto.Enabled)
					{
						break;
					}
					goto IL_0142;
					IL_00fa:
					num2 = 15;
					txtDail.BackColor = Color.PaleVioletRed;
					goto end_IL_0001_3;
					IL_0142:
					num2 = 21;
					GetAllSmsfromDB(Conversions.ToString(Conversion.Val(txtEnumSH.Text)));
					break;
					IL_000b:
					num2 = 2;
					txtDail.BackColor = Color.White;
					goto IL_001e;
					IL_001e:
					num2 = 3;
					if (Conversion.Val(txtEnumSH.Text) <= 0.0)
					{
						goto IL_0042;
					}
					goto IL_006c;
					IL_0042:
					num2 = 4;
					Interaction.MsgBox("اكمل الخانات اللازمة من فضلك", MsgBoxStyle.Critical);
					goto IL_0052;
					IL_0052:
					num2 = 5;
					txtDail.BackColor = Color.PaleVioletRed;
					goto end_IL_0001_3;
					IL_006c:
					num2 = 8;
					if ((txtDail.Text.Trim().Length <= 0) & btnADDAuto.Enabled)
					{
						goto IL_009b;
					}
					goto IL_00c7;
					IL_009b:
					num2 = 9;
					Interaction.MsgBox("الرقم غير سليم", MsgBoxStyle.Critical);
					goto IL_00ac;
					IL_00ac:
					num2 = 10;
					txtDail.BackColor = Color.PaleVioletRed;
					goto end_IL_0001_3;
					IL_00c7:
					num2 = 13;
					if (btnADDAuto.Enabled)
					{
						goto IL_00db;
					}
					goto IL_0114;
					IL_00db:
					num2 = 14;
					if (chktelNumFound(txtDail.Text.Trim()))
					{
						goto IL_00fa;
					}
					goto IL_0114;
					end_IL_0001_2:
					break;
				}
				num2 = 22;
				txtDail.BackColor = Color.PaleGreen;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 486;
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

	private bool chktelNumFound(string eetel)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num = default(int);
		int num2 = default(int);
		bool result = default(bool);
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
				case 206:
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
							goto IL_002e;
						case 4:
							goto IL_0049;
						case 5:
							goto IL_005a;
						case 6:
							goto IL_008a;
						case 7:
						case 8:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 9:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0049:
					num2 = 4;
					if (!AutoFlag)
					{
						goto IL_005a;
					}
					goto IL_008a;
					IL_005a:
					num2 = 5;
					Interaction.MsgBox(Operators.ConcatenateObject("الرقم موجود من قبل بالحركة رقم \r\n", objDataTabletemp.Rows[0]["enums"]), MsgBoxStyle.Critical);
					goto IL_008a;
					IL_002e:
					num2 = 3;
					if (objDataTabletemp.Rows.Count <= 0)
					{
						break;
					}
					goto IL_0049;
					IL_008a:
					num2 = 6;
					result = true;
					goto end_IL_0001_3;
					IL_000b:
					num2 = 2;
					objDataTabletemp = objData.QueryDatabase("SELECT * FROM vcnums where  mobnum = '" + eetel + "'");
					goto IL_002e;
					end_IL_0001_2:
					break;
				}
				num2 = 8;
				result = false;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 206;
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

	private void GetAllSmsfromDB(string eeDB)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num = default(int);
		int num2 = default(int);
		DataTable dataTable = default(DataTable);
		int num5 = default(int);
		int num7 = default(int);
		DataRow dataRow = default(DataRow);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num6;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000b;
				case 531:
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
							goto IL_0046;
						case 7:
							goto IL_0073;
						case 8:
							goto IL_0091;
						case 9:
							goto IL_00ae;
						case 10:
							goto IL_00ba;
						case 11:
							goto IL_00e6;
						case 12:
							goto IL_0112;
						case 13:
							goto IL_0124;
						case 14:
							goto IL_012a;
						case 15:
						case 16:
							goto IL_013b;
						case 17:
							goto IL_015f;
						case 18:
							goto IL_0170;
						case 19:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 20:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_013b:
					num2 = 16;
					lblCount.Text = Conversions.ToString(objDataTabletemp.Rows.Count);
					goto IL_015f;
					IL_015f:
					num2 = 17;
					dataViewGrid.DataSource = dataTable;
					goto IL_0170;
					IL_012a:
					num2 = 14;
					num5 = checked(num5 + 1);
					goto IL_0131;
					IL_0170:
					num2 = 18;
					dataViewGrid.Columns[0].Width = 160;
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
					dataTable.Columns.Add("اخر امر تشغيل");
					goto IL_0041;
					IL_0041:
					num2 = 5;
					num6 = 0;
					goto IL_0046;
					IL_0046:
					num2 = 6;
					objDataTabletemp = objData.QueryDatabase("SELECT * FROM vcnums where  enums =  " + Conversions.ToString(Conversion.Val(eeDB)) + " order by eid");
					goto IL_0073;
					IL_0073:
					num2 = 7;
					if (objDataTabletemp.Rows.Count > 0)
					{
						goto IL_0091;
					}
					goto IL_013b;
					IL_0091:
					num2 = 8;
					num7 = checked(objDataTabletemp.Rows.Count - 1);
					num5 = 0;
					goto IL_0131;
					IL_0131:
					if (num5 <= num7)
					{
						goto IL_00ae;
					}
					goto IL_013b;
					IL_00ae:
					num2 = 9;
					dataRow = dataTable.NewRow();
					goto IL_00ba;
					IL_00ba:
					num2 = 10;
					dataRow[0] = RuntimeHelpers.GetObjectValue(objDataTabletemp.Rows[num5]["mobnum"]);
					goto IL_00e6;
					IL_00e6:
					num2 = 11;
					dataRow[1] = RuntimeHelpers.GetObjectValue(objDataTabletemp.Rows[num5]["evalue"]);
					goto IL_0112;
					IL_0112:
					num2 = 12;
					dataTable.Rows.Add(dataRow);
					goto IL_0124;
					IL_0124:
					num2 = 13;
					dataRow = null;
					goto IL_012a;
					end_IL_0001_2:
					break;
				}
				num2 = 19;
				dataViewGrid.Columns[1].Width = 160;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 531;
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

	private void GetAllSmsfromWWDB(string eeDB)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num = default(int);
		int num2 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num7;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000b;
				case 222:
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
							goto IL_0010;
						case 4:
							goto IL_003d;
						case 5:
							goto IL_0058;
						case 6:
							goto IL_0072;
						case 7:
							goto IL_009b;
						default:
							goto end_IL_0001;
						case 8:
						case 9:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_00a1:
					if (num5 > num6)
					{
						goto end_IL_0001_2;
					}
					goto IL_0072;
					IL_0072:
					num2 = 6;
					AddBoxToLstPreXC(Conversions.ToString(objDataTabletemp.Rows[num5]["mobnum"]));
					goto IL_009b;
					IL_0058:
					num2 = 5;
					num6 = checked(objDataTabletemp.Rows.Count - 1);
					num5 = 0;
					goto IL_00a1;
					IL_009b:
					num2 = 7;
					num5 = checked(num5 + 1);
					goto IL_00a1;
					IL_000b:
					num2 = 2;
					num7 = 0;
					goto IL_0010;
					IL_0010:
					num2 = 3;
					objDataTabletemp = objData.QueryDatabase("SELECT * FROM vcnums where  enums =  " + Conversions.ToString(Conversion.Val(eeDB)) + " order by eid");
					goto IL_003d;
					IL_003d:
					num2 = 4;
					if (objDataTabletemp.Rows.Count <= 0)
					{
						goto end_IL_0001_2;
					}
					goto IL_0058;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 222;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void GetAllSmsfromDBExc(string eeDB)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num = default(int);
		int num2 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num7;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000b;
				case 262:
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
							goto IL_0010;
						case 4:
							goto IL_003d;
						case 5:
							goto IL_0058;
						case 6:
							goto IL_0072;
						case 7:
							goto IL_009b;
						case 8:
						case 9:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 10:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_00a1:
					if (num5 > num6)
					{
						break;
					}
					goto IL_0072;
					IL_0072:
					num2 = 6;
					AddBoxToLstPreXC(Conversions.ToString(objDataTabletemp.Rows[num5]["mobnum"]));
					goto IL_009b;
					IL_0058:
					num2 = 5;
					num6 = checked(objDataTabletemp.Rows.Count - 1);
					num5 = 0;
					goto IL_00a1;
					IL_009b:
					num2 = 7;
					num5 = checked(num5 + 1);
					goto IL_00a1;
					IL_000b:
					num2 = 2;
					num7 = 0;
					goto IL_0010;
					IL_0010:
					num2 = 3;
					objDataTabletemp = objData.QueryDatabase("SELECT * FROM vcnums where  enums =  " + Conversions.ToString(Conversion.Val(eeDB)) + " order by eid");
					goto IL_003d;
					IL_003d:
					num2 = 4;
					if (objDataTabletemp.Rows.Count <= 0)
					{
						break;
					}
					goto IL_0058;
					end_IL_0001_2:
					break;
				}
				num2 = 9;
				lblCount.Text = Conversions.ToString(objDataTabletemp.Rows.Count);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 262;
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

	private void txtDail_KeyPress(object sender, KeyPressEventArgs e)
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
				case 179:
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
							goto IL_0020;
						case 4:
							goto IL_0040;
						case 5:
							goto IL_0049;
						case 6:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 7:
						case 8:
						case 9:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0020:
					num2 = 3;
					if (txtDail.Text.Trim().Length <= 0)
					{
						goto end_IL_0001_3;
					}
					goto IL_0040;
					IL_0040:
					num2 = 4;
					Addtelnumber();
					goto IL_0049;
					IL_000b:
					num2 = 2;
					if (Strings.Asc(e.KeyChar) != 13)
					{
						goto end_IL_0001_3;
					}
					goto IL_0020;
					IL_0049:
					num2 = 5;
					if (!(txtDail.BackColor == Color.PaleGreen))
					{
						goto end_IL_0001_3;
					}
					break;
					end_IL_0001_2:
					break;
				}
				num2 = 6;
				txtDail.Text = "";
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 179;
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

	private void frmAddVCNums_Load(object sender, EventArgs e)
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
				case 102:
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
							goto IL_0014;
						case 4:
							goto IL_0024;
						case 5:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 6:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_000b:
					num2 = 2;
					Reset();
					goto IL_0014;
					IL_0014:
					num2 = 3;
					btnNewnums_Click(RuntimeHelpers.GetObjectValue(sender), e);
					goto IL_0024;
					IL_0024:
					num2 = 4;
					AutoFlag = false;
					break;
					end_IL_0001_2:
					break;
				}
				num2 = 5;
				cmbColom.SelectedIndex = 0;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 102;
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

	private void btnNewnums_Click(object sender, EventArgs e)
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
				case 90:
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
					txtEnumSH.Text = Conversions.ToString(GetNextenums());
					break;
					end_IL_0001_2:
					break;
				}
				num2 = 3;
				GetAllSmsfromDB(txtEnumSH.Text);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 90;
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

	private void btnDelNums_Click(object sender, EventArgs e)
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
				case 160:
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
							goto IL_003b;
						case 5:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 4:
						case 6:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_000b:
					num2 = 2;
					num5 = (int)Interaction.MsgBox("هل  تريد حذف رقم حركة ادخال رقم" + txtEnumSH.Text + "\r\n وعددهم " + lblCount.Text, MsgBoxStyle.YesNo | MsgBoxStyle.Question);
					goto IL_003b;
					IL_003b:
					num2 = 3;
					if (num5 != 7)
					{
						break;
					}
					goto end_IL_0001_3;
					end_IL_0001_2:
					break;
				}
				num2 = 5;
				objData.DatabaseCommand("Delete From vcnums WHERE enums = " + Conversions.ToString(Conversion.Val(txtEnumSH.Text)));
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 160;
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

	private void txtEnumSH_KeyPress(object sender, KeyPressEventArgs e)
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
				case 224:
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
							goto IL_0020;
						case 4:
							goto IL_0043;
						case 5:
						case 6:
						case 7:
							goto IL_005b;
						case 8:
							goto IL_0074;
						case 9:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 10:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0043:
					num2 = 4;
					GetAllSmsfromDB(txtEnumSH.Text);
					goto IL_005b;
					IL_005b:
					num2 = 7;
					if (Strings.Asc(e.KeyChar) == 8)
					{
						goto end_IL_0001_3;
					}
					goto IL_0074;
					IL_0020:
					num2 = 3;
					if (Conversion.Val(txtEnumSH.Text) > 0.0)
					{
						goto IL_0043;
					}
					goto IL_005b;
					IL_0074:
					num2 = 8;
					if (!((Strings.Asc(e.KeyChar) < 48) | (Strings.Asc(e.KeyChar) > 57)))
					{
						goto end_IL_0001_3;
					}
					break;
					IL_000b:
					num2 = 2;
					if (Strings.Asc(e.KeyChar) == 13)
					{
						goto IL_0020;
					}
					goto IL_005b;
					end_IL_0001_2:
					break;
				}
				num2 = 9;
				e.KeyChar = '\0';
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 224;
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
				case 222:
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
					objData.DatabaseCommand("Delete From vcnums WHERE mobnum = '" + lblTelNum.Text + "'");
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
					GetAllSmsfromDB(txtEnumSH.Text);
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
				try0001_dispatch = 222;
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

	private void btnADDAuto_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num = default(int);
		int num2 = default(int);
		int num5 = default(int);
		int num6 = default(int);
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
				case 395:
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
							goto IL_000f;
						case 4:
							goto IL_0020;
						case 6:
							goto IL_0032;
						case 7:
							goto IL_003b;
						case 10:
							goto IL_004c;
						case 11:
							goto IL_0071;
						case 12:
							goto IL_007b;
						case 13:
							goto IL_0082;
						case 14:
							goto IL_00b0;
						case 8:
						case 9:
						case 15:
							goto IL_00ba;
						case 16:
							goto IL_00dc;
						case 17:
							goto IL_00fb;
						case 18:
							goto IL_010c;
						case 19:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 5:
						case 20:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_007b:
					num2 = 12;
					num5 = checked(num5 + 1);
					goto IL_0082;
					IL_0082:
					num2 = 13;
					lblCount.Text = Conversions.ToString(Conversion.Val(lblCount.Text) + 1.0);
					goto IL_00b0;
					IL_0071:
					num2 = 11;
					Addtelnumber();
					goto IL_007b;
					IL_00b0:
					num2 = 14;
					Application.DoEvents();
					goto IL_00ba;
					IL_000b:
					num2 = 2;
					num5 = 0;
					goto IL_000f;
					IL_000f:
					num2 = 3;
					num6 = (int)Interaction.MsgBox("هل تريد اضافة الارقام المحددة  الى النظام", MsgBoxStyle.YesNo | MsgBoxStyle.Question);
					goto IL_0020;
					IL_0020:
					num2 = 4;
					if (num6 == 7)
					{
						goto end_IL_0001_3;
					}
					goto IL_0032;
					IL_0032:
					num2 = 6;
					AutoFlag = true;
					goto IL_003b;
					IL_003b:
					num2 = 7;
					btnADDAuto.Enabled = false;
					goto IL_00ba;
					IL_00ba:
					num2 = 9;
					if (num5 < lstNumbers.Items.Count)
					{
						goto IL_004c;
					}
					goto IL_00dc;
					IL_00dc:
					num2 = 16;
					GetAllSmsfromDB(Conversions.ToString(Conversion.Val(txtEnumSH.Text)));
					goto IL_00fb;
					IL_00fb:
					num2 = 17;
					Interaction.MsgBox("تم اضافة الارقام بنجاح", MsgBoxStyle.Information);
					goto IL_010c;
					IL_010c:
					num2 = 18;
					AutoFlag = false;
					break;
					IL_004c:
					num2 = 10;
					txtDail.Text = Conversions.ToString(lstNumbers.Items[num5]);
					goto IL_0071;
					end_IL_0001_2:
					break;
				}
				num2 = 19;
				btnADDAuto.Enabled = true;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 395;
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

	private void btnDelOnePre_Click(object sender, EventArgs e)
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
				case 145:
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
							goto IL_0024;
						case 4:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 5:
						case 6:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_000b:
					num2 = 2;
					if (lstNumbers.SelectedItems.Count <= 0)
					{
						goto end_IL_0001_3;
					}
					goto IL_0024;
					IL_0024:
					num2 = 3;
					lstNumbers.Items.RemoveAt(lstNumbers.SelectedIndex);
					break;
					end_IL_0001_2:
					break;
				}
				num2 = 4;
				lblCountPre.Text = Conversions.ToString(lstNumbers.Items.Count);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 145;
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

	private void btnClear_Click(object sender, EventArgs e)
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
					lstNumbers.Items.Clear();
					break;
					end_IL_0001_2:
					break;
				}
				num2 = 3;
				lblCountPre.Text = "0";
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

	private void txtCardNew_KeyPress(object sender, KeyPressEventArgs e)
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
				case 262:
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
							goto IL_0023;
						case 4:
							goto IL_0043;
						case 5:
							goto IL_0056;
						case 6:
							goto IL_0074;
						case 8:
						case 9:
							goto IL_008b;
						case 10:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 7:
						case 11:
						case 12:
						case 13:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0056:
					num2 = 5;
					if (chktelNumFound(txtCardNew.Text.Trim()))
					{
						goto IL_0074;
					}
					goto IL_008b;
					IL_0074:
					num2 = 6;
					txtCardNew.BackColor = Color.PaleVioletRed;
					goto end_IL_0001_3;
					IL_0043:
					num2 = 4;
					txtCardNew.BackColor = Color.White;
					goto IL_0056;
					IL_008b:
					num2 = 9;
					AddBoxToLstPre(txtCardNew.Text.Trim());
					break;
					IL_000b:
					num2 = 2;
					if (Strings.Asc(e.KeyChar) != 13)
					{
						goto end_IL_0001_3;
					}
					goto IL_0023;
					IL_0023:
					num2 = 3;
					if (txtCardNew.Text.Trim().Length <= 0)
					{
						goto end_IL_0001_3;
					}
					goto IL_0043;
					end_IL_0001_2:
					break;
				}
				num2 = 10;
				txtCardNew.Text = "";
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 262;
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

	private void AddBoxToLstPre(string EER)
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
				case 244:
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
							goto IL_000f;
						case 4:
							goto IL_0020;
						case 6:
						case 7:
						case 9:
						case 10:
							goto IL_003a;
						case 11:
							goto IL_004a;
						case 13:
							goto IL_005c;
						case 5:
						case 8:
						case 12:
						case 14:
							goto IL_0072;
						case 15:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 16:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_004a:
					num2 = 11;
					if (num5 < 0)
					{
						goto IL_005c;
					}
					goto IL_0072;
					IL_005c:
					num2 = 13;
					lstNumbers.Items.Add(EER);
					goto IL_0072;
					IL_003a:
					num2 = 10;
					num5 = lstNumbers.FindString(EER);
					goto IL_004a;
					IL_0072:
					num2 = 14;
					lblCountPre.Text = Conversions.ToString(lstNumbers.Items.Count);
					break;
					IL_000b:
					num2 = 2;
					num5 = 0;
					goto IL_000f;
					IL_000f:
					num2 = 3;
					if (EER.Length > 0)
					{
						goto IL_0020;
					}
					goto IL_0072;
					IL_0020:
					num2 = 4;
					if (chktelNumFound(EER))
					{
						goto IL_0072;
					}
					goto IL_003a;
					end_IL_0001_2:
					break;
				}
				num2 = 15;
				Application.DoEvents();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 244;
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

	private void AddBoxToLstPreXC(string EER)
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
				case 165:
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
							goto IL_000f;
						case 4:
							goto IL_001e;
						case 6:
							goto IL_002f;
						case 5:
						case 7:
							goto IL_0044;
						case 8:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 9:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_001e:
					num2 = 4;
					if (num5 < 0)
					{
						goto IL_002f;
					}
					goto IL_0044;
					IL_002f:
					num2 = 6;
					lstNumbers.Items.Add(EER);
					goto IL_0044;
					IL_000f:
					num2 = 3;
					num5 = lstNumbers.FindString(EER);
					goto IL_001e;
					IL_0044:
					num2 = 7;
					lblCountPre.Text = Conversions.ToString(lstNumbers.Items.Count);
					break;
					IL_000b:
					num2 = 2;
					num5 = 0;
					goto IL_000f;
					end_IL_0001_2:
					break;
				}
				num2 = 8;
				Application.DoEvents();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 165;
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

	private void btnOpen_Click(object sender, EventArgs e)
	{
		OpenFileLoc();
	}

	private void btnDel_Click(object sender, EventArgs e)
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
				case 218:
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
							goto IL_0025;
						case 4:
							goto IL_006e;
						case 5:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 6:
						case 7:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_000b:
					num2 = 2;
					if (lstB1.SelectedIndex < 0)
					{
						goto end_IL_0001_3;
					}
					goto IL_0025;
					IL_0025:
					num2 = 3;
					lblC.Text = Conversions.ToString(Conversion.Val(lblC.Text) - Conversion.Val(RuntimeHelpers.GetObjectValue(lstB2.Items[lstB2.SelectedIndex])));
					goto IL_006e;
					IL_006e:
					num2 = 4;
					lstB1.Items.RemoveAt(lstB1.SelectedIndex);
					break;
					end_IL_0001_2:
					break;
				}
				num2 = 5;
				lstB2.Items.RemoveAt(lstB2.SelectedIndex);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 218;
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

	private void lstB2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (lstB2.SelectedIndex >= 0)
		{
			lstB1.SelectedIndex = lstB2.SelectedIndex;
		}
	}

	private void lstB1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (lstB1.SelectedIndex >= 0)
		{
			lstB2.SelectedIndex = lstB1.SelectedIndex;
		}
	}

	private void OpenFileLoc()
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
				case 268:
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
							goto IL_0063;
						case 8:
							goto IL_007e;
						case 9:
							goto IL_0091;
						case 10:
							goto IL_00a1;
						case 11:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 12:
						case 13:
						case 14:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_007e:
					num2 = 8;
					FileNamePath = ODfile.FileName;
					goto IL_0091;
					IL_0091:
					num2 = 9;
					btnOpen.Enabled = false;
					goto IL_00a1;
					IL_0063:
					num2 = 7;
					if (Strings.Len(ODfile.FileName) <= 2)
					{
						goto end_IL_0001_3;
					}
					goto IL_007e;
					IL_00a1:
					num2 = 10;
					OpenExcelFileToprocess();
					break;
					IL_000b:
					num2 = 2;
					ODfile.Title = "Open File";
					goto IL_001e;
					IL_001e:
					num2 = 3;
					ODfile.Filter = "Excel - (*.xls;*.xlsx)|*.xls;*.xlsx";
					goto IL_0031;
					IL_0031:
					num2 = 4;
					ODfile.FilterIndex = 1;
					goto IL_0040;
					IL_0040:
					num2 = 5;
					ODfile.Multiselect = false;
					goto IL_004f;
					IL_004f:
					num2 = 6;
					if (ODfile.ShowDialog() != DialogResult.OK)
					{
						goto end_IL_0001_3;
					}
					goto IL_0063;
					end_IL_0001_2:
					break;
				}
				num2 = 11;
				btnOpen.Enabled = true;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 268;
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

	private void DoExcelImport()
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
						double num3 = 0.0;
						double num4 = 0.0;
						long num5 = 1L;
						double num6 = 0.0;
						double num7 = 0.0;
						double num8 = 0.0;
						double num9 = 0.0;
						double num10 = 0.0;
						double num11 = 0.0;
						int num12 = 0;
						Cursor = Cursors.WaitCursor;
						PB1.Minimum = 0;
						PB1.Value = 0;
						PB1.Maximum = (int)Math.Round(Conversion.Val(lblC.Text));
						object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("EXCEL.APPLICATION"));
						object instance = NewLateBinding.LateGet(objectValue, null, "Workbooks", new object[0], null, null, null);
						object[] array = new object[1];
						ref string fileNamePath = ref FileNamePath;
						array[0] = fileNamePath;
						object[] array2 = array;
						bool[] obj = new bool[1] { true };
						bool[] array3 = obj;
						object obj2 = NewLateBinding.LateGet(instance, null, "Open", array, null, null, obj);
						if (array3[0])
						{
							fileNamePath = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
						}
						object objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
						NewLateBinding.LateSet(objectValue, null, "DisplayAlerts", new object[1] { false }, null, null);
						object objectValue3;
						while (true)
						{
							ListBox.ObjectCollection items;
							int index;
							object[] obj3 = new object[1] { (items = lstB1.Items)[index = num12] };
							array2 = obj3;
							bool[] obj4 = new bool[1] { true };
							array3 = obj4;
							object obj5 = NewLateBinding.LateGet(objectValue2, null, "Worksheets", obj3, null, null, obj4);
							if (array3[0])
							{
								items[index] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2[0]));
							}
							objectValue3 = RuntimeHelpers.GetObjectValue(obj5);
							for (num5 = 1L; !Operators.ConditionalCompareObjectGreater(num5, lstB2.Items[num12], TextCompare: false); num5++)
							{
								string text = "";
								if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Range", new object[1] { cmbColom.Text + num5 }, null, null, null), null, "value", new object[0], null, null, null))))
								{
									text = NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Range", new object[1] { cmbColom.Text + num5 }, null, null, null), null, "value", new object[0], null, null, null).ToString().Trim();
									AddBoxToLstPre(text);
								}
								PB1.Value++;
								Application.DoEvents();
							}
							num12++;
							if (!((num12 < lstB2.Items.Count) & (Information.Err().Number == 0)))
							{
								break;
							}
							num5 = 1L;
						}
						NewLateBinding.LateCall(objectValue2, null, "Close", new object[0], null, null, null, IgnoreReturn: true);
						releaseObject(RuntimeHelpers.GetObjectValue(objectValue));
						releaseObject(RuntimeHelpers.GetObjectValue(objectValue2));
						releaseObject(RuntimeHelpers.GetObjectValue(objectValue3));
						objectValue = null;
						Cursor = Cursors.Default;
						if (num5 > 3)
						{
							Interaction.MsgBox("تم استيراد جميع الارقام بنجاح", MsgBoxStyle.Information);
						}
						goto end_IL_0001;
					}
					case 912:
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
			catch (object obj6) when (obj6 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj6);
				try0001_dispatch = 912;
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

	private void OpenExcelFileToprocess()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		long num5 = default(long);
		double num6 = default(double);
		double num7 = default(double);
		object obj = default(object);
		object objectValue = default(object);
		int num = default(int);
		object objectValue2 = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					object instance2;
					object[] obj3;
					object[] array2;
					bool[] obj4;
					bool[] array3;
					object obj2;
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						double num3 = 0.0;
						double num4 = 0.0;
						num5 = 1L;
						num6 = 1.0;
						num7 = 0.0;
						if (Operators.CompareString(FileNamePath.Trim(), "", TextCompare: false) == 0)
						{
							goto end_IL_0001;
						}
						Cursor = Cursors.WaitCursor;
						obj = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("EXCEL.APPLICATION"));
						object instance = NewLateBinding.LateGet(obj, null, "Workbooks", new object[0], null, null, null);
						object[] array = new object[1];
						ref string fileNamePath = ref FileNamePath;
						array[0] = fileNamePath;
						array2 = array;
						obj2 = NewLateBinding.LateGet(instance, null, "Open", array, null, null, array3 = new bool[1] { true });
						if (array3[0])
						{
							fileNamePath = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
						}
						objectValue = RuntimeHelpers.GetObjectValue(obj2);
						NewLateBinding.LateSet(obj, null, "DisplayAlerts", new object[1] { false }, null, null);
						num5 = 1L;
						lblC.Text = "0";
						lstB1.Items.Clear();
						lstB2.Items.Clear();
						num7 = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Worksheets", new object[0], null, null, null), null, "count", new object[0], null, null, null));
						goto IL_017b;
					}
					case 887:
						{
							num = -1;
							switch (num2)
							{
							case 2:
								break;
							default:
								goto end_IL_0001_2;
							}
							goto IL_0242;
						}
						IL_017b:
						instance2 = objectValue;
						obj3 = new object[1] { num6 };
						array2 = obj3;
						obj4 = new bool[1] { true };
						array3 = obj4;
						obj2 = NewLateBinding.LateGet(instance2, null, "Worksheets", obj3, null, null, obj4);
						if (array3[0])
						{
							num6 = (double)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(double));
						}
						objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
						while (NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, null, "Range", new object[1] { cmbColom.Text + num5 }, null, null, null), null, "value", new object[0], null, null, null).ToString().Trim()
							.Length >= 4)
						{
							num5++;
						}
						goto IL_0242;
						IL_0242:
						num5--;
						if (num5 > 1)
						{
							lstB1.Items.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, null, "name", new object[0], null, null, null)));
							lstB2.Items.Add(num5);
						}
						num6 += 1.0;
						lblC.Text = Conversions.ToString(Conversion.Val(lblC.Text) + (double)num5);
						if (Conversion.Val(lblC.Text) < 0.0)
						{
							lblC.Text = "0";
						}
						if ((num6 <= num7) & (Information.Err().Number == 0))
						{
							num5 = 1L;
							goto IL_017b;
						}
						NewLateBinding.LateCall(objectValue, null, "Close", new object[0], null, null, null, IgnoreReturn: true);
						releaseObject(RuntimeHelpers.GetObjectValue(obj));
						releaseObject(RuntimeHelpers.GetObjectValue(objectValue));
						releaseObject(RuntimeHelpers.GetObjectValue(objectValue2));
						obj = null;
						Cursor = Cursors.Default;
						goto end_IL_0001;
						end_IL_0001_2:
						break;
					}
				}
			}
			catch (object obj5) when (obj5 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj5);
				try0001_dispatch = 887;
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

	private void btnExport_Click(object sender, EventArgs e)
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
				case 158:
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
							goto IL_002c;
						case 4:
							goto IL_003b;
						case 5:
							goto IL_0044;
						case 7:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 6:
						case 8:
						case 9:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_002c:
					num2 = 3;
					btnExport.Enabled = false;
					goto IL_003b;
					IL_003b:
					num2 = 4;
					DoExcelImport();
					goto IL_0044;
					IL_000b:
					num2 = 2;
					if (!(Conversion.Val(lblC.Text) > 0.0))
					{
						break;
					}
					goto IL_002c;
					IL_0044:
					num2 = 5;
					btnExport.Enabled = true;
					goto end_IL_0001_3;
					end_IL_0001_2:
					break;
				}
				num2 = 7;
				Interaction.MsgBox("لا يوجد ارقام للتنفيذ", MsgBoxStyle.Critical);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 158;
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

	private void cmbPaste_Click(object sender, EventArgs e)
	{
		string text = Clipboard.GetText();
		if (text.Trim().Length > 0)
		{
			txtDail.Text = text.Trim();
			Clipboard.Clear();
		}
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

	private void btnExport2_Click(object sender, EventArgs e)
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
							object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Workbooks", new object[0], null, null, null), null, "Open", new object[1] { Application.StartupPath + "\\reports\\xyz2.xls" }, null, null, null));
							NewLateBinding.LateSet(objectValue, null, "DisplayAlerts", new object[1] { false }, null, null);
							object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, null, "Worksheets", new object[1] { "Sheet1" }, null, null, null));
							for (num3 = 0.0; !(num3 > (double)(lstNumbers.Items.Count - 1)); num3 += 1.0)
							{
								NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue3, null, "Range", new object[1] { "A" + num5 }, null, null, null), null, "Value", new object[1] { lstNumbers.Items[(int)Math.Round(num3)] }, null, null, OptimisticSet: false, RValueBase: true);
								num5 += 1.0;
							}
							if (num5 > 1.0)
							{
								NewLateBinding.LateCall(objectValue2, null, "SaveAs", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(lblSavePath.Text + "_", lstNumbers.Items[0]), ".xls") }, null, null, null, IgnoreReturn: true);
							}
							else
							{
								Interaction.MsgBox("لا توجد اى ارقام ", MsgBoxStyle.Critical);
							}
							NewLateBinding.LateCall(objectValue2, null, "Close", new object[0], null, null, null, IgnoreReturn: true);
							releaseObject(RuntimeHelpers.GetObjectValue(objectValue));
							releaseObject(RuntimeHelpers.GetObjectValue(objectValue2));
							releaseObject(RuntimeHelpers.GetObjectValue(objectValue3));
							objectValue = null;
							Cursor = Cursors.Default;
							if (num5 > 3.0)
							{
								Interaction.MsgBox("تم تصدير جميع الارقام بنجاح", MsgBoxStyle.Information);
							}
						}
						goto end_IL_0001;
					}
					case 679:
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
				try0001_dispatch = 679;
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

	private void btnAddFF_Click(object sender, EventArgs e)
	{
		if (Conversion.Val(txtEnumSH.Text) > 0.0)
		{
			GetAllSmsfromDBExc(txtEnumSH.Text);
		}
	}

	private void btnSaveFromOut_Click(object sender, EventArgs e)
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
				case 780:
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
							goto IL_001a;
						case 4:
							goto IL_0041;
						case 5:
							goto IL_0068;
						case 6:
						case 7:
							goto IL_0073;
						case 8:
							goto IL_009c;
						case 9:
							goto IL_00c3;
						case 10:
						case 11:
							goto IL_00cf;
						case 12:
							goto IL_00f9;
						case 13:
							goto IL_0121;
						case 14:
						case 15:
							goto IL_012d;
						case 16:
							goto IL_0157;
						case 17:
							goto IL_017f;
						case 18:
						case 19:
							goto IL_018b;
						case 20:
							goto IL_01b5;
						case 21:
							goto IL_01dd;
						case 22:
						case 23:
							goto IL_01e9;
						case 24:
							goto IL_0213;
						case 25:
							goto IL_023b;
						case 26:
						case 27:
							goto IL_0247;
						case 28:
							goto IL_0266;
						case 29:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 30:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_023b:
					num2 = 25;
					Addtelnumber();
					goto IL_0247;
					IL_0247:
					num2 = 27;
					GetAllSmsfromDB(Conversions.ToString(Conversion.Val(txtEnumSH.Text)));
					goto IL_0266;
					IL_0213:
					num2 = 24;
					txtDail.Text = MyProject.Forms.frmUssd.lblNum6.Text.Trim();
					goto IL_023b;
					IL_0266:
					num2 = 28;
					Application.DoEvents();
					break;
					IL_000b:
					num2 = 2;
					btnSaveFromOut.Enabled = false;
					goto IL_001a;
					IL_001a:
					num2 = 3;
					if (MyProject.Forms.frmUssd.lblNum1.Text.Trim().Length > 0)
					{
						goto IL_0041;
					}
					goto IL_0073;
					IL_0041:
					num2 = 4;
					txtDail.Text = MyProject.Forms.frmUssd.lblNum1.Text.Trim();
					goto IL_0068;
					IL_0068:
					num2 = 5;
					Addtelnumber();
					goto IL_0073;
					IL_0073:
					num2 = 7;
					if (MyProject.Forms.frmUssd.lblNum2.Text.Trim().Length > 0)
					{
						goto IL_009c;
					}
					goto IL_00cf;
					IL_009c:
					num2 = 8;
					txtDail.Text = MyProject.Forms.frmUssd.lblNum2.Text.Trim();
					goto IL_00c3;
					IL_00c3:
					num2 = 9;
					Addtelnumber();
					goto IL_00cf;
					IL_00cf:
					num2 = 11;
					if (MyProject.Forms.frmUssd.lblNum3.Text.Trim().Length > 0)
					{
						goto IL_00f9;
					}
					goto IL_012d;
					IL_00f9:
					num2 = 12;
					txtDail.Text = MyProject.Forms.frmUssd.lblNum3.Text.Trim();
					goto IL_0121;
					IL_0121:
					num2 = 13;
					Addtelnumber();
					goto IL_012d;
					IL_012d:
					num2 = 15;
					if (MyProject.Forms.frmUssd.lblNum4.Text.Trim().Length > 0)
					{
						goto IL_0157;
					}
					goto IL_018b;
					IL_0157:
					num2 = 16;
					txtDail.Text = MyProject.Forms.frmUssd.lblNum4.Text.Trim();
					goto IL_017f;
					IL_017f:
					num2 = 17;
					Addtelnumber();
					goto IL_018b;
					IL_018b:
					num2 = 19;
					if (MyProject.Forms.frmUssd.lblNum5.Text.Trim().Length > 0)
					{
						goto IL_01b5;
					}
					goto IL_01e9;
					IL_01b5:
					num2 = 20;
					txtDail.Text = MyProject.Forms.frmUssd.lblNum5.Text.Trim();
					goto IL_01dd;
					IL_01dd:
					num2 = 21;
					Addtelnumber();
					goto IL_01e9;
					IL_01e9:
					num2 = 23;
					if (MyProject.Forms.frmUssd.lblNum6.Text.Trim().Length > 0)
					{
						goto IL_0213;
					}
					goto IL_0247;
					end_IL_0001_2:
					break;
				}
				num2 = 29;
				btnSaveFromOut.Enabled = true;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 780;
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

	private void txtEnumSH_TextChanged(object sender, EventArgs e)
	{
	}

	private void btnTransfer_Click(object sender, EventArgs e)
	{
		if (Conversion.Val(txtEnumSH.Text) > 0.0)
		{
			GetAllSmsfromWWDB(txtEnumSH.Text);
		}
	}

	private void txtCardNew_TextChanged(object sender, EventArgs e)
	{
	}

	private void txtDail_TextChanged(object sender, EventArgs e)
	{
	}

	private void btnAddFromWebServer_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num = default(int);
		int num2 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
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
				case 512:
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
							goto IL_000f;
						case 4:
							goto IL_0020;
						case 6:
							goto IL_0032;
						case 7:
							goto IL_003b;
						case 8:
							goto IL_0040;
						case 11:
							goto IL_0054;
						case 12:
							goto IL_0082;
						case 13:
							goto IL_008c;
						case 14:
							goto IL_0093;
						case 15:
							goto IL_009c;
						case 16:
							goto IL_00bd;
						case 17:
							goto IL_00c3;
						case 18:
						case 19:
							goto IL_00d6;
						case 20:
							goto IL_0104;
						case 9:
						case 10:
						case 21:
							goto IL_010e;
						case 22:
							goto IL_0139;
						case 23:
							goto IL_0158;
						case 24:
							goto IL_0169;
						case 25:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 5:
						case 26:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_00c3:
					num2 = 17;
					btnNewnums_Click(RuntimeHelpers.GetObjectValue(sender), e);
					goto IL_00d6;
					IL_00d6:
					num2 = 19;
					lblCount.Text = Conversions.ToString(Conversion.Val(lblCount.Text) + 1.0);
					goto IL_0104;
					IL_00bd:
					num2 = 16;
					num5 = 0;
					goto IL_00c3;
					IL_0104:
					num2 = 20;
					Application.DoEvents();
					goto IL_010e;
					IL_000b:
					num2 = 2;
					num6 = 0;
					goto IL_000f;
					IL_000f:
					num2 = 3;
					num7 = (int)Interaction.MsgBox("are you sure", MsgBoxStyle.YesNo | MsgBoxStyle.Question);
					goto IL_0020;
					IL_0020:
					num2 = 4;
					if (num7 == 7)
					{
						goto end_IL_0001_3;
					}
					goto IL_0032;
					IL_0032:
					num2 = 6;
					AutoFlag = true;
					goto IL_003b;
					IL_003b:
					num2 = 7;
					num5 = 0;
					goto IL_0040;
					IL_0040:
					num2 = 8;
					btnAddFromWebServer.Enabled = false;
					goto IL_010e;
					IL_010e:
					num2 = 10;
					if (num6 < MyProject.Forms.frmUssd.lstWebQry.Items.Count)
					{
						goto IL_0054;
					}
					goto IL_0139;
					IL_0139:
					num2 = 22;
					GetAllSmsfromDB(Conversions.ToString(Conversion.Val(txtEnumSH.Text)));
					goto IL_0158;
					IL_0158:
					num2 = 23;
					Interaction.MsgBox("تم اضافة الارقام بنجاح", MsgBoxStyle.Information);
					goto IL_0169;
					IL_0169:
					num2 = 24;
					AutoFlag = false;
					break;
					IL_0054:
					num2 = 11;
					txtDail.Text = Conversions.ToString(MyProject.Forms.frmUssd.lstWebQry.Items[num6]);
					goto IL_0082;
					IL_0082:
					num2 = 12;
					Addtelnumber();
					goto IL_008c;
					IL_008c:
					num2 = 13;
					num6 = checked(num6 + 1);
					goto IL_0093;
					IL_0093:
					num2 = 14;
					num5 = checked(num5 + 1);
					goto IL_009c;
					IL_009c:
					num2 = 15;
					if ((double)num5 >= Conversion.Val(txtGroupQty.Text))
					{
						goto IL_00bd;
					}
					goto IL_00d6;
					end_IL_0001_2:
					break;
				}
				num2 = 25;
				btnAddFromWebServer.Enabled = true;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 512;
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
