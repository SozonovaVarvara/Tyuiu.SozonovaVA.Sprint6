using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SozonovaVA.Sprint6.Task1.V2.Lib
{
    public class DataService : ISprint6Task1V2
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double fx = 0.0;

                double denominator = Math.Sin(x) + 2;

                if (denominator == 0)
                {
                    fx = 0.0;
                }
                else
                {
                    fx = (5.0 * x + 2.5) / denominator + 2.0 * x + 2.0;
                }

                fx = Math.Round(fx, 2);
                result[index] = fx;
                index++;
            }

            return result;

        }
    }
}
