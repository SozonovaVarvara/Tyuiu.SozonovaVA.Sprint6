using Tyuiu.SozonovaVA.Sprint6.Task7.V5.Lib;
namespace Tyuiu.SozonovaVA.Sprint6.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = $@"C:\DataSprint6\InPutDataFileTask7V5.csv";
            if (File.Exists(path))
            {
                int[,] result = ds.GetMatrix(path);
                Assert.IsNotNull(result);
            }
        }
    }
}
