using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPdf;

namespace IronPDFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hold on tight!");

            var htmlToPdf = new HtmlToPdf();  // new instance of HtmlToPdf

            //html to pdf
            //html to turn into pdf
            var html = @"<h1>Hello World!</h1><br><p>This is IronPdf.</p>";

            // turn html to pdf
            var pdf = htmlToPdf.RenderHtmlAsPdf(html);

            // save resulting pdf into file
            pdf.SaveAs(Path.Combine(Directory.GetCurrentDirectory(), "HtmlToPdf.Pdf"));  

            //url to pdf
            // uri of the page to turn into pdf
            var uri = new Uri("http://www.google.com/ncr");

            // turn page into pdf
            pdf = htmlToPdf.RenderUrlAsPdf(uri);

            // save resulting pdf into file
            pdf.SaveAs(Path.Combine(Directory.GetCurrentDirectory(), "UrlToPdf.Pdf"));

            Console.WriteLine("Done. Please find results under '{0}' directory.", Directory.GetCurrentDirectory());
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
