using Tyuiu.KravchenkoDS.Sprint4.Task3.V29.Lib;



namespace Tyuiu.KravchenkoDS.Sprint4.Task3.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[5, 5] { { 9, 9, 8, 6, 9 },
                                          { 5, 8, 8, 8, 7 },
                                          { 6, 5, 9, 7, 9 },
                                          { 7, 7, 9, 7, 8 },
                                          { 8, 5, 8, 5, 5 } };

            int rows = mtrx.GetUpperBound(0) + 1;  
            int columns = mtrx.Length / rows;      
           

            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Кравченко Д. С. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнила: Кравченко Дарья Сергеевна | ИСТНб-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 5 до 9. Найдите произведение       *");
            Console.WriteLine("* элементов в первом столбце массива.                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

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

            int res = ds.Calculate(mtrx);

            Console.WriteLine("Произведение элементов первого столбца = " + res);

            Console.ReadKey();
        }
    }
}
