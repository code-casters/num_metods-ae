using System.Collections.Generic;
using nume_metodsae;

namespace Numerical_Methods
{
	public class MathBinaryTree
	{	  
		private List<MathNode> Body = new List<MathNode>(); 
		private Stack<MathNode> AuxStack = new Stack<MathNode>();

		public MathBinaryTree ()
		{
			
		}
		public static void Parsing (string PostfixExp , params char[] VarNames){
			for (int i = 0; i < PostfixExp.Length; i++) {
				int num ;
				while (double.TryParse(PostfixExp[i],out num) || PostfixExp[i] == '.' ) {
					i++;
				}
			}
		}
        private bool IsOp(string pop,out Operator op)
        {
            bool res = Operator.TryParse(pop, out op);
            if(!res)
            {
                switch (pop)
                {
                    case "*" :
                        op = Operator.Mult;
                        return true;
                    case "/" :
                        op = Operator.Div;
                        return true;
                    case "%" :
                        op = Operator.Mod;
                        return true;
                    case "+" :
                        op = Operator.Sum;
                        return true;
                    case "-" :
                        op = Operator.Sub;
                        return true;
                }
            }
            return res;
        }

	}
}

