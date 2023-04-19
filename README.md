# IronPDF "Hello World" Example in C#

## IronPDF Features and Compatiblity

IronPDF easily handles all these features:
- Generating PDFs from: HTML, URL, JavaScript, CSS and many image formats
- Adding headers/footers, signatures, attachments, compression, and passwords and security
- Performance optimization: Full Multihreading and Async support
- And many more! Visit our website to see all our code examples and a full list of our 50+ features

IronPDF also has cross platform support compatibility with:
- .NET 7 and .NET 6, .NET Core, Standard, and Framework (4.6.2+)
- Windows, macOS, Linux, Docker, Azure, and AWS

## Code Example

```csharp
using IronPdf;
using IronPdf.Engines.Chrome;
using IronPdf.Rendering;
 
// Example of HTML string to be rendered into a PDF
private const string SampleHtmlString = "<h1>Hello World!</h1><br><p>This is IronPdf.</p>";

static void Main(string[] args)
{
    // Get a free license key instantly: https://ironpdf.com/#trial-license
    IronPdf.License.LicenseKey = "ENTER-KEY-HERE";
    
    Console.WriteLine("Welcome to the IronPDF `Hello World' Tutorial!");
    
    // Example of an HTML String to PDF
    HtmlToPdfExample(SampleHtmlString);
    
    // Example of URL to PDF
    UrlToPdfExample("https://getbootstrap.com/");
    
    Console.WriteLine("IronPDF Tutorial Complete! Press any key to exit!");
    Console.ReadKey();
}

public static void HtmlToPdfExample(string htmlString)
{
    // Start by initializing the Chrome Renderer
    ChromePdfRenderer renderer = new ChromePdfRenderer();

    // Render a new PdfDocument using an HTML string
    PdfDocument newPdf = renderer.RenderHtmlAsPdf(SampleHtmlString);
    
    // Save new PDF File
    newPdf.SaveAs("pdf_from_html.pdf");
}

public static void UrlToPdfExample(string url)
{
    // Start by initializing the Chrome Renderer
    ChromePdfRenderer renderer = new ChromePdfRenderer();

    // Set Pdf CssMediaType to Screen to get all the background
    renderer.RenderingOptions = new ChromePdfRenderOptions()
    {
        // Screen vs Print: https://ironpdf.com/how-to/pixel-perfect-html-to-pdf/#1-decide-to-use-css-media-type-print-or-screen
        CssMediaType = PdfCssMediaType.Screen,
        PrintHtmlBackgrounds = true,
        
        // Set Margins
        MarginTop = 10,
        MarginBottom = 10,
        MarginLeft = 10,
        MarginRight = 10
    };
    
    // Render a new PdfDocument from a URL
    PdfDocument newPdf = renderer.RenderUrlAsPdf(url);
    
    // Save new PDF File
    newPdf.SaveAs("pdf_from_url.pdf");
}
```

Get Started creating PDF documents with IronPDF in C# now! https://github.com/iron-software
