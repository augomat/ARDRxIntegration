﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Reporting;
using Ranorex.Core.Testing;

namespace SingleArDconfigTest
{
    public partial class Flow2_Path1
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public TestResult Path1Usermethod()
        {
        	TestReport.BeginTestCase("Flow2_Path1");
        	
        	TestResult testResult = TestResult.Skipped;
        	try {
        		TestReport.BeginTestModule("Flow2_Path1_Block1");
	        		// --- BEGIN ARD Blockcode ---
		        	Report.Info("Flow2 Path Block1");
		        	Validate.IsTrue(false);
		        	// --- END ARD Blockcode ---
	        	TestReport.EndTestModule();
	        	
	        	testResult = TestResult.Passed;
        	}
			catch (Exception e) {
        		TestReport.EndTestModule();
        		testResult = RanorexCoreReflectionHelper.HandleError(e);
        		TestReport.SaveLocalScreenshotBuffer();
        	}
        	finally {
        		TestReport.BeginTestCaseTeardown();
        		
        		try 
        		{
        			TestReport.BeginTestModule("Flow2_Path1_Teardown");
		        		// --- BEGIN ARD Blockcode ---
		        		Report.Info("And our teardown does its job");	
		        		Validate.IsTrue(true);
		        		// --- END ARD Blockcode ---
	        		TestReport.EndTestModule();
        		}
        		catch (Exception e) {
        			TestReport.EndTestModule();
	                testResult = RanorexCoreReflectionHelper.HandleError(e);
	                TestReport.SaveLocalScreenshotBuffer();
	        	}
        		finally
        		{
        			TestReport.EndTestCaseTeardown();
        			TestReport.EndTestCase();
        		}
        	}	
			return testResult;         	
        }

    }
}
