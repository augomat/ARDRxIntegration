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
	[TestModule("Close_Browser", ModuleType.UserCode, 1)]
	public class Close_Browser : ITestModule
	{
		public Close_Browser()
		{
		}
		public static NOP_Commerce.NOP_CommerceRepository repo = NOP_Commerce.NOP_CommerceRepository.Instance;
		void ITestModule.Run()
		{

Mouse.DefaultMoveTime = 300;
Keyboard.DefaultKeyPressTime = 10;
Delay.SpeedFactor = 1.5;
// Close Browser : Object name, repo.YourStore is the root path.
IList<Ranorex.WebDocument> webList = Host.Local.Find<Ranorex.WebDocument>(repo.YourStore.BasePath);
foreach (Ranorex.WebDocument webdoc in webList)
{  
  webdoc.Close();
}
		}
	}
}
