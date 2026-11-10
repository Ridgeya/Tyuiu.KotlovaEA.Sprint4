using Tyuiu.KotlovaEA.Sprint4.Task0.V9.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Котлова Е.А. | АСОиУБ-26-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы                                                *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #9                                                              *");
        Console.WriteLine("* Выполнила: Котлова Елизавета Алексеевна | АСОиУБ-26-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов                     *");
        Console.WriteLine("* Подсчитать сумму чётных элементов массива.                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] numsArray = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i <= numsArray.Length - 1; i++)
        {
            Console.Write(numsArray[i] + "\t");
        }
        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Сумма чётных элементов = " + ds.GetSumEvenArrEl(numsArray));

        Console.ReadKey();
    }
}