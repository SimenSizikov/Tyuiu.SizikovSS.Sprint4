using Tyuiu.SizikovSS.Sprint4.Task1.V29.Lib;

namespace Tyuiu.SizikovSS.Sprint4.Task1.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new();

            Console.Title = "Спринт #4 | Выполнил: Сизиков С. С. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #29                                                            *");
            Console.WriteLine("* Выполнил: Сизиков С. С. | РППб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 9 подсчитать произведение   *");
            Console.WriteLine("* четных элементов массива.                                               *");
            Console.WriteLine("* С клавиатуры: 5, 3, 3, 4, 1, 3, 3, 5, 6, 2, 7, 2, 1, 8                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int N;
            Console.Write("Количество элементов в массиве: ");
            do
            {
                N = Convert.ToInt32(Console.ReadLine());
                if (N < 0) Console.Write("Введите неотрицательное число: ");
            } while (N < 0);
            Console.WriteLine();

            int[] mass = new int[N];
            for (int i = 0; i < mass.Length; i++)
            {
                do
                {
                    Console.Write("Введите " + (i + 1) + " элемент массива: ");
                    mass[i] = Convert.ToInt32(Console.ReadLine());
                    if ((mass[i] < 1) || (mass[i] > 9)) Console.WriteLine("Элементы массива должны быть в промежутке [1,9].");
                } while ((mass[i] < 1) || (mass[i] > 9));
            }

            Console.Write("\nМассив: ");
            for (int i = 0; i < mass.Length; i++) Console.Write(mass[i] + ", ");
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение нечётных элементов массива: " + ds.Calculate(mass));

            Console.ReadLine();
        }
    }
}
