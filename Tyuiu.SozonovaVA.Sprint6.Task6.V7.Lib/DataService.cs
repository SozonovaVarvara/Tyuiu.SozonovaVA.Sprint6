using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SozonovaVA.Sprint6.Task6.V7.Lib
{
    public class DataService : ISprint6Task6V7
    {
        public string CollectTextFromFile(string path)
        {
            string res = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                string[] fragments;
                while ((line = reader.ReadLine()) != null)
                {
                    fragments = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (fragments.Length > 2)
                    {
                        res += fragments[2] + " ";
                    }
                }
            }
            return res.Trim();
        }
    }
}
