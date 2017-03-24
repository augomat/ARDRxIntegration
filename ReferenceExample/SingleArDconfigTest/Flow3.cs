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
	public class Flow3 
	{
		public Flow3()
		{
		}
		
		public void Run()
		{
			// --- BEGIN ARD Pathcode ---
			TestModuleRunner.Run(new Flow3_Path1());
			// --- END ARD Pathcode ---
		}
	}
}
