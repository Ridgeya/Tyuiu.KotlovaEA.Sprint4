using Tyuiu.KotlovaEA.Sprint4.Task3.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Котлова Е.А. | АСОиУБ-26-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы                                                 *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнила: Котлова Елизавета Алексеевна | АСОиУБ-26-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[,] mtrx = new int[5, 5]
        {
            { 3, 4, 3, 4, 1 },
            { 8, 1, 6, 6, 9 },
            { 9, 8, 5, 1, 3 },
            { 1, 8, 7, 1, 2 },
            { 9, 9, 7, 5, 6 }
        };

        int rows = mtrx.GetUpperBound(0) + 1;
        int columns = mtrx.Length / rows;

        Console.WriteLine("Массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{mtrx[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Сумма элементов в последнем столбце = " + ds.Calculate(mtrx));

        Console.ReadKey();
    }
}