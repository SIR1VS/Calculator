namespace Calculator
{
    internal class Program
    {
        private delegate double Operation(double number1, double number2);

        private static double Add(double number1, double number2) => number1 + number2;

        private static double Subtract(double number1, double number2) => number1 - number2;

        private static double Multiply(double number1, double number2) => number1 * number2;

        private static double Divide(double number1, double number2)
        {
            if (number2 == 0) throw new DivideByZeroException("Деление на ноль недопустимо");
            return number1 / number2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(new string('=', 38));
            Console.WriteLine("\tКОНСОЛЬНЫЙ КАЛЬКУЛЯТОР\t");
            Console.WriteLine(new string('=', 38));

            try
            {
                Console.Write("Введите первое число: ");
                if (!double.TryParse(Console.ReadLine(), out double number1))
                {
                    Console.WriteLine("Некорректный ввод числа");
                    return;
                }

                Console.Write("Введите второе число: ");
                if (!double.TryParse(Console.ReadLine(), out double number2))
                {
                    Console.WriteLine("Некорректный ввод числа");
                    return;
                }

                Console.WriteLine("Выберите операцию:");
                Console.WriteLine();
                Console.WriteLine("[ + ] - сложение");
                Console.WriteLine("[ - ] - вычитание");
                Console.WriteLine("[ * ] - умножение");
                Console.WriteLine("[ / ] - деление");
                Console.WriteLine();
                Console.Write("Ваш выбор: ");

                string? input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Операция не выбрана");
                    return;
                }

                char choice = input[0];

                Operation operation;

                switch (choice)
                {
                    case '+':
                        operation = Add;
                        break;
                    case '-':
                        operation = Subtract;
                        break;
                    case '*':
                        operation = Multiply;
                        break;
                    case '/':
                        operation = Divide;
                        break;
                    default:
                        Console.WriteLine("Неизвестная операция");
                        return;
                }

                double result = operation(number1, number2);
                Console.WriteLine($"Результат: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine(new string('=', 38));
            }
        }
    }
}