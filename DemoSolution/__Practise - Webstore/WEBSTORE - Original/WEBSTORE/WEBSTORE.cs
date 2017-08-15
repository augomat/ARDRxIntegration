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
			// --- END ARD Pathcode ---
		}
	}
}
