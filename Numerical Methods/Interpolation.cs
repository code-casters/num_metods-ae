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
			if (Integration.CheckPointTable(pTable))
			{
            double[,] PdiffTable = new double[pointsTable.GetLength(1) - 1, pointsTable.GetLength(1) - 1];
			int degree = pTable.GetLength(1);
			for (int i = 0; i < pTable.GetLength(1); i++)
			{
				for (int j = 0; j < degree--; j++)
				{
					PdiffTable[j,i] = CalcPdiff(pTable,i,j);
				}
			}
			return PdiffTable;
			}
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
       /*public static double Lagrange(double [,] pointsTable)
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

