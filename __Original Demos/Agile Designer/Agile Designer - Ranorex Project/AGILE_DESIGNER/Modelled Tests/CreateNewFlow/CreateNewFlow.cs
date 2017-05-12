/*
 * Created by Ranorex
 * User: guawi01
 * Date: 17/02/2016
 * Time: 17:07
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

namespace AGILE_DESIGNER.Recordings
{
	/// <summary>
	/// Description of UserCodeModule1.
	/// </summary>
	[TestModule("56A217AF-769D-4687-95FC-F02DE322B5D9", ModuleType.UserCode, 1)]
	public class CreateNewFlow : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public CreateNewFlow()
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
			
			// Expects Agile Designer to be open.
			
			// Create new flow from main menu
			repo.Agile_Designer2.Main_Window.MainWindow.Menubar.N1_File.Click();
			Delay.Milliseconds(100);
			
			repo.Agile_Designer2.Main_Window.MenuBarContext.N1_File.N1_MenuItemNew.Click();
			Delay.Milliseconds(100);
			
			
			// Fill in General Properties
			repo.Agile_Designer2.New_Flow.File_NewFlowChart.N1_GeneralProperties.N1_Title.PressKeys("~~FlowchartName~~");
			Delay.Milliseconds(100);
			{
				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N1_GeneralProperties.N2_Description.PressKeys("~FlowchartDescription~");
				Delay.Milliseconds(100);

				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N1_GeneralProperties.N3_Author.PressKeys("~FlowchartAuthor~");
				Delay.Milliseconds(100);

				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N1_GeneralProperties.N4_VersionNumber1.DoubleClick();
				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N1_GeneralProperties.N4_VersionNumber1.PressKeys("12");
				Delay.Milliseconds(100);
				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N1_GeneralProperties.N4_VersionNumber2.DoubleClick();
				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N1_GeneralProperties.N4_VersionNumber2.PressKeys("34");
				Delay.Milliseconds(100);
				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N1_GeneralProperties.N4_VersionNumber3.DoubleClick();
				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N1_GeneralProperties.N4_VersionNumber3.PressKeys("56");
				Delay.Milliseconds(100);
				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N1_GeneralProperties.N4_VersionNumber4.DoubleClick();
				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N1_GeneralProperties.N4_VersionNumber4.PressKeys("78");
				Delay.Milliseconds(100);
				
				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N1_GeneralProperties.N5_TDod_Combobox.Click();
				Delay.Milliseconds(100);
				repo.Agile_Designer2.New_Flow.N1_GeneralProperties_TDoDCombo.N1_CalculateJobSubmissionOrder.Click();
				Delay.Milliseconds(100);
			}
			// Fill in Details
			repo.Agile_Designer2.New_Flow.File_NewFlowChart.Buttons.ButtonNext.Click();
			Delay.Milliseconds(100);
			{
				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N2_Details.N1_Documentation.PressKeys("~FlowchartDocumentation~");
				Delay.Milliseconds(100);
				
				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N2_Details.N2_Source_Code.PressKeys("~FlowchartSourceCode~");
				Delay.Milliseconds(100);
				
				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N2_Details.N3_Environment.PressKeys("~FlowchartEnvironment~");
				Delay.Milliseconds(100);
				
				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N2_Details.N4_Test_Plan.PressKeys("~FlowchartTestPlan~");
				Delay.Milliseconds(100);
				
				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N2_Details.N5_Audit.PressKeys("~FlowchartAudit~");
				Delay.Milliseconds(100);
				
				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N2_Details.N6_Jira.PressKeys("~FlowchartJIRA~");
				Delay.Milliseconds(100);

				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N2_Details.N7_ALM.PressKeys("~FlowchartALM~");
				Delay.Milliseconds(100);
				
				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N2_Details.N8_Requirement_Details.PressKeys("~FlowchartRequirementDetails~");
				Delay.Milliseconds(100);
			}
			// Fill in Parameters
			repo.Agile_Designer2.New_Flow.File_NewFlowChart.Buttons.ButtonNext.Click();
			Delay.Milliseconds(100);
			{
				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N3_Parameters.AddAnotherParameter.Click();
				Delay.Milliseconds(100);

				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N3_Parameters.N1_Name.PressKeys("~FlowchartParameterName~");
				Delay.Milliseconds(100);

				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N3_Parameters.N2_Value.PressKeys("~FlowchartParameterValue~");
				Delay.Milliseconds(100);
			}
			// Fill in Variables
			repo.Agile_Designer2.New_Flow.File_NewFlowChart.Buttons.ButtonNext.Click();
			Delay.Milliseconds(100);
			{
				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N4_Variables.AddAnotherVariable.Click();
				Delay.Milliseconds(100);

				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N4_Variables.N1_Name.PressKeys("~FlowchartVariableName~");
				Delay.Milliseconds(100);

				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N4_Variables.N2_Description.PressKeys("~FlowchartVariableDescription~");
				Delay.Milliseconds(100);

				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N4_Variables.N3_DefaultValue.PressKeys("~FlowchartVariableDefaultValue~");
				Delay.Milliseconds(100);
			}
			// Fill in People and Roles
			repo.Agile_Designer2.New_Flow.File_NewFlowChart.Buttons.ButtonNext.Click();
			Delay.Milliseconds(100);
			{
				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N5_PeopleAndRoles.Buttons.AddPerson.Click();
				Delay.Milliseconds(100);
				{
					repo.Agile_Designer2.People_And_Roles.PersonDetails.N1_Name.PressKeys("~FlowchartPersonName~");
					Delay.Milliseconds(100);
					
					repo.Agile_Designer2.People_And_Roles.PersonDetails.N2_Email.PressKeys("~FlowchartEmailAddress~");
					Delay.Milliseconds(100);
					
					repo.Agile_Designer2.People_And_Roles.PersonDetails.Buttons.OK.Click();
					Delay.Milliseconds(100);
				}
				
				repo.Agile_Designer2.New_Flow.File_NewFlowChart.N5_PeopleAndRoles.Buttons.AddRole.Click();
				Delay.Milliseconds(100);
				{
					repo.Agile_Designer2.People_And_Roles.RoleDetails.N1_Name.PressKeys("~FlowchartRoleName~");
					Delay.Milliseconds(100);
					
					repo.Agile_Designer2.People_And_Roles.RoleDetails.Buttons.OK.Click();
					Delay.Milliseconds(100);
				}
			}
			
			repo.Agile_Designer2.New_Flow.File_NewFlowChart.Buttons.ButtonFinish.Click();
			Delay.Milliseconds(100);
			
			// Leaves Agile Designer open with a flow created.
		}
	}
}
