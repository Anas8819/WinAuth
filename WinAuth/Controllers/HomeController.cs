using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WinAuth.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [System.Web.Services.WebMethod]
        public string GetBytes()
        {
            byte[] fileContent = null;
            System.IO.FileStream fs = new System.IO.FileStream("C:\\Users\\anas.ahmed\\source\\repos\\PrintPDFFromURL\\PrintPDFFromURL\\App_Data\\CrystalReportDocument.pdf", System.IO.FileMode.Open, System.IO.FileAccess.Read);
            System.IO.BinaryReader binaryReader = new System.IO.BinaryReader(fs);
            long byteLength = new System.IO.FileInfo("C:\\Users\\anas.ahmed\\source\\repos\\PrintPDFFromURL\\PrintPDFFromURL\\App_Data\\CrystalReportDocument.pdf").Length;
            fileContent = binaryReader.ReadBytes((Int32)byteLength);
            fs.Close();
            fs.Dispose();
            binaryReader.Close();
            //return fileContent;
            return JsonConvert.SerializeObject(fileContent);
            var bytes = System.IO.File.ReadAllBytes("C:\\Users\\anas.ahmed\\source\\repos\\PrintPDFFromURL\\PrintPDFFromURL\\App_Data\\CrystalReportDocument.pdf");
            //return bytes;
        }

        [System.Web.Services.WebMethod]
        public string GetBytesInBytes()
        {
            byte[] fileContent = null;
            System.IO.FileStream fs = new System.IO.FileStream("C:\\Users\\anas.ahmed\\source\\repos\\PrintPDFFromURL\\PrintPDFFromURL\\App_Data\\CrystalReportDocument.pdf", System.IO.FileMode.Open, System.IO.FileAccess.Read);
            System.IO.BinaryReader binaryReader = new System.IO.BinaryReader(fs);
            long byteLength = new System.IO.FileInfo("C:\\Users\\anas.ahmed\\source\\repos\\PrintPDFFromURL\\PrintPDFFromURL\\App_Data\\CrystalReportDocument.pdf").Length;
            fileContent = binaryReader.ReadBytes((Int32)byteLength);
            fs.Close();
            fs.Dispose();
            binaryReader.Close();
            //return fileContent;

            return Convert.ToBase64String(fileContent);

            //return JsonConvert.SerializeObject(fileContent);
            var bytes = System.IO.File.ReadAllBytes("C:\\Users\\anas.ahmed\\source\\repos\\PrintPDFFromURL\\PrintPDFFromURL\\App_Data\\CrystalReportDocument.pdf");
            //return bytes;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}