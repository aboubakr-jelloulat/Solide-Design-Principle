using System;
using System.Collections.Generic;
using System.Text;

namespace _3___Liskov_Substitution_Principle__LSP_.Person_LSP
{
    internal class clsPerson
    {

        public abstract class Person
        {
            public abstract void SendEmail();
        }

        public interface IPayable
        {
            void PaySalary();
        }

        public class Employee : Person, IPayable
        {
            public override void SendEmail()
            {
                Console.WriteLine("Sending email to an employee...");
            }

            public void PaySalary()
            {
                Console.WriteLine("Paying salary to an employee...");
            }
        }

        public class Manager : Person, IPayable
        {
            public void PaySalary()
            {
                Console.WriteLine("Paying salary to a manager...");
            }

            public override void SendEmail()
            {
                Console.WriteLine("Sending email to a manager...");
            }
        }

        public class Student : Person
        {
            public override void SendEmail()
            {
                Console.WriteLine("Sending email to a student...");
            }
        }

       
        public static void PersonFolowLSP()
        {
            //Person person1 = new Employee();
            //person1.SendEmail();
            //((IPayable)person1).PaySalary();


            //Person person2 = new Manager();
            //person2.SendEmail();
            //((IPayable)person2).PaySalary();


            //Person person3 = new Student();
            //person3.SendEmail();
            //// person3 is not IPayable, so no salary → LSP is safe
            ///

            // **** or use ****


            IEnumerable<Person> people = new List<Person>
            {
                new Employee(),
                new Manager(),
                new Student()
            };

            foreach (var person in people)
            {
                // Every person can receive email
                person.SendEmail();

                // Only persons that are payable will get salary
                if (person is IPayable payablePerson)
                {
                    payablePerson.PaySalary();
                }
            }


        }

    }
}
