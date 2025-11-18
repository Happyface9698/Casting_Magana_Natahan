namespace Casting_Magana_Natahan
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Please tell me your favorite number: "); // Prompt user for favorite number
            int userInput = Convert.ToInt32(Console.ReadLine());// Read user input as string
            Console.WriteLine("Your favorite number is: " + userInput); // Display the favorite number

            Console.WriteLine("True or False, Programmers some times wish they had an extra finger!"); // Prompt user for a boolean input
            bool isTrue = Convert.ToBoolean(Console.ReadLine()); // Read user input and convert to boolean
            Console.WriteLine("It is " + isTrue + " sometimes."); // Display the boolean value

        }
    }
}
