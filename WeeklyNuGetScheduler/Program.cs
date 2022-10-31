using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using Syncfusion.CI.Base;
using Syncfusion.EmailSender.Base;

namespace SyncfusionNuGetScheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> finalBuilderProjectLists = new List<string>();
			NugetInfo nugetInfo = new NugetInfo();
			XDocument xDocument = XDocument.Load("FinalBuilderProjectDetails.xml");
            List<XElement> source = xDocument.Elements("FinalBuilderProjectDetails").ToList();
            foreach (XElement finalBuilderProjectPath in source.Elements())
            {
				finalBuilderProjectLists.Add(finalBuilderProjectPath.Value);
            }
            if (nugetInfo.GetAllPlatformBuildStatus())
            {
                foreach (string finalBuilderProject in finalBuilderProjectLists)
                {
                    if (Program.StartFinalBuilderApplication(finalBuilderProject) != 0)
                    {
                        break;
                    }
                }
            }
        }


		/// <summary>
		/// Method to start the Weekly NuGet publish automation(Finalbuilder project) when all platform build status is success
		/// </summary>
		private static int StartFinalBuilderApplication(string automationPath)
		{
			int result = 1;
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\FinalBuilder 7\\FinalBuilder7.exe";
				process.StartInfo.Arguments = "/o /n /r /e \"" + automationPath + "\"";
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				process.WaitForExit();
				result = process.ExitCode;
			}
			catch (Exception ex)
			{
				FailureNotification.SendNotification("Start finalbuilder application : Program", "Error in starting the finalbuilder", new Dictionary<string, string>
			{
				{
					"File",
					"Program.cs"
				},
				{
					"Method",
					"StartFinalBuilderApplication()"
				},
				{
					"ExceptionMessage",
					ex.Message
				},
				{
					"InnerException",
					(ex.InnerException != null) ? ex.InnerException.ToString() : string.Empty
				},
				{
					"StackTrace",
					ex.StackTrace
				}
			});
			}
			return result;
		}
	}


}
    

