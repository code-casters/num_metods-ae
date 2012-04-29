using System;
using Numerical_Methods;

namespace Numerical_Methods
{
    public static class Integration
    {
        /// <summary>
        /// Solving the integration by Simpson method.
        /// </summary>
        /// <param name='pTable'>
        /// Two dimensons array contains a set of point to used in integration.
        /// </param>
        public static double Simpson(double[,] pTable)
        {
            if (CheckPointTable(pTable))
            {
                double h = pTable[0, 1] - pTable[0, 0]; // the step between Point.
                int n = pTable.GetLength(1) - 1; // the number of table point (y section ).
                double sum = 0;
                if (n % 2 == 0)
                {
                    for (int i = 0; i <= n; i++)
                    {
                        if (i == 0 || i == n) // Simpson low (f0 & fn) .
                        {
                            sum += pTable[1, i];
                        }
                        else if (i % 2 == 0) // Simpson low pair num mult with 2
                        {
                            sum += (2 * pTable[1, i]);
                        }
                        else
                        {
                            sum += (4 * pTable[1, i]); // Simpson low odd num mult with 4
                        }
                    }
                }
                return h / 3 * sum;
            }
            return -1;
        }

        /// <summary>
        /// Solving the integration by Rectangles method.
        /// </summary>
        /// <param name='pTable'>
        /// Two dimensons array contains a set of point to used in integration.
        /// </param>
        public static double Rects(double[,] pTable)
        {
            //a and b are pTable[0,0] and pTable[0,pTable.GetLength(1)]
            if (pTable.GetLength(1) != 1)
            {
                double sum = 0d;
                for (int i = 0; i < pTable.GetLength(1); i++)
                {
                    sum += pTable[1, i];
                }
                return sum * (pTable[0, pTable.GetLength(1) - 1] - pTable[0, 0]) / pTable.GetLength(1);
            }
            return pTable[1, 0] * (pTable[0, pTable.GetLength(1) - 1] - pTable[0, 0]); //Consider pTable[1,0] = f(a) , pTable[0,0] = a
        }

        /// <summary>
        /// Solving the integration by Trapezoid method.
        /// </summary>
        /// <param name='pTable'>
        /// Two dim array contain set of point to use in integration.
        /// </param>
        public static double Trapezoid(double[,] pTable)
        {
            if (CheckPointTable(pTable))
            {
                double sum = 0d;
                if (pTable.GetLength(1) != 1)
                {
                    for (int i = 1; i < pTable.GetLength(1)-1; i++)
                    {
                        sum += pTable[1, i];
                    }
                    sum *= 2;
                }
                return (sum + pTable[1, pTable.GetLength(1) - 1] + pTable[1, 0]) * (pTable[0, 1] - pTable[0, 0]) / 2;
            }
            return -1;
        }
        public static bool CheckPointTable(double[,] pointTable)
        {
            double len = Math.Round((pointTable[0, 1] - pointTable[0, 0]), 5);
            for (int i = 2; i < pointTable.GetLength(1); i++)
            {
                if (Math.Round(pointTable[0, i] - pointTable[0, i - 1], 5) != len)
                {
                    return false;
                }
            }
            return true;
        }
    }
}