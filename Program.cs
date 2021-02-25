using System;

namespace Homework_week_3
{
    class Program
    {
        static void Main(string[] args)
        {        
            int agency, firstdigit, secdigit, thirddigit, fordigit, fifdigit, sixdigit;
            Console.WriteLine("CIA = 1, FBI = 2, NSA = 3");
            Console.Write("Please enter your agency number : ");
            agency = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your password");
            
            Console.Write("Your sixth digit is : ");
            sixdigit = int.Parse(Console.ReadLine());
            Console.Write("Your fifthth digit is : ");
            fifdigit = int.Parse(Console.ReadLine());
            Console.Write("Your fourth digit is : ");
            fordigit = int.Parse(Console.ReadLine());
            Console.Write("Your third digit is : ");
            thirddigit = int.Parse(Console.ReadLine());
            Console.Write("Your second digit is : ");
            secdigit = int.Parse(Console.ReadLine());
            Console.Write("Your first digit is : ");
            firstdigit = int.Parse(Console.ReadLine());

            if (agency == 1)
            {
                if ((firstdigit == 3 || firstdigit == 6 || firstdigit == 9) && (secdigit != 1 && secdigit != 3 && secdigit != 5) && (fordigit == 6 || fordigit == 7 || fordigit == 9))
                {
                    Console.WriteLine("Access Granted.Welcome back CIA Agent.");
                }
                else
                {
                    Console.WriteLine("Access Denied");
                }
            }
            if (agency == 2)
            {
                if ((sixdigit >= 4 && sixdigit <= 7) && (thirddigit == 2 || thirddigit == 4 || thirddigit == 8) && (fifdigit == 1 || fifdigit == 3 || fifdigit == 5 || fifdigit == 7 || fifdigit == 9))
                {
                    Console.WriteLine("Access Granted.Welcome back FBI Agent.");
                }
                else
                {
                    Console.WriteLine("Access Denied");
                }
            }
            if (agency == 3)
            {
                if ((firstdigit == 1 || firstdigit == 2 || firstdigit == 3 || firstdigit == 5 || firstdigit == 6) && (thirddigit == 3 || thirddigit == 9) && (secdigit == 7 || fordigit == 7 || fifdigit == 7 || sixdigit == 7))
                {
                    Console.WriteLine("Access Granted.Welcome back NSA Agent.");
                }
                else
                {
                    Console.WriteLine("Access Denied");
                }
            }
            Console.ReadLine();
        }
    }
}
