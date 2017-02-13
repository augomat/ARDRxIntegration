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
            
            /* -- not necessary, only if we want to write report to another location
  			TestReport.Clear();
        	TestReport.Setup(Ranorex.ReportLevel.Info, "C:\\tmp\\Testreport.rxlog", false);
        	*/
        	/* -- not necessary, only if you want to change tracing screenshot settings
            TestReport.EnableTracingScreenshots = true;
            TestReport.TracingScreenshotMode = TestReport.ScreenshotMode.Background;
            TestReport.TracingScreenshotCountLocal = 3;
            TestReport.TracingScreenshotQuality = 40;
            */
           
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0;
           
           	TestResult overallResult = TestResult.Skipped;
			TestResult result = TestResult.Skipped;
			
            TestReport.BeginTestSuite("SingleARDConfigTest");
            
            //TODO wrap into IDisposible class
			Ranorex.Core.Reporting.ActivityStack.Begin(new TestFolderActivity("Flow 1", ""));
           	result = Flow1.run(); 
           	Ranorex.Core.Reporting.ActivityStack.End(RanorexCoreReflectionHelper.InferStatus(result));
           	overallResult = RanorexCoreReflectionHelper.InferResult(overallResult, result);
           
           	Ranorex.Core.Reporting.ActivityStack.Begin(new TestFolderActivity("Flow 2", ""));
           	result = Flow2.run();
           	Ranorex.Core.Reporting.ActivityStack.End(RanorexCoreReflectionHelper.InferStatus(result));
           	overallResult = RanorexCoreReflectionHelper.InferResult(overallResult, result);
           	
           	return (overallResult == TestResult.Passed) ? 1 : 0;
        }
    }
    
    public static class RanorexCoreReflectionHelper
	{
    	private static MethodInfo HandleErrorMethod;
    	private static MethodInfo InferResultMethod;
    	private static MethodInfo InferStatusMethod;
    	
    	static RanorexCoreReflectionHelper()
    	{
	        HandleErrorMethod = typeof(Ranorex.Core.Testing.TestCaseNode).Assembly
	            .GetType("Ranorex.Core.Testing.TestRunHelper")
	            .GetMethod("HandleError", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);
	        
	    	InferResultMethod = typeof(Ranorex.Core.Testing.TestSuite).Assembly
	    		.GetType("Ranorex.Core.Testing.TestSuite")
	    		.GetMethod("InferResult", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);
	    	
	    	InferStatusMethod = typeof(Ranorex.Core.Testing.TestSuite).Assembly
	    		.GetType("Ranorex.Core.Testing.TestSuite")
	    		.GetMethod("InferStatus", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);
    	}
    	
	    public static Ranorex.Core.Testing.TestResult HandleError(Exception exc)
	    {
	        return (Ranorex.Core.Testing.TestResult)HandleErrorMethod.Invoke(null, new object[] { exc });
	    }
	    
	    public static TestResult InferResult(TestResult overallResult, TestResult childResult)
	    {
	    	return (Ranorex.Core.Testing.TestResult)InferResultMethod.Invoke(null, new object[] { overallResult, childResult, null });
	    }
	    
	    public static ActivityStatus InferStatus(TestResult result)
	    {
	    	return (Ranorex.Core.Reporting.ActivityStatus)InferStatusMethod.Invoke(null, new object[] { result });
	    }
	}
}
