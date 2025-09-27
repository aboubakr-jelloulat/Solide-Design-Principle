using System;
using System.Collections.Generic;
using System.Text;

namespace _4___Interface_Segregation_Principle__ISP_.Device_Applying_ISP
{
    internal class clsDeviceApplyingISP
    {
        public interface ICallDevice
        {
            void MakeCall();
        }

        public interface IPhotoDevice
        {
            void TakePhoto();
        }

        public interface IEmailDevice
        {
            void SendEmail();

        }

        public interface IGPSDevice
        {
            void UseGPS();
        }


        public class Smartphone : ICallDevice, IPhotoDevice, IEmailDevice, IGPSDevice
        {
            public void MakeCall()
            {
                Console.WriteLine("Making a call.");
            }

            public void TakePhoto()
            {
                Console.WriteLine("Taking Photo.");
            }

            public void SendEmail()
            {
                Console.WriteLine("Sending an email.");
            }

            public void UseGPS()
            {
                Console.WriteLine("Using GPS.");
            }
        }

        public class Computer : IEmailDevice
        {

            public void SendEmail()
            {
                Console.WriteLine("Sending an email.");
            }

        }


        public static void DeviceApplyingISP()
        {

            Smartphone smartphone = new Smartphone();
            Console.WriteLine("SmartPhone:");
            smartphone.MakeCall();
            smartphone.TakePhoto();
            smartphone.SendEmail();
            smartphone.UseGPS();

            Computer computer = new Computer();
            Console.WriteLine("\nComputer:");
            computer.SendEmail();
  

        }

    }
}
