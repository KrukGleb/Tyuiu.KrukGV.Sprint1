
using Tyuiu.KrukGV.Sprint1.Task4.V11.Lib;

namespace Tyuiu.KrukGV.Sprint1.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(4, 0.3);

            Assert.AreEqual(0.982, res);
        }
    }
}
