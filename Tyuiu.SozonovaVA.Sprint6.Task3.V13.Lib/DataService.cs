using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SozonovaVA.Sprint6.Task3.V13.Lib
{
    public class DataService : ISprint6Task3V13
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i + 1; j < matrix.GetLength(0); j++)
                {
                    if (matrix[j, 1] < matrix[i, 1])
                    {
                        int temp = matrix[i, 1];
                        matrix[i, 1] = matrix[j, 1];
                        matrix[j, 1] = temp;
                    }
                }
            }
            return matrix;
        }
    }
}
