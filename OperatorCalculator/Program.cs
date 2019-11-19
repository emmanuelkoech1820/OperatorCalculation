using System;

namespace OperatorCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the First number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            String Operator = Console.ReadLine();

            Console.Write("Enter the Second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());


            if (Operator == "+")
            {
                Console.WriteLine("The answer is: {0}", number1 + number2);
            }
            else if (Operator == "-")
            {
                Console.WriteLine("The answer is: {0}", number1 - number2);
            }
            else if (Operator == "/")
            {
                Console.WriteLine("The answer is: {0}", number1 / number2);
            }
            else if (Operator == "*")
            {
                Console.WriteLine("The answer is: {0}", number1 * number2);
            }
            else   
            {
                Console.WriteLine("Invalid Operator");
            }
            Console.ReadLine();
        }
    }
}
