using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KotlovaEA.Sprint4.Task2.V1.Lib
{
    public class DataService : ISprint4Task2V1
    {
        public int Calculate(int[] array)
        {
            int multArray = 1;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    multArray *= array[i];
                }
            }
            return multArray;
        }
    }
}
