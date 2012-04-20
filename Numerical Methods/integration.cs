using System;
using Numerical_Methods;

namespace Numerical_Methods
{
    public class Integration
    {
        public Integration()
        {
        }
		/// <summary>
		/// Solving the integration by Sempson method .
		/// </summary>
		/// <param name='pointTable'>
		/// two dim array contain set of point to use in integration.
		/// </param>
        public static double Sempson(double[,] pointTable)
        {
			if (Integration.CheckPointTable(pointTable)){
	            double h = pointTable[0, 1] - pointTable[0, 0]; // the step between Point.
	            int n = pointTable.GetLength(1) - 1; // the number of table point (y section ).
	            double sum = 0;
	            if (n % 2 == 0)
	            {
	                for (int i = 0; i <= n; i++)
	                {
	                    if (i == 0 || i == n) // Sempson low (f0 & fn) .
	                    {
	                        sum += pointTable[1, i];
	                    }
	                    else if (i % 2 == 0) // Sempson low pair num mult with 2
	                    {
	                        sum += (2 * pointTable[1, i]);
	                    }
	                    else
	                    {
	                        sum += (4 * pointTable[1, i]); // Sempson low odd num mult with 4
	                    }
	                }
	            }
	            return h / 3 * sum;
			}
			else {
				return -1 ;
			}
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
		public static bool CheckPointTable(double[,] PointTable){
			double len = Math.Round((PointTable[0,1] - PointTable[0,0]),5);
			for (int i = 2; i < PointTable.GetLength(1)  ; i++) {
				if(Math.Round(PointTable[0,i] - PointTable[0,i-1],5) != len){
					return false ;
				}
			}
			return true ;
		}
    }
}