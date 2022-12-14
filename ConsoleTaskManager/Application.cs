namespace ConsoleTaskManager
{
    internal class Application
    {
        public static void StartApp()
        {
            Console.WriteLine("***********Program Manager*************\n");
            Console.WriteLine("What would you like to do?\n1. View list of all the running processes" +
                "\n2. Start a new process\n3. Stop/Kill a process\n4. Start Thread\n5. Exit the program");
            var StartUpOptions = Convert.ToInt32(Console.ReadLine());

            switch (StartUpOptions)
            {
                case 1:
                    DisplayProcesses.EnumeratingProcesses();
                    break;
                case 2:
                    StartAndKillTask.StartACustomProcess();
                    break;
                case 3:
                    StartAndKillTask.KillAProcess();
                    break;
                case 4:
                    CustomThread.StartThread();
                    break;
                case 5:
                    Environment.Exit(10);
                    break;
                default:
                    Console.WriteLine("Invalid Input Try Again");
                    StartApp();
                    break;

            }
            
        }

        public static void EndApp()
        {
            Console.WriteLine("Would you like to exit the app?\nY or N");
            var EndOptions = Console.ReadLine().ToUpper();
            if (EndOptions == "Y")
            {
                Environment.Exit(10);
            }
            else if (EndOptions != "Y")
            {
                StartApp();
            }
        }
    }
}
