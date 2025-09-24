using System;

namespace _2_Open_Closed_Principle__OCP_.Payment_Service
{
    internal class clsPaymentService
    {
        public interface IPayment
        {
            void Payment(decimal amount);
        }

        class PayPalPayment : IPayment
        {
            public void Payment(decimal amount) =>
                Console.WriteLine($"[PayPal] Processing payment of {amount:C}");
        }

        class CreditCardPayment : IPayment
        {
            public void Payment(decimal amount) =>
                Console.WriteLine($"[Credit Card] Charging {amount:C} to the customer’s card");
        }

        class BankTransferPayment : IPayment
        {
            public void Payment(decimal amount) =>
                Console.WriteLine($"[Bank Transfer] Transferring {amount:C} to the recipient’s account");
        }

        class BitcoinPayment : IPayment
        {
            public void Payment(decimal amount) =>
                Console.WriteLine($"[Bitcoin] Sending {amount} BTC (approx. {amount * 65000:C} at current rate)");
            // assuming 1 BTC = 65k USD, just for demo
        }

        public class PaymentService
        {
            private readonly IPayment _payment;

            public PaymentService(IPayment payment)
            {
                _payment = payment;
            }

            public void PaymentProcess(decimal amount)
            {
                _payment.Payment(amount);
            }
        }


        public static void PaymentServiceDemo()
        {

            var paypal = new PaymentService(new PayPalPayment());
            paypal.PaymentProcess(120.50m);

            Console.WriteLine();

            var creditCard = new PaymentService(new CreditCardPayment());
            creditCard.PaymentProcess(250.00m);

            Console.WriteLine();

            var bank = new PaymentService(new BankTransferPayment());
            bank.PaymentProcess(999.99m);

            Console.WriteLine();

            var bitcoin = new PaymentService(new BitcoinPayment());
            bitcoin.PaymentProcess(0.02m);

        }
    }
}
