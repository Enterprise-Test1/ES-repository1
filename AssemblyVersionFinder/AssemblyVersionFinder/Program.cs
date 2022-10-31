using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyVersionFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath;
            string isLicenseEnforcedorNot ;
            filePath = args[0];

            Assembly loadedAssembly = Assembly.LoadFrom(filePath);
            string version = loadedAssembly.FullName.Split(',')[1].Split('=')[1];
            isLicenseEnforcedorNot = FileVersionInfo.GetVersionInfo(filePath).FileDescription.Contains("LR") ? "LicenseEnforced" : (FileVersionInfo.GetVersionInfo(filePath).ProductName.Contains("LR") ? "LicenseEnforced" : "LicenseNotEnforced");
            Console.WriteLine(version + ":" + isLicenseEnforcedorNot);
        }
    }
}
