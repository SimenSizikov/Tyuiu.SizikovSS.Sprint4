using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SizikovSS.Sprint4.Task2.V2.Lib
{
    public class DataService : ISprint4Task2V2
    {
        public int Calculate(int[] array)
        {
            int p = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0) p *= array[i];
            }
            return p;
        }
    }
}
