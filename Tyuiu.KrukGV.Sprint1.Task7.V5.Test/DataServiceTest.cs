
using Tyuiu.KrukGV.Sprint1.Task7.V5.Lib;

namespace Tyuiu.KrukGV.Sprint1.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(1);

            Assert.AreEqual(-0.888, res);
        }
    }
}
