using Tyuiu.SizikovSS.Sprint4.Task0.V22.Lib;

namespace Tyuiu.SizikovSS.Sprint4.Task0.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new();

            Console.Title = "Спринт #4 | Выполнил: Сизиков С. С. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Сизиков С. С. | РППб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму          *");
            Console.WriteLine("* нечетных элементов массива. {9, 5, 7, 4, 5, 3, 7, 8, 9, 1}              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] mass = [4, 8, 7, 6, 5, 8, 2, 4, 3, 2];

            Console.Write("Массив: ");
            for (int i = 0; i < mass.Length; i++) Console.Write(mass[i] + ", ");
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма нечётных элементов массива: " + ds.GetSumOddArrEl(mass));

            Console.ReadLine();
        }
    }
}
