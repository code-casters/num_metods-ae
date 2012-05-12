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
    public partial class MainForm : Form
    {
        double[,] pTable;
        private bool CheckTable(DataGridView dataGrid)
        {
            pTable = new double[datgridTable.Rows.GetLastRow(DataGridViewElementStates.Visible), 2];
            for (int i = 0; i < datgridTable.Rows.GetLastRow(DataGridViewElementStates.Visible); i++)
            {
                if (!(double.TryParse(datgridTable[0, i].ToString(), out pTable[i, 0])) && !(double.TryParse(datgridTable[1, i].ToString(), out pTable[i, 1])))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (!CheckTable(datgridTable))
            {
                MessageBox.Show(@"You've entered invalid values");
            }
            else
            {
                lblres.Font = txtbxRegular.Font;
                if (rdbtnLagrange.Checked)
                {
                    MessageBox.Show(Interpolation.Lagrange(pTable, double.Parse(txtbxNum.Text)).ToString());
                }
                else if (rdbtnNewton.Checked)
                {
                    MessageBox.Show(
                        Interpolation.NewtonGreekory(pTable, int.Parse(txtbxrank.Text), double.Parse(txtbxNum.Text)).
                            ToString());
                }
            }
        }

        private void rdbtnNewton_CheckedChanged(object sender, EventArgs e)
        {
            txtbxrank.Visible = !txtbxrank.Visible;
            txtbxrank.Text = @"Enter rank";
            txtbxrank.Font = txtbxInactive.Font;
            lblres.Font = txtbxRegular.Font;
            lblres.Text = @"Result goes here ..";
        }

        private void txtbxrank_Enter(object sender, EventArgs e)
        {
            if ((((TextBox)sender).Text == @"Enter rank") || (((TextBox)sender).Text == ""))
            {
                ((TextBox)sender).Text = "";
                ((TextBox)sender).Font = txtbxRegular.Font;
            }
        }

        private void txtbxrank_Leave(object sender, EventArgs e)
        {
            if ((((TextBox)sender).Text == @"Enter rank") || (((TextBox)sender).Text == ""))
            {
                ((TextBox)sender).Text = @"Enter rank";
                ((TextBox)sender).Font = txtbxInactive.Font;
            }
        }

        private void datgridTable_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < datgridTable.Rows.GetLastRow(DataGridViewElementStates.Visible); i++)
            {
                if ((datgridTable[0, i].ToString() == "") || (datgridTable[1, i].ToString() == ""))
                {
                    datgridTable.Rows.RemoveAt(i);
                }
            }
            datgridTable.Sort(this.datgridTable.Columns[0], ListSortDirection.Ascending);
        }
        public MainForm()
        {
            InitializeComponent();
            //double[,] pt = new double[2, 7];
            //pt[0, 0] = 30; pt[1, 0] = 0.5;
            //pt[0, 1] = 35; pt[1, 1] = 0.5736;
            //pt[0, 2] = 40; pt[1, 2] = 0.6428;
            //pt[0, 3] = 45; pt[1, 3] = 0.7071;
            //pt[0, 4] = 50; pt[1, 4] = 0.7660;
            //pt[0, 5] = 55; pt[1, 5] = 0.8192;
            //pt[0, 6] = 60; pt[1, 6] = 0.8660;
            //MessageBox.Show(Functions.Postfix("a+c+b"));
			//MathBinaryTree te = new MathBinaryTree("5+x");
			//MathBinaryTree dte = te.Drive(te.Root);
            //double[,] pt = new double[2, 7];
            //pt[0, 0] = 30; pt[1, 0] = 0.5;
            //pt[0, 1] = 35; pt[1, 1] = 0.5736;
            //pt[0, 2] = 40; pt[1, 2] = 0.6428;
            //pt[0, 3] = 45; pt[1, 3] = 0.7071;
            //pt[0, 4] = 50; pt[1, 4] = 0.7660;
            //pt[0, 5] = 55; pt[1, 5] = 0.8192;
            //pt[0, 6] = 60; pt[1, 6] = 0.8660;
            //MessageBox.Show(@"Rectangles method : " + Integration.Rects(pt).ToString() + @" , Trapezoid method : " + Integration.Trapezoid(pt).ToString() + @" , Simpson method : "+ Integration.Simpson(pt).ToString());
        }

        private void txtbxNum_Enter(object sender, EventArgs e)
        {
            if ((((TextBox)sender).Text == @"Enter value") || (((TextBox)sender).Text == ""))
            {
                ((TextBox)sender).Text = "";
                ((TextBox)sender).Font = txtbxRegular.Font;
            }
        }

        private void txtbxNum_Leave(object sender, EventArgs e)
        {
            if ((((TextBox)sender).Text == @"Enter value") || (((TextBox)sender).Text == ""))
            {
                ((TextBox)sender).Text = @"Enter value";
                ((TextBox)sender).Font = txtbxInactive.Font;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Numerical Methods v0.04 Alpha\nCreated by :\n      Mohammad Eyad Arnabeh\n      Ammar Lakis");
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void creditsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Numerical Methods v0.04 Alpha2 \n\nCreated by :\n      Mohammad Eyad Arnabeh\n      Ammar Lakis");
        }

        private void sendFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/perfect-ite/num_metods-ae/issues/new");
        }
    }
}
