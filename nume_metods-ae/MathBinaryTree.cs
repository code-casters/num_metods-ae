using System;
using System.Collections;
using System.Collections.Generic;
namespace nume_metodsae
{
	public enum Type {
    	None = 0 , // no type x only
		Sin = 1 , // sin()
		Cos = 2 , // Cos()
		Tan = 3 , // Tan()
		Cot = 4 , // Cot()
		Log = 5 , // Log( , )
		Ln  = 6 , // Log( , 2)
		Pow = 7 , // Pow( , )
		Sqrt= 8 , // Sqrt( , 2)
		root= 9 , // root( , )
		Abs = 10 , // ||
		Acos = 11 , // Arcos ()
		ASin = 12 , // Arcsin ()
		Atan = 13 , // Arctan ()
		Sinh = 14 , // Sinh()
		Cosh = 15 , // Cosh()
		Tanh = 16 , // Tanh()
		exp  = 17 , // e()
	}
	public class MathBinaryTree
	{	
		public class MathNode 
		{  
			public double Const; // constant part 3* , 5* , .......
			public double Power; // power part ^2,^3 .......
			public Type type ;   // sin , cos , or None
			public List<MathNode> inner ; // the inner of sin or cos ..... etc .
			public List<MathNode> Children = new List<MathNode>(); //List of nodes contain node children
			 
			public MathNode(){
				this.Create(null);
			}
			
			public MathNode(double cons){
				this.Create(cons);
			}
			
			public MathNode(double cons, double power ){
				this.Create(cons,power);
			}
			
			public MathNode(double cons, double power, Type type ){
				this.Create(cons,power,type);
			}
			
			public MathNode(double cons, double power, Type type, MathNode Inner ){
				this.Create(cons,power,type,Inner);
			}
			
		    public void Create(double cons , double pow = 1 , Type type = 0 , MathNode Inner = null){
				this.Const = cons ;
				this.Power = pow  ;
				this.type  = type ;
				this.inner = Inner;
				this.Children.Add(null);
				this.Children.Add(null);
			}
			
			public void AddInner (MathNode Inner ){
				this.inner = Inner;
			}
			
			public void Addchild(MathNode child , char dir){
				if(dir == 'l' || dir == 'L'){
					this.Children[0] = child;
				}
				else if(dir == 'r' || dir == 'R'){
					this.Children[1] = child ;
				}
			}
			
			public bool isLeaf(){
				if(this.Children[0] == null && this.Children[1] == null){
					return true ;
				}
				else 
					return false;
			}
			
		}
		
		public MathNode Root {set;get;} // Tree root node  
		
		private Stack aux = new Stack();
		
		private List<MathNode> Body = new List<MathNode>(); 
		
		
		private Stack Tstack = new Stack() ;
		
		public MathBinaryTree ()
		{
			
		}
		

		public void Add (MathNode node) {
			this.Body.Add(node);
			this.Body.Add(node.Children[0]);
			this.Body.Add(node.Children[1]);
		}
		
/*		public void Build (string Expression){
		    int i = 0;
			while( i < Expression.Length){
				if(IsInt(Expression[i])){
					string new_num  = Expression[i];
					while(isInt(Expression[i+1]) || Expression[i+1] == '.' ){
						new_num += Expression[i];
						i++;
					}
					MathNode tmp = new MathNode(Convert.ToDouble(new_num));
					aux.Push(tmp);
				}
				else {
					if(Expression[i]){
						
					}
				}
				i++;
			}
		}*/
		
		private bool isInt(string x){
			int y = Convert.ToInt32(x);
			if(Convert.ToInt32(y) != Convert.ToInt32(x)){
				return false ;
			}
			else 
				return true ;
		}
		private bool Is_Simple_op(char x){
			if(x == '+' || x == '-' || x == '*' || x == '/'){
				return true;
			}
			else 
				return false ;
			
		}
	}
}

