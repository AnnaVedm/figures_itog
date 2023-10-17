namespace Фигурки
{
    class Program
    {
        static void Main(string[] args)
        {
            square schet = new square();
            prymougolnik schet1 = new prymougolnik();
            krug schet2 = new krug();
            triangle schet3 = new triangle();

            while (true)
            {
                Console.WriteLine("Выберите фигуру:");
                Console.WriteLine("1. Квадрат");
                Console.WriteLine("2. Прямоугольник");
                Console.WriteLine("3. Круг");
                Console.WriteLine("4. Треугольник");
                Console.WriteLine("5. Выйти");
                int vybory = int.Parse(Console.ReadLine());

                switch (vybory)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Вы выбрали квадрат: ");
                        schet.Perimetr();
                        schet.S();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Вы выбрали прямоугольник: ");
                        schet1.Perimetr1();
                        schet1.S1();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Вы выбрали круг: ");
                        schet2.Perimetr2();
                        schet2.S2();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Вы выбрали треугольник: ");
                        schet3.Perimetr3();
                        schet3.S3();
                        break;
                    case 5:
                        Console.WriteLine("Выход.");
                        Console.Clear();
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Некорректный выбор.");
                        break;
                }
            }
        }
    }
}
