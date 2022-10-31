using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Licensing;

namespace SyncfusionLicenseKeyValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                string _platform = args[0];
                string _licensekey = args[1];

                Platform platform;
                switch (_platform)
                {
                    case "AspNet": platform = Platform.ASPNET; break;
                    case "AspNetMvc": platform = Platform.ASPNETMVC; break;
                    case "AspNetCore": platform = Platform.ASPNETCore; break;
                    case "Blazor": platform = Platform.Blazor; break;
                    case "WPF": platform = Platform.WPF; break;
                    case "Winforms": platform = Platform.WindowsForms; break;
                    case "UWP": platform = Platform.UWP; break;
                    case "Xamarin": platform = Platform.Xamarin; break;
                    case "Fileformat": platform = Platform.FileFormats; break;
                    default: platform = Platform.Utility; break;
                }
                if (Platform.Utility != platform)
                {
                    SyncfusionLicenseProvider.RegisterLicense(_licensekey);
                    string licenseMessage = SyncfusionLicenseProvider.GetLicenseType(platform);
                    if (licenseMessage != null)
                    {
                        Console.WriteLine(licenseMessage);
                        Environment.Exit(1);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid arguments");
                Environment.Exit(1);
            }
        }
    }
}
