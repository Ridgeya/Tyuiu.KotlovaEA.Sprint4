using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KotlovaEA.Sprint4.Task3.V1.Lib
{
    public class DataService : ISprint4Task3V1
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                sum += array[i, columns - 1];
            }

            return sum;
        }
    }
}
