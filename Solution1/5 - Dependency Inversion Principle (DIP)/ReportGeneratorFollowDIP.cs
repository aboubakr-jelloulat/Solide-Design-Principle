using System;
using System.Collections.Generic;
using System.Text;
using static _5___Dependency_Inversion_Principle__DIP_.ReportGeneratorViolatingDIP;

namespace _5___Dependency_Inversion_Principle__DIP_
{
    internal class ReportGeneratorFollowDIP
    {

        public interface IReportGenerator
        {
            public void Generate();

        }

        public class PdfReportGenerator : IReportGenerator
        {
            public void Generate()
            {
                Console.WriteLine("PDF report generated :-).");
            }
        }

        public class ExcelReportGenerator : IReportGenerator
        {
            public void Generate()
            {
                Console.WriteLine("Excel report generated :-).");
            }

        }


        public class ReportGenerator
        {
            private IReportGenerator _ReportGenerator;


            public ReportGenerator(IReportGenerator reportGenerator)
            {
                // Direct dependency on interface or abstract class

                _ReportGenerator = reportGenerator;

            }

            public void GenerateReport()
            {
                _ReportGenerator.Generate();
            }

        }

        public static void ReportGeneratorFollowDIPMethode()
        {
            ReportGenerator report = new ReportGenerator(new PdfReportGenerator());
            report.GenerateReport();

            report = new ReportGenerator(new ExcelReportGenerator());
            report.GenerateReport();

        }

    }
}
