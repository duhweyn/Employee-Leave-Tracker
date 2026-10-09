namespace EMPLOYEE_LEAVE_TRACKER
{
    internal class Program
    {
        static int balance = 15;
        static int request;
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            if (name == "Dwayne")
            {
                bool running = true;
                while (running)
                {
                    Console.WriteLine("" +
                        $"\n-- Welcome to Employee Leave Tracker, {name} --\n" +
                        "1. Request Leave\n" +
                        "2. Check Balance\n" +
                        "3. Exit");
                    int input = ReadInput("Enter a number: ", 1, 3);
                    switch (input)
                    {
                        case 1:
                            RequestLeave();
                            break;
                        case 2:
                            Console.WriteLine($"Remaining balance: {balance}");
                            break;
                        case 3:
                            Console.WriteLine("\nThank you for using ELT\n");
                            running = false;
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Name invalid.");
            }
        }
        static int ReadInput(string prompt, int min, int max)
        {
            string input;
            while (true)
            {
                Console.Write(prompt);
                input = Console.ReadLine();
                if (!int.TryParse(input, out int num))
                {
                    Console.WriteLine($"\"{input}\" is not a whole number.");
                    continue;
                } 
                if (num < min || num > max)
                {
                    Console.WriteLine($"Enter a value from {min}-{max}.");
                    continue;
                }
                return num;
            }
        }
        static int RequestLeave()
        {
            if (balance == 0)
            {
                Console.WriteLine("You have no remaining balance.");
                return 0;
            }
            int request = ReadInput("Enter day(s): ", 1, balance);
            balance -= request;
            Console.WriteLine($"Approved. Remaining Balance: {balance}");
            return request;
        }
    }
}
