using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace _3___Liskov_Substitution_Principle__LSP_.Payment_System
{

    public class clsGgame
    {

        public class PlayerCharacter
        {
            public virtual void Move()
            {
                Console.WriteLine("Player moves...");
            }

            public virtual void Jump()
            {
                Console.WriteLine("Player jumps...");
            }
        }


        public class Warrior : PlayerCharacter
        {
            public override void Move()
            {
                Console.WriteLine("Warrior moves forward!");
            }

            public override void Jump()
            {
                Console.WriteLine("Warrior jumps high!");
            }
        }

        public class Ghost : PlayerCharacter
        {
            public override void Move()
            {
                Console.WriteLine("Ghost floats forward...");
            }

            // Problem: Ghost cannot jump like normal characters
            public override void Jump()
            {
                throw new NotSupportedException("Ghost cannot jump!");
            }

        }


        public static void GameViolatingLSP()
        {
            PlayerCharacter[] characters = { new Warrior(), new Ghost() };

            foreach (var c in characters)
            {
                c.Move(); // Works for both 
                c.Jump(); //  Ghost throws exception → LSP violated
            }


        }


    }
}

