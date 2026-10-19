using Tyuiu.KravchenkoDS.Sprint4.Task6.V29.Lib;



namespace Tyuiu.KravchenkoDS.Sprint4.Task6.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var seasons = new string[] { "Весна", "Лето", "Осень", "Зима" };
            int res = ds.Calculate(seasons);
            int wait = 2;
            Assert.AreEqual(wait, res);


        }
    }
}
