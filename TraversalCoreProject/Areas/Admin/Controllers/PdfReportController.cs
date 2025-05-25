using DocumentFormat.OpenXml.Wordprocessing;

using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Mozilla;
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
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfReports/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);
            iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();
            iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph("Traversal Rezervasyon Pdf Raporu");
            document.Add(paragraph);
            document.Close();
            return File("pdfReports/dosya1.pdf", "application/pdf", "dosya1.pdf");
        }
        public IActionResult StaticCustomerResport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfReports/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);
            iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();
            PdfPTable pdfPTable = new PdfPTable(3);
            pdfPTable.AddCell("Misafir Adı");
            pdfPTable.AddCell("Misafir Soyadı");
            pdfPTable.AddCell("Misafir TC");

            pdfPTable.AddCell("Ali");
            pdfPTable.AddCell("CANDAN");
            pdfPTable.AddCell("12345678910");

            pdfPTable.AddCell("Zeynep");
            pdfPTable.AddCell("DÜZENLİ");
            pdfPTable.AddCell("12345678912");

            pdfPTable.AddCell("İsmail Baran");
            pdfPTable.AddCell("KARASU");
            pdfPTable.AddCell("12345678925");

            document.Add(pdfPTable);
            document.Close();
            return File("pdfReports/dosya2.pdf", "application/pdf", "dosya2.pdf");
        }
    }
}
