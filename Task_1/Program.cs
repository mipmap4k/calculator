using System;

class Calculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Substract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Ошибка: деление на ноль.");
        }

        return a * b;
    }

    public double Exponentiation(double a, double b)
    {
        return Math.Pow(a, b);
    }

    public double Persent(double a, double b)
    {
        return (a * b) / 100;
    }

    public double CalcSin(double a)
    {
        double angleInRadians = a * Math.PI / 180;
        double sinVal = Math.Sin(angleInRadians);
        return sinVal;
    }

    public double CalcCos(double a)
    {
        double angleInRadians = a * Math.PI / 180;
        double cosVal = Math.Cos(angleInRadians);
        return cosVal;
    }

    public double CalcTan(double a)
    {
        double angleInRadians = a * Math.PI / 180;
        double tanVal = Math.Tan(angleInRadians);
        return tanVal;
    }

    public double CalcSqrt(double a, double b)
    {
        if (a < 0)
        { 
            throw new ArgumentException("Ошибка: нельзя взять квадратный корень из отрицательного числа.");
        } 
        else if (a == 0)
        {
            return 0;
        }
        return Math.Pow(b, 1 / a);
    }

    public double CalcLog_2(double a)
    {
        return Math.Log(a);
    }

    public double CalcLog(double a)
    {
        return Math.Log10(a);
    }

    public double CalcExp(double a)
    {
        return Math.Exp(a);
    }
}
class Program
{
    static void Main()
    {
        var calculator = new Calculator();
        Console.WriteLine("Выберите операцию:");
        Console.WriteLine("1. Экспонента");
        Console.WriteLine("2. Логарифм (lg)");
        Console.WriteLine("3. Логарифм (Ln)");
        Console.WriteLine("4. Тангенс");
        Console.WriteLine("5. Синус");
        Console.WriteLine("6. Косинус");
        Console.WriteLine("7. Сложение");
        Console.WriteLine("8. Вычитание");
        Console.WriteLine("9. Умножение");
        Console.WriteLine("10. Деление");
        Console.WriteLine("11. Взятие корня(a^Sqrt(b))");
        Console.WriteLine("12. Возведение в степень");
        Console.WriteLine("13. Процент");

        int operationChoice = Convert.ToInt32(Console.ReadLine());

        if (operationChoice >= 1 && operationChoice <= 6)
        {
            Console.WriteLine("Введите число:");
            double number = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (operationChoice)
            {
                case 1:
                    result = calculator.CalcExp(number);
                    break;
                case 2:
                    result = calculator.CalcLog(number);
                    break;
                case 3:
                    result = calculator.CalcLog_2(number);
                    break;
                case 4:
                    result = calculator.CalcTan(number);
                    break;
                case 5:
                    result = calculator.CalcSin(number);
                    break;
                case 6:
                    result = calculator.CalcCos(number);
                    break;
            }
            Console.WriteLine($"Результат: {result}");
        }
        
        else if (operationChoice >= 7 && operationChoice <= 13)
        {
            Console.WriteLine("Введите первое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (operationChoice)
            {
                case 7:
                    result = calculator.Add(num1, num2);
                    break;
                case 8:
                    result = calculator.Substract(num1, num2);
                    break;
                case 9:
                    result = calculator.Multiply(num1, num2);
                    break;
                case 10:
                    result = calculator.Divide(num1, num2);
                    break;
                case 11:
                    result = calculator.CalcSqrt(num1, num2);
                    break;
                case 12:
                    result = calculator.Exponentiation(num1, num2);
                    break;
                case 13:
                    result = calculator.Persent(num1, num2);
                    break;
            }

            Console.WriteLine($"Результат: {result}");
        }
        else
        {
            Console.WriteLine("Ошибка: Неверный выбор операции.");
        }
    }
}