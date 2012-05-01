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
        public void Build(string[] mathexp)
        {
            for (int i = 0; i < mathexp.GetLength(0) ; i++)
            {
                double num;
                Operator op;
                if (IsNum(mathexp[i],out num))
                {
                    MathNode tmp = new MathNode(num);
                    AuxStack.Push(tmp);
                }
                else if(IsOp(mathexp[i],out op))
                {
                     MathNode tmp = new MathNode(op);
                     tmp.Children.Add(AuxStack.Pop());
                     tmp.Children.Add(AuxStack.Pop());
                     AuxStack.Push(tmp);
                }
            }
        }

        private static bool IsNum(string pnum,out double num)
        {
            bool res = double.TryParse(pnum, out num);
            return res;
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
        //Function returns equation's rank
        public byte Rank()
        {
            return 1;
        }
        //Function returns equation's degree
        public byte Degree()
        {
            return 1;
        }
	}
}

