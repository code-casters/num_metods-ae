using System;
using System.Collections;
using System.Collections.Generic;
using Numerical_Methods;

namespace Numerical_Methods
{
	public class MathBinaryTree
	{	
		public int Root {set;get;}
		private ArrayList Nodes = new ArrayList(); 
		
		public MathBinaryTree ()
		{
		
		}
		public MathBinaryTree (double num)
		{
			MathNode tmp = new MathNode(num);
			Nodes.Add(tmp);
		}
		public MathBinaryTree (string exp,string varname = "x")
		{
			this.Parsing(exp,varname);
		}
		public MathNode this [int index] {
			get 
			{
				return (MathNode)Nodes[index];
			}
			set 
			{
				Nodes[index] = (object)value;
			}
		}
		
		public  void Parsing (string exp, string varname="x"){
			string[] Split_str = Split(exp,varname);
			string[] postfix = Postfix(Split_str);
			Build(postfix,varname);
		}
		
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
		private void Build (string[] exp , string varname = "x" ){
			Stack<int> Id_stack = new Stack<int>();
			for (int i = 0; i < exp.Length; i++) {
				if (exp[i] != null) {
					MathNode tmp  = new MathNode();
					double res ;
					if (double.TryParse(exp[i],out res)) // if it was a double
					{
						tmp.Create(res);
					}
					else if (varname.Contains(exp[i])) // if it was a var name
					{
						char t = Convert.ToChar(exp[i]);
						tmp.Create(t);
					}
					else 
					{   //check if it an operator
						int abs_bracket_num = 0 ;// for check for ||
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
					}//end checking of operator
					if (tmp.Op != Operator.None) 
					{
						/*if it was an op put two of stack node as 
						 * left and right child
						 * set thire Pid
						 * finally push the new tree to the stack
						*/
						if (Id_stack.Count > 0) {
							tmp.Rchild = Id_stack.Pop();	
						}
						if (Id_stack.Count > 0) {
							tmp.Lchild = Id_stack.Pop();	
						}
					 	int Nid = this.Nodes.Add(tmp);
						if (tmp.Rchild != -1) {
							this[tmp.Rchild].ParentId = Nid;	
						}
						if (tmp.Lchild != -1) {
							this[tmp.Lchild].ParentId = Nid;	
						}
						Id_stack.Push(Nid);
						if (tmp.ParentId == -1) {
							this.Root = Nid;
						}
					}
					else
					{
						//creat a new node and push it to the stack
						int Nid = this.Nodes.Add(tmp);
						Id_stack.Push(Nid);
					}	
				}
			}
		}
		public void Clone(MathBinaryTree Original)
		{
			this.Nodes.Clear();
			foreach (MathNode Node in Original.Nodes) {
				MathNode t = new MathNode();
				t = Node.Clone();
				this.Nodes.Add(t);
			}
			this.Root = Original.Root;
		}
		/// <summary>
		/// Eval the specified value of function.
		/// </summary>
		/// <param name='val'>
		/// Value.
		/// </param>
		public double Eval (double val)
		{
			double res = 0 ;
			MathBinaryTree tmpTree = new MathBinaryTree();
			tmpTree.Clone(this);
			for (int i = 0; i < Nodes.Count; i++) {
				if (this[i].Op != Operator.None) {
					switch (this[i].Op) {
					case Operator.Pow:
						res = Math.Pow(this[this[i].Lchild].Num,this[this[i].Rchild].Num) ;
						this[i].Create(res,this[i].ParentId);
						break;
					case Operator.Mult :
						res = this[this[i].Lchild].Num * this[this[i].Rchild].Num ;
						this[i].Create(res,this[i].ParentId);
						break;
					case Operator.Sum :
						res = this[this[i].Lchild].Num + this[this[i].Rchild].Num ;
						this[i].Create(res,this[i].ParentId);
						break;
					case Operator.Sub :
						res = this[this[i].Lchild].Num - this[this[i].Rchild].Num ;
						this[i].Create(res,this[i].ParentId);
						break;
					case Operator.Div:
					res = this[this[i].Lchild].Num / this[this[i].Rchild].Num ;
						this[i].Create(res,this[i].ParentId);
						break;
					case Operator.Abs:
						res = Math.Abs(this[this[i].Rchild].Num);
						this[i].Create(res,this[i].ParentId);
						break;
					case Operator.Acos:
						res = Math.Acos(this[this[i].Rchild].Num);
						this[i].Create(res,this[i].ParentId);
						break;
					case Operator.Cos:
						res = Math.Cos(this[this[i].Rchild].Num);
						this[i].Create(res,this[i].ParentId);
						break;
					case Operator.ASin:
						res = Math.Asin(this[this[i].Rchild].Num);
						this[i].Create(res,this[i].ParentId);
						break;
					case Operator.Atan:
						res = Math.Atan(this[this[i].Rchild].Num);
						this[i].Create(res,this[i].ParentId);
						break;
					case Operator.Cosh:
						res = Math.Cosh(this[this[i].Rchild].Num);
						this[i].Create(res,this[i].ParentId);
						break;
					case Operator.Sin:
						res = Math.Sin(this[this[i].Rchild].Num);
						this[i].Create(res,this[i].ParentId);
						break;
					case Operator.Tan:
						res = Math.Tan(this[this[i].Rchild].Num);
						this[i].Create(res,this[i].ParentId);
						break;
					case Operator.Cot:
						res = 1/Math.Tan(this[this[i].Rchild].Num);
						this[i].Create(res,this[i].ParentId);
						break;
					case Operator.Ln:
						res = Math.Log(this[this[i].Rchild].Num);
						this[i].Create(res,this[i].ParentId);
						break;
					case Operator.Exp:
						res = Math.Exp(this[this[i].Rchild].Num);
						this[i].Create(res,this[i].ParentId);
						break;
					}
					
				}
				else if (this[i].Varname != '\0') {
					this[i].Varname = '\0';
					this[i].Num = val;
				}
			}
			this.Clone(tmpTree);
			return res ;
		}
		
		private string[] Split(string exp , string varname)
		{
			int j = 0 ;
			string[] spstr = new string[exp.Length];
			for (int i = 0; i < exp.Length ; i++) 
			{
				if ((char.IsDigit(exp[i]) || exp[i] == '.') || (i==0 && exp[i] == '-') ) {
					spstr[j] = exp[i].ToString();
					i++;
					while( i < exp.Length  && (char.IsDigit(exp[i]) || exp[i] == '.') )
					{
						spstr[j]+=exp[i].ToString();
						i++;
					}
					i--;
				}
				else if (varname.Contains(exp[i].ToString()))
				{
					spstr[j] = exp[i].ToString();
				}
				else if (exp[i] == '+' || exp[i] == '-' || exp[i] == '*' || exp[i] == '/' || exp[i] == '%' || exp[i] == '|' 
				         || exp[i] == '^' )
				{
					spstr[j] = exp[i].ToString();
				}
				else if (exp[i] == '(' || exp[i] == ')' ) 
				{
					spstr[j] = exp[i].ToString();
				}
				else 
				{
					spstr[j] = exp[i].ToString();
					i++;
					while(i < exp.Length && exp[i] != '(')
					{
						spstr[j] += exp[i].ToString();
						i++;
					}
					i--;
				}
				j++;
			}
			int n = 0 ;
			for (int i = 0; i < spstr.Length; i++) {
				if (spstr[i] != null) {
					n++;
				}
			}
			string[] Fstr = new string[n];
			int j1 = 0;
			for (int i = 0; i < spstr.Length; i++) {
				if (spstr[i] != null) {
					Fstr[j1]=spstr[i];
					j1++;
				}
			}
			return Fstr;
		}
		private string[] Postfix(string[] infix ){
			Stack<string> aux = new Stack<string>();
			string[] postfix  = new string[infix.Length];
			int j  = 0;
			for (int i = 0; i < infix.Length; i++) {
				if (infix[i] == "+" || infix[i] == "-" || infix[i] == "*" || infix[i] == "/"
				    || infix[i] == "|" || infix[i] == "sin" || infix[i] == "cos" || infix[i] == "tan"
				    || infix[i] == "ln" || infix[i] == "cot" || infix[i] == "^"
				    ) {
					if (aux.Count == 0) {
						aux.Push(infix[i]);
					}
					else if (precedence(aux.Peek()) == precedence(infix[i])) {
						postfix[j]= aux.Pop();
						j++;
						aux.Push(infix[i]);
					}
					else if (precedence(aux.Peek()) < precedence(infix[i])) {
						aux.Push(infix[i]);
					}
					else {
						while ( (aux.Count > 0) && (precedence(aux.Peek()) > precedence(infix[i]))) {
							postfix[j] = aux.Pop();
							j++;
						}
						aux.Push(infix[i]);
					}
				}
				else if (infix[i] == "(") {
					string[] subPostfix = new string[infix.Length] ;
					int j1 = 0;
					int Bnum = 1 ;
					i++;
					while ((Bnum != 0) && (i < infix.Length)) {
						if (infix[i] == "(") {
							Bnum ++;
							subPostfix[j1] = infix[i];
						}
						else if (infix[i] == ")") {
							Bnum -- ;
							if (Bnum != 0) {
								subPostfix[j1] = infix[i];
							}
						}
						else {
							subPostfix[j1] = infix[i];
						}
						i++;
						j1++;
					}
					i--;
					subPostfix = Postfix(subPostfix);
					for (int k = 0; k < subPostfix.Length ; k++) {
						if (subPostfix[k] != null) {
							postfix[j]=subPostfix[k];
							j++;
						}
					}
				}
				else {
					postfix[j]= infix[i];
					j++;
				}
			}
			while (aux.Count > 0) {
				postfix[j] = aux.Pop();
				j++;
			}
			int n = 0 ;
			for (int i = 0; i < postfix.Length; i++) {
				if (postfix[i] != null) {
					n++;
				}
			}
			string[] Fpostfix = new string[n];
			int j2 = 0;
			for (int i = 0; i < postfix.Length; i++) {
				if (postfix[i] != null) {
					Fpostfix[j2]=postfix[i];
					j2++;
				}
			}
			return Fpostfix;
		}
		private int precedence (string op){
			if (op == "+" || op == "-") {
				return 1 ;
			}
			else if(op == "*" || op == "/" || op == "^") {
				return 2 ;
			}
			else 
				return 3 ;
		} 
		}
}
