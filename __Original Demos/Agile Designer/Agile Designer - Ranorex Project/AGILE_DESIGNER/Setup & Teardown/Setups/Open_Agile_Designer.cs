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
	[TestModule("Open_Agile_Designer", ModuleType.UserCode, 1)]
	public class Open_Agile_Designer : ITestModule
	{
		public Open_Agile_Designer()
		{
		}
		public static AGILE_DESIGNER.AGD repo = AGILE_DESIGNER.AGD.Instance;
		void ITestModule.Run()
		{

Mouse.DefaultMoveTime = 300;
Keyboard.DefaultKeyPressTime = 10;
Delay.SpeedFactor = 1.5;
// Open Application
Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Program Files\\Grid-Tools\\AgileDesigner\\AgileDesigner.exe' with arguments '' in normal mode.", new RecordItemIndex(0));
Host.Local.RunApplication("C:\\Program Files\\Grid-Tools\\AgileDesigner\\AgileDesigner.exe", "", "C:\\Program Files\\Grid-Tools\\AgileDesigner", false);

		}
	}
}
