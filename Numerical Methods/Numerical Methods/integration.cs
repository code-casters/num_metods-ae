using System;
using Numerical_Methods;

namespace Numerical_Methods
{
    public class Integration
    {
        public Integration()
        {
        }
        public static double Sempson(double[,] pointTable)
        {
            double h = pointTable[0, 1] - pointTable[0, 0];
            int n = pointTable.GetLength(1) - 1;
            double sum = 0;
            if (n % 2 == 0)
            {
                for (int i = 0; i <= n; i++)
                {
                    if (i == 0 || i == n)
                    {
                        sum += pointTable[1, i];
                    }
                    else if (i % 2 == 0)
                    {
                        sum += (2 * pointTable[1, i]);
                    }
                    else
                    {
                        sum += (4 * pointTable[1, i]);
                    }
                }
            }
            return h / 3 * sum;
        }
        public static double Rects(double[,] pTable, double a, double b, int rangesNum = 1)
        {
            if (rangesNum != 1)
            {
                double sum = 0d;
                for (int i = 0; i < rangesNum; i++)
                {
                    sum += pTable[1, i];
                }
                return sum * (b - a) / rangesNum;
            }
            return pTable[0, 1] * (b - a);
        }
        public static double Trapezoid(double[,] pTable, double a, double b, int rangesNum = 1)
        {
            if (rangesNum != 1)
            {
                double sum = 0d;
                for (int i = 0; i < rangesNum; i++)
                {
                    sum += pTable[1, i];
                }
                return (2 * sum - pTable[1, 0] - pTable[1, pTable.GetLength(0) - 1]) * (b - a) / 2;
            }
            return (b + a) * (b - a) / 2;
        }
    }
}