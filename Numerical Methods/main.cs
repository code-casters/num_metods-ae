using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace Numerical_Methods
{
    public partial class MainForm : Form
    {
<<<<<<< HEAD
        private double[,] _pTable;

=======
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
>>>>>>> origin/master
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
<<<<<<< HEAD
            //MathBinaryTree te = new MathBinaryTree("5+x");
            //MathBinaryTree dte = te.Drive(te.Root);
=======
			//MathBinaryTree te = new MathBinaryTree("5+x");
			//MathBinaryTree dte = te.Drive(te.Root);
>>>>>>> origin/master
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

<<<<<<< HEAD
        private void TxtbxNumEnter(object sender, EventArgs e)
        {
            if ((((TextBox) sender).Text == @"Enter value") || (((TextBox) sender).Text == ""))
            {
                ((TextBox) sender).Text = "";
                ((TextBox) sender).Font = txtbxRegular.Font;
                txtbxNum.ForeColor = txtbxRegular.ForeColor;
            }
        }

        private void TxtbxNumLeave(object sender, EventArgs e)
        {
            if ((((TextBox) sender).Text == @"Enter value") || (((TextBox) sender).Text == ""))
            {
                ((TextBox) sender).Text = @"Enter value";
                ((TextBox) sender).Font = txtbxInactive.Font;
                txtbxNum.ForeColor = txtbxInactive.ForeColor;
            }
        }

        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
=======
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
>>>>>>> origin/master
        {
            Application.Exit();
        }

<<<<<<< HEAD
        private void CreditsToolStripMenuItemClick(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Numerical Methods v0.04 Alpha\nCreated by :\n      Mohammad Eyad Arnabeh\n      Ammar Lakis");
        }

        private void SendFeedbackToolStripMenuItemClick(object sender, EventArgs e)
        {
            Process.Start("https://github.com/perfect-ite/num_metods-ae/issues/new");
        }
        
        /// <summary>
        /// Checks invalid values in DataGridView
        /// </summary>
        /// <param name="dataGrid">Table to check</param>
        /// <returns>boolean</returns>
        private bool CheckTable(DataGridView dataGrid)
        {
            _pTable = new double[datgridTable.Rows.GetLastRow(DataGridViewElementStates.Visible),2];
            for (int i = 0; i < datgridTable.Rows.GetLastRow(DataGridViewElementStates.Visible); i++)
            {
                if ((!double.TryParse(datgridTable[0, i].ToString(), out _pTable[i, 0])) ||
                    (!double.TryParse(datgridTable[1, i].ToString(), out _pTable[i, 1])))
                {
                    return false;
                }
            }
            return true;
        }

        private void BtnCalcClick(object sender, EventArgs e)
        {
            if (!CheckTable(datgridTable))
            {
                MessageBox.Show(@"You've entered invalid values");
            }
            else
            {
                lblres.Font = txtbxRegular.Font;
                lblres.ForeColor = txtbxRegular.ForeColor;
                if (tabPInterpolation.Focused)
                {
                    if (rdbtnLagrange.Checked)
                    {
                        lblres.Text = Interpolation.Lagrange(_pTable, double.Parse(txtbxNum.Text)).ToString();
                    }
                    else if (rdbtnNewton.Checked)
                    {
                        lblres.Text =
                            Interpolation.NewtonGreekory(_pTable, int.Parse(txtbxrank.Text), double.Parse(txtbxNum.Text))
                                .
                                ToString();
                    }
                    else
                    {
                        MessageBox.Show(@"Please choose a method ..");
                    }
                }
                else if (tabPIntegration.Focused)
                {
                    if (rdbtnTrapezoid.Checked)
                    {
                        lblres.Text = Integration.Trapezoid(_pTable).ToString();
                    }
                    else if (rdbtnRectangles.Checked)
                    {
                        lblres.Text = Integration.Rects(_pTable).ToString();
                    }
                    else if (rdbtnTrapezoid.Checked)
                    {
                        lblres.Text = Integration.Simpson(_pTable).ToString();
                    }
                    else
                    {
                        MessageBox.Show(@"Please choose a method ..");
                    }
                }
            }
        }

        private void RdbtnNewtonCheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Text == @"Newton Greekory")
            {
                txtbxrank.Visible = !txtbxrank.Visible;
                txtbxrank.Text = @"Enter rank";
                txtbxrank.Font = txtbxInactive.Font;                
            }
            lblres.Font = txtbxInactive.Font;
            lblres.ForeColor = txtbxInactive.ForeColor;
            lblres.Text = @"Result goes here ..";
        }

        private void TxtbxrankEnter(object sender, EventArgs e)
        {
            if ((((TextBox) sender).Text == @"Enter rank") || (((TextBox) sender).Text == ""))
            {
                ((TextBox) sender).Text = "";
                ((TextBox) sender).Font = txtbxRegular.Font;
                txtbxrank.ForeColor = txtbxRegular.ForeColor;
            }
        }

        private void TxtbxrankLeave(object sender, EventArgs e)
        {
            if ((((TextBox) sender).Text != @"Enter rank") && (((TextBox) sender).Text != "")) return;
            ((TextBox) sender).Text = @"Enter rank";
            ((TextBox) sender).Font = txtbxInactive.Font;
            txtbxrank.ForeColor = txtbxInactive.ForeColor;
        }

        private void DatgridTableLeave(object sender, EventArgs e)
        {
            for (int i = 0; i < datgridTable.Rows.GetLastRow(DataGridViewElementStates.Visible); i++)
            {
                if ((datgridTable[0, i].ToString() == "") || (datgridTable[1, i].ToString() == ""))
                {
                    datgridTable.Rows.RemoveAt(i);
                }
            }
            datgridTable.Sort(datgridTable.Columns[0], ListSortDirection.Ascending);
=======
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
>>>>>>> origin/master
        }
    }
}
