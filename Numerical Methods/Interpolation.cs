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
		public static double Lagrange(double[,] pTable,double num,MathBinaryTree func)
		{
			if (pTable.GetLength(1) != 3){
				double sum = 0d;
				for (int i = 0; i < pTable.GetLength(1);i++)
				{
					sum += pTable[1,i]*func.derivative().eval();//and should be multiplied with the 1st derivative of lagrange polynomial
				}
				return sum;
			}
			else {
				if (Integration.CheckPointTable(pTable)){
					double h = pTable[1,0]-pTable[1,1];
					return 1/(2*h) *(-3*pTable[1,0]+4*pTable[1,1]-pTable[1,2]);
				}
				else {	
					return pTable[1,0]*(2*num-pTable[0,1]-pTable[0,2])/((pTable[0,0]-pTable[0,1])*(pTable[0,0]-pTable[0,2]))+pTable[1,1]*(2*num-pTable[0,0]-pTable[0,2])/((pTable[0,1]-pTable[0,0])*(pTable[0,1]-pTable[0,2]))+pTable[1,2]*(2*num-pTable[0,0]-pTable[0,1])/((pTable[0,2]-pTable[0,0])*(pTable[0,2]-pTable[0,1]));
				}
			}
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

