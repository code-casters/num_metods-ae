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
        /*Fields And Properties*/
        public char Variable;
        public double Num;
        public Operator Op = new Operator();
        public List<MathNode> Children = new List<MathNode>();
        /* Constructors*/
        public MathNode()
        {  //Default Constructor 
            this.Create(0d);
        }

        public MathNode(double num)
        {  //Num Constructor 
            this.Create(num);
        }

        public MathNode(Operator op)
        {  //operator Constructor 
            this.Create(op);
        }


        public void Create(char Var)
        {
            this.Variable = Var;
            this.Children.Add(null);
            this.Children.Add(null);
        }

        public void Create(double num)
        {
            this.Num = num;
            this.Children.Add(null);
            this.Children.Add(null);
        }
        public  void Create(Operator op)
        {
            this.Op = op;
            this.Children.Add(null);
            this.Children.Add(null);
        }

        

        public bool IsLeaf()
        { // Check if this Node is leaf or not
            if (this.Children[0] == null && this.Children[1] == null)
            {
                return true;
            }
            else
                return false;
        }

    }
}

