

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string calcContinue;
            Console.WriteLine("Hello, welcome tot he calculator program!");
            do
            {
                Console.WriteLine("Please enter your first number:");
                string firstNumInput = Console.ReadLine();
                Console.WriteLine("Please enter your second number:");
                string secondNumInput = Console.ReadLine();
                int firstNum = Int32.Parse(firstNumInput);
                int secondNum = Int32.Parse(secondNumInput);
                Console.WriteLine("What type of operation would you like to do?");
                Console.WriteLine("Please enter A for addition, S for subtraction, M for multiplication, or any other key division.");
                string inputOperation = Console.ReadLine();
                if (inputOperation.Equals("a") || inputOperation.Equals("A"))
                {
                    Console.WriteLine(firstNum + secondNum);
                }
                else if (inputOperation.Equals("s") || inputOperation.Equals("S"))
                {
                    Console.WriteLine(firstNum - secondNum);
                }
                else if (inputOperation.Equals("m") || inputOperation.Equals("M"))
                {
                    Console.WriteLine(firstNum * secondNum);
                }
                else
                {
                    Console.Write((firstNum / secondNum));
                    Console.WriteLine(" R " + firstNum%secondNum);
                }
                Console.WriteLine("Would you like do do another calculation: Y or N");
                calcContinue = Console.ReadLine();
            } while (calcContinue == "Y");
        }
    }

}