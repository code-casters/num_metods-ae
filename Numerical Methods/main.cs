using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Numerical_Methods;

namespace Numerical_Methods
{
	
    public partial class main : Form
    {
		
        public main()
        {
            double[,] pt = new double[2, 7];
            pt[0, 0] = 30; pt[1, 0] = 0.5;
            pt[0, 1] = 35; pt[1, 1] = 0.5736;
            pt[0, 2] = 40; pt[1, 2] = 0.6428;
            pt[0, 3] = 45; pt[1, 3] = 0.7071;
            pt[0, 4] = 50; pt[1, 4] = 0.7660;
            pt[0, 5] = 55; pt[1, 5] = 0.8192;
            pt[0, 6] = 60; pt[1, 6] = 0.8660;
			MessageBox.Show(Functions.Postfix("23+54^x^x^x^sin(ln(5*pi*n!))^n^x"));
            InitializeComponent();
        }
    }
}
