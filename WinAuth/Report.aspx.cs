using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WinAuth
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public byte[] FileToByteArray()
        {
            byte[] fileContent = null;
            System.IO.FileStream fs = new System.IO.FileStream("C:\\Users\\anas.ahmed\\source\\repos\\PrintPDFFromURL\\PrintPDFFromURL\\App_Data\\CrystalReportDocument.pdf", System.IO.FileMode.Open, System.IO.FileAccess.Read);
            System.IO.BinaryReader binaryReader = new System.IO.BinaryReader(fs);
            long byteLength = new System.IO.FileInfo("C:\\Users\\anas.ahmed\\source\\repos\\PrintPDFFromURL\\PrintPDFFromURL\\App_Data\\CrystalReportDocument.pdf").Length;
            fileContent = binaryReader.ReadBytes((Int32)byteLength);
            fs.Close();
            fs.Dispose();
            binaryReader.Close();
            return fileContent;
        }
    }
}