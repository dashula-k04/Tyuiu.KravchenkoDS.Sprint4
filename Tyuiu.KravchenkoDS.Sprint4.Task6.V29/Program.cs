using Tyuiu.KravchenkoDS.Sprint4.Task6.V29.Lib;


namespace Tyuiu.KravchenkoDS.Sprint4.Task6.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Кравченко Д. С. | ИСТНБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:    класс Array                                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнила: Кравченко Дарья Сергеевна | ИСТНБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Дан строковый массив данных (Весна ,Лето, Осень, Зима) используя класс Array*");
            Console.WriteLine("* подсчитайте количество элементов, длина которых больше 4.               *");     
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            var seasons = new string[] { "Весна", "Лето", "Осень", "Зима" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < seasons.Length; i++)
            {
                Console.WriteLine(seasons[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(seasons);

            Console.WriteLine("Количество элементов, длина которых > 4: " + res);

            Console.ReadKey();


        }
    }
}
