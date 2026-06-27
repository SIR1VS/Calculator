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
            Console.WriteLine(new string('=', 38));
            Console.WriteLine("\tКОНСОЛЬНЫЙ КАЛЬКУЛЯТОР\t");
            Console.WriteLine(new string('=', 38));

            Console.Write("Введите первое число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("[ + ] - сложение");
            Console.WriteLine("[ - ] - вычитание");
            Console.WriteLine("[ * ] - умножение");
            Console.WriteLine("[ / ] - деление");
            Console.Write("Ваш выбор: ");
            char choice = Console.ReadLine()[0];
        }
    }
}
