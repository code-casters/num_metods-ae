using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
namespace nume_metodsae
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		    double[,] pt = new double[2,7];	
		    pt[0,0] = 0 ; pt[1,0] = 0 ;
			pt[0,1] = 0.1 ; pt[1,1] = 0.0001 ;
			pt[0,2] = 0.2 ; pt[1,2] = 0.0016 ;
			pt[0,3] = 0.3 ; pt[1,3] = 0.0081 ;
			pt[0,4] = 0.4 ; pt[1,4] = 0.0256 ;
			pt[0,5] = 0.5 ; pt[1,5] = 0.0625 ;
			pt[0,6] = 0.6 ; pt[1,6] = 0.1296 ;
			Console.WriteLine(integration.Sempson(pt));
		}
		
	}
}
