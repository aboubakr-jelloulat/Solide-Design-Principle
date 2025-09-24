using _3___Liskov_Substitution_Principle__LSP_.GameEngine;
using _3___Liskov_Substitution_Principle__LSP_.Payment_System;
using _3___Liskov_Substitution_Principle__LSP_.Person_LSP;
using _3___Liskov_Substitution_Principle__LSP_.Vehicle_LSP;

namespace _3___Liskov_Substitution_Principle__LSP_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // clsGgame.GameViolatingLSP();
            // clsGameEngineWithLSP.GameFollowLSP();


            //clsVehicle.VehicleFollowLSP();


            clsPerson.PersonFolowLSP();


            Console.ReadKey();
        }

    }
}


