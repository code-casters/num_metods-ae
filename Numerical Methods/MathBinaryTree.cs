using System;
using System.Collections;
using System.Collections.Generic;
using Numerical_Methods;

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
		public MathNode this [int index] {
			get 
			{
				return (MathNode)Nodes[index]; ;
			}
			set 
			{
				Nodes[index] = (object)value;
			}
		}
		
	/*	public static void Parsing (string PostfixExp , params char[] VarNames){
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
		public void Build (string[] exp , string varname = "x" ){
			Stack<int> Id_stack = new Stack<int>();
			for (int i = 0; i < exp.Length; i++) {
				MathNode tmp  = new MathNode();
				double res ;
				if (double.TryParse(exp[i],out res)) 
				{
					tmp.Create(res);
				}
				else if (varname.Contains(exp[i])) 
				{
					char t = Convert.ToChar(exp[i]);
					tmp.Create(t);
				}
				else
				{
					int abs_bracket_num = 0 ;
					switch (exp[i]) {
					case "+" :
						tmp.Create(Operator.Sum);
						break;
					case "-" :
						tmp.Create(Operator.Sub);
						break;
					case "*" :
						tmp.Create(Operator.Mult);	
						break;
					case "/" :
						tmp.Create(Operator.Div);
						break;
					case "^" :
						tmp.Create(Operator.Pow);
						break;
					case "%" :
						tmp.Create(Operator.Mod);
						break;
					case "|" :
						if (abs_bracket_num == 0) 
						{
							abs_bracket_num++;
							tmp.Create(Operator.Abs);
						}
						break;
					case "sin" :
						tmp.Create(Operator.Sin);
						break;
					case "cos" :
						tmp.Create(Operator.Cos);
						break;
					case "tan" :
						tmp.Create(Operator.Tan);
						break;
					case "cot" :
						tmp.Create(Operator.Cot);
						break;
					case "sinh" :
						tmp.Create(Operator.Sinh);
						break;
					case "cosh" :
						tmp.Create(Operator.Cosh);
						break;
					case "tanh" :
						tmp.Create(Operator.Tanh);
						break;
					case "asin" :
						tmp.Create(Operator.ASin);
						break;
					case "acos" :
						tmp.Create(Operator.Acos);
						break;
					case "atan" :
						tmp.Create(Operator.Atan);
						break;
					case "ln" :
						tmp.Create(Operator.Ln);
						break;
					case "log" :
						tmp.Create(Operator.Log);
						break;
					case "sqrt":
						tmp.Create(Operator.Sqrt);
						break;
					case "e" :
						tmp.Create(Operator.Exp);
						break;
					}
				}
				if (tmp.Op != Operator.None) 
				{
					tmp.Rchild = Id_stack.Pop();
					tmp.Lchild = Id_stack.Pop();
				 	int Nid = this.Nodes.Add(tmp);
					this[tmp.Rchild].ParentId = Nid;
					this[tmp.Lchild].ParentId = Nid;
					Id_stack.Push(Nid);
				}
				else
				{
					int Nid = this.Nodes.Add(tmp);
					Id_stack.Push(Nid);
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

