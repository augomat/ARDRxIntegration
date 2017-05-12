/*
 * Created by Ranorex
 * User: guawi01
 * Date: 13/05/2016
 * Time: 21:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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

namespace NOP_Commerce
{
    /// <summary>
    /// Description of UserCodeModule1.
    /// </summary>
    [TestModule("E1E94959-FE42-402F-946F-F7EA464B5612", ModuleType.UserCode, 1)]
    public class UserCodeModule1_MalformedUsername : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UserCodeModule1_MalformedUsername()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        public static NOP_CommerceRepository repo = NOP_CommerceRepository.Instance;

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            // Init
            Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://localhost:8010/login' with browser 'IE' in normal mode.", new RecordItemIndex(0));
			Host.Local.OpenBrowser("http://localhost:8010/login", "IE", "", false, false, false, false, false);
            Delay.Milliseconds(4000);

            

            repo.YourStore.LeftPane.LoginPage.Email.Click();
            repo.YourStore.LeftPane.LoginPage.Email.PressKeys("~Email~");

            repo.YourStore.LeftPane.LoginPage.Password.Click();
            repo.YourStore.LeftPane.LoginPage.Password.PressKeys("~Password~");
            
            repo.YourStore.LeftPane.LoginPage.LoginSection.LoginButton_RENAMED.Click();
            
            Validate.Exists(repo.YourStore.LeftPane.LoginPage.WrongEmail);
            
            // Teardown

			// Logout
//            if(repo.YourStore.MasterWrapperPage.GoodsMenu.LogOut.Visible)
//            {
//            	repo.YourStore.MasterWrapperPage.GoodsMenu.LogOut.Click();
//            }
            
            // Close Browser
            IList<Ranorex.WebDocument> webList = Host.Local.Find<Ranorex.WebDocument>(repo.YourStore.BasePath);
			foreach (Ranorex.WebDocument webdoc in webList)
			{  
			    webdoc.Close();
			}
        }
    }
}
