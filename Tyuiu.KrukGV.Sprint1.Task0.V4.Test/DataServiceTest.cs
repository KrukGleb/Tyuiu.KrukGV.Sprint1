using Tyuiu.KrukGV.Sprint1.Task0.V4.Lib;

namespace Tyuiu.KrukGV.Sprint1.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();

            Assert.AreEqual(6, res);
        }
    }
}
