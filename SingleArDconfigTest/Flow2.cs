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
	/// Description of Flow2
	/// </summary>
	public class Flow2 : IFlow
	{
		public Flow2()
		{
		}
		
		string IFlow.FlowName { get { return "Flow 2"; } set { } }
		string IFlow.FlowComment { get { return "Flow 2 comment"; } set { } }
		
		public TestResult run()
		{
			TestResult overallResult = TestResult.Skipped;
			TestResult result = TestResult.Skipped;
			
			// --- BEGIN ARD Pathcode ---
			result = Flow2_Path1.Instance.Path1Usermethod();
			overallResult = RanorexCoreReflectionHelper.InferResult(overallResult, result);
			// --- END ARD Pathcode ---
			
			return overallResult;
		}
	}
}
