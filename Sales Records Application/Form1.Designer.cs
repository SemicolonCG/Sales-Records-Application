
namespace Sales_Records_Application
{
    partial class frmSales
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
            this.mainPnl = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.dtpInvoDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.txtIncl = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInvo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtExcl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdd3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSubrb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtPcode = new System.Windows.Forms.TextBox();
            this.mainPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPnl
            // 
            this.mainPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPnl.Controls.Add(this.dataGridView1);
            this.mainPnl.Controls.Add(this.txtNote);
            this.mainPnl.Controls.Add(this.dtpInvoDate);
            this.mainPnl.Controls.Add(this.cmbCustomer);
            this.mainPnl.Controls.Add(this.txtRefNo);
            this.mainPnl.Controls.Add(this.txtIncl);
            this.mainPnl.Controls.Add(this.txtTax);
            this.mainPnl.Controls.Add(this.label11);
            this.mainPnl.Controls.Add(this.label10);
            this.mainPnl.Controls.Add(this.label7);
            this.mainPnl.Controls.Add(this.txtInvo);
            this.mainPnl.Controls.Add(this.label9);
            this.mainPnl.Controls.Add(this.txtExcl);
            this.mainPnl.Controls.Add(this.label6);
            this.mainPnl.Controls.Add(this.label8);
            this.mainPnl.Controls.Add(this.txtPcode);
            this.mainPnl.Controls.Add(this.txtAdd3);
            this.mainPnl.Controls.Add(this.txtState);
            this.mainPnl.Controls.Add(this.label5);
            this.mainPnl.Controls.Add(this.label14);
            this.mainPnl.Controls.Add(this.txtAdd2);
            this.mainPnl.Controls.Add(this.txtSubrb);
            this.mainPnl.Controls.Add(this.label4);
            this.mainPnl.Controls.Add(this.label13);
            this.mainPnl.Controls.Add(this.txtAdd1);
            this.mainPnl.Controls.Add(this.label12);
            this.mainPnl.Controls.Add(this.label3);
            this.mainPnl.Controls.Add(this.label2);
            this.mainPnl.Controls.Add(this.label1);
            this.mainPnl.Location = new System.Drawing.Point(1, 34);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.Size = new System.Drawing.Size(608, 508);
            this.mainPnl.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(556, 176);
            this.dataGridView1.TabIndex = 5;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(416, 102);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(168, 95);
            this.txtNote.TabIndex = 4;
            this.txtNote.Text = "";
            // 
            // dtpInvoDate
            // 
            this.dtpInvoDate.Location = new System.Drawing.Point(416, 48);
            this.dtpInvoDate.Name = "dtpInvoDate";
            this.dtpInvoDate.Size = new System.Drawing.Size(168, 20);
            this.dtpInvoDate.TabIndex = 3;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(113, 22);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(168, 21);
            this.cmbCustomer.TabIndex = 2;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            this.cmbCustomer.SelectionChangeCommitted += new System.EventHandler(this.cusCmb_SelectionChangeCommitted);
            this.cmbCustomer.SelectedValueChanged += new System.EventHandler(this.cmbCustomer_SelectedValueChanged);
            this.cmbCustomer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbCustomer_MouseClick);
            // 
            // txtRefNo
            // 
            this.txtRefNo.Location = new System.Drawing.Point(416, 74);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Size = new System.Drawing.Size(168, 20);
            this.txtRefNo.TabIndex = 1;
            // 
            // txtIncl
            // 
            this.txtIncl.Location = new System.Drawing.Point(416, 456);
            this.txtIncl.Name = "txtIncl";
            this.txtIncl.Size = new System.Drawing.Size(168, 20);
            this.txtIncl.TabIndex = 1;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(416, 431);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(168, 20);
            this.txtTax.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(328, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Note";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(328, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Reference No.";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Incl";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtInvo
            // 
            this.txtInvo.Location = new System.Drawing.Point(416, 22);
            this.txtInvo.Name = "txtInvo";
            this.txtInvo.Size = new System.Drawing.Size(168, 20);
            this.txtInvo.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Invoice Date";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtExcl
            // 
            this.txtExcl.Location = new System.Drawing.Point(416, 407);
            this.txtExcl.Name = "txtExcl";
            this.txtExcl.Size = new System.Drawing.Size(168, 20);
            this.txtExcl.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Tax";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Invoice No.";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAdd3
            // 
            this.txtAdd3.Location = new System.Drawing.Point(113, 99);
            this.txtAdd3.Name = "txtAdd3";
            this.txtAdd3.Size = new System.Drawing.Size(168, 20);
            this.txtAdd3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Excl";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAdd2
            // 
            this.txtAdd2.Location = new System.Drawing.Point(113, 73);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(168, 20);
            this.txtAdd2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address 3";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAdd1
            // 
            this.txtAdd1.Location = new System.Drawing.Point(113, 49);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(168, 20);
            this.txtAdd1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address 2";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Address 1";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Location = new System.Drawing.Point(6, 5);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(75, 23);
            this.btnSaveOrder.TabIndex = 1;
            this.btnSaveOrder.Text = "Save Order";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Suburb";
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "State";
            this.label13.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSubrb
            // 
            this.txtSubrb.Location = new System.Drawing.Point(113, 127);
            this.txtSubrb.Name = "txtSubrb";
            this.txtSubrb.Size = new System.Drawing.Size(168, 20);
            this.txtSubrb.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Postal Code";
            this.label14.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(113, 151);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(168, 20);
            this.txtState.TabIndex = 1;
            // 
            // txtPcode
            // 
            this.txtPcode.Location = new System.Drawing.Point(113, 177);
            this.txtPcode.Name = "txtPcode";
            this.txtPcode.Size = new System.Drawing.Size(168, 20);
            this.txtPcode.TabIndex = 1;
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(610, 542);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.mainPnl);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "frmSales";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Order";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.mainPnl.ResumeLayout(false);
            this.mainPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPnl;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIncl;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExcl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdd3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.DateTimePicker dtpInvoDate;
        private System.Windows.Forms.TextBox txtRefNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInvo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.TextBox txtPcode;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSubrb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}

