using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Records_Application
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {

        }

        private void cusCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
      

        }

        private void cmbCustomer_MouseClick(object sender, MouseEventArgs e)
        {
            
          

        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clsdb clsdb = new Clsdb();
            DataTable dt = new DataTable();

            //String add1 = txtAdd1.Text;
            //String add2 = txtAdd2.Text;
            //String add3 = txtAdd3.Text;
            //String suburb = txtSubrb.Text;
            //String state = txtState.Text;
            //String postalcode = txtPcode.Text;


            dt= clsdb.getClients(cmbCustomer.Text);

            txtAdd1.Text= dt.Rows[0][0].ToString();

            txtAdd2.Text= dt.Rows[0][1].ToString();
            txtAdd3.Text= dt.Rows[0][2].ToString();

            txtSubrb.Text= dt.Rows[0][3].ToString();
            txtState.Text= dt.Rows[0][4].ToString();
            txtPcode.Text= dt.Rows[0][5].ToString();
         







        }

        private void cmbCustomer_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void frmSales_Load(object sender, EventArgs e)
        {

            Clsdb clsdb = new Clsdb();

            DataTable dt = new DataTable();
            dt = clsdb.cusCombo(cmbCustomer);
        }
    }
}
