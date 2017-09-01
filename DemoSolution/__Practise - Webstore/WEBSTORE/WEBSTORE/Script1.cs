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
    /// Description of Script1.
    /// </summary>
    [TestModule("4e0a625a-83ef-4d7c-ab90-559227d3d1a9", ModuleType.UserCode, 1)]
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
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 1,Open Browser,Passed,Automation Step: 0," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
            Host.Current.OpenBrowser("http://grid-tools-downloads.com/Will/TMF/index.php", "chrome", "", true, true, true, true, true);
            Report.Info("Finished Executing Script1 : Open Browser");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Confirm Product Catalog page has loaded");
Report.Info("Started Executing Script1 : Confirm Product Catalog page has loaded");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 1,Confirm Product Catalog page has loaded,Passed,Automation Step: 1," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page1_Product_Catalog.Header_PRODUCTCATALOGInfo, "InnerText", "Product Catalog");
Report.Info("Finished Executing Script1 : Confirm Product Catalog page has loaded");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Select Product");
Report.Info("Started Executing Script1 : Select Product");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 1,Select Product,Passed,Automation Step: 2," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
repo.WEBSTORE.Page1_Product_Catalog.ComboBox_ProductSelection.Element.SetAttributeValue("TagValue", "2");
Report.Info("Finished Executing Script1 : Select Product");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Click Order Product");
Report.Info("Started Executing Script1 : Click Order Product");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 1,Click Order Product,Passed,Automation Step: 3," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
repo.WEBSTORE.Page1_Product_Catalog.Button_OrderProduct.Click();
Report.Info("Finished Executing Script1 : Click Order Product");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Confirm Delivery Location page has loaded");
Report.Info("Started Executing Script1 : Confirm Delivery Location page has loaded");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 1,Confirm Delivery Location page has loaded,Passed,Automation Step: 4," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page2_Delivery_Location.Header_DELIVERYLOCATIONInfo, "InnerText", "Delivery Location");
Report.Info("Finished Executing Script1 : Confirm Delivery Location page has loaded");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Enter Email Address");
Report.Info("Started Executing Script1 : Enter Email Address");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 1,Enter Email Address,Passed,Automation Step: 5," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N1_Email.Click();
repo.WEBSTORE.Page2_Delivery_Location.N1_Email.PressKeys("{LControlKey down}{Akey}{LControlKey up}{Back}");
repo.WEBSTORE.Page2_Delivery_Location.N1_Email.PressKeys("william.guastalla@ca.com");
Report.Info("Finished Executing Script1 : Enter Email Address");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Enter Confirmed Email Address");
Report.Info("Started Executing Script1 : Enter Confirmed Email Address");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 1,Enter Confirmed Email Address,Passed,Automation Step: 8," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N2_ConfirmEmail.Click();
repo.WEBSTORE.Page2_Delivery_Location.N2_ConfirmEmail.PressKeys("{LControlKey down}{Akey}{LControlKey up}{Back}");
repo.WEBSTORE.Page2_Delivery_Location.N2_ConfirmEmail.PressKeys("other.email@ca.com");
Report.Info("Finished Executing Script1 : Enter Confirmed Email Address");
TestReport.EndTestModule();
// End Block
repo.WEBSTORE.Page2_Delivery_Location.N3_Name.Click();
repo.WEBSTORE.Page2_Delivery_Location.N3_Name.PressKeys("{LControlKey down}{Akey}{LControlKey up}{Back}");
repo.WEBSTORE.Page2_Delivery_Location.N3_Name.PressKeys("William Guastalla");
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Enter Address Line 1");
Report.Info("Started Executing Script1 : Enter Address Line 1");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 1,Enter Address Line 1,Passed,Automation Step: 14," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N4_AddressLine1.Click();
repo.WEBSTORE.Page2_Delivery_Location.N4_AddressLine1.PressKeys("{LControlKey down}{Akey}{LControlKey up}{Back}");
repo.WEBSTORE.Page2_Delivery_Location.N4_AddressLine1.PressKeys("43a,34,23");
Report.Info("Finished Executing Script1 : Enter Address Line 1");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Enter Address Line 2");
Report.Info("Started Executing Script1 : Enter Address Line 2");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 1,Enter Address Line 2,Passed,Automation Step: 17," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N5_AddressLine2.Click();
repo.WEBSTORE.Page2_Delivery_Location.N5_AddressLine2.PressKeys("{LControlKey down}{Akey}{LControlKey up}{Back}");
repo.WEBSTORE.Page2_Delivery_Location.N5_AddressLine2.PressKeys("");
Report.Info("Finished Executing Script1 : Enter Address Line 2");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Enter County");
Report.Info("Started Executing Script1 : Enter County");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 1,Enter County,Passed,Automation Step: 20," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N6_County.Click();
repo.WEBSTORE.Page2_Delivery_Location.N6_County.PressKeys("{LControlKey down}{Akey}{LControlKey up}{Back}");
repo.WEBSTORE.Page2_Delivery_Location.N6_County.PressKeys("Oxfordshire");
Report.Info("Finished Executing Script1 : Enter County");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Enter Post Code");
Report.Info("Started Executing Script1 : Enter Post Code");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 1,Enter Post Code,Passed,Automation Step: 23," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N7_PostCode.Click();
repo.WEBSTORE.Page2_Delivery_Location.N7_PostCode.PressKeys("{LControlKey down}{Akey}{LControlKey up}{Back}");
repo.WEBSTORE.Page2_Delivery_Location.N7_PostCode.PressKeys("M242912");
Report.Info("Finished Executing Script1 : Enter Post Code");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Enter Country");
Report.Info("Started Executing Script1 : Enter Country");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 1,Enter Country,Passed,Automation Step: 26," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N8_Country.Element.SetAttributeValue("TagValue", "England");
Report.Info("Finished Executing Script1 : Enter Country");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Click Save Shipping");
Report.Info("Started Executing Script1 : Click Save Shipping");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 1,Click Save Shipping,Passed,Automation Step: 27," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.Button_SaveShipping.Click();
Report.Info("Finished Executing Script1 : Click Save Shipping");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Check Email Address");
Report.Info("Started Executing Script1 : Check Email Address");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 1,Check Email Address,Passed,Automation Step: 28," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page2_Delivery_Location.N1_EmailErrorInfo, "InnerText", "");
Report.Info("Finished Executing Script1 : Check Email Address");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Check Confirmed Email Address");
Report.Info("Started Executing Script1 : Check Confirmed Email Address");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 1,Check Confirmed Email Address,Passed,Automation Step: 29," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page2_Delivery_Location.N2_ConfirmEmailErrorInfo, "InnerText", "The Confirm Email field must match the Email field");
Report.Info("Finished Executing Script1 : Check Confirmed Email Address");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Check Name");
Report.Info("Started Executing Script1 : Check Name");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 1,Check Name,Passed,Automation Step: 30," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page2_Delivery_Location.N3_NameErrorInfo, "InnerText", "");
Report.Info("Finished Executing Script1 : Check Name");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Check Address Line 1");
Report.Info("Started Executing Script1 : Check Address Line 1");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 1,Check Address Line 1,Passed,Automation Step: 31," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page2_Delivery_Location.N4_Adr1ErrorInfo, "InnerText", " - The Address Line 1 field can only contain letters, numbers, and spaces");
Report.Info("Finished Executing Script1 : Check Address Line 1");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Check Address Line 2");
Report.Info("Started Executing Script1 : Check Address Line 2");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 1,Check Address Line 2,Passed,Automation Step: 32," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page2_Delivery_Location.N5_Adr2ErrorInfo, "InnerText", "");
Report.Info("Finished Executing Script1 : Check Address Line 2");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Check County");
Report.Info("Started Executing Script1 : Check County");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 1,Check County,Passed,Automation Step: 33," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page2_Delivery_Location.N6_CountyErrorInfo, "InnerText", "");
Report.Info("Finished Executing Script1 : Check County");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Check Post Code");
Report.Info("Started Executing Script1 : Check Post Code");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 1,Check Post Code,Passed,Automation Step: 34," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page2_Delivery_Location.N7_PostCodeErrorInfo, "InnerText", "Please enter a valid UK postcode (OX294TP is a valid UK postcode)");
Report.Info("Finished Executing Script1 : Check Post Code");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Check Country");
Report.Info("Started Executing Script1 : Check Country");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 1,Check Country,Passed,Automation Step: 35," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page2_Delivery_Location.N8_CountryErrorInfo, "InnerText", "- The Country field cannot be empty");
Report.Info("Finished Executing Script1 : Check Country");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script1 : Test Cases 1 - Click Home");
Report.Info("Started Executing Script1 : Click Home");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 1,Click Home,Passed,Automation Step: 36," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
repo.WEBSTORE.Navigation.Home.Click();
Report.Info("Finished Executing Script1 : Click Home");
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