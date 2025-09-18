using Single_Responsibility_Principle_SRP.Notification_Service;

namespace _1___Single_Responsibility_Principle__SRP_
{

    /*
     * 
     * Introduction to SOLID principles
        SOLID principles are the design principles that enable us to manage several software design problems.
        Robert C. Martin compiled these principles in the 1990s. 
        These principles provide us with ways to move from tightly coupled code and little encapsulation to the desired results of loosely coupled and encapsulated real business needs properly. SOLID is an acronym for the following.

        S: Single Responsibility Principle (SRP)
        O: Open-closed Principle (OCP)
        L: Liskov substitution Principle (LSP)
        I: Interface Segregation Principle (ISP)
        D: Dependency Inversion Principle (DIP)
     * 
     * 
     */



    internal class Program
    {


        // ***** [  S: Single Responsibility Principle(SRP) ] *******


        // => SRP says, "Every software module should have only one reason to change." meaning it should have only one job or responsibility.


        static void Main(string[] args)
        {
            NotificationDemo.RunNotificationService();



        }

    }
}
