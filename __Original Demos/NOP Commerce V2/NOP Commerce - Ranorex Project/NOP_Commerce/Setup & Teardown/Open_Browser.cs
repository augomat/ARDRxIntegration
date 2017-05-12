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

namespace NOP_Commerce.Recordings
{
	[TestModule("Open_Browser", ModuleType.UserCode, 1)]
	public class Open_Browser : ITestModule
	{
		public Open_Browser()
		{
		}
		public static NOP_Commerce.NOP_CommerceRepository repo = NOP_Commerce.NOP_CommerceRepository.Instance;
		void ITestModule.Run()
		{

Mouse.DefaultMoveTime = 300;
Keyboard.DefaultKeyPressTime = 10;
Delay.SpeedFactor = 1.5;
            Host.Local.OpenBrowser("http://localhost:8010/login", "IE", "", false, false, true, true, true);
            Delay.Milliseconds(3000);

		}
	}
}
