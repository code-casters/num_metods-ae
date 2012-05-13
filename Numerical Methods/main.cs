using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace Numerical_Methods
{
    public partial class MainForm : Form
    {
        private double[,] _pTable;
        MathBinaryTree _mathEx;

        public MainForm()
        {
            InitializeComponent();
        }

        private void TxtbxNumEnter(object sender, EventArgs e)
        {
            if ((((TextBox)sender).Text == @"Enter value") || (((TextBox)sender).Text == ""))
            {
                ((TextBox)sender).Text = "";
                ((TextBox)sender).Font = txtbxRegular.Font;
                ((TextBox)sender).ForeColor = txtbxRegular.ForeColor;
            }
        }

        private void TxtbxNumLeave(object sender, EventArgs e)
        {
            if ((((TextBox)sender).Text == @"Enter value") || (((TextBox)sender).Text == ""))
            {
                ((TextBox)sender).Text = @"Enter value";
                ((TextBox)sender).Font = txtbxInactive.Font;
                ((TextBox)sender).ForeColor = txtbxInactive.ForeColor;
            }
        }

        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

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
            _pTable = new double[datgridTable.Rows.GetLastRow(DataGridViewElementStates.Visible), 2];
            for (int i = 0; i < datgridTable.Rows.GetLastRow(DataGridViewElementStates.Visible); i++)
            {
                if ((!double.TryParse(datgridTable[0, i].Value.ToString(), out _pTable[i, 0])) ||
                    (!double.TryParse(datgridTable[1, i].Value.ToString(), out _pTable[i, 1])))
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
            if ((((TextBox)sender).Text == @"Enter rank") || (((TextBox)sender).Text == ""))
            {
                ((TextBox)sender).Text = "";
                ((TextBox)sender).Font = txtbxRegular.Font;
                ((TextBox)sender).ForeColor = txtbxRegular.ForeColor;
            }
        }

        private void TxtbxrankLeave(object sender, EventArgs e)
        {
            if ((((TextBox)sender).Text == @"Enter rank") || (((TextBox)sender).Text == ""))
            {
                ((TextBox)sender).Text = @"Enter rank";
                ((TextBox)sender).Font = txtbxInactive.Font;
                ((TextBox)sender).ForeColor = txtbxInactive.ForeColor;
            }
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
        }

        private void TxtbxMathExpressionEnter(object sender, EventArgs e)
        {
            if ((((TextBox)sender).Text == @"Enter mathematical expression") || (((TextBox)sender).Text == ""))
            {
                ((TextBox)sender).Text = "";
                ((TextBox)sender).Font = txtbxRegular.Font;
                ((TextBox)sender).ForeColor = txtbxRegular.ForeColor;
            }
        }

        private void TxtbxMathExpressionLeave(object sender, EventArgs e)
        {
            if ((((TextBox)sender).Text == @"Enter mathematical expression") || (((TextBox)sender).Text == ""))
            {
                ((TextBox)sender).Text = @"Enter mathematical expression";
                ((TextBox)sender).Font = txtbxInactive.Font;
                ((TextBox)sender).ForeColor = txtbxInactive.ForeColor;
            }
            else
            {
                if (txtbxVariable.Text == "")
                {
                    _mathEx = new MathBinaryTree(txtbxMathExpression.Text);
                }
                else
                {
                    _mathEx = new MathBinaryTree(txtbxMathExpression.Text,txtbxVariable.Text);
                }
                InitilizePtable();
            }
        }

        private void TxtbxVariableEnter(object sender, EventArgs e)
        {
            if ((((TextBox)sender).Text == @"Enter variable name") || (((TextBox)sender).Text == ""))
            {
                ((TextBox)sender).Text = "";
                ((TextBox)sender).Font = txtbxRegular.Font;
                ((TextBox)sender).ForeColor = txtbxRegular.ForeColor;
            }
        }

        private void TxtbxVariableLeave(object sender, EventArgs e)
        {
            if ((((TextBox)sender).Text == @"Enter variable name") || (((TextBox)sender).Text == ""))
            {
                ((TextBox)sender).Text = @"Enter variable name";
                ((TextBox)sender).Font = txtbxInactive.Font;
                ((TextBox)sender).ForeColor = txtbxInactive.ForeColor;
            }
        }
        
        private void InitilizePtable()
        {
            for (int i = 0; i <= 10; i++)
            {
                datgridTable[0, i].Value = i;
                datgridTable[1, i].Value = _mathEx.Eval(i);
            }
        }
    }
}