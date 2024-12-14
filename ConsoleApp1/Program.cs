using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[] { "Программирование", "Код", "Класс", "Функция" , "Массив", "Переменная" , "Структура" };
            int count = words.Count(w => w.Length > 5);
            Console.WriteLine(count);
        }
    }
}
