using CalculatorChallenge;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        Console.WriteLine("welcome to simple calculator.");

        while (true)
        {
            Console.WriteLine("What type of operation do you want to do?");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit the program");
            Console.Write("Enter your choice (1-5): ");

            int Operation = Convert.ToInt32(Console.ReadLine());

            if (Operation == 5)
            {
                Console.WriteLine("Exiting the calculator. Goodbye!");
                break;
            }

            if (Operation < 1 || Operation > 5 )
            {
                Console.WriteLine($"{Operation} is Invalid choice for calulator operation. Please enter a number between 1 and 5.");
                continue;
            }


            Console.WriteLine("enter first number: ");
            double FirstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number: ");
            double SecondNumber = Convert.ToInt32(Console.ReadLine());

            switch (Operation)
            {
                case 1:
                    double Sum = calculator.Add(FirstNumber, SecondNumber);
                    Console.WriteLine($"sum of {FirstNumber} and {SecondNumber} is {Sum}.");
                    break;

                case 2:
                    double difference = calculator.Subtract(FirstNumber, SecondNumber);
                    Console.WriteLine($"The difference between {FirstNumber} and {SecondNumber}  is {difference}.");
                    break;

                case 3:
                    double Product = calculator.Multiply(FirstNumber, SecondNumber);
                    Console.WriteLine($"The product of {FirstNumber} and {SecondNumber} is {Product}.");
                    break;

                case 4:
                    double Divided = calculator.Divide(FirstNumber, SecondNumber);
                    Console.WriteLine($"The quotient of {FirstNumber} and {SecondNumber} is {Divided}.");
                    break;
            }
            
        }

    }

}
