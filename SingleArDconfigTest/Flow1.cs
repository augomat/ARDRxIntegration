/*
 * Created by Ranorex
 * User: gkapeller
 * Date: 2/2/2017
 * Time: 12:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using Ranorex.Core.Reporting;
using Ranorex.Core.Testing;

namespace SingleArDconfigTest
{
	/// <summary>
	/// Description of Flow1.
	/// </summary>
	public class Flow1 : IFlow 
	{
		public Flow1()
		{
		}
		
		string IFlow.FlowName { get { return "Flow 1"; } set { } }
		string IFlow.FlowComment { get { return "Flow 1 comment"; } set { } }
		
		public TestResult run()
		{
			TestResult overallResult = TestResult.Skipped;
			TestResult result = TestResult.Skipped;
			
			// --- BEGIN ARD Pathcode ---
			result = Flow1_Path1.Instance.Path1Usermethod();
			overallResult = RanorexCoreReflectionHelper.InferResult(overallResult, result);
			
			result = Flow1_Path2.Instance.Path2Usermethod();
			overallResult = RanorexCoreReflectionHelper.InferResult(overallResult, result);
			// --- END ARD Pathcode ---
			
			return overallResult;
		}
	}
}
