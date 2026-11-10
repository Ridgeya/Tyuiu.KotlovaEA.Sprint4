using Tyuiu.KotlovaEA.Sprint4.Task4.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Котлова Е.А. | АСОиУБ-26-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнила: Котлова Елизавета Алексеевна | АСОиУБ-26-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите количество строк в массиве: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество столбцов в массиве: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        int[,] mtrx = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Введите {i},{j} элемент массива: ");
                mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nИсходный массив:");
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

        int[,] res = ds.Calculate(mtrx);

        Console.WriteLine("Массив после замены нечётных элементов на 0:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{res[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}