using System;

namespace _9994086_assessment3_question1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();

            var falconers = new string[6] {"Debbie", "Heidi", "Noel", "Melissa", "Kirsten", "Koshy"};
            var falcons = new string[6] {"Hisan", "Ka Kite", "Siren", "Koa", "Stella", "Mojo"};

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Flying for the Wingspan Display at 2pm today we have:\n");
            Console.WriteLine($"Falconer: {falconers[RandomNumber(falconers)]}");
            Console.WriteLine($"with Falcon: {falcons[RandomNumber(falcons)]}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }

        static int RandomNumber(string[] array)
        {
            var rand = new Random();
            return rand.Next(1, array.Length);
        }
    }
}
