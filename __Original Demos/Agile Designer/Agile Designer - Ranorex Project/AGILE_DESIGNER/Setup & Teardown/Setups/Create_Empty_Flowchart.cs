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
	[TestModule("Create_Empty_Flowchart", ModuleType.UserCode, 1)]
	public class Create_Empty_Flowchart : ITestModule
	{
		public Create_Empty_Flowchart()
		{
		}
		public static AGILE_DESIGNER.AGD repo = AGILE_DESIGNER.AGD.Instance;
		void ITestModule.Run()
		{

Mouse.DefaultMoveTime = 300;
Keyboard.DefaultKeyPressTime = 10;
Delay.SpeedFactor = 1.5;
// --- =========  Create New Flowchart ========= ---
{
repo.Agile_Designer2.Main_Window.MainWindow.Menubar.N1_File.Click();
Delay.Milliseconds(10);
repo.Agile_Designer2.Main_Window.MenuBarContext.N1_File.N1_MenuItemNew.Click();
Delay.Milliseconds(10);
repo.Agile_Designer2.New_Flow.File_NewFlowChart.N1_GeneralProperties.N1_Title.Click();
repo.Agile_Designer2.New_Flow.File_NewFlowChart.N1_GeneralProperties.N1_Title.PressKeys("Flowchart Name");
Delay.Milliseconds(10);
repo.Agile_Designer2.New_Flow.File_NewFlowChart.Buttons.ButtonFinish.Click();
Delay.Milliseconds(10);
}
// --- ================================= ---

		}
	}
}
