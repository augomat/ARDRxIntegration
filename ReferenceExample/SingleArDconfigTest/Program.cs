/*
 * Created by Ranorex
 * User: gkapeller
 * Date: 2/2/2017
 * Time: 12:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Threading;
using System.Drawing;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Reporting;
using Ranorex.Core.Testing;

using System.Reflection;

namespace SingleArDconfigTest
{
    class Program
    {
        [STAThread]
        public static int Main(string[] args)
        {
            // Uncomment the following 2 lines if you want to automate Windows apps
            // by starting the test executable directly
            //if (Util.IsRestartRequiredForWinAppAccess)
            //    return Util.RestartWithUiAccess();

            Keyboard.AbortKey = System.Windows.Forms.Keys.Pause; 
           
            // ------- GENERAL CONFIG - will not affect replay of individual modules -----
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0;
            // ---------------------------------------------------------------------------
            
            TestReport.BeginTestSuite("SingleARDconfigTest");
           	
           	TestReport.BeginSmartFolderContainer("Flow1", "Path2 blows up in the teardown");
           	new Flow1().Run();
           	TestReport.EndSmartFolderContainer();
           	
           	TestReport.BeginSmartFolderContainer("Flow2", "Path1 blows up in the module");
           	new Flow2().Run();
           	TestReport.EndSmartFolderContainer();
           	
           	TestReport.BeginSmartFolderContainer("Flow3", "Folder successful");
           	new Flow3().Run();
           	TestReport.EndSmartFolderContainer();
           	
           	TestReport.EndTestSuite();           	
			
			return ActivityStack.Instance.RootActivity.Status == ActivityStatus.Success ? 1 : 0;
        }
    }
}
