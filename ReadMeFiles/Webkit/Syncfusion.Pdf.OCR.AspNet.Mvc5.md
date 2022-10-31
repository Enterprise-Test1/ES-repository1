### Syncfusion .NET OCR Library

The Syncfusion [.NET Framework OCR library](https://help.syncfusion.com/file-formats/pdf/working-with-ocr/dot-net-framework?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget) is a feature-rich and high-performance library that is used to recognizes characters from both images and PDF. Syncfusion OCRProcessor uses tesseract, one of most accurate OCR engines.

![NET OCR Library](https://cdn.syncfusion.com/nuget-readme/fileformats/net-pdf-ocr-processing.png)

[Features overview](https://help.syncfusion.com/file-formats/pdf/working-with-ocr/dot-net-framework?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget) | [Docs](https://help.syncfusion.com/file-formats/pdf/working-with-ocr?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget) | [API Reference](https://help.syncfusion.com/cr/file-formats/Syncfusion.OCRProcessor.html?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget) | [Blogs](https://www.syncfusion.com/blogs/?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget&s=ocr) | [support](https://support.syncfusion.com/support/tickets/create?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget) | [Forums](https://www.syncfusion.com/forums?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget) | [Feedback](https://www.syncfusion.com/feedback/wpf?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget)

### Key Features

* Converts [scanned PDF to searchable PDF](https://help.syncfusion.com/file-formats/pdf/working-with-ocr/dot-net-framework?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget#performing-ocr-for-an-entire-document).
* Converts various image formats such as [TIFF, JPEG, PNG, BMP to searchable PDF](https://help.syncfusion.com/file-formats/pdf/working-with-ocr/dot-net-framework?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget#performing-ocr-on-image).
* Converts image or PDF to text with location.
* [Process OCR for the specified region](https://help.syncfusion.com/file-formats/pdf/working-with-ocr/dot-net-framework?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget#performing-ocr-for-a-region-of-the-document) in both PDF and image.
* Supports 60+ languages.
* [Recognize text from rotated images](https://help.syncfusion.com/file-formats/pdf/working-with-ocr/dot-net-framework?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget#performing-ocr-on-rotated-page-of-pdf-document) and PDF documents.
* Works both in 32-bit and 64-bit environments.
* Thread safe.

### System Requirements

* [System Requirements](https://help.syncfusion.com/file-formats/installation-and-upgrade/system-requirements?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget)

### Getting Started

Install the [Syncfusion.Pdf.OCR.AspNet.Mvc5](https://www.nuget.org/packages/Syncfusion.PDF.OCR.AspNet.Mvc5/?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget) NuGet package as reference to your ASP.NET MVC application from [NuGet.org](https://www.nuget.org/).

### OCR a PDF document programmatically using C#

```csharp
//Initialize the OCR processor by providing the path of tesseract binaries(SyncfusionTesseract.dll and liblept168.dll)
using (OCRProcessor processor = new OCRProcessor(@"TesseractBinaries\"))
{

//Load a PDF document
PdfLoadedDocument lDoc = new PdfLoadedDocument("Input.pdf");

//Set OCR language to process
processor.Settings.Language = Languages.English;

//Process OCR by providing the PDF document and Tesseract data
processor.PerformOCR(lDoc, @"TessData\");

//Save the OCR processed PDF document in the disk
lDoc.Save("Sample.pdf");
lDoc.Close(true);

}
```

### License

This NuGet package is a part of the [OPX](https://www.syncfusion.com/products/opx?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget) product line. Any part of the OPX product line may be subject to additional terms, to include GPL or similar licenses. Syncfusion holds no liability and provides no indemnity in any form for any OPX product. If you do not agree to these terms, do not download this NuGet package. 

### About Syncfusion

Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 27,000+ customers and more than 1 million users, including large financial institutions, Fortune 500 companies, and global IT consultancies.
 
Today, we provide 1700+ components and frameworks for web ([Blazor](https://www.syncfusion.com/blazor-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget), [ASP.NET Core](https://www.syncfusion.com/aspnet-core-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget), [ASP.NET MVC](https://www.syncfusion.com/aspnet-mvc-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget), [ASP.NET Web Forms](https://www.syncfusion.com/jquery/aspnet-webforms-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget), [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget), [Angular](https://www.syncfusion.com/angular-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget), [React](https://www.syncfusion.com/react-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget), [Vue](https://www.syncfusion.com/vue-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget), and [jQuery](https://www.syncfusion.com/jquery-ui-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget)), mobile ([.NET MAUI (Preview)](https://www.syncfusion.com/maui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget), [Xamarin](https://www.syncfusion.com/xamarin-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget), [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget), and [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget)), and desktop development ([WinForms](https://www.syncfusion.com/winforms-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget), [WPF](https://www.syncfusion.com/wpf-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget), [WinUI](https://www.syncfusion.com/winui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget), [.NET MAUI (Preview)](https://www.syncfusion.com/maui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget), [Xamarin](https://www.syncfusion.com/xamarin-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget), and [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget)). We provide ready-to-deploy enterprise software for dashboards, reports, data integration, and big data processing. Many customers have saved millions in licensing fees by deploying our software.

[sales@syncfusion.com](mailto:sales@syncfusion.com?Subject=Syncfusion%20OCRProcessor%20-%20NuGet) | [www.syncfusion.com](https://www.syncfusion.com?utm_source=nuget&utm_medium=listing&utm_campaign=aspnetmvc-ocrprocessor-nuget) | Toll Free: 1-888-9 DOTNET
