/*
 * Created by Ranorex
 * User: user
 * Date: 3/22/2017
 * Time: 11:37 PM
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
    /// Description of Flow3_Path1.
    /// </summary>
    [TestModule("D7E819C1-CA0B-4308-A599-DFCB243C644F", ModuleType.UserCode, 1)]
    public class Flow3_Path1 : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Flow3_Path1()
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
        	var repo = SingleArDconfigTestRepository.Instance;
       		
        	TestReport.BeginTestCaseContainer("Flow3_Path1");
        	
        	try {
        		TestReport.BeginTestModule("Flow3_Path1_Block1");
	        		// --- BEGIN ARD Blockcode ---
		        	Report.Info("Flow3 Path Block1");
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
        			TestReport.BeginTestModule("Flow3_Path2_Teardown");
		        		// --- BEGIN ARD Blockcode ---
		        		Report.Info("There goes the successful Teardown");
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
