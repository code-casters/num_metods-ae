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
	/*	public static double Lagrange (double[,] pTable)
		{
			for (int i = 0; i < pTable.GetLength(1);i++)
			{
				return pTable[1,i]*Lagrange1Derivative(pTable.GetLength(1),i,Numerical_Methods);
			}
		}
		
		/// <summary>
		/// Lagrange first derivative.
		/// </summary>
		/// <returns>
		/// The derivative.
		/// </returns>
		/// <param name='M'>
		/// Values number.
		/// </param>
		/// <param name='i'>
		/// Lagrange's polynomynal degree.
		/// </param>
		/// <param name='num'>
		/// Entered value.
		/// </param>
		private static double Lagrange1Derivative(int M, int i, double num)
		{
			double [] s = new double[M]();
			for (int c = 0; c < M; c++)
			{
				s[c] = -1+2	*(i-1)/(M-1);
			}
			for (int k = 0; k < M; k++)
			{
				double sum = 0d;
				double mult = 1d;
				if (k != i)
				{
					sum += 1/(s[i]-s[k]);
				}
				for (int j = 0; j < M; j++)
				{
					if ((j != i) && (j != k))
					{
						mult *= (num-s[j])/(s[i]-s[j]);
					}
				}
				return sum*mult;
			}
		}
	*/
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

