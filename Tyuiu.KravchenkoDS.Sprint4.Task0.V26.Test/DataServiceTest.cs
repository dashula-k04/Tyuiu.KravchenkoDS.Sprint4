using Tyuiu.KravchenkoDS.Sprint4.Task0.V26.Lib;



namespace Tyuiu.KravchenkoDS.Sprint4.Task0.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();
            int[] numsArray = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
            int res = ds.GetSumOddArrEl(numsArray);
            int wait = 41;
            Assert.AreEqual(wait, res);

        }
    }
}
