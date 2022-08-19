using System;
using IronPdf;
using IronPdf.Engines.Chrome;
using IronPdf.Rendering;

namespace IronPDF_Sample_Project
{
    class Program
    {
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
                // Screen vs Print: https://ironpdf.com/tutorials/pixel-perfect-html-to-pdf/#decide-to-use-css-media-type-print-or-screen
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
    }
}