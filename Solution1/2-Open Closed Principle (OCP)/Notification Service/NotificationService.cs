using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Open_Closed_Principle__OCP_.Notification_Service
{

    public class EmailService : INotification
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"\nSending Email to {to}: {message}");
        }
    }

    public class SMSService : INotification
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"\nSending SMS to {to}: {message}");
        }
    }



    public class FaxService : INotification
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"\nSending Fax to {to}: {message}");
        }
    }

    public class TelegramService : INotification
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"\nSending Telegram message to {to}: {message}");
        }
    }

    public class DiscordService : INotification
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"\nSending Discord message to {to}: {message}");
        }
    }


    public interface INotification
    {
        public void Send(string to, string message);

    }

    internal class NotificationService
    {
        private readonly INotification _notification;

        public NotificationService(INotification Notification)
        {
            _notification = Notification;
        }

        public void SendNotification(string to, string message)
        {
            _notification.Send(to, message);
        }
    }


    internal class clsNotificationService
    {
        public static void NotificationServiceDemo()
        {

            NotificationService emailService = new NotificationService(new EmailService());
            emailService.SendNotification("joSanderhn@example.com", "Welcome to our service!");

          
            NotificationService smsService = new NotificationService(new SMSService());
            smsService.SendNotification("+41 76 887 90 41", "Your OTP code is 1234");

            
            NotificationService faxService = new NotificationService(new FaxService());
            faxService.SendNotification("05-5229-8831", "Fax Message: Important document.");

            
            NotificationService telegramService = new NotificationService(new TelegramService());
            telegramService.SendNotification("@ajelloul", "Hello from Telegram!");

            
            NotificationService discordService = new NotificationService(new DiscordService());
            discordService.SendNotification("MyNameisTrez", "Hello from Discord!");

        }

    }
}

