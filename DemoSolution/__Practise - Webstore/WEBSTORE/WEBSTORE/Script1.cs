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
    /// Description of Script1.
    /// </summary>
    [TestModule("a138b929-d725-4ee5-9231-23fa29519692", ModuleType.UserCode, 1)]
    public class Script1 : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Script1()
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
        	TestReport.BeginTestCaseContainer("FLOWCHART - Script1");
	try {
		// Begin Test Case

		
			
		
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Open Browser");
Report.Info("Started Executing Script1 : Open Browser");
            Host.Local.OpenBrowser("http://grid-tools-downloads.com/Will/TMF/index.php", "firefox", "", true, true, true, true, true);
            Report.Info("Finished Executing Script1 : Open Browser");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Open WebStore Page");
Report.Info("Started Executing Script1 : Open WebStore Page");
Report.Info("Finished Executing Script1 : Open WebStore Page");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Confirm page has loaded");
Report.Info("Started Executing Script1 : Confirm page has loaded");
//Validate.Attribute(repo.IThinkThisIsMuchBetter.Page1_Product_Catalog.Header_PRODUCTCATALOGInfo, "AccessibleName", "PRODUCT CATALOG");


string res = repo.WEBSTORE.Page1_Product_Catalog.Header_PRODUCTCATALOG.InnerText;



Report.Info("Finished Executing Script1 : Confirm page has loaded");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Click Order Product");
Report.Info("Started Executing Script1 : Click Order Product");
repo.MozillaFirefox.WebStore.Page1_Product_Catalog.Button_OrderProduct.Click();
Report.Info("Finished Executing Script1 : Click Order Product");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Confirm page has loaded");
Report.Info("Started Executing Script1 : Confirm page has loaded");
Validate.Attribute(repo.MozillaFirefox.WebStore.Page2_Delivery_Location.Header_DELIVERYLOCATIONInfo, "AccessibleName", "DELIVERY LOCATION");
Report.Info("Finished Executing Script1 : Confirm page has loaded");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Click Save Shipping");
Report.Info("Started Executing Script1 : Click Save Shipping");
repo.MozillaFirefox.WebStore.Page2_Delivery_Location.Button_SaveShipping.Click();
Report.Info("Finished Executing Script1 : Click Save Shipping");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Confirm page has loaded");
Report.Info("Started Executing Script1 : Confirm page has loaded");
Validate.Attribute(repo.MozillaFirefox.WebStore.Page3_Shipping_Specification.Header_SHIPPINGSPECIFICATIONInfo, "AccessibleName", "SHIPPING SPECIFICATION");
Report.Info("Finished Executing Script1 : Confirm page has loaded");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Click Continue");
Report.Info("Started Executing Script1 : Click Continue");
repo.MozillaFirefox.WebStore.Page3_Shipping_Specification.Button_Continue.Click();
Report.Info("Finished Executing Script1 : Click Continue");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Confirm page has loaded");
Report.Info("Started Executing Script1 : Confirm page has loaded");
Validate.Attribute(repo.MozillaFirefox.WebStore.Page4_Payment_Details.Header_PAYMENTDETAILSInfo, "AccessibleName", "PAYMENT DETAILS");
Report.Info("Finished Executing Script1 : Confirm page has loaded");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Click Complete Purchase");
Report.Info("Started Executing Script1 : Click Complete Purchase");
repo.MozillaFirefox.WebStore.Page4_Payment_Details.Button_CompletePurchase.Click();
Report.Info("Finished Executing Script1 : Click Complete Purchase");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Confirm page has loaded");
Report.Info("Started Executing Script1 : Confirm page has loaded");
Validate.Attribute(repo.MozillaFirefox.WebStore.Page5_Order_Finalised.Header_ORDERFINALISEDInfo, "AccessibleName", "ORDER FINALISED");
Report.Info("Finished Executing Script1 : Confirm page has loaded");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Click Home");
Report.Info("Started Executing Script1 : Click Home");
repo.MozillaFirefox.WebStore.HOME.Click();
Report.Info("Finished Executing Script1 : Click Home");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Close Browser");
Report.Info("Started Executing Script1 : Close Browser");
Report.Info("Finished Executing Script1 : Close Browser");
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
        			TestReport.BeginTestModule("Script1_Teardown");
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