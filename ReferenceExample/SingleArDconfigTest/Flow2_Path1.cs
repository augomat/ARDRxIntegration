﻿/*
 * Created by Ranorex
 * User: user
 * Date: 3/23/2017
 * Time: 12:37 AM
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
using Ranorex.Core.Reporting;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace SingleArDconfigTest
{
    /// <summary>
    /// Description of Flow2_Path1.
    /// </summary>
    [TestModule("09DF8553-36DF-4807-B193-62CBE5425928", ModuleType.UserCode, 1)]
    public class Flow2_Path1 : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Flow2_Path1()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            TestReport.BeginTestCaseContainer("Flow2_Path1");

        	try {
        		TestReport.BeginTestModule("Flow2_Path1_Block1");
	        		// --- BEGIN ARD Blockcode ---
		        	Report.Info("Flow2 Path Block1");
		        	Validate.IsTrue(false);
		        	// --- END ARD Blockcode ---
	        	TestReport.EndTestModule();
        	}
			catch (Exception) {
        		TestReport.EndTestModule();
        	}
        	finally {
        		TestReport.BeginTestContainerTeardown();
        		
        		try 
        		{
        			TestReport.BeginTestModule("Flow2_Path1_Teardown");
		        		// --- BEGIN ARD Blockcode ---
		        		Report.Info("And our teardown does its job");	
		        		Validate.IsTrue(true);
		        		// --- END ARD Blockcode ---
	        		TestReport.EndTestModule();
        		}
        		catch (Exception) {
        			TestReport.EndTestModule();
	        	}
        		finally
        		{
        			TestReport.EndTestContainerTeardown();
        			TestReport.EndTestCaseContainer();
        		}
        	}	
        }
    }
}
