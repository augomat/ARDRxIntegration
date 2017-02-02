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

namespace SingleArDconfigTest
{
	/// <summary>
	/// Description of Flow1.
	/// </summary>
	public class Flow1
	{
		public Flow1()
		{
		}
		
		public static void run()
		{
			//TestReport.BeginTestSuite("MyTestSuite");
			
			Flow1_Path1.Start();
			Flow1_Path2.Start();
		}
	}
}
