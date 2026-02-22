
using System;

namespace Homework1
{
    class Program
    {



        // 1. Обнулить разряд десятков в трехзначном числе
        static void NullDec(ref int n)
        {
            int absN = Math.Abs(n);
            if (absN < 100 || absN > 999)
                throw new ArgumentException("Число должно быть трехзначным");

            int sign = Math.Sign(n);
            int result = (absN / 100) * 100 + (absN % 10);
            n = sign * result;
        }

        // 2. Цвет шахматной клетки
        static string ChessColor(int x, int y)
        {
            if (x < 1  x > 8  y < 1 || y > 8)


        throw new ArgumentOutOfRangeException("Координаты должны быть от 1 до 8");

            return (x + y) % 2 == 0 ? "черный" : "белый";
        }

        // 3. Количество корней квадратного уравнения
        static int CountRoots(int a, int b, int c)
        {
            if (a == 0)
                throw new ArgumentException("A не может быть равно 0");

            double d = b * b - 4 * a * c;

            if (d < 0)
                return 0;
            if (d == 0)
                return 1;
            return 2;
        }

        // 4. Минимум из двух чисел
        static double MyMin(double x, double y)
        {
            return x < y ? x : y;
        }

        // 5. Произведение четных чисел от A до B
        static double MultAB(int A, int B)
        {
            int start = A < B ? A : B;
            int end = A > B ? A : B;

            if (start % 2 != 0)
                start++;

            double result = 1;
            for (int i = start; i <= end; i += 2)
            {
                result *= i;
            }

            return result;
        }

        // 6. Анализ набора чисел
        static void CountNumbers(int K)
        {
            if (K == 0)
                throw new ArgumentException("K не может быть равно 0");

            Console.WriteLine("Введите числа (0 для завершения):");

            int countLess = 0;
            int countDivisible = 0;
            int num;

            Console.Write("Число: ");
            num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                if (num < K) countLess++;
                if (num % K == 0) countDivisible++;

                Console.Write("Число: ");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Количество чисел, меньших {K}: {countLess}");
            Console.WriteLine($"Количество чисел, делящихся на {K} нацело: {countDivisible}");
        }

        // 7. Время года по месяцу
        enum Seasons { Winter, Spring, Summer, Autumn }

        static Seasons TimeOfYear(int n)
        {
            if (n < 1 || n > 12)
                throw new ArgumentOutOfRangeException("Месяц должен быть от 1 до 12");

            return n switch
            {
                12 or 1 or 2 => Seasons.Winter,
                3 or 4 or 5 => Seasons.Spring,
                6 or 7 or 8 => Seasons.Summer,
                9 or 10 or 11 => Seasons.Autumn,
                _ => Seasons.Winter // Эта ветка никогда не выполнится из-за проверки выше
            };
        }

        // 8. Случайные месяцы
        static void RandSeason(int n)
        {
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                int month = rnd.Next(1, 13);
                Console.WriteLine($"Месяц №{month}, его сезон: {TimeOfYear(month)}");
            }
        }






        static void Main(string[] args)
        {
            Console.WriteLine("TASK 1");
            int num1 = 123;
            Console.WriteLine($"Было: {num1}");
            NullDec(ref num1);
            Console.WriteLine($"Стало: {num1}");

            int num2 = -456;
            Console.WriteLine($"\nБыло: {num2}");
            NullDec(ref num2);
            Console.WriteLine($"Стало: {num2}");



            
            Console.WriteLine("TASK 2");

            Console.WriteLine($"Клетка (1, 1): {ChessColor(1, 1)}");
            Console.WriteLine($"Клетка (2, 3): {ChessColor(2, 3)}");
            Console.WriteLine($"Клетка (8, 8): {ChessColor(8, 8)}");



            Console.WriteLine("TASK 3");

            Console.WriteLine($"x^2 - 3x + 2 = 0 -> корней: {CountRoots(1, -3, 2)}");
            Console.WriteLine($"x^2 - 2x + 1 = 0 -> корней: {CountRoots(1, -2, 1)}");
            Console.WriteLine($"x^2 + x + 1 = 0 -> корней: {CountRoots(1, 1, 1)}");


            Console.WriteLine("TASK 4");
            Console.WriteLine($"Min(5.7, 3.2) = {MyMin(5.7, 3.2)}");
            Console.WriteLine($"Min(-1.5, -2.8) = {MyMin(-1.5, -2.8)}");
            Console.WriteLine($"Min(10, 10) = {MyMin(10, 10)}");

            Console.WriteLine("TASK 5");
            Console.WriteLine($"A=2, B=5: {MultAB(2, 5)}");
            Console.WriteLine($"A=1, B=5: {MultAB(1, 5)}");
            Console.WriteLine($"A=3, B=3: {MultAB(3, 3)}");
            Console.WriteLine($"A=3, B=7: {MultAB(3, 7)}");
            Console.WriteLine($"A=5, B=2: {MultAB(5, 2)}");
            Console.WriteLine($"A=-4, B=4: {MultAB(-4, 4)}");

            Console.WriteLine("TASK 6");

            CountNumbers(3);
            

            Console.WriteLine("TASK 7");

            Console.WriteLine($"Месяц 1: {TimeOfYear(1)}");
            Console.WriteLine($"Месяц 4: {TimeOfYear(4)}");
            Console.WriteLine($"Месяц 8: {TimeOfYear(8)}");
            Console.WriteLine($"Месяц 12: {TimeOfYear(12)}");
            


            Console.WriteLine("TASK 8");
            RandSeason(5);
        

        
    }
}