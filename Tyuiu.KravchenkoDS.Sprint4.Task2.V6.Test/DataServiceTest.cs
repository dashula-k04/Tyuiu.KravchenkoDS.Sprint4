using Tyuiu.KravchenkoDS.Sprint4.Task2.V6.Lib;



namespace Tyuiu.KravchenkoDS.Sprint4.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

           
            int[] numsArray = { 3, 4, 5, 2, 7, 6, 3, 4, 5, 2, 7, 6, 3, 4, 5 };
            int res = ds.Calculate(numsArray);

            int wait = 165375;

            Assert.AreEqual(wait, res);


        }
    }
}
