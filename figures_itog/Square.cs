using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фигурки
{
    class square
    {
        private double perimetr;
        private double s;
        private double storona;


        public void Perimetr()
        {
            Console.Write("Введите сторону квадрата a(см): ");
            storona = Convert.ToSingle(Console.ReadLine());
            if (storona <= 0)
            {
                Console.WriteLine("Такое значение невозможно для стороны квадрата. Попробуйте ввести данные ещё раз.");
                Perimetr();
            }
            else
            {
                perimetr = Math.Round(4 * storona, 3);
                Console.WriteLine($"\nПериметр квадрата = {perimetr} см");
            }
        }

        public void S()
        {
            s = Math.Round(storona * storona, 3);
            Console.WriteLine($"\nПлощадь квадрата = {s} см^2\n");
        }
    }
}
