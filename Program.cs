namespace EMPLOYEE_LEAVE_TRACKER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            if (name == "Dwayne")
            {
                int balance = 15;
                int choice = 0;

                while (choice != 3)
                {
                    Console.WriteLine($"\n-- Welcome to Employee Leave Tracker, {name} --");
                    Console.WriteLine("1. Request Leave\n2. Check Balance\n3. Exit");
                    Console.Write("Enter your choice: ");
                    choice = Convert.ToInt16(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter days: ");
                            int days = Convert.ToInt16(Console.ReadLine());
                            if (days <= balance)
                            {
                                balance -= days;
                                Console.WriteLine($"Approved. Your current balance is now {balance}");
                            }
                            else
                            {
                                Console.WriteLine($"Request denied. Your requested day(s) ({days}) exceeds your current balance ({balance}).");
                            }
                            break;
                        case 2:
                            Console.WriteLine($"Remaining balance: {balance}");
                            break;
                        case 3:
                            Console.WriteLine("Thank you for using ELT");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Name invalid.");
            }
        }
    }
}
