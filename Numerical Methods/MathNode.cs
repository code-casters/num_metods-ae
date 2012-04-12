using System;
using System.Collections.Generic;
namespace nume_metodsae
{
	public enum Type {
    	None = 0  , // no type x only
		Sin  = 1  , // sin()
		Cos  = 2  , // Cos()
		Tan  = 3  , // Tan()
		Cot  = 4  , // Cot()
		Log  = 5  , // Log( , )
		Ln   = 6  , // Log( , 2)
		Pow  = 7  , // Pow( , )
		Sqrt = 8  , // Sqrt( , 2)
		root = 9  , // root( , )
		Abs  = 10 , // ||
		Acos = 11 , // Arcos ()
		ASin = 12 , // Arcsin ()
		Atan = 13 , // Arctan ()
		Sinh = 14 , // Sinh()
		Cosh = 15 , // Cosh()
		Tanh = 16 , // Tanh()
		Exp  = 17 , // e()
		Sum  = 18 , // +
		Sub  = 19 , // -
		Mult = 20 , // *
		Div  = 21 , // /
		Mod  = 22   // %
	}
	
	public class MathNode 
	{  
		/*Fields And Properties*/
		public double Const; // constant part 3* , 5* , .......
			
		public double Power; // power part ^2,^3 .......
			
		public Type type ;   // sin , cos , or None
			
		public List<MathNode> inner ; // the inner of sin or cos ..... etc .
			
		public List<MathNode> Children = new List<MathNode>(); //List of nodes contain node children
		
		/* Constructors*/	 
		public MathNode(){  //Default Constructor 
			this.Create(0);
		}
			
		public MathNode(double cons){ //With a number only
			this.Create(cons);
		}
		
		public MathNode(double cons, double power ){ //Number and power
				this.Create(cons,power);
		}
			
		public MathNode(double cons, double power, Type type ){ //Number,power and type maybe log,sin,cos ... etc .
			this.Create(cons,power,type);
		}
		
		public MathNode(double cons, double power, Type type, MathNode Inner ){ //ading one Inner .
			this.Create(cons,power,type);
			this.inner.Add(Inner);
		}
		
		public MathNode(char op){ // Creating op Node Only with + - * / 
			if(op == '+'){
				this.Create(Type:Type.Sum);
			}
			else if (op == '-'){
				this.Create(Type:Type.Sub);
			}
			else if (op == '*'){
				this.Create(Type:Type.Mult);
			}
			else if (op == '/' || op == '÷'){
				this.Create(Type:Type.Div);
			}
			else if (op == '%'){
				this.Create(Type:Type.Mod);
			}
		}
		
		/*Methods*/
		/// <summary>
		/// Create a new MathNode .
		/// </summary>
		/// <param name='cons'>
		/// Cons: The Constant value of expression ex: 3x^2 Cons is 3 .
		/// </param>
		/// <param name='pow'>
		/// Pow : The Power value of expression ex: 3x^2 Pow is 2 .
		/// </param>
		/// <param name='type'>
		/// Type : The Type of expression operator such log,sin,cos....etc. ex: 3x^2 Cons is None  .
		/// </param>
		/// <param name='Inner'>
		/// Inner : The Inner value of expression operator . ex : log(5x) Inner is 5x .
		/// </param>
		public void Create(double cons , double pow = 0 , Type type = 0 , List<MathNode> Inner = null){
			this.Const = cons ;
			this.Power = pow  ;
			this.type  = type ;
			this.inner = Inner;
			this.Children.Add(null);
			this.Children.Add(null);
		}
			
		public void AddInner (MathNode Inner ){ //add a new Inner Item to the node .
			this.inner.Add(Inner);
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
}

