using Tyuiu.SizikovSS.Sprint4.Task3.V15.Lib;

namespace Tyuiu.SizikovSS.Sprint4.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new();

            Console.Title = "Спринт #4 | Выполнил: Сизиков С. С. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Сизиков С. С. | РППб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 9.                          *");
            Console.WriteLine("* Подсчитайте количество нечетных элементов во всем массиве.              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] mass = new int[5, 5] { { 7, 4, 2, 5, 3 }, { 4, 3, 2, 5, 6 }, { 6, 3, 4, 7, 5 }, { 5, 7, 4, 3, 8 }, { 7, 8, 8, 5, 6 } };

            Console.WriteLine("Массив:");
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write(mass[i, j] + ", ");
                }
                Console.WriteLine();

            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество нечетных элементов во всем массиве: " + ds.Calculate(mass));

            Console.ReadLine();
        }
    }
}
