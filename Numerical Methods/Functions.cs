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
					else if (precedence(aux.Peek().ToString()) == precedence(infix[i].ToString())) {
						postfix += aux.Pop();
						aux.Push(infix[i]);
					}
					else if (precedence(aux.Peek().ToString()) < precedence(infix[i].ToString())) {
						aux.Push(infix[i]);
					}
					else {
						while ( (aux.Count > 0) && (precedence(aux.Peek().ToString()) > precedence(infix[i].ToString()))) {
							postfix += aux.Pop();
						}
						aux.Push(infix[i]);
					}
				}
				else if (infix[i] == '(') {
					string subPostfix = " " ;
					int Bnum = 1 ;
					i++;
					while ((Bnum != 0) && (i < infix.Length)) {
						if (infix[i] == '(') {
							Bnum ++;
							subPostfix += infix[i].ToString();
						}
						else if (infix[i] == ')') {
							Bnum -- ;
							if (Bnum != 0) {
								subPostfix += infix[i].ToString();
							}
						}
						else {
							subPostfix += infix[i].ToString();
						}
						i++;
					}
					i--;
					postfix += Postfix(subPostfix.TrimStart());
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

