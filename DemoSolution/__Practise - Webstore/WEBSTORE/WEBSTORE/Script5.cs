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

namespace WEBSTORE
{
    /// <summary>
    /// Description of Script5.
    /// </summary>
    [TestModule("4080a48e-aec8-4629-aa9d-52af30db1af5", ModuleType.UserCode, 1)]
    public class Script5 : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Script5()
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
        	var repo = WEBSTORERepository.Instance;
        	TestReport.BeginTestCaseContainer("FLOWCHART - Script5");
	try {
		// Begin Test Case

// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Open Browser");
Report.Info("Started Executing Script5 : Open Browser");
            Host.Local.OpenBrowser("http://grid-tools-downloads.com/Will/TMF/index.php", "firefox", "", true, true, true, true, true);
            Report.Info("Finished Executing Script5 : Open Browser");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Open WebStore Page");
Report.Info("Started Executing Script5 : Open WebStore Page");
Report.Info("Finished Executing Script5 : Open WebStore Page");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Confirm page has loaded");
Report.Info("Started Executing Script5 : Confirm page has loaded");
Validate.Attribute(repo.MozillaFirefox.WebStore.Page1_Product_Catalog.Header_PRODUCTCATALOGInfo, "AccessibleName", "PRODUCT CATALOG");
Report.Info("Finished Executing Script5 : Confirm page has loaded");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Click Order Product");
Report.Info("Started Executing Script5 : Click Order Product");
repo.MozillaFirefox.WebStore.Page1_Product_Catalog.Button_OrderProduct.Click();
Report.Info("Finished Executing Script5 : Click Order Product");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Click Save Shipping");
Report.Info("Started Executing Script5 : Click Save Shipping");
Report.Info("Finished Executing Script5 : Click Save Shipping");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Click Continue");
Report.Info("Started Executing Script5 : Click Continue");
Report.Info("Finished Executing Script5 : Click Continue");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Click Complete Purchase");
Report.Info("Started Executing Script5 : Click Complete Purchase");
Report.Info("Finished Executing Script5 : Click Complete Purchase");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Close Browser");
Report.Info("Started Executing Script5 : Close Browser");
Report.Info("Finished Executing Script5 : Close Browser");
TestReport.EndTestModule();
// End Block

		// End Test Case
        	}
        	catch (Exception) {
        		TestReport.EndTestModule();
        	}
        	finally {
        		TestReport.BeginTestContainerTeardown();
        		
        		try 
        		{
        			TestReport.BeginTestModule("Script5_Teardown");
			// Begin Teardown


			// End Teardown
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