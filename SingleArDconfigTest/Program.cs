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
            
            TestReport.EnableTracingScreenshots = true;
            TestReport.TracingScreenshotMode = TestReport.ScreenshotMode.Foreground;
            TestReport.TracingScreenshotCountLocal = 3;
            TestReport.TracingScreenshotQuality = 40;
            
            TestReport.BeginTestSuite("Hallo");
               
			int error = 0;            
           	Flow1.run();
           
           	return error; //TODO
        }
    }
    
    public static class RanorexCoreReflectionHelper
	{
	    public static Ranorex.Core.Testing.TestResult HandleError(Exception exc)
	    {
	        Assembly assembly = typeof(Ranorex.Core.Testing.TestCaseNode).Assembly;
	        var m = assembly
	            .GetType("Ranorex.Core.Testing.TestRunHelper")
	            .GetMethod("HandleError", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);
	
	        return (Ranorex.Core.Testing.TestResult)m.Invoke(null, new object[] { exc });
	    }
	}
}
