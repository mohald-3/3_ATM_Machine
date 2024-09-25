

namespace _3_ATM_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UI uI = new UI();
            BankAccount bank1 = new BankAccount(11223344, 1234, 50000);

            WelcomePhrase();
            Menu1Choices(uI, bank1);

        }

        private static void Menu1Choices(UI uI, BankAccount bank1)
        {
            Menu1();
            string inputChoice = uI.GetChoiceInput();
            if (inputChoice == "1")
            {
                Console.WriteLine("Please type in the pincode to your account:");
                bank1.verification();
                if (bank1.authorised == true)
                {
                    Menu2Choices(uI, bank1);
                }
                else
                {
                    Menu1Choices(uI, bank1);
                }
            }
            else if (inputChoice == "2")
            {
                ExitConsole();
            }
        }

        private static void Menu2Choices(UI uI, BankAccount bank1)
        {
            Menu2();
            string inputChoice = uI.GetChoiceInput();
            if (inputChoice == "1")
            {
                bank1.Deposit();
            }
            else if (inputChoice == "2")
            {
                bank1.Draw();

            }
            else if (inputChoice == "3")
            {
                bank1.CheckBalance();
            }
            else if (inputChoice == "4")
            {
                bank1.LogOut();
                Menu1Choices(uI, bank1);
            }
            else if (inputChoice == "5")
            {
                ExitConsole();
            }
            Console.WriteLine("=========================");

            Menu2Choices(uI, bank1);
        }

        private static void WelcomePhrase()
        {
            Console.WriteLine("Welcome to Eddies ATM!");
            Console.WriteLine("=========================");
        }



        private static void Menu1()
        {
            Console.WriteLine("Please choose a number from the list below:");
            Console.WriteLine("1. Log in");
            Console.WriteLine("2. Exit");
        }
        private static void Menu2()
        {
            Console.WriteLine("How can we help you today?");
            Console.WriteLine("Please choose a number from the list below:");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Draw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Log out");
            Console.WriteLine("5. Exit");
        }

        private static void ExitConsole()
        {
            Console.WriteLine("Sad to see you leave. Have a nice day!");
            Environment.Exit(0);
        }


    }
}
