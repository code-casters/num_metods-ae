using System.Collections.Generic;
using nume_metodsae;

namespace Numerical_Methods
{
	public class MathBinaryTree
	{	  
		private List<MathNode> Nodes = new List<MathNode>(); 

		public MathBinaryTree ()
		{
			
		}
		/*public static void Parsing (string PostfixExp , params char[] VarNames){
			Stack<MathNode> PexStack = new Stack<MathNode>();
			for (int i = 0; i < PostfixExp.Length; i++) {
				if (double.TryParse(PostfixExp[i],out num) || PostfixExp[i] == '.' ) {
					int num ;
					string Dnum = string.Empty;
					while (double.TryParse(PostfixExp[i],out num) || PostfixExp[i] == '.' ) {
						Dnum += PostfixExp[i];
						i++;
					}
					i--;
					MathNode tmp = new MathNode(double.Parse(Dnum));
					PexStack.Push(tmp);
				}
			}
		}*/
		public int addLnode(object val , int Pid)
		{
			MathNode tmp = new	MathNode(val);
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

