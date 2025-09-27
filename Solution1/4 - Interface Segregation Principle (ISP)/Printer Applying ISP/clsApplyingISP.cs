using System;
using System.Collections.Generic;
using System.Text;
using static _4___Interface_Segregation_Principle__ISP_.Violating_ISP.clsViolatingISP;

namespace _4___Interface_Segregation_Principle__ISP_.Printer_Applying_ISP
{
    internal class clsApplyingISP
    {

        public interface IPrint
        {
            void Print(string content);
        }

        public interface IScan
        {
            void Scan();
        }

        public interface IFax
        {
            void Fax();
        }

        public class AdvancedPrinter : IPrint, IScan, IFax
        {
            public void Print(string content)
            {
                Console.WriteLine($"Printing: {content}");
            }

            public void Scan()
            {
                Console.WriteLine($"Scanning..");
            }

            public void Fax()
            {
                Console.WriteLine($"Faxing...");
            }
        }


        public class BasicPrinter : IPrint
        {
            public void Print(string content)
            {
                Console.WriteLine($"Printing: {content}");
            }

        }



        public static  void PrinterApplyingISP()
        {
            var advanced = new AdvancedPrinter();

            advanced.Print("Hej This is Advanced Printer ");
            advanced.Scan();
            advanced.Fax();


            var basic = new BasicPrinter();

            basic.Print("Hej This is Basics Printer ");
        
        }

    }
}
