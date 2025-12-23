using Tyuiu.SozonovaVA.Sprint6.Task6.V7.Lib;
namespace Tyuiu.SozonovaVA.Sprint6.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"C:\DataSprint6\InPutDataFileTask6V7.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
