using System;
using System.Collections.Generic;
using System.Text;

namespace _4___Interface_Segregation_Principle__ISP_.Violating_ISP
{
    internal class clsViolatingISP
    {

        public interface IPrinter
        {
            void Print(string content);
            void Scan();
            void Fax();

        }

        public class AdvancedPrinter : IPrinter
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

        public class BasicPrinter : IPrinter
        {
            public void Print(string content)
            {
                Console.WriteLine($"Printing: {content}");
            }

            public void Scan()
            {
                // BasicPrinter doesn't support scanning, but must implement this method
                throw new NotImplementedException();
            }

            public void Fax()
            {
                // BasicPrinter doesn't support faxing, but must implement this method
                throw new NotImplementedException();
            }
        }




        public static void PrinterViolatingISP()
        {

            var advanced = new AdvancedPrinter();

            advanced.Print("Hej This is Advanced Printer ");
            advanced.Scan();
            advanced.Fax();


            var basic = new BasicPrinter();

            basic.Print("Hej This is Basics Printer ");
            basic.Scan();
            basic.Fax();

        }
    }
}
