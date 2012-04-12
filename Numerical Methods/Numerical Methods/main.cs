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
            pt[0, 0] = 0; pt[1, 0] = 0;
            pt[0, 1] = 0.1; pt[1, 1] = 0.0001;
            pt[0, 2] = 0.2; pt[1, 2] = 0.0016;
            pt[0, 3] = 0.3; pt[1, 3] = 0.0081;
            pt[0, 4] = 0.4; pt[1, 4] = 0.0256;
            pt[0, 5] = 0.5; pt[1, 5] = 0.0625;
            pt[0, 6] = 0.6; pt[1, 6] = 0.1296;
            MessageBox.Show(Integration.Sempson(pt).ToString());
            InitializeComponent();
        }
    }
}
