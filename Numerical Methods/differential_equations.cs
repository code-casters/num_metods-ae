using System;
using Numerical_Methods;

namespace Numerical_Methods
{
    public static class DifferentialEquations
    {
        public static double Tailor(MathBinaryTree eq, double[,] pTable , int rank)
        {
			double h = pTable[0,1]-pTable[0,0];
            if (rank == 0) {
				return pTable[1,0];
            }
			else {
				return 0;
			}
		}

    }
}

