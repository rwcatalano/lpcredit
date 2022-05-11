using System;


namespace LPCredit
{
    public class Program
    {


        public static void Main(string[] args)
        {
            string choice = "";
            CreditFactory factory = new CreditFactory();

            Console.WriteLine("Welcome to the Credit Score CLI");


            while(choice != "q")
            {
                Console.WriteLine("What service to pull from? 0=Equifax, 1=Experian, 2=TransUnion, q=quit");
                var tmp = Console.ReadLine();

                if (tmp == "q")
                    break;

                var agency = factory.Create(Int32.Parse(tmp));
                var score = agency.PullScore();

                Console.WriteLine($"The score was {score}");
                Console.WriteLine("\n\n");
            }

            Console.WriteLine("Thanks for playing!");
            Console.WriteLine("Press any key to quit");
            var bla = Console.ReadLine();
        }
    }
}


