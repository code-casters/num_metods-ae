using System;

namespace Numerical_Methods
{
	public class Interpolation
	{
		public Interpolation ()
		{
		}
		public static double[,] CreatPdiffTable(double[,] PointTable){
			double[,] PdiffTable = new double[PointTable.GetLength(1)-1,PointTable.GetLength(1)-1];
			
		}
		public static double CalcPdiff(double[,] PointTable , int rank , int index){
			double ans = 0 ;
			for (int k = 0; k <=rank; k++) {
				double s =Interpolation.Factorial(rank) / (Interpolation.Factorial(rank-k)*Interpolation.Factorial(k)) ;
			    ans += s*Math.Pow(-1,k) * PointTable[1,index+rank-k];
			}
			return ans ;
		}
		public static double Factorial(double num){
			if (num == 1 || num == 0 ) {
				return 1 ;
			}
			else {
				return Factorial(num-1) * num;
			}
		}
	}
}

