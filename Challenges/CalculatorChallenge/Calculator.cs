namespace CalculatorChallenge
{
    public class Calculator
    {
        public double Add(double x, double y)
        { 
            return x + y; 
        }

        public double Subtract(double x, double y)
        {      
            return x - y;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }

            return a / b;
        }

    }
}
