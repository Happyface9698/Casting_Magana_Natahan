namespace Casting_Magana_Natahan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please tell me your favorite number: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("Your favorite number is: " + userInput);

            Console.WriteLine("True or False, Programmers some times wish they had an extra finger!");
            bool isTrue = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("It is " + isTrue);
        }
    }
}
