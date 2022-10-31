### Syncfusion WPF HTML to PDF converter

The Syncfusion Essential [WPF HTML to PDF converter](https://www.syncfusion.com/pdf-framework/net/html-to-pdf?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget) is a .NET library that converts URLs, HTML string to PDF in any WPF application. This converter uses IE rendering engine.

![WPF HTML to PDF converter](https://cdn.syncfusion.com/nuget-readme/fileformats/net-html-to-pdf.png)

[Features overview](https://www.syncfusion.com/pdf-framework/net/html-to-pdf?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget) | [Docs](https://help.syncfusion.com/file-formats/pdf/converting-html-to-pdf?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget) | [API Reference](https://help.syncfusion.com/cr/file-formats/Syncfusion.Pdf.HtmlToPdf.html?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget) | [Blogs](https://www.syncfusion.com/blogs/?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget&s=html+to+pdf) | [Support](https://support.syncfusion.com/support/tickets/create?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget) | [Forums](https://www.syncfusion.com/forums?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget) | [Feedback](https://www.syncfusion.com/feedback/wpf?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget)

### Key Features

* Converts any [webpage to PDF](https://help.syncfusion.com/file-formats/pdf/convert-html-to-pdf/ie#converting-the-url-to-a-pdf-document?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget).
* Converts any raw [HTML string to PDF.](https://help.syncfusion.com/file-formats/pdf/convert-html-to-pdf/ie#converting-the-html-string-to-pdf-document?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget)
* Prevents text and image split across pages.
* Converts HTML form to fillable PDF form.
* Works both in 32-bit and 64-bit environments.
* Supports header and footer.
* Converts any HTML to image.
* Converts any SVG to image.
* Supports [Windows authentication.](https://help.syncfusion.com/file-formats/pdf/convert-html-to-pdf/ie#converting-windows-authenticated-web-page-to-pdf-document?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget)
* Thread safe.
* Supports internal and external hyperlinks.
* Sets document properties, page settings, security, viewer preferences, etc.
* Protects PDF document with password and permission.

### System Requirements

* [System Requirements](https://help.syncfusion.com/file-formats/installation-and-upgrade/system-requirements?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget).

### Getting Started

Install the [Syncfusion.HtmlToPdfConverter.IE.Wpf](https://www.nuget.org/packages/Syncfusion.HtmlToPdfConverter.IE.Wpf?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget) NuGet package as reference to your WPF application from [NuGet.org](https://www.nuget.org/)

### Convert HTML to PDF document programmatically using C#

```csharp
static void Main(string[] args)
{
    Thread t = new Thread(Convert);
    t.SetApartmentState(ApartmentState.STA);
    t.Start();
    t.Join();
}
public static void Convert()
{
    //Initialize HTML to PDF converter 

    HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.IE);
	
	//Convert HTML to PDF document 

    PdfDocument document = htmlConverter.Convert("https://www.google.com");

    //Save and close the PDF document 

    document.Save("Output.pdf");

    document.Close(true);
}
```

### License
 
This is a commercial product and requires a paid license for possession or use. Syncfusion’s licensed software, including this component, is subject to the terms and conditions of [Syncfusion's EULA](https://www.syncfusion.com/eula/es/?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget). You can purchase a license [here](https://www.syncfusion.com/sales/products?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget) or start a free 30-day trial [here](https://www.syncfusion.com/account/manage-trials/start-trials?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget).

### About Syncfusion

Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 27,000+ customers and more than 1 million users, including large financial institutions, Fortune 500 companies, and global IT consultancies.
 
Today, we provide 1700+ components and frameworks for web ([Blazor](https://www.syncfusion.com/blazor-components?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget), [ASP.NET Core](https://www.syncfusion.com/aspnet-core-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget), [ASP.NET MVC](https://www.syncfusion.com/aspnet-mvc-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget), [ASP.NET Web Forms](https://www.syncfusion.com/jquery/aspnet-webforms-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget), [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget), [Angular](https://www.syncfusion.com/angular-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget), [React](https://www.syncfusion.com/react-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget), [Vue](https://www.syncfusion.com/vue-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget), and [jQuery](https://www.syncfusion.com/jquery-ui-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget)), mobile ([.NET MAUI (Preview)](https://www.syncfusion.com/maui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget), [Xamarin](https://www.syncfusion.com/xamarin-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget), [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget), and [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget)), and desktop development ([WinForms](https://www.syncfusion.com/winforms-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget), [WPF](https://www.syncfusion.com/wpf-controls?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget), [WinUI](https://www.syncfusion.com/winui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget), [.NET MAUI (Preview)](https://www.syncfusion.com/maui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget), [Xamarin](https://www.syncfusion.com/xamarin-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget), and [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget)). We provide ready-to-deploy enterprise software for dashboards, reports, data integration, and big data processing. Many customers have saved millions in licensing fees by deploying our software.

[sales@syncfusion.com](mailto:sales@syncfusion.com?Subject=Syncfusion%20HTMLConverter%20-%20NuGet) | [www.syncfusion.com](https://www.syncfusion.com?utm_source=nuget&utm_medium=listing&utm_campaign=wpf-htmltopdfconverter-nuget) | Toll Free: 1-888-9 DOTNET
