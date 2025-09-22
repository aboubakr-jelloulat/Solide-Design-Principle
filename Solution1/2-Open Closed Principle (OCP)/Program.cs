using _2_Open_Closed_Principle__OCP_.Logging_Service;
using _2_Open_Closed_Principle__OCP_.Notification_Service;
using _2_Open_Closed_Principle__OCP_.Payment_Service;

namespace _2_Open_Closed_Principle__OCP_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // clsNotificationService.NotificationServiceDemo();


            // clsLoggingService.LoggingServiceDemo();


            clsPaymentService.PaymentServiceDemo();


            Console.ReadKey();
        }
    }
}
