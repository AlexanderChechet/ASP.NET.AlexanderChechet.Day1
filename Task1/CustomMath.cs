using System;

namespace Task1
{
    public static class CustomMath
    {
        public static double Pow(double number, int power, double accuracy)
        {
            if (power <= 0)
                throw new ArgumentNullException();
            if (number < 0 && power % 2 == 0)
                throw  new ArgumentException();
            double x0;
            double x1 = 1;
            do
            {
                x0 = x1;
                x1 = ((power - 1)*x0 + number/Math.Pow(x0, power - 1))/power;
            } while (Math.Abs(x1 - x0) > accuracy);
            return x1;
        }

    }
}
