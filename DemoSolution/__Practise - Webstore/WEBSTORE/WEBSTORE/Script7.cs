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
    /// Description of Script7.
    /// </summary>
    [TestModule("799c8b3e-f752-4a2d-8f80-92425bb73b9b", ModuleType.UserCode, 1)]
    public class Script7 : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Script7()
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
        	TestReport.BeginTestCaseContainer("FLOWCHART - Script7");
	try {
		// Begin Test Case

// Begin Block
TestReport.BeginTestModule("Script7 : Test Cases 7 - Open Browser");
Report.Info("Started Executing Script7 : Open Browser");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 7,Open Browser,Passed,Automation Step: 0," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
            Host.Current.OpenBrowser("http://grid-tools-downloads.com/Will/TMF/index.php", "chrome", "", true, true, true, true, true);
            Report.Info("Finished Executing Script7 : Open Browser");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script7 : Test Cases 7 - Confirm Product Catalog page has loaded");
Report.Info("Started Executing Script7 : Confirm Product Catalog page has loaded");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 7,Confirm Product Catalog page has loaded,Passed,Automation Step: 1," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page1_Product_Catalog.Header_PRODUCTCATALOGInfo, "InnerText", "Product Catalog");
Report.Info("Finished Executing Script7 : Confirm Product Catalog page has loaded");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script7 : Test Cases 7 - Select Product");
Report.Info("Started Executing Script7 : Select Product");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 7,Select Product,Passed,Automation Step: 2," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
repo.WEBSTORE.Page1_Product_Catalog.ComboBox_ProductSelection.Element.SetAttributeValue("TagValue", "3");
Report.Info("Finished Executing Script7 : Select Product");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script7 : Test Cases 7 - Click Order Product");
Report.Info("Started Executing Script7 : Click Order Product");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 7,Click Order Product,Passed,Automation Step: 3," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
repo.WEBSTORE.Page1_Product_Catalog.Button_OrderProduct.Click();
Report.Info("Finished Executing Script7 : Click Order Product");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script7 : Test Cases 7 - Confirm Delivery Location page has loaded");
Report.Info("Started Executing Script7 : Confirm Delivery Location page has loaded");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 7,Confirm Delivery Location page has loaded,Passed,Automation Step: 4," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page2_Delivery_Location.Header_DELIVERYLOCATIONInfo, "InnerText", "Delivery Location");
Report.Info("Finished Executing Script7 : Confirm Delivery Location page has loaded");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script7 : Test Cases 7 - Enter Email Address");
Report.Info("Started Executing Script7 : Enter Email Address");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 7,Enter Email Address,Passed,Automation Step: 5," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N1_Email.Click();
repo.WEBSTORE.Page2_Delivery_Location.N1_Email.PressKeys("{LControlKey down}{Akey}{LControlKey up}{Back}");
repo.WEBSTORE.Page2_Delivery_Location.N1_Email.PressKeys("asdf,as,dfasd,@gmail.");
Report.Info("Finished Executing Script7 : Enter Email Address");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script7 : Test Cases 7 - Enter Confirmed Email Address");
Report.Info("Started Executing Script7 : Enter Confirmed Email Address");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 7,Enter Confirmed Email Address,Passed,Automation Step: 8," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N2_ConfirmEmail.Click();
repo.WEBSTORE.Page2_Delivery_Location.N2_ConfirmEmail.PressKeys("{LControlKey down}{Akey}{LControlKey up}{Back}");
repo.WEBSTORE.Page2_Delivery_Location.N2_ConfirmEmail.PressKeys("other.email@ca.com");
Report.Info("Finished Executing Script7 : Enter Confirmed Email Address");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script7 : Test Cases 7 - Enter Name");
Report.Info("Started Executing Script7 : Enter Name");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 7,Enter Name,Passed,Automation Step: 11," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N3_Name.Click();
repo.WEBSTORE.Page2_Delivery_Location.N3_Name.PressKeys("{LControlKey down}{Akey}{LControlKey up}{Back}");
repo.WEBSTORE.Page2_Delivery_Location.N3_Name.PressKeys("bill12345");
Report.Info("Finished Executing Script7 : Enter Name");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script7 : Test Cases 7 - Enter Address Line 1");
Report.Info("Started Executing Script7 : Enter Address Line 1");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 7,Enter Address Line 1,Passed,Automation Step: 14," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N4_AddressLine1.Click();
repo.WEBSTORE.Page2_Delivery_Location.N4_AddressLine1.PressKeys("{LControlKey down}{Akey}{LControlKey up}{Back}");
repo.WEBSTORE.Page2_Delivery_Location.N4_AddressLine1.PressKeys("");
Report.Info("Finished Executing Script7 : Enter Address Line 1");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script7 : Test Cases 7 - Enter Address Line 2");
Report.Info("Started Executing Script7 : Enter Address Line 2");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 7,Enter Address Line 2,Passed,Automation Step: 17," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N5_AddressLine2.Click();
repo.WEBSTORE.Page2_Delivery_Location.N5_AddressLine2.PressKeys("{LControlKey down}{Akey}{LControlKey up}{Back}");
repo.WEBSTORE.Page2_Delivery_Location.N5_AddressLine2.PressKeys("Eynsham, Oxford");
Report.Info("Finished Executing Script7 : Enter Address Line 2");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script7 : Test Cases 7 - Enter County");
Report.Info("Started Executing Script7 : Enter County");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 7,Enter County,Passed,Automation Step: 20," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N6_County.Click();
repo.WEBSTORE.Page2_Delivery_Location.N6_County.PressKeys("{LControlKey down}{Akey}{LControlKey up}{Back}");
repo.WEBSTORE.Page2_Delivery_Location.N6_County.PressKeys("Aharashord,a,");
Report.Info("Finished Executing Script7 : Enter County");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script7 : Test Cases 7 - Enter Post Code");
Report.Info("Started Executing Script7 : Enter Post Code");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 7,Enter Post Code,Passed,Automation Step: 23," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N7_PostCode.Click();
repo.WEBSTORE.Page2_Delivery_Location.N7_PostCode.PressKeys("{LControlKey down}{Akey}{LControlKey up}{Back}");
repo.WEBSTORE.Page2_Delivery_Location.N7_PostCode.PressKeys("M242912");
Report.Info("Finished Executing Script7 : Enter Post Code");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script7 : Test Cases 7 - Enter Country");
Report.Info("Started Executing Script7 : Enter Country");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 7,Enter Country,Passed,Automation Step: 26," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.N8_Country.Element.SetAttributeValue("TagValue", "Wales");
Report.Info("Finished Executing Script7 : Enter Country");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script7 : Test Cases 7 - Click Save Shipping");
Report.Info("Started Executing Script7 : Click Save Shipping");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 7,Click Save Shipping,Passed,Automation Step: 27," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
repo.WEBSTORE.Page2_Delivery_Location.Button_SaveShipping.Click();
Report.Info("Finished Executing Script7 : Click Save Shipping");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script7 : Test Cases 7 - Check Email Address");
Report.Info("Started Executing Script7 : Check Email Address");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 7,Check Email Address,Passed,Automation Step: 28," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page2_Delivery_Location.N1_EmailErrorInfo, "InnerText", "Enter a valid email. ");
Report.Info("Finished Executing Script7 : Check Email Address");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script7 : Test Cases 7 - Check Confirmed Email Address");
Report.Info("Started Executing Script7 : Check Confirmed Email Address");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 7,Check Confirmed Email Address,Passed,Automation Step: 29," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page2_Delivery_Location.N2_ConfirmEmailErrorInfo, "InnerText", "The Confirm Email field must match the Email field");
Report.Info("Finished Executing Script7 : Check Confirmed Email Address");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script7 : Test Cases 7 - Check Name");
Report.Info("Started Executing Script7 : Check Name");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 7,Check Name,Passed,Automation Step: 30," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page2_Delivery_Location.N3_NameErrorInfo, "InnerText", " - The Name field cannot contain numbers or special characters.");
Report.Info("Finished Executing Script7 : Check Name");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script7 : Test Cases 7 - Check Address Line 1");
Report.Info("Started Executing Script7 : Check Address Line 1");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 7,Check Address Line 1,Passed,Automation Step: 31," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page2_Delivery_Location.N4_Adr1ErrorInfo, "InnerText", "- The Address Line 1 field cannot be empty - The Address Line 1 field can only contain letters, numbers, and spaces");
Report.Info("Finished Executing Script7 : Check Address Line 1");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script7 : Test Cases 7 - Check Address Line 2");
Report.Info("Started Executing Script7 : Check Address Line 2");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 7,Check Address Line 2,Passed,Automation Step: 32," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page2_Delivery_Location.N5_Adr2ErrorInfo, "InnerText", "- The Address Line 2 field must be either empty or only contain letters, numbers and spaces.");
Report.Info("Finished Executing Script7 : Check Address Line 2");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script7 : Test Cases 7 - Check County");
Report.Info("Started Executing Script7 : Check County");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 7,Check County,Passed,Automation Step: 33," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page2_Delivery_Location.N6_CountyErrorInfo, "InnerText", "- The County field can only contain letters, numbers and spaces.");
Report.Info("Finished Executing Script7 : Check County");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script7 : Test Cases 7 - Check Post Code");
Report.Info("Started Executing Script7 : Check Post Code");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 7,Check Post Code,Passed,Automation Step: 34," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page2_Delivery_Location.N7_PostCodeErrorInfo, "InnerText", "Please enter a valid UK postcode (OX294TP is a valid UK postcode)");
Report.Info("Finished Executing Script7 : Check Post Code");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script7 : Test Cases 7 - Check Country");
Report.Info("Started Executing Script7 : Check Country");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 7,Check Country,Passed,Automation Step: 35," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
Validate.Attribute(repo.WEBSTORE.Page2_Delivery_Location.N8_CountryErrorInfo, "InnerText", "- The Country field cannot be empty");
Report.Info("Finished Executing Script7 : Check Country");
TestReport.EndTestModule();
// End Block
// Begin Block
TestReport.BeginTestModule("Script7 : Test Cases 7 - Click Home");
Report.Info("Started Executing Script7 : Click Home");
// Results Format: Path Guid, Block Guid, Result (pass/fail), Result, Resolved Test Data, Execution time, Stack Trace, Exception, Notes, Image
File.AppendAllText(Environment.CurrentDirectory + "\\" + "WEBSTORE" + ".csv", "Test Cases 7,Click Home,Passed,Automation Step: 36," + System.DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz") + Environment.NewLine);
repo.WEBSTORE.Navigation.Home.Click();
Report.Info("Finished Executing Script7 : Click Home");
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
        			TestReport.BeginTestModule("Script7_Teardown");
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