using System.Threading;
using System;

namespace MultiMethodProgram
{
    internal class Program
    {
        static void Main()
        {
            int userInput = '\0';
            string temp;

            Console.Clear();

            Console.WriteLine("Welcome to the Main Menu, please select one of the options below typing the number corresponding to each task");
            Console.WriteLine("1    Lab One");
            Console.WriteLine("2    Lab Two");
            Console.WriteLine("3    Lab Three");
            Console.WriteLine("0    Exit");

            temp = Console.ReadLine();
            userInput = Convert.ToInt32(temp);

            Console.Clear();

            switch (userInput)
            {
                case 1:


                    break;

                case 2:
                    break;

                case 3:
                    Lab3();
                    break;

                case 0:
                    Exit();
                    break;

            static void Exit()
            {
                Console.WriteLine("This is the Exit Screen\nHit enter to Exit");
                Console.ReadLine();
                Thread.Sleep(500);
            }
        }



        //LAB1










        //LAB2










        //LAB3
        static void Lab3()
            {
                string temp;
                int userInput;

                Console.WriteLine("Please type the number of times you want this loop to repeat! (Using Integers)");
                temp = Console.ReadLine();
                userInput = Convert.ToInt32(temp);

                for (int i = 0; i < userInput; i++)
                {
                    Console.WriteLine($"This loop has run {i + 1} times");
                    Thread.Sleep(500);
                }

                Console.WriteLine("Hit Enter To return to the Menu");
                Console.ReadLine();
                Main();
            }

        }

    }
}
