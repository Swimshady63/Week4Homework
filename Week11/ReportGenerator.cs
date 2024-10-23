using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week11
{
     public class ReportGenerator
    { 
        HTML GetHTML=new HTML();
        PDF  GetPDF=new PDF();
        public void GeneratePDFreport()
        {
            GetPDF.GenerateB();
            
        }
        public void GenerateHTMLreport()
        {
            GetHTML.GenerateA();

        }
        public void GenerateReports()
        {
            GetPDF.GenerateB();
            GetHTML.GenerateA();
        }

    }

    class HTML 
    {
        public void GenerateA()
        {
            Console.WriteLine("<header>My Header </header>\n");
            Console.WriteLine("<body>\r\nVideo provides a powerful way to help you prove your point. When you click\r\nOnline Video, you can paste in the embed code for the video you want to add.\n");
            Console.WriteLine("</body>\n");
            Console.WriteLine("<footer>My Footer </footer>\n");
        }
    }

    class PDF
    {
        public void GenerateB()
        {
            Console.WriteLine("Header : I’m using Facade Pattern\n");
            Console.WriteLine("Body :\r\nVideo provides a powerful way to help you prove your point. When you click\r\nOnline Video, you can paste in the embed code for the video you want to add.\r\nYou can also type a keyword to search online for the video that best fits your\r\ndocument. To make your document look professionally produced, Word provides\n");
            Console.WriteLine("Footer: Page 1");
        }

    }
}
