using Tyuiu.KravchenkoDS.Sprint4.Task7.V18.Lib;


namespace Tyuiu.KravchenkoDS.Sprint4.Task7.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rows = 5;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "145258749635789";
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Кравченко Д. С. | ИСТНБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:  Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Кравченко Дарья Сергеевна | ИСТНБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Дана строка из одноразрядных цифр 145258749635789.        Преобразуйте ее*");
            Console.WriteLine("* в матрицу 5 на 3 и подсчитайте произведение четных чисел                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int index = 0;
            Console.WriteLine("\nМассив");
           
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = ds.Calculate(rows, columns, str);
            Console.WriteLine("Произведение четных чисел = " + res);

            Console.ReadKey();
        }
    }
}

