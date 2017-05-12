using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace AGILE_DESIGNER.Recordings
{
	[TestModule("Close_Agile_Designer", ModuleType.UserCode, 1)]
	public class Close_Agile_Designer : ITestModule
	{
		public Close_Agile_Designer()
		{
		}
		public static AGILE_DESIGNER.AGD repo = AGILE_DESIGNER.AGD.Instance;
		void ITestModule.Run()
		{

Mouse.DefaultMoveTime = 300;
Keyboard.DefaultKeyPressTime = 10;
Delay.SpeedFactor = 1.5;

repo.Agile_Designer2.Main_Window.MainWindow.Titlebar.Buttons.Close.Click();
Delay.Milliseconds(100);

if(repo.Agile_Designer2.Warning_Dialogs.SaveBeforeExitDialog.SaveChangesLabelInfo.Exists(10))
{
	if(repo.Agile_Designer2.Warning_Dialogs.SaveBeforeExitDialog.SaveChangesLabel.TextValue.Contains("save"))
	{
	repo.Agile_Designer2.Warning_Dialogs.SaveBeforeExitDialog.Buttons.No.Click();
	}
}
		}
	}
}
