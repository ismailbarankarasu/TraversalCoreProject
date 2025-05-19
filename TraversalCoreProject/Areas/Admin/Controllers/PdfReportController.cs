using DocumentFormat.OpenXml.Wordprocessing;

using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Reflection.Metadata;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfReports" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);
            iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();
            iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph("Traversal Rezervasyon Pdf Raporu");
            document.Add(paragraph);
            document.Close();
            return File("pdfReports/dosya1.pdf", "application/pdf", "dosya1.pdf");
        }
    }
}
