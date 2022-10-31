using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;
using System.Xml.Linq;

namespace ReadMeFileValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string readmeContent = string.Empty;
            string[] files = Directory.GetFiles(args[1], "*.nupkg");
            string platform = args[0];
            string version = args[2];
            string successEmailContent = File.ReadAllText(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\EmailFormats\\CompleteMail_Success.htm");
            string failureEmailContent = File.ReadAllText(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\EmailFormats\\CompleteMail_Failure.htm");
            string emailContent = string.Empty;
            string mismatchUrl = string.Empty;
            string mismatchReleaseNotes = string.Empty;
            string packageName = string.Empty;
            string replaceContent = string.Empty;
            string replaceReleaseNotesContent = string.Empty;
            string replaceReadmeFileNorExist = string.Empty;
            string campiagnPackageName = string.Empty;
            string xmlPath = string.Empty;
            string emailId = args[3];
            bool isToolStop = false;
            Dictionary<string, List<string>> nugetPackagelist = new Dictionary<string, List<string>>();
            if (platform.ToLower().Replace(" ", "") == "ej2")
            {
                nugetPackagelist.Add("aspnetcore", new List<string>());
                nugetPackagelist.Add("aspnetmvc", new List<string>());
                nugetPackagelist.Add("js", new List<string>());
                xmlPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), @"..\..\..\NuGetPublish\NuGetPublishDetails.xml");
                XDocument document = XDocument.Load(xmlPath);
                List<XElement> ProjectConfigurations = document.Elements("Platforms").ToList();
                List<XElement> PlatformList = ProjectConfigurations.Elements("Platform").ToList();
                foreach (XElement platformNode in PlatformList)
                {
                    if (platformNode.Attribute("Name").Value == "EJ2-Core")
                    {
                        List<XElement> corePackageList = platformNode.Elements("Packages").ElementAt(0).Elements("Package").ToList();
                        foreach (XElement corePackage in corePackageList)
                        {
                            if (corePackage.Attribute("IsReadmeFilePresent") != null)
                            {
                                if (corePackage.Attribute("IsReadmeFilePresent").Value.ToLower() == "true")
                                {
                                    if(corePackage.Attribute("IsNotEJ2Package") != null)
                                    {
                                        if (corePackage.Attribute("IsNotEJ2Package").Value.ToLower() != "true")
                                        {
                                            nugetPackagelist["aspnetcore"].Add(corePackage.Attribute("Name").Value + "," + corePackage.Attribute("CampignUrlName").Value);
                                        }
                                    }
                                    else
                                    {
                                        nugetPackagelist["aspnetcore"].Add(corePackage.Attribute("Name").Value + "," + corePackage.Attribute("CampignUrlName").Value);
                                    }
                                    
                                }
                            }
                        }
                    }
                    if (platformNode.Attribute("Name").Value == "EJ2-MVC")
                    {
                        List<XElement> mvcPackageList = platformNode.Elements("Packages").ElementAt(0).Elements("Package").ToList();
                        foreach (XElement mvcPackage in mvcPackageList)
                        {
                            if (mvcPackage.Attribute("IsReadmeFilePresent") != null)
                            {
                                if (mvcPackage.Attribute("IsReadmeFilePresent").Value.ToLower() == "true")
                                {
                                    if (mvcPackage.Attribute("IsNotEJ2Package") != null)
                                    {
                                        if (mvcPackage.Attribute("IsNotEJ2Package").Value.ToLower() != "true")
                                        {
                                            nugetPackagelist["aspnetmvc"].Add(mvcPackage.Attribute("Name").Value + "," + mvcPackage.Attribute("CampignUrlName").Value);
                                        }
                                    }
                                    else
                                    {
                                        nugetPackagelist["aspnetmvc"].Add(mvcPackage.Attribute("Name").Value + "," + mvcPackage.Attribute("CampignUrlName").Value);
                                    }
                                }
                            }
                        }
                    }
                }
                nugetPackagelist["js"].Add("Syncfusion.EJ2.JavaScript,common");
            }
            if (platform.ToLower().Replace(" ", "") == "fileformats")
            {
                nugetPackagelist.Add("aspnetcore", new List<string>());
                nugetPackagelist.Add("aspnetmvc", new List<string>());
                xmlPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), @"..\..\..\NuGetPublish\NuGetPublishDetails.xml");
                XDocument document = XDocument.Load(xmlPath);
                List<XElement> ProjectConfigurations = document.Elements("Platforms").ToList();
                List<XElement> PlatformList = ProjectConfigurations.Elements("Platform").ToList();
                foreach (XElement platformNode in PlatformList)
                {
                    if (platformNode.Attribute("Name").Value == "EJ2-Core")
                    {
                        List<XElement> corePackageList = platformNode.Elements("Packages").ElementAt(0).Elements("Package").ToList();
                        foreach (XElement corePackage in corePackageList)
                        {
                            if (corePackage.Attribute("IsReadmeFilePresent") != null && corePackage.Attribute("IsFileFormatDependent") != null)
                            {
                                if (corePackage.Attribute("IsReadmeFilePresent").Value.ToLower() == "true" && corePackage.Attribute("IsFileFormatDependent").Value.ToLower() == "true")
                                {
                                    nugetPackagelist["aspnetcore"].Add(corePackage.Attribute("Name").Value + "," + corePackage.Attribute("CampignUrlName").Value);
                                }
                            }
                        }
                    }
                    if (platformNode.Attribute("Name").Value == "EJ2-MVC")
                    {
                        List<XElement> mvcPackageList = platformNode.Elements("Packages").ElementAt(0).Elements("Package").ToList();
                        foreach (XElement mvcPackage in mvcPackageList)
                        {
                            if (mvcPackage.Attribute("IsReadmeFilePresent") != null && mvcPackage.Attribute("IsFileFormatDependent") != null)
                            {
                                if (mvcPackage.Attribute("IsReadmeFilePresent").Value.ToLower() == "true" && mvcPackage.Attribute("IsFileFormatDependent").Value.ToLower() == "true")
                                {
                                    nugetPackagelist["aspnetmvc"].Add(mvcPackage.Attribute("Name").Value + "," + mvcPackage.Attribute("CampignUrlName").Value);
                                }
                            }
                        }
                    }
                }
            }
            if (platform.ToLower().Replace(" ", "") == "blazor")
            {
                nugetPackagelist.Add("blazor", new List<string>());
                xmlPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), @"..\..\..\NuGetPublish\NuGetPublishDetails.xml");
                XDocument document = XDocument.Load(xmlPath);
                List<XElement> ProjectConfigurations = document.Elements("Platforms").ToList();
                List<XElement> PlatformList = ProjectConfigurations.Elements("Platform").ToList();
                foreach (XElement platformNode in PlatformList)
                {
                    if (platformNode.Attribute("Name").Value == "Blazor")
                    {
                        List<XElement> blazorPackageList = platformNode.Elements("Packages").ElementAt(0).Elements("Package").ToList();
                        foreach (XElement blazorPackage in blazorPackageList)
                        {
                            if (blazorPackage.Attribute("IsReadmeFilePresent") != null)
                            {
                                if (blazorPackage.Attribute("IsReadmeFilePresent").Value.ToLower() == "true")
                                {
                                    nugetPackagelist["blazor"].Add(blazorPackage.Attribute("Name").Value + "," + blazorPackage.Attribute("CampignUrlName").Value);
                                }
                            }
                        }
                    }
                }
            }
            if (platform.ToLower().Replace(" ", "") == "ej1")
            {
                nugetPackagelist.Add("aspnetcore", new List<string>());
                xmlPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), @"..\..\..\NuGetPublish\NuGetPublishDetails.xml");
                XDocument document = XDocument.Load(xmlPath);
                List<XElement> ProjectConfigurations = document.Elements("Platforms").ToList();
                List<XElement> PlatformList = ProjectConfigurations.Elements("Platform").ToList();
                foreach (XElement platformNode in PlatformList)
                {
                    if (platformNode.Attribute("Name").Value == "EJ1-Core")
                    {
                        List<XElement> portablePackageList = platformNode.Elements("Packages").ElementAt(0).Elements("Package").ToList();
                        foreach (XElement portablePackage in portablePackageList)
                        {
                            if (portablePackage.Attribute("IsReadmeFilePresent") != null)
                            {
                                if (portablePackage.Attribute("IsReadmeFilePresent").Value.ToLower() == "true")
                                {
                                    nugetPackagelist["aspnetcore"].Add(portablePackage.Attribute("Name").Value + "," + portablePackage.Attribute("CampignUrlName").Value);
                                }
                            }
                        }
                    }
                }
            }
            if (platform.ToLower().Replace(" ", "") == "webkit")
            {
                nugetPackagelist.Add("aspnetcore", new List<string>());
                xmlPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), @"..\..\..\NuGetPublish\NuGetPublishDetails.xml");
                XDocument document = XDocument.Load(xmlPath);
                List<XElement> ProjectConfigurations = document.Elements("Platforms").ToList();
                List<XElement> PlatformList = ProjectConfigurations.Elements("Platform").ToList();
                foreach (XElement platformNode in PlatformList)
                {
                    if (platformNode.Attribute("Name").Value.ToLower() == "webkit-core")
                    {
                        List<XElement> portablePackageList = platformNode.Elements("Packages").ElementAt(0).Elements("Package").ToList();
                        foreach (XElement portablePackage in portablePackageList)
                        {
                            if (portablePackage.Attribute("IsReadmeFilePresent") != null)
                            {
                                if (portablePackage.Attribute("IsReadmeFilePresent").Value.ToLower() == "true")
                                {
                                    nugetPackagelist["aspnetcore"].Add(portablePackage.Attribute("Name").Value + "," + portablePackage.Attribute("CampignUrlName").Value);
                                }
                            }
                        }
                    }
                }
            }
            if (platform.ToLower().Replace(" ", "") == "xamarin")
            {
                nugetPackagelist.Add("xamarin", new List<string>());
                nugetPackagelist.Add("xamarin-android", new List<string>());
                nugetPackagelist.Add("xamarin-ios", new List<string>());
                nugetPackagelist.Add("xamarin-wpf", new List<string>());
                xmlPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), @"..\..\..\Xamarin\XAMARIN.xml");
                XDocument document = XDocument.Load(xmlPath);
                List<XElement> ProjectConfigurations = document.Elements("Xamarin").ToList();
                List<XElement> PlatformList = ProjectConfigurations.Elements("Platform").ToList();
                foreach (XElement platformNode in PlatformList)
                {
                    if (platformNode.Attribute("Name").Value == "XForms")
                    {
                        List<XElement> PackageList = platformNode.Elements("Project").ToList();
                        foreach (XElement Package in PackageList)
                        {
                            if (Package.Attribute("IsReadmeFilePresent") != null)
                            {
                                if (Package.Attribute("IsReadmeFilePresent").Value.ToLower() == "true")
                                {
                                    nugetPackagelist["xamarin"].Add("Syncfusion.Xamarin." + Package.Attribute("Name").Value + "," + Package.Attribute("CampignUrlName").Value);
                                }
                            }
                        }
                    }
                    if (platformNode.Attribute("Name").Value == "Android")
                    {
                        List<XElement> PackageList = platformNode.Elements("Project").ToList();
                        foreach (XElement Package in PackageList)
                        {
                            if (Package.Attribute("IsReadmeFilePresent") != null)
                            {
                                if (Package.Attribute("IsReadmeFilePresent").Value.ToLower() == "true")
                                {
                                    nugetPackagelist["xamarin-android"].Add("Syncfusion.Xamarin." + Package.Attribute("Name").Value + ".Android," + Package.Attribute("CampignUrlName").Value);
                                }
                            }
                        }
                    }
                    if (platformNode.Attribute("Name").Value == "IOS-unified")
                    {
                        List<XElement> PackageList = platformNode.Elements("Project").ToList();
                        foreach (XElement Package in PackageList)
                        {
                            if (Package.Attribute("IsReadmeFilePresent") != null)
                            {
                                if (Package.Attribute("IsReadmeFilePresent").Value.ToLower() == "true")
                                {
                                    nugetPackagelist["xamarin-ios"].Add("Syncfusion.Xamarin." + Package.Attribute("Name").Value + ".IOS," + Package.Attribute("CampignUrlName").Value);
                                }
                            }
                        }
                    }
                    if (platformNode.Attribute("Name").Value == "WPF")
                    {
                        List<XElement> PackageList = platformNode.Elements("Project").ToList();
                        foreach (XElement Package in PackageList)
                        {
                            if (Package.Attribute("IsReadmeFilePresent") != null)
                            {
                                if (Package.Attribute("IsReadmeFilePresent").Value.ToLower() == "true")
                                {
                                    nugetPackagelist["xamarin-wpf"].Add("Syncfusion.Xamarin." + Package.Attribute("Name").Value + ".WPF," + Package.Attribute("CampignUrlName").Value);
                                }
                            }
                        }
                    }
                }
            }
            if (platform.ToLower().Replace(" ", "") == "uap10.0")
            {
                nugetPackagelist.Add("uwp", new List<string>());
                xmlPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), @"..\..\..\GenerationAutomation\NuGet-Package.xml");
                XDocument document = XDocument.Load(xmlPath);
                List<XElement> ProjectConfigurations = document.Elements("Platforms").ToList();
                List<XElement> PlatformList = ProjectConfigurations.Elements("Platform").ToList();
                foreach (XElement platformNode in PlatformList)
                {
                    if (platformNode.Attribute("Name").Value == "uap10.0")
                    {
                        List<XElement> uwpPackageList = platformNode.Elements("Packages").ElementAt(0).Elements("Package").ToList();
                        foreach (XElement uwpPackage in uwpPackageList)
                        {
                            if (uwpPackage.Attribute("IsReadmeFilePresent") != null)
                            {
                                if (uwpPackage.Attribute("IsReadmeFilePresent").Value.ToLower() == "true")
                                {
                                    nugetPackagelist["uwp"].Add(uwpPackage.Attribute("Name").Value + "," + uwpPackage.Attribute("CampignUrlName").Value);
                                }
                            }
                        }
                    }
                }
            }
            if (platform.ToLower().Replace(" ", "") == "wpf")
            {
                nugetPackagelist.Add("wpf", new List<string>());
                xmlPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), @"..\..\..\GenerationAutomation\NuGet-Package.xml");
                XDocument document = XDocument.Load(xmlPath);
                List<XElement> ProjectConfigurations = document.Elements("Platforms").ToList();
                List<XElement> PlatformList = ProjectConfigurations.Elements("Platform").ToList();
                foreach (XElement platformNode in PlatformList)
                {
                    if (platformNode.Attribute("Name").Value == "WPF")
                    {
                        List<XElement> wpfPackageList = platformNode.Elements("Packages").ElementAt(0).Elements("Package").ToList();
                        foreach (XElement wpfPackage in wpfPackageList)
                        {
                            if (wpfPackage.Attribute("IsReadmeFilePresent") != null)
                            {
                                if (wpfPackage.Attribute("IsReadmeFilePresent").Value.ToLower() == "true")
                                {
                                    nugetPackagelist["wpf"].Add(wpfPackage.Attribute("Name").Value + "," + wpfPackage.Attribute("CampignUrlName").Value);
                                }
                            }
                        }
                    }
                }
            }
            if (platform.ToLower().Replace(" ", "") == "windows")
            {
                nugetPackagelist.Add("winforms", new List<string>());
                xmlPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), @"..\..\..\GenerationAutomation\NuGet-Package.xml");
                XDocument document = XDocument.Load(xmlPath);
                List<XElement> ProjectConfigurations = document.Elements("Platforms").ToList();
                List<XElement> PlatformList = ProjectConfigurations.Elements("Platform").ToList();
                foreach (XElement platformNode in PlatformList)
                {
                    if (platformNode.Attribute("Name").Value == "Windows")
                    {
                        List<XElement> windowsPackageList = platformNode.Elements("Packages").ElementAt(0).Elements("Package").ToList();
                        foreach (XElement windowsPackage in windowsPackageList)
                        {
                            if (windowsPackage.Attribute("IsReadmeFilePresent") != null)
                            {
                                if (windowsPackage.Attribute("IsReadmeFilePresent").Value.ToLower() == "true")
                                {
                                    nugetPackagelist["winforms"].Add(windowsPackage.Attribute("Name").Value + "," + windowsPackage.Attribute("CampignUrlName").Value);
                                }
                            }
                        }
                    }
                }
            }
            if (platform.ToLower().Replace(" ", "") == "winui")
            {
                nugetPackagelist.Add("winui", new List<string>());
                xmlPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), @"..\..\..\GenerationAutomation\NuGet-Package.xml");
                XDocument document = XDocument.Load(xmlPath);
                List<XElement> ProjectConfigurations = document.Elements("Platforms").ToList();
                List<XElement> PlatformList = ProjectConfigurations.Elements("Platform").ToList();
                foreach (XElement platformNode in PlatformList)
                {
                    if (platformNode.Attribute("Name").Value == "WinUI")
                    {
                        List<XElement> winuiPackageList = platformNode.Elements("Packages").ElementAt(0).Elements("Package").ToList();
                        foreach (XElement winuiPackage in winuiPackageList)
                        {
                            if (winuiPackage.Attribute("IsReadmeFilePresent") != null)
                            {
                                if (winuiPackage.Attribute("IsReadmeFilePresent").Value.ToLower() == "true")
                                {
                                    nugetPackagelist["winui"].Add(winuiPackage.Attribute("Name").Value + "," + winuiPackage.Attribute("CampignUrlName").Value);
                                }
                            }
                        }
                    }
                }
            }
            if (platform.ToLower().Replace(" ", "") == "maui")
            {
                nugetPackagelist.Add("maui", new List<string>());
                xmlPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), @"..\..\..\NuGetPublish\NuGetPublishDetails.xml");
                XDocument document = XDocument.Load(xmlPath);
                List<XElement> ProjectConfigurations = document.Elements("Platforms").ToList();
                List<XElement> PlatformList = ProjectConfigurations.Elements("Platform").ToList();
                foreach (XElement platformNode in PlatformList)
                {
                    if (platformNode.Attribute("Name").Value == "Maui")
                    {
                        List<XElement> mauiPackageList = platformNode.Elements("Packages").ElementAt(0).Elements("Package").ToList();
                        foreach (XElement mauiPackage in mauiPackageList)
                        {
                            if (mauiPackage.Attribute("IsReadmeFilePresent") != null)
                            {
                                if (mauiPackage.Attribute("IsReadmeFilePresent").Value.ToLower() == "true")
                                {
                                    nugetPackagelist["maui"].Add(mauiPackage.Attribute("Name").Value + "," + mauiPackage.Attribute("CampignUrlName").Value);
                                }
                            }
                        }
                    }
                }
            }
            if (Directory.Exists(args[1] + "\\MdFiles\\"))
            {
                Directory.Delete(args[1] + "\\MdFiles\\", true);
            }
            foreach (var keyValuePair in nugetPackagelist)
            {
                string nugetKey = keyValuePair.Key;
                foreach (var packages in keyValuePair.Value)
                {
                    System.IO.Compression.ZipFile.ExtractToDirectory(args[1] + "\\" + packages.Split(',')[0] + "." + version+".nupkg", args[1] + "\\MdFiles\\" + packages.Split(',')[0] + "\\");
                    packageName = packages.Split(',')[0];
                    mismatchUrl = string.Empty;
                    mismatchReleaseNotes = string.Empty;
                    if (File.Exists(args[1] + "\\MdFiles\\" + packages.Split(',')[0] + "\\README.md"))
                    {
                        readmeContent = File.ReadAllText(args[1] + "\\MdFiles\\" + packages.Split(',')[0] + "\\README.md");
                        Regex pattern = new Regex(@"\(https://(.*?)\)");
                        MatchCollection matchCollection = pattern.Matches(readmeContent);
                        foreach (Match match in matchCollection)
                        {

                            if (!match.Value.Contains("utm_source=nuget&utm_medium=listing&utm_campaign="+ nugetKey + "-"+ packages.Split(',')[1]+"-nuget") && !match.Value.Contains(".png")&& !match.Value.Contains(".PNG") && match.Value.Contains("syncfusion") && match.Value.Contains("Syncfusion"))
                            {
                                mismatchUrl = mismatchUrl + "<br>" + match.Value.Replace("(", "").Replace(")", "");
                            }

                            if (match.Value.Contains("release-notes"))
                            {
                                if (!match.Value.Contains(version.Split('.')[0] + "." + version.Split('.')[1] + "." + version.Split('.')[3]) && !match.Value.Contains(version.Split('.')[0] + "." + version.Split('.')[1] + "." + version.Split('.')[2]+ "." + version.Split('.')[3]))
                                {
                                    mismatchReleaseNotes = mismatchReleaseNotes + "<br>" + match.Value.Replace("(", "").Replace(")", "");
                                }
                            }
                        }
                        replaceContent = @"<tr>
			<td>" + packageName + @"</td>
			<td>" + mismatchUrl + @"</td>
		</tr>
          ##Data##";
                        replaceReleaseNotesContent = @"<tr>
			<td>" + packageName + @"</td>
			<td>" + mismatchReleaseNotes + @"</td>
		</tr>
          ##ReleaseNotes##";
                        if (!string.IsNullOrEmpty(mismatchUrl))
                        {
                            failureEmailContent = failureEmailContent.Replace("##Data##", replaceContent);
                        }
                        if (!string.IsNullOrEmpty(mismatchReleaseNotes))
                        {
                            failureEmailContent = failureEmailContent.Replace("##ReleaseNotes##", replaceReleaseNotesContent);
                        }
                        if (!string.IsNullOrEmpty(mismatchUrl) || !string.IsNullOrEmpty(mismatchReleaseNotes))
                        {
                            isToolStop = true;
                        }
                    }
                    else
                    {
                        replaceReadmeFileNorExist = @"<tr>
			<td>" + packageName + @"</td>
		</tr>
          ##ReadMeNotExistPackages##";
                        failureEmailContent = failureEmailContent.Replace("##ReadMeNotExistPackages##", replaceReadmeFileNorExist);
                        isToolStop = true;
                    }
                }
            }
            failureEmailContent = failureEmailContent.Replace("##Data##", "").Replace("##ReleaseNotes##", "").Replace("##ReadMeNotExistPackages##", "");
            if (isToolStop)
            {
                emailContent = failureEmailContent;
                File.WriteAllText(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\EmailFormats\\CompleteMail_FailureEdited.htm", emailContent);
            }
            else
            {
                emailContent = successEmailContent;
            }
            if (CheckForInternetConnection())
            {
                MailMessage message = new MailMessage();
                foreach (string mailId in emailId.Split(','))
                {
                    message.To.Add(mailId);
                }
                if (isToolStop)
                {
                    message.Subject = platform+" Readme Validation Report - Failed";
                }
                else
                {
                    message.Subject = platform + " Readme Validation Report - Success";
                }
                message.From = new System.Net.Mail.MailAddress("buildautomation@syncfusion.com");
                message.Body = emailContent;
                message.IsBodyHtml = true;
                //now attached the file


                SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.office365.com", 587);
                smtp.Credentials = new System.Net.NetworkCredential("buildautomation@syncfusion.com", "kmtsvprrgjtyytpb");
                smtp.EnableSsl = true;

                smtp.Send(message);
            }
            else
                Console.WriteLine("Internet connection not available. So mail is not sent to the recipients");

            if (isToolStop)
            {
                Environment.Exit(1);
            }

        }
        /// <summary>
        /// Check Internet connectivity
        /// </summary>
        /// <returns></returns>
        private static bool CheckForInternetConnection()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.google.com");
                request.Timeout = 5000;
                request.Credentials = CredentialCache.DefaultNetworkCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK) return true;
                else return false;
            }
            catch
            {
                return false;
            }
        }

    }
}
