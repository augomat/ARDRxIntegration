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
	[TestModule("Login1", ModuleType.UserCode, 1)]
	public class Login1 : ITestModule
	{
		public Login1()
		{
		}
		public static NOP_Commerce.NOP_CommerceRepository repo = NOP_Commerce.NOP_CommerceRepository.Instance;
		void ITestModule.Run()
		{

repo.YourStore.HomePage.HeaderMenu.LogIn.Click();
repo.YourStore.LoginPage.Email.Click();
repo.YourStore.LoginPage.Email.PressKeys("jw");
repo.YourStore.LoginPage.LoginSection.LoginButton.Click();
Delay.Milliseconds(200);
Validate.Exists(repo.YourStore.LoginPage.WrongEmail);
Validate.Exists(repo.YourStore.HomePage.HeaderMenu.LogIn);

		}
	}
}
