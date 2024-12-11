using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SizikovSS.Sprint4.Task3.V15.Lib
{
    public class DataService : ISprint4Task3V15
    {
        public int Calculate(int[,] array)
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, array.GetLength(1) - 1] % 2 != 0)
                    count++;
            }
            return count;
        }
    }
}
