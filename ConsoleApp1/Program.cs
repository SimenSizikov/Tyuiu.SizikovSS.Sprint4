namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {  8, 8, 3, 7, 8, 1 };
            int s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0 && array[i] < s)
                    s = array[i];
            }
            Console.WriteLine(s);
        }
    }
}
