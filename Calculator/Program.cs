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

        static void Main(string[] args)
        {
        }
    }
}
