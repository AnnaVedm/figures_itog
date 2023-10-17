using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фигурки
{
    class krug
    {
        private double perimetr;
        private double s;
        private double radius;
        public void Perimetr2()
        {
            Console.Write("Введите радиус круга r(см): ");
            radius = Convert.ToSingle(Console.ReadLine());
            if (radius <= 0 ) 
            {
                Console.WriteLine("Такое значение невозможно для радиуса круга. Попробуйте ввести данные ещё раз.");
                Perimetr2();
            }
            else 
            {
                perimetr = Math.Round(2 * Math.PI * radius, 3);

                Console.WriteLine($"\nПериметр круга = {perimetr} см");
            }
        }
        public void S2()
        {
            s = Math.Round(Math.PI * (radius * radius), 3);
            Console.WriteLine($"\nПлощадь круга = {s} см^2\n");
        }
    }
}
