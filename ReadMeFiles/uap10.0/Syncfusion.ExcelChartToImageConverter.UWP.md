### Syncfusion UWP Excel Chart To Image Converter
The Syncfusion [UWP Excel Chart to Image Converter](https://www.syncfusion.com/excel-framework/net/excel-to-pdf-conversion?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget) is a .NET class library for converting Excel chart to image programatically without using Microsoft Office dependencies.

![UWP Excel Chart To Image Converter](https://cdn.syncfusion.com/nuget-readme/fileformats/net-excel-to-pdf.png)

[Features Overview](https://www.syncfusion.com/excel-framework/net/excel-to-pdf-conversion?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget) | [Docs](https://help.syncfusion.com/file-formats/xlsio/chart-to-image-conversion?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget) | [API Reference](https://help.syncfusion.com/cr/file-formats/Syncfusion.ExcelChartToImageConverter.html?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget) | [Online Demo](https://ej2.syncfusion.com/aspnetcore/XlsIO/ExcelToPDF#/bootstrap5?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget) | [GitHub Examples](https://github.com/SyncfusionExamples/XlsIO-Examples/tree/master/Chart%20to%20Image?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget) | [Blogs](https://www.syncfusion.com/blogs/?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget&s=excel) | [Support](https://support.syncfusion.com/create?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget) | [Forums](https://www.syncfusion.com/forums?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget) | [Feedback](https://www.syncfusion.com/feedback/winforms?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget)

### Key features
* Converts [Excel Chart into Image](https://help.syncfusion.com/file-formats/xlsio/chart-to-image-conversion?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget).
* Various [chart elements](https://help.syncfusion.com/file-formats/xlsio/chart-to-image-conversion#supported-chart-elements?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget) like axis, axis titles, chart title, data labels, gridlines, legend and trendline are supported in this conversion.
* About [35+ chart types](https://help.syncfusion.com/file-formats/xlsio/chart-to-image-conversion#supported-chart-types?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget) are supported in Chart to Image conversion. 

### System Requirements

* [System Requirements](https://help.syncfusion.com/file-formats/installation-and-upgrade/system-requirements?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget)

### Getting Started

You can fetch the Syncfusion UWP Excel Chart to Image converter library NuGet by simply running the command **Install-Package Syncfusion.ExcelChartToImageConverter.UWP** from the Package Manager Console in Visual Studio.

Try the following code snippet to convert an Excel Chart to Image.

```csharp
using Syncfusion.XlsIO;
using System.IO;
using System.Reflection;
using Syncfusion.ExcelChartToImageConverter;
//Initialize ExcelEngine.
using (ExcelEngine excelEngine = new ExcelEngine())
{
    //Initialize IApplication.
    IApplication application = excelEngine.Excel;
    //Set the default version as Xlsx.
    application.DefaultVersion = ExcelVersion.Xlsx;
    //Load an existing workbook into IWorkbook.
    Assembly assembly = typeof(App).GetTypeInfo().Assembly;
    //Gets input Excel document from an embedded resource collection
    Stream inputStream = assembly.GetManifestResourceStream("Sample.xlsx");
    IWorkbook workbook = application.Workbooks.Open(inputStream, ExcelOpenType.Automatic);
    //Get the worksheet into IWorksheet.
    IWorksheet worksheet = workbook.Worksheets[0];
    //Get the Excel chart into IChart
	IChart chart = worksheet.Charts[0];
    //Save the chart as image
    FileStream outputStream = new FileStream("Output.png", FileMode.Create, FileAccess.Write);
    chart.SaveAsImage(outputStream);
}
```

For more information to get started, refer to our [Getting Started Documentation page](https://help.syncfusion.com/file-formats/xlsio/getting-started-create-excel-file-csharp-vbnet?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget).

### License
This is a commercial product and requires a paid license for possession or use. Syncfusion’s licensed software, including this component, is subject to the terms and conditions of [Syncfusion's EULA](https://www.syncfusion.com/eula/es/?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget). You can purchase a license [here]( https://www.syncfusion.com/sales/products?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget) or start a free 30-day trial [here](https://www.syncfusion.com/account/manage-trials/start-trials?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget).

### About Syncfusion
Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 27,000+ customers and more than 1 million users, including large financial institutions, Fortune 500 companies, and global IT consultancies.
 
Today, we provide 1700+ components and frameworks for web ([Blazor](https://www.syncfusion.com/blazor-components?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget), [ASP.NET Core](https://www.syncfusion.com/aspnet-core-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget), [ASP.NET MVC](https://www.syncfusion.com/aspnet-mvc-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget), [ASP.NET Web Forms](https://www.syncfusion.com/jquery/aspnet-webforms-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget), [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget), [Angular](https://www.syncfusion.com/angular-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget), [React](https://www.syncfusion.com/react-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget), [Vue](https://www.syncfusion.com/vue-ui-components?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget), and [jQuery](https://www.syncfusion.com/jquery-ui-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget)), mobile ([.NET MAUI (Preview)](https://www.syncfusion.com/maui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget), [Xamarin](https://www.syncfusion.com/xamarin-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget), [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget), and [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget)), and desktop development ([WinForms](https://www.syncfusion.com/winforms-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget), [WPF](https://www.syncfusion.com/wpf-controls?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget), [WinUI](https://www.syncfusion.com/winui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget), [.NET MAUI (Preview)](https://www.syncfusion.com/maui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget), [Xamarin](https://www.syncfusion.com/xamarin-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget), and [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget)). We provide ready-to-deploy enterprise software for dashboards, reports, data integration, and big data processing. Many customers have saved millions in licensing fees by deploying our software.
___

[sales@syncfusion.com](mailto:sales@syncfusion.com?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget) | [www.syncfusion.com](https://www.syncfusion.com?utm_source=nuget&utm_medium=listing&utm_campaign=uwp-excelcharttoimageconverter-nuget) | Toll Free: 1-888-9 DOTNET