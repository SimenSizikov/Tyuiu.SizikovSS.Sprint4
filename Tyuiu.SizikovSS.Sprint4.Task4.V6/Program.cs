using Tyuiu.SizikovSS.Sprint4.Task4.V6.Lib;

namespace Tyuiu.SizikovSS.Sprint4.Task4.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new();

            Console.Title = "Спринт #4 | Выполнил: Сизиков С. С. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Сизиков С. С. | РППб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 4 до 9.                          *");
            Console.WriteLine("* Заменить нечетные элементы массива на 0.                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] mass = new int[5, 5];

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    do
                    {
                        Console.Write($"Введите [{i},{j}] элемент массива: ");
                        mass[i, j] = Convert.ToInt32(Console.ReadLine());
                        if (mass[i, j] < 4 || mass[i, j] > 9) Console.WriteLine("Элементы массива должны быть в данном диапазоне[5,9].");
                    } while (mass[i, j] < 4 || mass[i, j] > 9);
                }
                Console.WriteLine();

            }

            Console.WriteLine("Массив:");
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write(mass[i, j] + ", ");
                }
                Console.WriteLine();
            }

            mass = ds.Calculate(mass);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Полученный массив:");
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write(mass[i, j] + ", ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
