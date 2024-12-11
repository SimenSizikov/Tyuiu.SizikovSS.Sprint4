namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 4, 3, 7, 5, 9 };
            int s = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0 && array[i] < s)
                    s= array[i];
            }
            Console.WriteLine(s);
        }
    }
}
