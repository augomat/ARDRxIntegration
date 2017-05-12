/*
 * Created by Ranorex
 * User: guawi01
 * Date: 19/02/2016
 * Time: 12:37
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
using Ranorex.Core.Testing;

namespace AGILE_DESIGNER.Recordings.EditGlobalProperties
{
	/// <summary>
	/// Description of EditGlobalProperties.
	/// </summary>
	[TestModule("4904C1E9-9C44-4364-910D-F91B7527FB04", ModuleType.UserCode, 1)]
	public class EditGlobalProperties : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public EditGlobalProperties()
		{
			// Do not delete - a parameterless constructor is required!
		}
		public static AGILE_DESIGNER.AGD repo = AGILE_DESIGNER.AGD.Instance;
		/// <summary>
		/// Performs the playback of actions in this module.
		/// </summary>
		/// <remarks>You should not call this method directly, instead pass the module
		/// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
		/// that will in turn invoke this method.</remarks>
			void ITestModule.Run()
		{
			Mouse.DefaultMoveTime = 300;
			Keyboard.DefaultKeyPressTime = 10;
			Delay.SpeedFactor = 1.0;
			
			// Open Application
			Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Program Files\\Grid-Tools\\AgileDesigner\\AgileDesigner.exe' with arguments '' in normal mode.", new RecordItemIndex(0));
			Host.Local.RunApplication("C:\\Program Files\\Grid-Tools\\AgileDesigner\\AgileDesigner.exe", "", "C:\\Program Files\\Grid-Tools\\AgileDesigner", false);
			Delay.Milliseconds(10);
		
			// Create New Flowchart
			{
				repo.Agile_Designer2.Main_Window.MainWindow.Menubar.N1_File.Click();
				Delay.Milliseconds(10);
				repo.Agile_Designer2.Main_Window.MenuBarContext.N1_File.N1_MenuItemNew.Click();
				Delay.Milliseconds(10);
				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N1_GeneralProperties.N1_Title.PressKeys("~FlowchartTitle~");
				repo.Agile_Designer2.New_Flow.File_NewFlowChart.Buttons.ButtonFinish.Click();
				Delay.Milliseconds(10);
			}
			
			repo.Agile_Designer2.Main_Window.MainWindow.Toolbar.N3_MostFeatures.Buttons.Properties.Click();
			Delay.Milliseconds(10);
			
			
			// --- ========= 1. GENERAL ========= ---
			repo.Agile_Designer2.Flowchart_Properties.Properties.General.Click();
			Delay.Milliseconds(10);

			repo.Agile_Designer2.Flowchart_Properties.Properties.N1_General.N1_Title2.Click();

			
			repo.Agile_Designer2.Flowchart_Properties.Properties.N1_General.N1_Title2.PressKeys("~FlowchartTitle~");
			repo.Agile_Designer2.Flowchart_Properties.Properties.N1_General.N2_ShortName.DoubleClick();
			repo.Agile_Designer2.Flowchart_Properties.Properties.N1_General.N2_ShortName.PressKeys("~FlowchartShortName~");
			repo.Agile_Designer2.Flowchart_Properties.Properties.N1_General.N3_Description.DoubleClick();
			repo.Agile_Designer2.Flowchart_Properties.Properties.N1_General.N3_Description.PressKeys("~FlowchartDescription~");
			repo.Agile_Designer2.Flowchart_Properties.Properties.N1_General.N4_Author.DoubleClick();
			repo.Agile_Designer2.Flowchart_Properties.Properties.N1_General.N4_Author.PressKeys("~FlowchartAuthor~");
			
			// --- ================================= ---
			
			
			// --- ========= 2. DETAILS ========= ---
			repo.Agile_Designer2.Flowchart_Properties.Properties.Details.Click();
			Delay.Milliseconds(10);

			repo.Agile_Designer2.Flowchart_Properties.Properties.N2_Details.N1_Documentation.DoubleClick();
			repo.Agile_Designer2.Flowchart_Properties.Properties.N2_Details.N1_Documentation.PressKeys("~FlowchartTitle~");
			repo.Agile_Designer2.Flowchart_Properties.Properties.N2_Details.N2_SourceCode.DoubleClick();
			repo.Agile_Designer2.Flowchart_Properties.Properties.N2_Details.N2_SourceCode.PressKeys("~FlowchartShortName~");
			repo.Agile_Designer2.Flowchart_Properties.Properties.N2_Details.N3_Environment.DoubleClick();
			repo.Agile_Designer2.Flowchart_Properties.Properties.N2_Details.N3_Environment.PressKeys("~FlowchartDescription~");
			repo.Agile_Designer2.Flowchart_Properties.Properties.N2_Details.N4_TestPlan.DoubleClick();
			repo.Agile_Designer2.Flowchart_Properties.Properties.N2_Details.N4_TestPlan.PressKeys("~FlowchartTestPlan~");
			repo.Agile_Designer2.Flowchart_Properties.Properties.N2_Details.N5_Audit.DoubleClick();
			repo.Agile_Designer2.Flowchart_Properties.Properties.N2_Details.N5_Audit.PressKeys("~FlowchartAudit~");
			repo.Agile_Designer2.Flowchart_Properties.Properties.N2_Details.N6_Jira.DoubleClick();
			repo.Agile_Designer2.Flowchart_Properties.Properties.N2_Details.N6_Jira.PressKeys("~FlowchartJira~");
			repo.Agile_Designer2.Flowchart_Properties.Properties.N2_Details.N7_ALM.DoubleClick();
			repo.Agile_Designer2.Flowchart_Properties.Properties.N2_Details.N7_ALM.PressKeys("~FlowchartALM~");
			repo.Agile_Designer2.Flowchart_Properties.Properties.N2_Details.N8_RequirementDetails.DoubleClick();
			repo.Agile_Designer2.Flowchart_Properties.Properties.N2_Details.N8_RequirementDetails.PressKeys("~FlowchartRequirementDetails~");
			// --- ================================= ---
			
			
// guawi01 - Need to be updated

//			// --- ========= 3. PARAMETERS ========= ---
//			repo.Agile_Designer.Flowchart_Properties.Properties.Parameters.Click();
//			Delay.Milliseconds(10);
//			
//			for(int i = 0; i < 2; ++i)
//			{
//				repo.Agile_Designer.Flowchart_Properties.Properties.N3_Parameters.Buttons.AddParameter.Click();
//				Delay.Milliseconds(10);
//			}
//			IList<Row> parameterRows = repo.Agile_Designer.Flowchart_Properties.Properties.N3_Parameters.ParametersTable.Rows;
//			for(int i = 0; i < parameterRows.Count; ++i)
//			{
//				IList<Cell> rowCells = parameterRows[i].Cells;
//				rowCells[0].Click();
//				Delay.Milliseconds(10);
//				rowCells[0].PressKeys("~ParameterName~");
//				Delay.Milliseconds(10);
//				rowCells[1].Click();
//				Delay.Milliseconds(10);
//				rowCells[1].PressKeys("~ParameterDescription~");
//				Delay.Milliseconds(10);
//				rowCells[2].Click();
//				Delay.Milliseconds(10);
//				rowCells[2].PressKeys("~ParameterDefaultValue~");
//				Delay.Milliseconds(10);
//				rowCells[3].Click();
//				Delay.Milliseconds(30);
//				// TDoD Login
//				{
//					repo.Agile_Designer.Repository_Connect.SpecifyTDoDService.Buttons.Cancel.Click();
//				}
//				Delay.Milliseconds(50);
//			}
//			// --- ================================= ---
//			
//			
//			// --- ========= 4. VARIABLES ========= ---
//			repo.Agile_Designer.Flowchart_Properties.Properties.Variables.Click();
//			Delay.Milliseconds(10);
//
//			for(int i = 0; i < 2; ++i)
//			{
//				repo.Agile_Designer.Flowchart_Properties.Properties.N4_Variables.Buttons.AddVariable.Click();
//				Delay.Milliseconds(10);
//			}
//			IList<Row> variableRows = repo.Agile_Designer.Flowchart_Properties.Properties.N4_Variables.VariablesTable.Rows;
//			for(int i = 0; i < variableRows.Count; ++i)
//			{
//				IList<Cell> rowCells = variableRows[i].Cells;
//				rowCells[0].Click();
//				Delay.Milliseconds(10);
//				rowCells[0].PressKeys("~VariableName~");
//				Delay.Milliseconds(10);
//				rowCells[1].Click();
//				Delay.Milliseconds(10);
//				rowCells[1].PressKeys("~VariableDescription~");
//				Delay.Milliseconds(10);
//				rowCells[2].Click();
//				Delay.Milliseconds(10);
//				rowCells[2].PressKeys("~VariableDefaultValue~");
//				Delay.Milliseconds(10);
//				rowCells[3].Click();
//				Delay.Milliseconds(30);
//				// TDoD Login
//				{
//					repo.Agile_Designer.Repository_Connect.SpecifyTDoDService.Buttons.Cancel.Click();
//				}
//				Delay.Milliseconds(50);
//			}
//			// --- ================================= ---
//			
			
			// --- ========= 5. PEOPLE & ROLES ========= ---
			repo.Agile_Designer2.Flowchart_Properties.Properties.PeopleRoles.Click();
			Delay.Milliseconds(10);
			
			// Person
			repo.Agile_Designer2.Flowchart_Properties.Properties.N5_PeopleAndRoles.Buttons.AddPerson.Click();
			{
				repo.Agile_Designer2.People_And_Roles.PersonDetails.N1_Name.PressKeys("~PersonName~");
				repo.Agile_Designer2.People_And_Roles.PersonDetails.N2_Email.PressKeys("~PersonEmail~");
				repo.Agile_Designer2.People_And_Roles.PersonDetails.Buttons.OK.Click();
			}
			// Role
			repo.Agile_Designer2.Flowchart_Properties.Properties.N5_PeopleAndRoles.Buttons.AddRole.Click();
			{
				repo.Agile_Designer2.People_And_Roles.RoleDetails.N1_Name.PressKeys("~RoleName~");
				repo.Agile_Designer2.People_And_Roles.RoleDetails.Buttons.OK.Click();
			}
			// --- ================================= ---
			
			// --- ========= 6. APPLICATION LINKS ========= ---
			repo.Agile_Designer2.Flowchart_Properties.Properties.ApplicationLinks.Click();
			Delay.Milliseconds(10);
			// --- ================================= ---
			
			// --- ========= 7. REQUIREMENTS IDS ========= ---
			repo.Agile_Designer2.Flowchart_Properties.Properties.RequirementsIDs.Click();
			Delay.Milliseconds(10);
			// Add Numeric REQIDs
			{
				repo.Agile_Designer2.Flowchart_Properties.Properties.N7_RequirementsIDs.AddReqIDNumber1.PressKeys("1");
				repo.Agile_Designer2.Flowchart_Properties.Properties.N7_RequirementsIDs.AddReqIDNumber2.PressKeys("2");
				repo.Agile_Designer2.Flowchart_Properties.Properties.N7_RequirementsIDs.AddReqIDNumber3.PressKeys("3");
				repo.Agile_Designer2.Flowchart_Properties.Properties.N7_RequirementsIDs.AddReqIDNumber4.PressKeys("4");
				for(int i = 0; i < 10; ++i)
					repo.Agile_Designer2.Flowchart_Properties.Properties.N7_RequirementsIDs.Buttons.AddReqIDSNumber.DoubleClick();
				repo.Agile_Designer2.Flowchart_Properties.Properties.N7_RequirementsIDs.AddReqIDStringEdit.PressKeys("~ReqIDString~");
				for(int i = 0; i < 10; ++i)
					repo.Agile_Designer2.Flowchart_Properties.Properties.N7_RequirementsIDs.Buttons.AddReqIDString.DoubleClick();
			}			
			// --- ================================= ---
			
			
			// --- ========= 8. CUSTOM FIELDS ========= ---
			repo.Agile_Designer2.Flowchart_Properties.Properties.CustomFields.Click();
			Delay.Milliseconds(10);
			// --- ================================= ---

			
			
			
			repo.Agile_Designer2.Flowchart_Properties.Properties.Buttons.Save.Click();
			Delay.Milliseconds(10);
			
			repo.Agile_Designer2.Main_Window.MainWindow.Titlebar.Buttons.Close.Click();
			Delay.Milliseconds(10);
		}
	}
}
