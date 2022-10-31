using System;
using EvalKeyGen;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SyncfusionLicenseKeyGenerator
{
    class SyncfusionLicenseGenerate
    {
        static void Main(string[] args)
        {
            List<string> productList = new List<string>();
            string[] allProducts = new string[] { "aspnet", "aspnetsrc", "aspnetmvc", "aspnetmvcsrc", "silverlight", "silverlightsrc", "windowsforms", "windowsformsrc", "windowsappsplatform", "windowsappsplatformssrc", "wpf", "wpfsrc", "javascript", "javascriptsrc", "lightswith", "fileformats", "fileformatssrc", "maui", "mauisrc", "lightswitchsrc", "android", "androidsrc", "reportplatform", "dashboardplatform", "dashboardplatformsdk", "reportplatformsdk", "aspnetcore", "aspnetcoresrc", "php", "phpsrc", "jsp", "jspsrc", "flutter", "fluttersrc", "blazor", "blazorsrc", "winui", "winuisrc" };
            string version = args[0];
            XDocument licenseKeyXmldocument = XDocument.Load("../LicenseKeyValidation/LicenseKey.xml");
            List<XElement> PlatformsDetails = licenseKeyXmldocument.Elements("Platforms").ToList();
            List<XElement> PlatformDetails = PlatformsDetails.Elements("Platform").ToList();
            KeyGenerator keyGenerator = new KeyGenerator(GetVersionDetails(version), allProducts);
            Controller.studioVersion = GetVersionDetails(version);
            string licenseXMLfileContents = File.ReadAllText("../LicenseKeyValidation/LicenseKey.xml");
            foreach(var platform in PlatformDetails)
            {
                if (platform.Attribute("Name").Value == "UWP")
                    productList.Add("windowsappsplatform");
                else if(platform.Attribute("Name").Value == "Winforms")
                    productList.Add("windowsforms");
                else if (platform.Attribute("Name").Value == "Fileformat")
                    productList.Add("fileformats");
                else if (platform.Attribute("Name").Value == "Xamarin")
                    productList.Add("maui");
                else
                    productList.Add(platform.Attribute("Name").Value.ToLower());

                string[] products = productList.ToArray();
                string unlockKey = keyGenerator.GetKey("vadiveln@syncfsuion.com", products);
                string licenseKey = Base64Encode("001" + unlockKey);
                licenseXMLfileContents = licenseXMLfileContents.Replace(platform.Attribute("Key").Value, licenseKey);

                if (platform.Attribute("Name").Value == "UWP")
                    productList.Remove("windowsappsplatform");
                else if (platform.Attribute("Name").Value == "Winforms")
                    productList.Remove("windowsforms");
                else if (platform.Attribute("Name").Value == "Fileformat")
                    productList.Remove("fileformats");
                else if (platform.Attribute("Name").Value == "Xamarin")
                    productList.Remove("maui");
                else
                    productList.Remove(platform.Attribute("Name").Value.ToLower());
            }
            File.WriteAllText("../LicenseKeyValidation/LicenseKey.xml", licenseXMLfileContents);
        }

        /// <summary>
        /// Method to get the Version Details
        /// </summary>
        /// <param name="studioVersion"></param>
        /// <returns></returns>
        public static Version GetVersionDetails(string studioVersion)
        {
            Version version = new Version(studioVersion);

            if (version.Build == -1)
                version = new Version(version.Major, version.Minor, 0);

            if (version.Revision == -1)
                version = new Version(version.Major, version.Minor, version.Build, 0);

            return version;
        }

        /// <summary>
        /// Encode the key with UTF8.
        /// </summary>
        /// <param name="plainText">combined Project key and application id</param>
        /// <returns></returns>
        private static string Base64Encode(string projectKey)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(projectKey));
        }
    }
}
