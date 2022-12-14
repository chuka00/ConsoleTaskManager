using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTaskManager
{
    internal class CustomThread
    {

        public static void StartThread()
        {
            Console.WriteLine("This program prints numbers from 0 - 9");
            Console.WriteLine("1. Run program on a single thread\n2. Run program on multithread\n3. Back to Main Menu");
            var option = Console.ReadLine();
            if (int.TryParse(option, out int userInput))
            {
                switch (userInput)
                {
                    case 1:
                        PrintNumbers();
                        break;
                    case 2:
                        getMultithread();
                        break;
                    case 3:
                        Application.StartApp();
                        break;
                    default:
                        Console.WriteLine("Invalid Input, Try again");
                        StartThread();
                        break;

                }
            }

            else
            {
                Console.WriteLine("Please, Enter a numerical value!");
                StartThread();
            }
        }

        public static void PrintNumbers()
        {
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "ThePrimaryThread";

            Console.Clear();
            Console.WriteLine($"{primaryThread.Name} is executing a program that print numbers from 0 - 9.");


            Console.Write("The numbers are: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"\n{i}");
                Thread.Sleep(2000);
            }
            Console.WriteLine("\nCompleted!");

            Application.EndApp();
        }

        public static void getMultithread()
        {
            ThreadStart thread = new ThreadStart(PrintNumbers);
            Thread backgroundThread = new Thread(thread);
            backgroundThread.Start();

            Application.EndApp();
        }

    }
}

        

