using System;

namespace nume_metodsae
{
	public class integration
	{
		public integration ()
		{
		}
		public static double Sempson(double[,] PointTable){
			double h = PointTable[0,1] - PointTable[0,0] ;
			int n = PointTable.GetLength(1)-1;
			double sum = 0 ;
			if(n % 2 == 0){
				for (int i = 0; i <= n; i++) {
					if(i == 0 || i == n ){
						sum += PointTable[1,i];
					}
					else if ( i % 2 == 0) {
						sum += (2*PointTable[1,i]);
					}
					else {
						sum += (4*PointTable[1,i]);
					}
						
				}
			}
			return h/3 * sum ;
		}
	}
}