﻿namespace AljabarLibraries
{
    public class Kuadrat
    {
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double d = b * b - 4 * a * c;

            if (d >= 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 *a);

                return new double[] { x1, x2 };
            } else
            {
                return new double[] { 0, 0 };
            }
        }

        public static double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];

            double c = a * a;
            double d = -2 * a * b;
            double e = b * b;

            return new double[] { c, d, e };
        }
    }
}
