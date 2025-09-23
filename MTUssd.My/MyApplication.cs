using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace MTUssd.My;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class MyApplication : WindowsFormsApplicationBase
{
	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	[STAThread]
	[DebuggerHidden]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static void Main(string[] Args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
		}
		finally
		{
		}
		MyProject.Application.Run(Args);
	}

	[DebuggerStepThrough]
	public MyApplication()
		: base(AuthenticationMode.Windows)
	{
		base.IsSingleInstance = false;
		base.EnableVisualStyles = false;
		base.SaveMySettingsOnExit = true;
		base.ShutdownStyle = ShutdownMode.AfterAllFormsClose;
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		base.MainForm = MyProject.Forms.frmConError;
	}

	[DebuggerStepThrough]
	protected override bool OnInitialize(ReadOnlyCollection<string> commandLineArgs)
	{
		base.MinimumSplashScreenDisplayTime = 0;
		return base.OnInitialize(commandLineArgs);
	}
}
