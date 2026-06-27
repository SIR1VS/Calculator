namespace Calculator
{
    internal class Program
    {
        internal delegate double Operation(double number1, double number2);

        internal static double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        internal static double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }

        internal static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        internal static double Divide(double number1, double number2)
        {
            if (number2 == 0) throw new DivideByZeroException("Деление на ноль недопустимо.");
            return number1 / number2;
        }

        static void Main(string[] args)
        {
        }
    }
}
