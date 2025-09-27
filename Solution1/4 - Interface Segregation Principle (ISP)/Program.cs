using _4___Interface_Segregation_Principle__ISP_.Device_Applying_ISP;
using _4___Interface_Segregation_Principle__ISP_.Paymen_Applying_ISP;
using _4___Interface_Segregation_Principle__ISP_.Printer_Applying_ISP;
using _4___Interface_Segregation_Principle__ISP_.Violating_ISP;


namespace _4___Interface_Segregation_Principle__ISP_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // clsViolatingISP.PrinterViolatingISP();

            // clsApplyingISP.PrinterApplyingISP();

            // clsPaymentApplyingISP.PaymentApplyingISP();

            clsDeviceApplyingISP.DeviceApplyingISP();


            Console.ReadKey();
        }
    }
}
