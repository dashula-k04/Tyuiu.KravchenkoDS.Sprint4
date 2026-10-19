using Tyuiu.KravchenkoDS.Sprint4.Task5.V26.Lib;



namespace Tyuiu.KravchenkoDS.Sprint4.Task5.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
               { { 3, -1, -2, 4, 4 },
                { 2, -2, 2,- 4, 3 },
                { -3, 2, 2,- 3,- 4 },
                { 2, 3, 2, -2, 3 },
                { -4, -2, 2, 2, 3 } };

            int[,] res = ds.Calculate(matrix);

            int[,] wait = new int[5, 5]
                { { 1, -1, -2, 1, 1 },
                { 1, -2, 1,- 4, 1 },
                { -3, 1, 1,- 3,- 4 },
                { 1, 1, 1, -2, 1 },
                { -4, -2, 1, 1, 1 } };

            CollectionAssert.AreEqual(wait, res);

        }
    }
}
