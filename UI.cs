namespace _3_ATM_Machine
{
    public class UI
    {
        public string? input;

        public string GetChoiceInput() 
        {
            input = Console.ReadLine()!;

            // Check if input is null or empty
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input cannot be empty. Please try again:");
                return null; // Indicate invalid input
            }

            return input;
        
        }
    }
}
