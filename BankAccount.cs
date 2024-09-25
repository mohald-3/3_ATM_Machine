namespace _3_ATM_Machine
{
    public class BankAccount
    {
        private int accountNumber;
        private int pinCode;
        private int balance;
        public int moneyInputInt;
        public string moneyInputString;

        public BankAccount(int accountNumber, int pinCode, int balance)
        {
            AccountNumber = accountNumber;
            PinCode = pinCode;
            Balance = balance;
        }

        public int AccountNumber { get; private set; }
        public int PinCode { get; private set; }
        public int Balance { get; private set; }

        public void verification(int userInput)
        {
            
            if (userInput == PinCode)
            {
                Console.WriteLine("Authentication successful!");
                Console.WriteLine("=========================");
            }
            else if (userInput != PinCode)
            {
                Console.WriteLine("Invalide pincode, please try again");
            }
        }

        public void Deposit() 
        {
            Console.WriteLine("You would like to deposit money! Please insert the amount you would like to deposit:");
            GetMoneyInput();
            Balance += moneyInputInt;
            Console.WriteLine($"You have added {moneyInputInt} to your account. Your current balance is {Balance}");
        }

        public void Draw()
        {
            Console.WriteLine("You would like to draw money! Please insert the amount you would like to draw:");
            GetMoneyInput();
            Balance -= moneyInputInt;
            Console.WriteLine($"You have added {moneyInputInt} to your account. Your current balance is {Balance}");
        }

        public void CheckBalance()
        {
            Console.WriteLine("You would like to check how much money have in your account.");
            Console.WriteLine($"Your current balance is {Balance}");
        }

        public int GetMoneyInput()
        {
            moneyInputString = Console.ReadLine()!;

            if (int.TryParse(moneyInputString, out moneyInputInt))
            {
                return moneyInputInt;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return GetMoneyInput(); // Ask for input again
            }
        }

    }
}
