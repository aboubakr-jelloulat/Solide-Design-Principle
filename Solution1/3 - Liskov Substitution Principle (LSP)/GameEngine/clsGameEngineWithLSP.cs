using System;
using System.Collections.Generic;
using System.Text;

namespace _3___Liskov_Substitution_Principle__LSP_.GameEngine
{
    internal class clsGameEngineWithLSP
    {
        public abstract class PlayerCharacter
        {
            public abstract void Move();
        }

        public interface ICanJump
        {
            void Jump();
        }

        public class Warrior : PlayerCharacter, ICanJump
        {
            public override void Move() => Console.WriteLine("Warrior moves forward!");
            public void Jump() => Console.WriteLine("Warrior jumps high!");
        }

        public class Ghost : PlayerCharacter
        {
            public override void Move() => Console.WriteLine("Ghost floats forward...");
        }

        public static void GameFollowLSP()
        {
            PlayerCharacter[] characters = { new Warrior(), new Ghost() };

            foreach (var c in characters)
            {
                c.Move();
                if (c is ICanJump jumper)
                {
                    jumper.Jump(); // Only jumpable characters jump
                }
            }

        }

    }
}
