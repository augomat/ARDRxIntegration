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
	[TestModule("Close_Current_Flowchart", ModuleType.UserCode, 1)]
	public class Close_Current_Flowchart : ITestModule
	{
		public Close_Current_Flowchart()
		{
		}
		public static AGILE_DESIGNER.AGD repo = AGILE_DESIGNER.AGD.Instance;
		void ITestModule.Run()
		{

Mouse.DefaultMoveTime = 300;
Keyboard.DefaultKeyPressTime = 10;
Delay.SpeedFactor = 1.5;
repo.Agile_Designer2.Main_Window.MainWindow.Menubar.N1_File.Click();
repo.Agile_Designer2.Main_Window.MenuBarContext.N1_File.N9_MenuItemCloseCurrentFlow.Click();
if(repo.Agile_Designer2.Warning_Dialogs.SaveBeforeExitDialog.SaveChangesLabelInfo.Exists(700))
if(repo.Agile_Designer2.Warning_Dialogs.SaveBeforeExitDialog.SaveChangesLabel.TextValue.Contains("save"))
{
repo.Agile_Designer2.Warning_Dialogs.SaveBeforeExitDialog.Buttons.No.Click();
}

		}
	}
}
