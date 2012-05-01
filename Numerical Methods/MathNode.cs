using System.Collections.Generic;

namespace Numerical_Methods
{
    public enum Operator
    {
        None = 0, // no type x only
        Sin = 1, // Sin()
        Cos = 2, // Cos()
        Tan = 3, // Tan()
        Cot = 4, // Cot()
        Log = 5, // Log( , )
        Ln = 6, // Log( , 2)
        Pow = 7, // Pow( , )
        Sqrt = 8, // Sqrt( , 2)
        Root = 9, // Root( , )
        Abs = 10, // ||
        Acos = 11, // Arcos ()
        ASin = 12, // Arcsin ()
        Atan = 13, // Arctan ()
        Sinh = 14, // Sinh()
        Cosh = 15, // Cosh()
        Tanh = 16, // Tanh()
        Exp = 17, // e()
        Sum = 18, // +
        Sub = 19, // -
        Mult = 20, // *
        Div = 21, // /
        Mod = 22, // %
    }

    public class MathNode
    {
        /// <summary>
        /// Gets or sets the varname.
        /// </summary>
        /// <value>
        /// The varname.
        /// </value>
        public char Varname{set;get;}
    	/// <summary>
		/// Gets or sets the number.
		/// </summary>
		/// <value>
		/// The number.
		/// </value>
        public double Num{set;get;}
		/// <summary>
		/// Gets or sets the operator.
		/// </summary>
		/// <value>
		/// The operator.
		/// </value>
        public Operator Op{set;get;}
		/// <summary>
		/// Gets or sets the right child id .
		/// </summary>
		/// <value>
		/// The id.
		/// </value>
		public int Rchild{set;get;}
		/// <summary>
		/// Gets or sets the left child id.
		/// </summary>
		/// <value>
		/// The id.
		/// </value>
		public int Lchild{set;get;}
		/// <summary>
		/// Gets or sets the parent identifier.
		/// </summary>
		/// <value>
		/// The parent identifier.
		/// </value>
		public int ParentId {set;get;}
        /* Constructors*/
        public MathNode()
        {  //Default Constructor 
            this.Create(0d);
        }

        public MathNode(double num , int Pid = -1)
        {  //Num Constructor 
            this.Create(num,Pid);
        }

        public MathNode(Operator op,int Pid = -1)
        {  //operator Constructor 
            this.Create(op,Pid);
        }

		public MathNode(char Varnum , int Pid = -1)
		{ // var name Constructor
			this.Create(Varnum,Pid);
		}
		
        public void Create(char Varname , int Pid = -1)
        {
            this.Varname = Varname ; // set the var name like x or y.
			// empty other fields.
			this.Op = Operator.None;
			this.Num = double.NaN ;
			// create empty children
			this.Rchild = -1;
			this.Lchild = -1;
			// set the Parent Id of this node 0 mean root
			this.ParentId = Pid;
        }

        public void Create(double num , int Pid = -1)
        {
            this.Num = num ; // set the numrical value.
			// empty other fields.
			this.Op = Operator.None;
			this.Varname = '\0' ;
			// create empty children
			this.Rchild = -1;
			this.Lchild = -1;
			// set the Parent Id of this node 0 mean root
			this.ParentId = Pid;        
		}
        public  void Create(Operator op , int Pid = -1)
        {
            this.Op = op ; // set the op value like ln , root.
			// empty other fields.
			this.Varname = '\0';
			this.Num = double.NaN ;
			// create empty children
			this.Rchild = -1;
			this.Lchild = -1;
			// set the Parent Id of this node 0 mean root
			this.ParentId = ParentId;
        }
		
        public bool IsLeaf()
        { // Check if this Node is leaf or not
            if (Rchild == -1 && Lchild == -1)
            {
                return true;
            }
            else
                return false;
        }

    }
}

