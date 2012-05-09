using System;
using Numerical_Methods;

namespace Numerical_Methods
{
    public static class Interpolation
    {
		/// <summary>
		/// Creats the pdiff table.
		/// </summary>
		/// <returns>
		/// The progressive differations table.
		/// </returns>
		/// <param name='pTable'>
		/// Points table.
		/// </param>
		public static double[,] CreatPdiffTable(double[,] pTable)
        	{
			double[,] PdiffTable = new double[pTable.GetLength(1) - 1, pTable.GetLength(1) - 1];
			if (Integration.CheckPointTable(pTable))
			{
				int degree = pTable.GetLength(1);
				for (int i = 0; i < pTable.GetLength(1); i++)
				{
					for (int j = 0; j < degree--; j++)
					{
						PdiffTable[j,i] = CalcPdiff(pTable,i,j);
					}
				}
			}
			return PdiffTable;
	        }
		/// <summary>
		/// Calculates a cell's value in progressive differations table.
		/// </summary>
		/// <returns>
		/// The \Delta^rank y_index.
		/// </returns>
		/// <param name='pTable'>
		/// Points table.
		/// </param>
		/// <param name='rank'>
		/// Rank.
		/// </param>
		/// <param name='index'>
		/// Index.
		/// </param>
		public static double CalcPdiff(double[,] pTable, int rank, int index)
		{
	            double ans = 0;
	            for (int k = 0; k <= rank; k++)
	            {
	                double s = Interpolation.Factorial(rank) / (Interpolation.Factorial(rank - k) * Interpolation.Factorial(k));
	                ans += s * Math.Pow(-1, k) * pTable[1, index + rank - k];
	            }
	            return ans;
	        }
	        
		/// <summary>
		/// Calculationg interpolation by Lagrange method.
		/// </summary>
		/// <param name='pTable'>
		/// Function's values table.
		/// </param>
		public static double Lagrange (double[,] pTable,double num, string func)
		{
			double result = 0d;
			for (int i = 0; i < pTable.GetLength(1);i++)
			{
				result += pTable[1,i] * Lagrange_Dif(pTable,i,pTable[i,0]);//and should be multiplied with the 1st derivative of lagrange polynomial

			}
			return result;
		}
		public static double Lagrange_Dif(double[,] pTable ,int num,double Val)
		{
			int m = pTable.GetLength(1)-1;
			double Fres = 0 ;
			for (int i = 1; i < m ; i++) {
				double s = 1 / (pTable[num,0]-pTable[i,0]);
				double res = 1 ;
				for (int j = 0; j < m; j++) {
					if (j!=m || j!=i) {
						res *= (Val-pTable[j,0])/(pTable[num,0]-pTable[j,0]);
					}
				}
				res *= s ;
				Fres += res;
			}
			return Fres;
		}
		/// <summary>
		/// Calculates the factorial for the specified num.
		/// </summary>
		/// <param name='num'>
		/// Number.
		/// </param>
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
    }
}

