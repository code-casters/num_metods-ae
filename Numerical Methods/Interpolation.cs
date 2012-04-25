using System;

namespace Numerical_Methods
{
    public class Interpolation
    {
        public Interpolation()
        {
        }
       /* public static double[,] CreatPdiffTable(double[,] pointsTable)
        {
            double[,] PdiffTable = new double[pointsTable.GetLength(1) - 1, pointsTable.GetLength(1) - 1];

        }*/
        public static double CalcPdiff(double[,] pointsTable, int rank, int index)
        {
            double ans = 0;
            for (int k = 0; k <= rank; k++)
            {
                double s = Interpolation.Factorial(rank) / (Interpolation.Factorial(rank - k) * Interpolation.Factorial(k));
                ans += s * Math.Pow(-1, k) * pointsTable[1, index + rank - k];
            }
            return ans;
        }
        public static double Factorial(double num)
        {
            if (num == 1 || num == 0)
            {
                return 1;
            }
            else
            {
                return Factorial(num - 1) * num;
            }
        }
       /* public static double Lagrange(double [,] pointsTable)
        {
            double sum = 0, l;
            for (int i = 0; i < pointsTable.GetLength(1); i++)
            {
                l = 1;
                for (int j = 0; j < pointsTable.GetLength(1); j++)
                {
                    l *= (x - pointsTable[0, j])/(pointsTable[0, 0] - pointsTable[0, i]);
                }
                sum += pointsTable[1, i]*l;
            }
            return sum;
        }*/
    }
}

