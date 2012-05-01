using System;
using Numerical_Methods;

namespace Numerical_Methods
{
    public static class DifferentialEquations
    {
        //public static double Tailor(MathBinaryTree eq, int h, double[,] primaryConds)
        //{
        //    if (CheckPrimaryConds(eq, primaryConds))
        //    {
                
        //    }
        //    return -1;
        //}

        private static bool CheckPrimaryConds(MathBinaryTree eq, double[,] primaryConds)
        {
            return primaryConds.GetLength(1) == eq.Rank();
        }

    }
}

