﻿/*
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
	public class Flow2
	{
		public Flow2()
		{
		}
		
		public void Run()
		{
			// --- BEGIN ARD Pathcode ---
			TestModuleRunner.Run(new Flow2_Path1());
			// --- END ARD Pathcode ---
		}
	}
}
