/*
 * Created by Ranorex
 * User: user
 * Date: 3/22/2017
 * Time: 11:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
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
    [TestModule("59b2d276-7e55-41e4-a24f-ea0704049c8e", ModuleType.UserCode, 1)]
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
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 5,Open Browser,Passed,Automation Step: 0,,2017-08-23T08:00:00+02:00" + Environment.NewLine);
            Host.Current.OpenBrowser("http://grid-tools-downloads.com/Will/TMF/index.php", "firefox", "", true, true, true, true, true);
            Report.Info("Finished Executing Script5 : Open Browser");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Confirm page has loaded");
Report.Info("Started Executing Script5 : Confirm page has loaded");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 5,Confirm page has loaded,Passed,Automation Step: 1,,2017-08-23T08:00:00+02:00" + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page1_Product_Catalog.Header_PRODUCTCATALOGInfo, "InnerText", "Product Catalog");
Report.Info("Finished Executing Script5 : Confirm page has loaded");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Select Product");
Report.Info("Started Executing Script5 : Select Product");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 5,Select Product,Passed,Automation Step: 2,,2017-08-23T08:00:00+02:00" + Environment.NewLine);
repo.WEBSTORE.Page1_Product_Catalog.ComboBox_ProductSelection.Element.SetAttributeValue("TagValue", "2");
Report.Info("Finished Executing Script5 : Select Product");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Click Order Product");
Report.Info("Started Executing Script5 : Click Order Product");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 5,Click Order Product,Passed,Automation Step: 3,,2017-08-23T08:00:00+02:00" + Environment.NewLine);
repo.WEBSTORE.Page1_Product_Catalog.Button_OrderProduct.Click();
Report.Info("Finished Executing Script5 : Click Order Product");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Confirm page has loaded");
Report.Info("Started Executing Script5 : Confirm page has loaded");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 5,Confirm page has loaded,Passed,Automation Step: 4,,2017-08-23T08:00:00+02:00" + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page2_Delivery_Location.Header_DELIVERYLOCATIONInfo, "InnerText", "Delivery Location");
Report.Info("Finished Executing Script5 : Confirm page has loaded");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Enter Email Address");
Report.Info("Started Executing Script5 : Enter Email Address");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 5,Enter Email Address,Passed,Automation Step: 5,,2017-08-23T08:00:00+02:00" + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N1_Email.Click();
repo.WEBSTORE.Page2_Delivery_Location.N1_Email.PressKeys("william.guastalla@ca.com");
Report.Info("Finished Executing Script5 : Enter Email Address");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Enter Confirmed Email Address");
Report.Info("Started Executing Script5 : Enter Confirmed Email Address");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 5,Enter Confirmed Email Address,Passed,Automation Step: 7,,2017-08-23T08:00:00+02:00" + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N2_ConfirmEmail.PressKeys("william.guastalla@ca.com");
Report.Info("Finished Executing Script5 : Enter Confirmed Email Address");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Enter Name");
Report.Info("Started Executing Script5 : Enter Name");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 5,Enter Name,Passed,Automation Step: 8,,2017-08-23T08:00:00+02:00" + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N3_Name.PressKeys("William Guastalla");
Report.Info("Finished Executing Script5 : Enter Name");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Enter Address Line 1");
Report.Info("Started Executing Script5 : Enter Address Line 1");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 5,Enter Address Line 1,Passed,Automation Step: 9,,2017-08-23T08:00:00+02:00" + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N4_AddressLine1.PressKeys("10 Oasis Business Park Stanton Harcourt");
Report.Info("Finished Executing Script5 : Enter Address Line 1");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Enter Address Line 2");
Report.Info("Started Executing Script5 : Enter Address Line 2");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 5,Enter Address Line 2,Passed,Automation Step: 10,,2017-08-23T08:00:00+02:00" + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N5_AddressLine2.PressKeys("Eynsham Oxford");
Report.Info("Finished Executing Script5 : Enter Address Line 2");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Enter County");
Report.Info("Started Executing Script5 : Enter County");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 5,Enter County,Passed,Automation Step: 11,,2017-08-23T08:00:00+02:00" + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N6_County.PressKeys("Oxfordshire");
Report.Info("Finished Executing Script5 : Enter County");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Enter Post Code");
Report.Info("Started Executing Script5 : Enter Post Code");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 5,Enter Post Code,Passed,Automation Step: 12,,2017-08-23T08:00:00+02:00" + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N7_PostCode.PressKeys("OX294TP");
Report.Info("Finished Executing Script5 : Enter Post Code");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Enter Country");
Report.Info("Started Executing Script5 : Enter Country");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 5,Enter Country,Passed,Automation Step: 13,,2017-08-23T08:00:00+02:00" + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N8_Country.Element.SetAttributeValue("TagValue", "England");
Report.Info("Finished Executing Script5 : Enter Country");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Click Save Shipping");
Report.Info("Started Executing Script5 : Click Save Shipping");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 5,Click Save Shipping,Passed,Automation Step: 14,,2017-08-23T08:00:00+02:00" + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.Button_SaveShipping.Click();
Report.Info("Finished Executing Script5 : Click Save Shipping");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Confirm page has loaded");
Report.Info("Started Executing Script5 : Confirm page has loaded");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 5,Confirm page has loaded,Passed,Automation Step: 15,,2017-08-23T08:00:00+02:00" + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page3_Shipping_Specification.Header_SHIPPINGSPECIFICATIONInfo, "InnerText", "Shipping Specification");
Report.Info("Finished Executing Script5 : Confirm page has loaded");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Click Continue");
Report.Info("Started Executing Script5 : Click Continue");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 5,Click Continue,Passed,Automation Step: 16,,2017-08-23T08:00:00+02:00" + Environment.NewLine);
repo.WEBSTORE.Page3_Shipping_Specification.Button_Continue.Click();
Report.Info("Finished Executing Script5 : Click Continue");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Confirm page has loaded");
Report.Info("Started Executing Script5 : Confirm page has loaded");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 5,Confirm page has loaded,Passed,Automation Step: 17,,2017-08-23T08:00:00+02:00" + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page4_Payment_Details.Header_PAYMENTDETAILSInfo, "InnerText", "Payment Details");
Report.Info("Finished Executing Script5 : Confirm page has loaded");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Enter Card Type");
Report.Info("Started Executing Script5 : Enter Card Type");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 5,Enter Card Type,Passed,Automation Step: 18,,2017-08-23T08:00:00+02:00" + Environment.NewLine);
repo.WEBSTORE.Page4_Payment_Details.N1_CardType.Element.SetAttributeValue("TagValue", "VISA");
Report.Info("Finished Executing Script5 : Enter Card Type");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Enter Card Number");
Report.Info("Started Executing Script5 : Enter Card Number");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 5,Enter Card Number,Passed,Automation Step: 19,,2017-08-23T08:00:00+02:00" + Environment.NewLine);
repo.WEBSTORE.Page4_Payment_Details.N2_CardNo.PressKeys("1111222233334444");
Report.Info("Finished Executing Script5 : Enter Card Number");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Click Complete Purchase");
Report.Info("Started Executing Script5 : Click Complete Purchase");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 5,Click Complete Purchase,Passed,Automation Step: 20,,2017-08-23T08:00:00+02:00" + Environment.NewLine);
repo.WEBSTORE.Page4_Payment_Details.Button_CompletePurchase.Click();
Report.Info("Finished Executing Script5 : Click Complete Purchase");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Confirm page has loaded");
Report.Info("Started Executing Script5 : Confirm page has loaded");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 5,Confirm page has loaded,Passed,Automation Step: 21,,2017-08-23T08:00:00+02:00" + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page5_Order_Finalised.Header_ORDERFINALISEDInfo, "InnerText", "Order Finalised");
Report.Info("Finished Executing Script5 : Confirm page has loaded");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script5 : Test Cases 5 - Click Home");
Report.Info("Started Executing Script5 : Click Home");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 5,Click Home,Passed,Automation Step: 22,,2017-08-23T08:00:00+02:00" + Environment.NewLine);
repo.WEBSTORE.Navigation.Home.Click();
Report.Info("Finished Executing Script5 : Click Home");
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