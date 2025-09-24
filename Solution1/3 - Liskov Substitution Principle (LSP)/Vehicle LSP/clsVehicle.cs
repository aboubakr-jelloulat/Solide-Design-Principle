using System;
using System.Collections.Generic;
using System.Text;

namespace _3___Liskov_Substitution_Principle__LSP_.Vehicle_LSP
{

    public class Vehicle
    {

        public virtual void Drive()
        {
            Console.WriteLine("Driving...");
        }

    }

    public class VehicleWithStartEngine : Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Starting engine...");
        }
    }

    public class Car : VehicleWithStartEngine
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started...");
        }

        public override void Drive()
        {
            Console.WriteLine("Car is driving...");
        }
    }

    public class Bicycle : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Bicycle is riding...");
        }
    }


    internal class clsVehicle
    {
        public static void VehicleFollowLSP()
        {
            VehicleWithStartEngine vehicle1 = new Car();
            vehicle1.Drive();
            vehicle1.StartEngine();


            Vehicle vehicle2 = new Bicycle();
            vehicle2.Drive();        // Behaves as expected for a bicycle.

        }



    }
}
