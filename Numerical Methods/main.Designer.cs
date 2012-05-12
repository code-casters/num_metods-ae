namespace Numerical_Methods
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMethods = new System.Windows.Forms.TabControl();
            this.tabPInterpolation = new System.Windows.Forms.TabPage();
            this.gboxOptions = new System.Windows.Forms.GroupBox();
            this.txtbxrank = new System.Windows.Forms.TextBox();
            this.rdbtnNewton = new System.Windows.Forms.RadioButton();
            this.rdbtnLagrange = new System.Windows.Forms.RadioButton();
            this.txtbxNum = new System.Windows.Forms.TextBox();
            this.tabPIntegration = new System.Windows.Forms.TabPage();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblres = new System.Windows.Forms.Label();
            this.datgridTable = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbxInactive = new System.Windows.Forms.TextBox();
            this.txtbxRegular = new System.Windows.Forms.TextBox();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMethods.SuspendLayout();
            this.tabPInterpolation.SuspendLayout();
            this.gboxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datgridTable)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMethods
            // 
            this.tabMethods.Controls.Add(this.tabPInterpolation);
            this.tabMethods.Controls.Add(this.tabPIntegration);
            this.tabMethods.Location = new System.Drawing.Point(159, 36);
            this.tabMethods.Name = "tabMethods";
            this.tabMethods.SelectedIndex = 0;
            this.tabMethods.Size = new System.Drawing.Size(242, 148);
            this.tabMethods.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMethods.TabIndex = 12;
            // 
            // tabPInterpolation
            // 
            this.tabPInterpolation.Controls.Add(this.gboxOptions);
            this.tabPInterpolation.Controls.Add(this.txtbxNum);
            this.tabPInterpolation.Location = new System.Drawing.Point(4, 22);
            this.tabPInterpolation.Name = "tabPInterpolation";
            this.tabPInterpolation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPInterpolation.Size = new System.Drawing.Size(234, 122);
            this.tabPInterpolation.TabIndex = 0;
            this.tabPInterpolation.Text = "Interpolation";
            this.tabPInterpolation.UseVisualStyleBackColor = true;
            // 
            // gboxOptions
            // 
            this.gboxOptions.Controls.Add(this.txtbxrank);
            this.gboxOptions.Controls.Add(this.rdbtnNewton);
            this.gboxOptions.Controls.Add(this.rdbtnLagrange);
            this.gboxOptions.Location = new System.Drawing.Point(6, 40);
            this.gboxOptions.Name = "gboxOptions";
            this.gboxOptions.Size = new System.Drawing.Size(222, 74);
            this.gboxOptions.TabIndex = 5;
            this.gboxOptions.TabStop = false;
            this.gboxOptions.Text = "Options";
            // 
            // txtbxrank
            // 
            this.txtbxrank.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxrank.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtbxrank.Location = new System.Drawing.Point(122, 44);
            this.txtbxrank.Name = "txtbxrank";
            this.txtbxrank.Size = new System.Drawing.Size(94, 21);
            this.txtbxrank.TabIndex = 2;
            this.txtbxrank.Text = "Enter rank";
            this.txtbxrank.Visible = false;
            this.txtbxrank.Enter += new System.EventHandler(this.txtbxrank_Enter);
            this.txtbxrank.Leave += new System.EventHandler(this.txtbxrank_Leave);
            // 
            // rdbtnNewton
            // 
            this.rdbtnNewton.AutoSize = true;
            this.rdbtnNewton.Location = new System.Drawing.Point(7, 44);
            this.rdbtnNewton.Name = "rdbtnNewton";
            this.rdbtnNewton.Size = new System.Drawing.Size(109, 17);
            this.rdbtnNewton.TabIndex = 1;
            this.rdbtnNewton.TabStop = true;
            this.rdbtnNewton.Text = "Newton Greekory";
            this.rdbtnNewton.UseVisualStyleBackColor = true;
            this.rdbtnNewton.CheckedChanged += new System.EventHandler(this.rdbtnNewton_CheckedChanged);
            // 
            // rdbtnLagrange
            // 
            this.rdbtnLagrange.AutoSize = true;
            this.rdbtnLagrange.Location = new System.Drawing.Point(7, 20);
            this.rdbtnLagrange.Name = "rdbtnLagrange";
            this.rdbtnLagrange.Size = new System.Drawing.Size(70, 17);
            this.rdbtnLagrange.TabIndex = 0;
            this.rdbtnLagrange.TabStop = true;
            this.rdbtnLagrange.Text = "Lagrange";
            this.rdbtnLagrange.UseVisualStyleBackColor = true;
            // 
            // txtbxNum
            // 
            this.txtbxNum.Location = new System.Drawing.Point(6, 14);
            this.txtbxNum.Name = "txtbxNum";
            this.txtbxNum.Size = new System.Drawing.Size(217, 20);
            this.txtbxNum.TabIndex = 3;
            this.txtbxNum.Enter += new System.EventHandler(this.txtbxNum_Enter);
            this.txtbxNum.Leave += new System.EventHandler(this.txtbxNum_Leave);
            // 
            // tabPIntegration
            // 
            this.tabPIntegration.Location = new System.Drawing.Point(4, 22);
            this.tabPIntegration.Name = "tabPIntegration";
            this.tabPIntegration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPIntegration.Size = new System.Drawing.Size(234, 122);
            this.tabPIntegration.TabIndex = 1;
            this.tabPIntegration.Text = "Integration";
            this.tabPIntegration.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(159, 185);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(242, 23);
            this.btnCalc.TabIndex = 11;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblres
            // 
            this.lblres.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblres.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblres.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblres.Location = new System.Drawing.Point(159, 211);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(242, 73);
            this.lblres.TabIndex = 10;
            this.lblres.Text = "Result goes here ..";
            // 
            // datgridTable
            // 
            this.datgridTable.AllowUserToResizeColumns = false;
            this.datgridTable.AllowUserToResizeRows = false;
            this.datgridTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datgridTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.datgridTable.ColumnHeadersHeight = 26;
            this.datgridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datgridTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y});
            this.datgridTable.Location = new System.Drawing.Point(12, 36);
            this.datgridTable.Name = "datgridTable";
            this.datgridTable.RowHeadersVisible = false;
            this.datgridTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datgridTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.datgridTable.Size = new System.Drawing.Size(141, 248);
            this.datgridTable.TabIndex = 9;
            this.datgridTable.Leave += new System.EventHandler(this.datgridTable_Leave);
            // 
            // x
            // 
            this.x.FillWeight = 70F;
            this.x.HeaderText = "x";
            this.x.MinimumWidth = 70;
            this.x.Name = "x";
            this.x.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.x.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.x.Width = 70;
            // 
            // y
            // 
            this.y.FillWeight = 70F;
            this.y.HeaderText = "y";
            this.y.MinimumWidth = 70;
            this.y.Name = "y";
            this.y.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.y.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.y.Width = 70;
            // 
            // txtbxInactive
            // 
            this.txtbxInactive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxInactive.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtbxInactive.Location = new System.Drawing.Point(455, 210);
            this.txtbxInactive.Name = "txtbxInactive";
            this.txtbxInactive.Size = new System.Drawing.Size(10, 21);
            this.txtbxInactive.TabIndex = 14;
            this.txtbxInactive.Visible = false;
            // 
            // txtbxRegular
            // 
            this.txtbxRegular.Location = new System.Drawing.Point(455, 186);
            this.txtbxRegular.Name = "txtbxRegular";
            this.txtbxRegular.Size = new System.Drawing.Size(10, 20);
            this.txtbxRegular.TabIndex = 13;
            this.txtbxRegular.Visible = false;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(410, 24);
            this.menuStripMain.TabIndex = 15;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(108, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendFeedbackToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // sendFeedbackToolStripMenuItem
            // 
            this.sendFeedbackToolStripMenuItem.Name = "sendFeedbackToolStripMenuItem";
            this.sendFeedbackToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sendFeedbackToolStripMenuItem.Text = "Report a bug";
            this.sendFeedbackToolStripMenuItem.Click += new System.EventHandler(this.sendFeedbackToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 296);
            this.Controls.Add(this.txtbxInactive);
            this.Controls.Add(this.txtbxRegular);
            this.Controls.Add(this.tabMethods);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.datgridTable);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Numerical Methods";
            this.tabMethods.ResumeLayout(false);
            this.tabPInterpolation.ResumeLayout(false);
            this.tabPInterpolation.PerformLayout();
            this.gboxOptions.ResumeLayout(false);
            this.gboxOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datgridTable)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxRegular;
        private System.Windows.Forms.TextBox txtbxInactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridView datgridTable;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TabPage tabPIntegration;
        private System.Windows.Forms.TabPage tabPInterpolation;
        private System.Windows.Forms.GroupBox gboxOptions;
        private System.Windows.Forms.TextBox txtbxrank;
        private System.Windows.Forms.RadioButton rdbtnNewton;
        private System.Windows.Forms.RadioButton rdbtnLagrange;
        private System.Windows.Forms.TextBox txtbxNum;
        private System.Windows.Forms.TabControl tabMethods;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendFeedbackToolStripMenuItem;

    }
}

