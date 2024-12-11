namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {  5, 7, 5, 9, 2, 3 };
            int m = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                    m += array[i];
            }
            Console.WriteLine(m);
        }
    }
}
