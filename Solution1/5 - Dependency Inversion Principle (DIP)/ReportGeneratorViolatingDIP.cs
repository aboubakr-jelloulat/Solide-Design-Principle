using System;
using System.Collections.Generic;
using System.Text;

namespace _5___Dependency_Inversion_Principle__DIP_
{
    internal class ReportGeneratorViolatingDIP
    {
        public class PdfReportGenerator
        {
            public void Generate()
            {
                Console.WriteLine("PDF report generated :-).");
            }
        }

        public class ReportGenerator
        {
            private PdfReportGenerator _pdfReportGenerator;


            public ReportGenerator() 
            {
                // Direct dependency on PdfReport (low-level module)
                _pdfReportGenerator = new PdfReportGenerator();

            }

            public void GenerateReport()
            {
                _pdfReportGenerator.Generate();
            }


        }


        public static void ReportGeneratorViolatingDIPMethode()
        {
            // Client code

            ReportGenerator reportGenerator = new ReportGenerator();

            reportGenerator.GenerateReport();

        }
    }
}
