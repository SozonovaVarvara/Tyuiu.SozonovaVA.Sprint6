using Tyuiu.SozonovaVA.Sprint6.Task0.V17.Lib;
namespace Tyuiu.SozonovaVA.Sprint6.Task0.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(2.718, ds.Calculate(1));
        }
    }
}
