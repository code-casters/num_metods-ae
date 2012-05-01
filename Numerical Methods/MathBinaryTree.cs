using System.Collections;
using nume_metodsae;

namespace Numerical_Methods
{
	public class MathBinaryTree
	{	
		
		private ArrayList Nodes = new ArrayList(); 

		public MathBinaryTree ()
		{
			
		}
		
		public MathBinaryTree (double num)
		{
			MathNode tmp = new MathNode(num);
			Nodes.Add(tmp);
		}
		public object this [int index] {
			get {
				MathNode tmp = (MathNode)Nodes[index] ;
				if (tmp.Num != double.NaN)
				{
					return (object)tmp.Num;
				}
				else if (tmp.Varname != '\0') 
				{
					return (object)tmp.Varname;
				}
				else {
					return (object)tmp.Op;
				}
			}
			set {
				MathNode tmp = (MathNode)Nodes[index] ; // shallow copy 
				
			}
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
		
		public int addLnode(char varname , int Pid)
		{  // this for var name .
			MathNode tmp = new	MathNode(varname);
			tmp.ParentId = Pid;
			int NodeId = Nodes.Add(tmp); // tmp is no longer needed
			tmp = (MathNode)Nodes[Pid]; // set the left child of node's parent.
			tmp.Lchild = NodeId;
			return NodeId;
		}
		
		public int addLnode(double num , int Pid)
		{  // This for numrical value .
			MathNode tmp = new	MathNode(num);
			tmp.ParentId = Pid;
			int NodeId = Nodes.Add(tmp); // tmp is no longer needed
			tmp = (MathNode)Nodes[Pid]; // set the left child of node's parent.
			tmp.Lchild = NodeId; // tmp is copied by refernce so any will be applied .
			return NodeId;
		}
		
		public int addLnode(Operator op , int Pid)
		{  // this for Operator.
			MathNode tmp = new	MathNode(op);
			tmp.ParentId = Pid;
			int NodeId = Nodes.Add(tmp); // tmp is no longer needed
			tmp = (MathNode)Nodes[Pid]; // set the left child of node's parent.
			tmp.Lchild = NodeId; // tmp is copied by refernce so any will be applied .
			return NodeId;
		}
		
	    public int addRnode(char varname , int Pid)
		{  // this for var name .
			MathNode tmp = new	MathNode(varname);
			tmp.ParentId = Pid;
			int NodeId = Nodes.Add(tmp); // tmp is no longer needed
			tmp = (MathNode)Nodes[Pid]; // set the left child of node's parent.
			tmp.Rchild = NodeId; // tmp is copied by refernce so any will be applied .
			return NodeId;
		}
		
		public int addRnode(double num , int Pid)
		{  // This for numrical value.
			MathNode tmp = new	MathNode(num);
			tmp.ParentId = Pid;
			int NodeId = Nodes.Add(tmp); // tmp is no longer needed
			tmp = (MathNode)Nodes[Pid]; // set the left child of node's parent.
			tmp.Rchild = NodeId; // tmp is copied by refernce so any will be applied .
			return NodeId;
		}
		
		public int addRnode(Operator op , int Pid)
		{  // this for operator.
			MathNode tmp = new	MathNode(op);
			tmp.ParentId = Pid;
			int NodeId = Nodes.Add(tmp); // tmp is no longer needed
			tmp = (MathNode)Nodes[Pid]; // set the left child of node's parent.
			tmp.Rchild = NodeId; // tmp is copied by refernce so any will be applied .
			return NodeId;
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

