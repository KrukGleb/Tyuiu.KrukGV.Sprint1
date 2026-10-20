
using Tyuiu.KrukGV.Sprint1.Task6.V7.Lib;

namespace Tyuiu.KrukGV.Sprint1.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.DeleteLastLetter("hello world");

            Assert.AreEqual("hello worl", res);
        }
    }
}
