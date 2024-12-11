namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { { -1, 2,  3 }, {  4, -5,  6}, { 7,-8 , 9 } };
            int s = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        s += array[i, j];
                    }
                }
            }
            Console.WriteLine(s);
        }
    }
}
