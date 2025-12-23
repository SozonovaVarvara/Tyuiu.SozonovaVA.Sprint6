using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SozonovaVA.Sprint6.Task7.V5.Lib
{
    public class DataService : ISprint6Task7V5
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int rows = lines.Length;
            string[] firstLineValues = lines[0].Split(';');
            int cols = firstLineValues.Length;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }
            int lastColumnIndex = cols - 1;
            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, lastColumnIndex] < 2)
                {
                    matrix[i, lastColumnIndex] = 2;
                }
            }

            return matrix;
        }

    }
}
    
