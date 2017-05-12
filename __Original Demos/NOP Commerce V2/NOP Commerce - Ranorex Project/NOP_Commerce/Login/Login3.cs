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
	[TestModule("Login3", ModuleType.UserCode, 1)]
	public class Login3 : ITestModule
	{
		public Login3()
		{
		}
		public static NOP_Commerce.NOP_CommerceRepository repo = NOP_Commerce.NOP_CommerceRepository.Instance;
		void ITestModule.Run()
		{

repo.YourStore.HomePage.HeaderMenu.LogIn_Changed.Click();
repo.YourStore.LeftPane.LoginPage.Email.Click();
repo.YourStore.LeftPane.LoginPage.Email.PressKeys("tom.jones@ca.com");
repo.YourStore.LeftPane.LoginPage.LoginSection.LoginButton_RENAMED.Click();
Delay.Milliseconds(200);
Validate.Exists(repo.YourStore.LeftPane.LoginPage.LoginSection.LoginFields.Warnings.WarningLabel_NoAccountFound);
Validate.Exists(repo.YourStore.HomePage.HeaderMenu.LogIn_Changed);

		}
	}
}
