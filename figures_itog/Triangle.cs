using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фигурки
{
    class triangle
    {
        private double perimetr;
        private double s;
        private double storona_a;
        private double storona_b;
        private double storona_c;
        private double summa_kvadratov1;//сторон в квадрате
        private double summa_kvadratov2;//сторон в квадрате
        private double summa1;//сумма сторон
        private double summa2;
        private double summa3;
        private double p;// Полупериметр для формулы герона
        public void Perimetr3()
        {
            Console.Write("Введите сторону треугольника a(см): ");
            storona_a = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите сторону треугольника b(см): ");
            storona_b = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите сторону треугольника с(см): ");
            storona_c = Convert.ToSingle(Console.ReadLine());
            if (storona_a <= 0 || storona_b <= 0 || storona_c <= 0)
            {
                Console.WriteLine("Такое значение невозможно для стороны треугольника. Попробуйте ввести данные ещё раз.");
                Perimetr3();
            }
            else
            {
                summa_kvadratov1 = (storona_a * storona_a) + (storona_b * storona_b);
                summa_kvadratov2 = (storona_b * storona_b) + (storona_c * storona_c);
                summa1 = storona_a + storona_b;
                summa2 = storona_b + storona_c;
                summa3 = storona_a + storona_c;

                if (summa1 <= storona_c || summa2 <= storona_a || summa3 <= storona_b)
                {
                    Console.WriteLine("\nТакой треугольник не существует! Попробуйте ввести данные ещё раз\n");
                    Perimetr3();
                }
                else if (storona_a == storona_b && storona_b == storona_c)
                {
                    Console.WriteLine("\nВаш треугольник равноcторонний!\n");
                    perimetr = Math.Round(storona_a + storona_b + storona_c, 3);
                    Console.WriteLine($"\nПериметр треугольника = {perimetr} см");
                }
                else if (storona_a == storona_b || storona_b == storona_c || storona_c == storona_a)
                {
                    Console.WriteLine("\nВаш треугольник равнобедренный!\n");
                    perimetr = Math.Round(storona_a + storona_b + storona_c, 3);
                    Console.WriteLine($"\nПериметр треугольника = {perimetr} см");
                }
                else if (storona_a != storona_b || storona_b != storona_c || storona_c != storona_a)
                {
                    Console.WriteLine("\nВаш треугольник разносторонний!\n");
                    perimetr = Math.Round(storona_a + storona_b + storona_c, 3);
                    Console.WriteLine($"\nПериметр треугольника = {perimetr} см");
                }

                if (summa_kvadratov1 == storona_c * storona_c || summa_kvadratov2 == storona_a * storona_a)
                {
                    Console.WriteLine("\nВаш треугольник прямоугольный!\n");
                    perimetr = Math.Round(storona_a + storona_b + storona_c, 3);
                    Console.WriteLine($"\nПериметр треугольника = {perimetr} см");
                }
            }
        }
        public void S3()
        {
            double p = (storona_a + storona_b + storona_c) / 2;
            s = Math.Round(Math.Sqrt(p * (p - storona_a) * (p - storona_b) * (p - storona_c)), 3);
            Console.WriteLine($"\nПлощадь треугольника = {s} см^2\n");
        }
    }
}
