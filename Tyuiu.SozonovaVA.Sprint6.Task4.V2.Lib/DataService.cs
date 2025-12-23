using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SozonovaVA.Sprint6.Task4.V2.Lib
{
    public class DataService : ISprint6Task4V2
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] arr = new double[length];

            for (int i = 0; i < length; i++)
            {
                double x = startValue + i;
 
                if (Math.Abs(x - 0.7) < 1e-10)
                {
                    arr[i] = 0;
                }
                else
                {
                    double numerator = Math.Cos(x);
                    double denominator = x - 0.7;
                    double part1 = numerator / denominator;
                    double part2 = Math.Sin(x) * 12 * x;
                    double result = part1 - part2 + 2;

                    arr[i] = Math.Round(result, 2);
                }
            }

            return arr;
        }
    }
}
