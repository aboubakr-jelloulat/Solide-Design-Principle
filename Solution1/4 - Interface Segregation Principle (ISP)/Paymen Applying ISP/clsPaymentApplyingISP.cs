using System;
using System.Collections.Generic;
using System.Text;

namespace _4___Interface_Segregation_Principle__ISP_.Paymen_Applying_ISP
{
    internal class clsPaymentApplyingISP
    {

  

        public interface IPayWithCredit
        {
            void PayWithCreditCard();
        }

        public interface IPayWithPayPal
        {
            void PayWithPayPal();
        }

        public interface IPayWithBitcoin
        {
            void PayWithBitcoin();
        }


        public class AllPayment : IPayWithBitcoin, IPayWithPayPal, IPayWithCredit
        {
            public void PayWithCreditCard()
            {
                Console.WriteLine("Payment with credit card.");
            }

            public void PayWithPayPal()
            {
                Console.WriteLine("Payment with PayPal.");
            }

            public void PayWithBitcoin()
            {
                Console.WriteLine("Payment with Bitcoin.");
            }

        }


        public class CreditCardPayment : IPayWithCredit
        {
            public void PayWithCreditCard()
            {
                Console.WriteLine("Payment with credit card.");
            }

        }

        public class PayPalPayment : IPayWithPayPal
        {
            
            public void PayWithPayPal()
            {
                Console.WriteLine("Payment with PayPal.");
            }

        }


        public static void PaymentApplyingISP()
        {

            var creditCardPayment = new CreditCardPayment();
            creditCardPayment.PayWithCreditCard();
         

            var payPalPayment = new PayPalPayment();
            payPalPayment.PayWithPayPal();


            Console.WriteLine("\n\n Test All Payment Class \n\n");

            AllPayment allPayment = new AllPayment();

            allPayment.PayWithCreditCard();
            allPayment.PayWithPayPal();
            allPayment.PayWithBitcoin();


        }

    }
}
