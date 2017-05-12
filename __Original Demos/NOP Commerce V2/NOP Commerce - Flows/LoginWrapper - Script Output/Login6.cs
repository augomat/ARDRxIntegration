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
	[TestModule("Login6", ModuleType.UserCode, 1)]
	public class Login6 : ITestModule
	{
		public Login6()
		{
		}
		public static NOP_Commerce.NOP_CommerceRepository repo = NOP_Commerce.NOP_CommerceRepository.Instance;
		void ITestModule.Run()
		{

repo.YourStore.HomePage.HeaderMenu.LogIn.Click();
repo.YourStore.LoginPage.Email.Click();
repo.YourStore.LoginPage.Email.PressKeys("william.guastalla@ca.com");
repo.YourStore.LoginPage.Password.Click();
repo.YourStore.LoginPage.Password.PressKeys("password");
repo.YourStore.LoginPage.LoginSection.LoginButton.Click();
Delay.Milliseconds(200);
Validate.Exists(repo.YourStore.HomePage.HeaderMenu.LogOut);
repo.YourStore.HomePage.HeaderMenu.LogOut.Click();

		}
	}
}
