
using Tyuiu.KrukGV.Sprint1.Task1.V5.Lib;

namespace Tyuiu.KrukGV.Sprint1.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(7,3);

            Assert.AreEqual(12, res);
        }
    }
}
