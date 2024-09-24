using System;

namespace Calculator
{
    class Funct
    {
        double num_one;
        double num_two;

        public void new_num()
        {
            Console.WriteLine("Введите первое число:");
            num_one = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            num_two = double.Parse(Console.ReadLine());
        }

        public void pow()
        {
            new_num();
            Console.WriteLine($"Результат: {Math.Pow(num_one, num_two)}\n");
        }

        public void max()
        {
            new_num();
            Console.WriteLine($"Максимум: {Math.Max(num_one, num_two)}\n");
        }

        public void sqrt()
        {
            new_num();
            Console.WriteLine($"Квадратный корень первого числа: {Math.Sqrt(num_one)}");
            Console.WriteLine($"Квадратный корень второго числа: {Math.Sqrt(num_two)}\n");
        }

        public void min()
        {
            new_num();
            Console.WriteLine($"Минимум: {Math.Min(num_one, num_two)}\n");
        }

        public void sin()
        {
            new_num();
            Console.WriteLine($"Синус первого числа: {Math.Sin(num_one)}");
            Console.WriteLine($"Синус второго числа: {Math.Sin(num_two)}\n");
        }

        public void tan()
        {
            new_num();
            Console.WriteLine($"Тангенс первого числа: {Math.Tan(num_one)}");
            Console.WriteLine($"Тангенс второго числа: {Math.Tan(num_two)}\n");
        }
    }
}
