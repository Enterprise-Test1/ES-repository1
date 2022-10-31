using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace SyncfusionNuGetManager
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variable Declaration

            NuGetConfig nugetConfigEntry = args[0].ToLower().Equals("add")? NuGetConfig.Add : args[0].ToLower().Equals("remove") ? NuGetConfig.Remove : NuGetConfig.InCorrectCommand;
            string[] packageNames = args[1].Split(',');
            string packageSource = nugetConfigEntry.Equals(NuGetConfig.Add) ? args[2] : string.Empty;
            string nuGetConfigFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NuGet\\NuGet.Config";

            #endregion

            if (nugetConfigEntry.Equals(NuGetConfig.InCorrectCommand))
            {
                Console.WriteLine("Argument is not Valid");
            }

            else
            {
                if (File.Exists(nuGetConfigFilePath))
                {
                    XDocument xdoc = XDocument.Load(nuGetConfigFilePath);

                    foreach (string packageName in packageNames)
                    {
                        try
                        {
                            List<XElement> tempElements = new List<XElement>();
                            foreach (XElement sourceElement in xdoc.Descendants("packageSources"))
                            {
                                bool isAlreadyPresented = false;
                                foreach (XElement tempAddElement in sourceElement.Descendants("add"))
                                {
                                    if (tempAddElement.Attribute("key").Value.ToLower().Equals("syncfusion_" + packageName.ToLower()))
                                    {
                                        isAlreadyPresented = true;
                                        break;
                                    }
                                }

                                if (nugetConfigEntry.Equals(NuGetConfig.Add) && !isAlreadyPresented)
                                    xdoc.Element("configuration").Element("packageSources").Add(new XElement("add"));

                                foreach (XElement addElement in sourceElement.Descendants("add"))
                                {
                                    //Node Update Logic
                                    if (nugetConfigEntry.Equals(NuGetConfig.Add) && isAlreadyPresented && addElement.Attribute("key").Value.ToLower().Equals("syncfusion_" + packageName.ToLower()))
                                    {
                                        addElement.SetAttributeValue("value", packageSource);
                                    }

                                    //Node Add Logic
                                    if (nugetConfigEntry.Equals(NuGetConfig.Add) && addElement.Attribute("key") == null)
                                    {
                                        addElement.SetAttributeValue("key", "Syncfusion_" + packageName);
                                        addElement.SetAttributeValue("value", packageSource);
                                    }

                                    //Deleting node adding in Temp
                                    if (nugetConfigEntry.Equals(NuGetConfig.Remove) &&
                                        addElement.Attribute("key").Value.ToLower().Equals("syncfusion_" + packageName.ToLower()))
                                    {
                                         tempElements.Add(addElement);
                                    }
                                }

                                //Node Remove Logic
                                if (nugetConfigEntry.Equals(NuGetConfig.Remove))
                                {
                                    foreach (XElement xele in tempElements)
                                    {
                                        sourceElement.Elements("add").Where(x => x.Attribute("key").Value.ToLower().Equals("syncfusion_" + packageName.ToLower())).Remove();
                                    }
                                }
                            }
                            xdoc.Save(nuGetConfigFilePath);
                        }
                        catch (Exception e){}
                    }
                }
            }
        }
    }

    public enum NuGetConfig
    {
        Add,
        Remove,
        InCorrectCommand
    }
}
