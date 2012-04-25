using System;
using System.Collections.Generic;
namespace Numerical_Methods
{
	public class Functions
	{
		public Functions ()
		{
		}
		public static string Postfix(string infix ){
			Stack<char> aux = new Stack<char>();
			string postfix  = " ";
			for (int i = 0; i < infix.Length; i++) {
				if (infix[i] == '+' || infix[i] == '-' || infix[i] == '*' || infix[i] == '/') {
					if (aux.Count == 0) {
						aux.Push(infix[i]);
					}
					else {
						while ( (aux.Count > 0) && (precedence(aux.Peek().ToString()) > precedence(infix[i].ToString()))) {
							postfix += aux.Pop();
						}
						aux.Push(infix[i]);
					}
				}
				else {
					postfix += infix[i].ToString();
				}
			}
			while (aux.Count > 0) {
				postfix += aux.Pop();
			}
			return postfix.TrimStart();
		}
		public static int precedence (string op){
			if (op == "+" || op == "-") {
				return 1 ;
			}
			else {
				return 2 ;
			}
		} 
	}
}

