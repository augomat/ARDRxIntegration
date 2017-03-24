/*
 * Created by Ranorex
 * User: user
 * Date: 3/22/2017
 * Time: 11:52 PM
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
    /// Description of Flow1_Path2.
    /// </summary>
    [TestModule("09C796BB-C467-4A17-BAFB-CA70ACCB05DD", ModuleType.UserCode, 1)]
    public class Flow1_Path2 : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Flow1_Path2()
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
        	
        	TestReport.BeginTestCaseContainer("Flow1_Path2");
        	
        	try {
        		TestReport.BeginTestModule("Flow1_Path2_Block1");
	        		// --- BEGIN ARD Blockcode  ---
		        	Report.Info("Flow1 Path2 Block1 (only block)");
		        	Report.Info("This is it!");
		        	Delay.Milliseconds(200);
		        	Report.Info("This is it!");
		        	Delay.Milliseconds(200);
		        	
		        	// copied from NotepadTest
		        	Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Windows\\System32\\notepad.exe' with arguments '' in normal mode.");
		            Host.Local.RunApplication("C:\\Windows\\System32\\notepad.exe", "", "C:\\Windows\\System32", false);
		            
		            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UntitledNotepad.Text15' at 254;96.", repo.UntitledNotepad.Text15Info);
		            repo.UntitledNotepad.Text15.Click("254;96");
		            
		            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'aaa' with focus on 'UntitledNotepad.Text15'.", repo.UntitledNotepad.Text15Info);
		            repo.UntitledNotepad.Text15.PressKeys("aaa");
		            
		            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UntitledNotepad.Edit' at 21;17.", repo.UntitledNotepad.EditInfo);
		            repo.UntitledNotepad.Edit.Click("21;17");
		            
		            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Notepad.UndoCtrlPlusZ' at 35;6.", repo.Notepad.UndoCtrlPlusZInfo);
		            repo.Notepad.UndoCtrlPlusZ.Click("35;6");
		            
		            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UntitledNotepad.File' at 5;14.", repo.UntitledNotepad.FileInfo);
		            repo.UntitledNotepad.File.Click("5;14");
		            
		            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Notepad.Exit' at 34;13.", repo.Notepad.ExitInfo);
		            repo.Notepad.Exit.Click("34;13");
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
        			TestReport.BeginTestModule("Flow1_Path2_Teardown");
		        		// --- BEGIN ARD Blockcode ---
		        		Report.Info("And our teardown blows off");	
		        		Validate.IsTrue(false);
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
