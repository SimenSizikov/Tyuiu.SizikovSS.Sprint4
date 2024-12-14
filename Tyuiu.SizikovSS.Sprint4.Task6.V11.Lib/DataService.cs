using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SizikovSS.Sprint4.Task6.V11.Lib
{
    public class DataService : ISprint4Task6V11
    {
        public int Calculate(string[] array)
        {
            int count = 0;
            foreach (string item in array) if (item.Length == 5) count++;
            return count;
        }
    }
}
