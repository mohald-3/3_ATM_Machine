namespace _3_ATM_Machine
{
    public class BankAccount
    {
        private int accountNumber;
        private int pinCode;
        private int balance;
        public int moneyInputInt;
        public string moneyInputString;
        public bool authorised = false;

        public BankAccount(int accountNumber, int pincode, int balance)
        {
            AccountNumber = accountNumber;
            Pincode = pincode;
            Balance = balance;
        }

        public int AccountNumber { get; private set; }
        public int Pincode { get; private set; }
        public int Balance { get; private set; }

        public void verification()
        {
            int pincodeInput = GetMoneyInput();

            if (pincodeInput == Pincode)
            {
                Console.WriteLine("Authentication successful!");
                Console.WriteLine("=========================");
                authorised = true;
                
            }
            else if (pincodeInput != Pincode)
            {
                Console.WriteLine("Incorrect pincode, please try again");
                return;
            }
        }

        public void LogOut() 
        {
            authorised = false;
            Console.WriteLine("You have been logged out!");
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
