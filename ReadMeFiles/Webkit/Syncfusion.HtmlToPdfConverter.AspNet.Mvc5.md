### Syncfusion .NET HTML to PDF converter

The Syncfusion [HTML to PDF converter](https://www.syncfusion.com/pdf-framework/net/html-to-pdf?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget) is a .NET Framework library that converts URLs, HTML string, SVG, MHTML to PDF in ASP.NET MVC application. This converter uses the advanced Blink rendering engine, thus generating pixel-perfect PDF from HTML or URL.

> #### Starting with v20.1.0.x, if you reference Syncfusion HTML converter assemblies from trial setup or from the NuGet feed, include a license key in your projects. Refer to [link](https://help.syncfusion.com/file-formats/licensing/licensing?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget) to learn about generating and registering Syncfusion license key in your application to use the components without trail message.

![NET HTML to PDF converter](https://cdn.syncfusion.com/nuget-readme/fileformats/net-html-to-pdf.png)

[Features overview](https://www.syncfusion.com/pdf-framework/net/html-to-pdf?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget) | [Docs](https://help.syncfusion.com/file-formats/pdf/converting-html-to-pdf?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget) | [API Reference](https://help.syncfusion.com/cr/file-formats/Syncfusion.Pdf.HtmlToPdf.html?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget) | [Online Demo](https://ej2.syncfusion.com/aspnetmvc/PDF/HtmltoPDF?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget#/bootstrap5) | [Blogs](https://www.syncfusion.com/blogs/?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget&s=html+to+pdf) | [Support](https://support.syncfusion.com/support/tickets/create?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget) | [Forums](https://www.syncfusion.com/forums?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget) | [Feedback](https://www.syncfusion.com/feedback/wpf?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget)

### Key Features

* Converts any [webpage to PDF.](https://help.syncfusion.com/file-formats/pdf/convert-html-to-pdf/blink#url-to-pdf?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget)
* Converts any raw [HTML string to PDF.](https://help.syncfusion.com/file-formats/pdf/convert-html-to-pdf/blink#html-string-to-pdf?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget)
* Prevents text and image split across pages.
* Converts [HTML form to fillable PDF form](https://help.syncfusion.com/file-formats/pdf/convert-html-to-pdf/blink#html-form-to-pdf-form?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget).
* Works both in 32-bit and 64-bit environments.
* Automatically [creates Table of Contents](https://help.syncfusion.com/file-formats/pdf/convert-html-to-pdf/blink#table-of-contents?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget).
* Automatically creates [bookmark hierarchy](https://help.syncfusion.com/file-formats/pdf/convert-html-to-pdf/blink#table-of-contents?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget).
* Converts only a [part of the web page to PDF](https://help.syncfusion.com/file-formats/pdf/convert-html-to-pdf/blink#partial-webpage-to-pdf?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget).
* Supports header and footer.
* Repeats HTML table header and footer in PDF.
* Supports HTML5, CSS3, SVG, and Web fonts.
* Converts any HTML to SVG.
* Converts any [HTML to image](https://help.syncfusion.com/file-formats/pdf/convert-html-to-pdf/blink#url-to-image?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget).
* Converts any SVG to image.
* Supports accessing HTML page using both HTTP POST and GET methods.
* Supports HTTP cookies.
* Supports cookies-based [form authentication](https://help.syncfusion.com/file-formats/pdf/convert-html-to-pdf/blink#form-authentication?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget).
* Thread safe.
* Supports internal and external hyperlinks.
* Sets document properties, page settings, security, viewer preferences, etc.
* Protects PDF document with password and permission.

### System Requirements

* [System Requirements](https://help.syncfusion.com/file-formats/installation-and-upgrade/system-requirements?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget)

### Getting Started

Install the [Syncfusion.HtmlToPdfConverter.AspNet.Mvc5](https://www.nuget.org/packages/Syncfusion.HtmlToPdfConverter.AspNet.Mvc5/?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget) NuGet package as reference to your ASP.NET MVC application from [NuGet.org](https://www.nuget.org/).

### Convert HTML to PDF document programmatically using C#

```csharp
//Initialize the HTML to PDF converter.
HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter();
//Convert URL to PDF.
PdfDocument document = htmlConverter.Convert("https://www.syncfusion.com");
//Save and close the PDF document. 
document.Save("Output.pdf");
 //Close the document
document.Close(true);
```

### License

This NuGet package includes code from the Chromium Project. This code is subject to the terms of the Chromium Project license available [here](https://chromium.googlesource.com/chromium/src/+/HEAD/LICENSE). Syncfusion does not provide any warranty or any indemnity with regard to the use of code from the Chromium Project. If you do not agree to these terms, please do not install, or use this NuGet package. 

### About Syncfusion

Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 27,000+ customers and more than 1 million users, including large financial institutions, Fortune 500 companies, and global IT consultancies.
 
Today, we provide 1700+ components and frameworks for web ([Blazor](https://www.syncfusion.com/blazor-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [ASP.NET Core](https://www.syncfusion.com/aspnet-core-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [ASP.NET MVC](https://www.syncfusion.com/aspnet-mvc-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [ASP.NET Web Forms](https://www.syncfusion.com/jquery/aspnet-webforms-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [Angular](https://www.syncfusion.com/angular-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [React](https://www.syncfusion.com/react-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [Vue](https://www.syncfusion.com/vue-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), and [jQuery](https://www.syncfusion.com/jquery-ui-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget)), mobile ([.NET MAUI (Preview)](https://www.syncfusion.com/maui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [Xamarin](https://www.syncfusion.com/xamarin-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), and [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget)), and desktop development ([WinForms](https://www.syncfusion.com/winforms-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [WPF](https://www.syncfusion.com/wpf-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [WinUI](https://www.syncfusion.com/winui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [.NET MAUI (Preview)](https://www.syncfusion.com/maui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), [Xamarin](https://www.syncfusion.com/xamarin-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget), and [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget)). We provide ready-to-deploy enterprise software for dashboards, reports, data integration, and big data processing. Many customers have saved millions in licensing fees by deploying our software.

[sales@syncfusion.com](mailto:sales@syncfusion.com?Subject=Syncfusion%20HTMLConverter%20-%20NuGet) | [www.syncfusion.com](https://www.syncfusion.com?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-htmltopdfconverter-nuget) | Toll Free: 1-888-9 DOTNET