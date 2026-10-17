using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.KravchenkoDS.Sprint4.Task1.V29.Lib
{
    public class DataService : ISprint4Task1V29
    {
        public int Calculate(int[] array)
        {
            int sumArray = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sumArray += array[i];
                }
            }
            return sumArray;
        }
    }
}
