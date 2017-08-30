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
    /// Description of Script10.
    /// </summary>
    [TestModule("4c3fada0-1be9-4356-a61e-5be4f82a7d8f", ModuleType.UserCode, 1)]
    public class Script10 : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Script10()
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
        	TestReport.BeginTestCaseContainer("FLOWCHART - Script10");
	try {
		// Begin Test Case

// Begin Block
TestReport.BeginTestModule("Script10 : Test Cases 10 - Open Browser");
Report.Info("Started Executing Script10 : Open Browser");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "NA_NA_NA_NA_ed87c99cf7804c3183bb87e285e8cb42,Open Browser,Pass,'''','','','','',''," + Environment.NewLine);
            Host.Current.OpenBrowser("http://grid-tools-downloads.com/Will/TMF/index.php", "chrome", "", true, true, true, true, true);
            Report.Info("Finished Executing Script10 : Open Browser");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script10 : Test Cases 10 - Confirm page has loaded");
Report.Info("Started Executing Script10 : Confirm page has loaded");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "NA_NA_NA_NA_ed87c99cf7804c3183bb87e285e8cb42,Confirm page has loaded,Pass,'''','','','','',''," + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page1_Product_Catalog.Header_PRODUCTCATALOGInfo, "InnerText", "Product Catalog");
Report.Info("Finished Executing Script10 : Confirm page has loaded");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script10 : Test Cases 10 - Select Product");
Report.Info("Started Executing Script10 : Select Product");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "NA_NA_NA_NA_ed87c99cf7804c3183bb87e285e8cb42,Select Product,Pass,'''','','','','',''," + Environment.NewLine);
repo.WEBSTORE.Page1_Product_Catalog.ComboBox_ProductSelection.Element.SetAttributeValue("TagValue", "7");
Report.Info("Finished Executing Script10 : Select Product");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script10 : Test Cases 10 - Click Order Product");
Report.Info("Started Executing Script10 : Click Order Product");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "NA_NA_NA_NA_ed87c99cf7804c3183bb87e285e8cb42,Click Order Product,Pass,'''','','','','',''," + Environment.NewLine);
repo.WEBSTORE.Page1_Product_Catalog.Button_OrderProduct.Click();
Report.Info("Finished Executing Script10 : Click Order Product");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script10 : Test Cases 10 - Confirm page has loaded");
Report.Info("Started Executing Script10 : Confirm page has loaded");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "NA_NA_NA_NA_ed87c99cf7804c3183bb87e285e8cb42,Confirm page has loaded,Pass,'''','','','','',''," + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page2_Delivery_Location.Header_DELIVERYLOCATIONInfo, "InnerText", "Delivery Location");
Report.Info("Finished Executing Script10 : Confirm page has loaded");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script10 : Test Cases 10 - Enter Email Address");
Report.Info("Started Executing Script10 : Enter Email Address");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "NA_NA_NA_NA_ed87c99cf7804c3183bb87e285e8cb42,Enter Email Address,Pass,'''','','','','',''," + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N1_Email.Click();
repo.WEBSTORE.Page2_Delivery_Location.N1_Email.PressKeys("william.guastalla@ca.com");
Report.Info("Finished Executing Script10 : Enter Email Address");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script10 : Test Cases 10 - Enter Confirmed Email Address");
Report.Info("Started Executing Script10 : Enter Confirmed Email Address");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "NA_NA_NA_NA_ed87c99cf7804c3183bb87e285e8cb42,Enter Confirmed Email Address,Pass,'''','','','','',''," + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N2_ConfirmEmail.PressKeys("william.guastalla@ca.com");
Report.Info("Finished Executing Script10 : Enter Confirmed Email Address");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script10 : Test Cases 10 - Enter Name");
Report.Info("Started Executing Script10 : Enter Name");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "NA_NA_NA_NA_ed87c99cf7804c3183bb87e285e8cb42,Enter Name,Pass,'''','','','','',''," + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N3_Name.PressKeys("William Guastalla");
Report.Info("Finished Executing Script10 : Enter Name");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script10 : Test Cases 10 - Enter Address Line 1");
Report.Info("Started Executing Script10 : Enter Address Line 1");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "NA_NA_NA_NA_ed87c99cf7804c3183bb87e285e8cb42,Enter Address Line 1,Pass,'''','','','','',''," + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N4_AddressLine1.PressKeys("10 Oasis Business Park Stanton Harcourt");
Report.Info("Finished Executing Script10 : Enter Address Line 1");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script10 : Test Cases 10 - Enter Address Line 2");
Report.Info("Started Executing Script10 : Enter Address Line 2");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "NA_NA_NA_NA_ed87c99cf7804c3183bb87e285e8cb42,Enter Address Line 2,Pass,'''','','','','',''," + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N5_AddressLine2.PressKeys("Eynsham Oxford");
Report.Info("Finished Executing Script10 : Enter Address Line 2");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script10 : Test Cases 10 - Enter County");
Report.Info("Started Executing Script10 : Enter County");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "NA_NA_NA_NA_ed87c99cf7804c3183bb87e285e8cb42,Enter County,Pass,'''','','','','',''," + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N6_County.PressKeys("Oxfordshire");
Report.Info("Finished Executing Script10 : Enter County");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script10 : Test Cases 10 - Enter Post Code");
Report.Info("Started Executing Script10 : Enter Post Code");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "NA_NA_NA_NA_ed87c99cf7804c3183bb87e285e8cb42,Enter Post Code,Pass,'''','','','','',''," + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N7_PostCode.PressKeys("OX294TP");
Report.Info("Finished Executing Script10 : Enter Post Code");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script10 : Test Cases 10 - Enter Country");
Report.Info("Started Executing Script10 : Enter Country");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "NA_NA_NA_NA_ed87c99cf7804c3183bb87e285e8cb42,Enter Country,Pass,'''','','','','',''," + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N8_Country.Element.SetAttributeValue("TagValue", "England");
Report.Info("Finished Executing Script10 : Enter Country");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script10 : Test Cases 10 - Click Save Shipping");
Report.Info("Started Executing Script10 : Click Save Shipping");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "NA_NA_NA_NA_ed87c99cf7804c3183bb87e285e8cb42,Click Save Shipping,Pass,'''','','','','',''," + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.Button_SaveShipping.Click();
Report.Info("Finished Executing Script10 : Click Save Shipping");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script10 : Test Cases 10 - Confirm page has loaded");
Report.Info("Started Executing Script10 : Confirm page has loaded");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "NA_NA_NA_NA_ed87c99cf7804c3183bb87e285e8cb42,Confirm page has loaded,Pass,'''','','','','',''," + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page3_Shipping_Specification.Header_SHIPPINGSPECIFICATIONInfo, "InnerText", "Shipping Specification");
Report.Info("Finished Executing Script10 : Confirm page has loaded");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script10 : Test Cases 10 - Click Continue");
Report.Info("Started Executing Script10 : Click Continue");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "NA_NA_NA_NA_ed87c99cf7804c3183bb87e285e8cb42,Click Continue,Pass,'''','','','','',''," + Environment.NewLine);
repo.WEBSTORE.Page3_Shipping_Specification.Button_Continue.Click();
Report.Info("Finished Executing Script10 : Click Continue");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script10 : Test Cases 10 - Confirm page has loaded");
Report.Info("Started Executing Script10 : Confirm page has loaded");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "NA_NA_NA_NA_ed87c99cf7804c3183bb87e285e8cb42,Confirm page has loaded,Pass,'''','','','','',''," + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page4_Payment_Details.Header_PAYMENTDETAILSInfo, "InnerText", "Payment Details");
Report.Info("Finished Executing Script10 : Confirm page has loaded");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script10 : Test Cases 10 - Enter Card Type");
Report.Info("Started Executing Script10 : Enter Card Type");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "NA_NA_NA_NA_ed87c99cf7804c3183bb87e285e8cb42,Enter Card Type,Pass,'''','','','','',''," + Environment.NewLine);
repo.WEBSTORE.Page4_Payment_Details.N1_CardType.Element.SetAttributeValue("TagValue", "VISA");
Report.Info("Finished Executing Script10 : Enter Card Type");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script10 : Test Cases 10 - Enter Card Number");
Report.Info("Started Executing Script10 : Enter Card Number");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "NA_NA_NA_NA_ed87c99cf7804c3183bb87e285e8cb42,Enter Card Number,Pass,'''','','','','',''," + Environment.NewLine);
repo.WEBSTORE.Page4_Payment_Details.N2_CardNo.PressKeys("1111222233334444");
Report.Info("Finished Executing Script10 : Enter Card Number");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script10 : Test Cases 10 - Click Complete Purchase");
Report.Info("Started Executing Script10 : Click Complete Purchase");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "NA_NA_NA_NA_ed87c99cf7804c3183bb87e285e8cb42,Click Complete Purchase,Pass,'''','','','','',''," + Environment.NewLine);
repo.WEBSTORE.Page4_Payment_Details.Button_CompletePurchase.Click();
Report.Info("Finished Executing Script10 : Click Complete Purchase");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script10 : Test Cases 10 - Confirm page has loaded");
Report.Info("Started Executing Script10 : Confirm page has loaded");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "NA_NA_NA_NA_ed87c99cf7804c3183bb87e285e8cb42,Confirm page has loaded,Pass,'''','','','','',''," + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page5_Order_Finalised.Header_ORDERFINALISEDInfo, "InnerText", "Order Finalised");
Report.Info("Finished Executing Script10 : Confirm page has loaded");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script10 : Test Cases 10 - Click Home");
Report.Info("Started Executing Script10 : Click Home");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "NA_NA_NA_NA_ed87c99cf7804c3183bb87e285e8cb42,Click Home,Pass,'''','','','','',''," + Environment.NewLine);
repo.WEBSTORE.Navigation.Home.Click();
Report.Info("Finished Executing Script10 : Click Home");
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
        			TestReport.BeginTestModule("Script10_Teardown");
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