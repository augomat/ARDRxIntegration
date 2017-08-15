using System;
using Ranorex.Core.Reporting;
using Ranorex.Core.Testing;

namespace WEBSTORE
{
	/// <summary>
	/// Description of FLOWCHART.
	/// </summary>
	public class FLOWCHART
	{
		public FLOWCHART()
		{
		}
		public static void run()
		{
			// --- BEGIN ARD Pathcode ---
			TestModuleRunner.Run(new Script1());
			TestModuleRunner.Run(new Script2());
			TestModuleRunner.Run(new Script3());
			TestModuleRunner.Run(new Script4());
			TestModuleRunner.Run(new Script5());
			TestModuleRunner.Run(new Script6());
			TestModuleRunner.Run(new Script7());
			TestModuleRunner.Run(new Script8());
			TestModuleRunner.Run(new Script9());
			TestModuleRunner.Run(new Script10());
			// --- END ARD Pathcode ---
		}
	}
}
