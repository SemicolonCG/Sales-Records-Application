using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Records_Application
{

    class Clsdb
    {
        SqlConnection con = new SqlConnection();
        string connString;

        public Clsdb()
        {

            connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sales_record_db;Persist Security Info=True;User ID=sa;Password=Dazz123@2020";
        }

        public DataTable cusCombo(ComboBox cmbCustomer)
        {
            DataTable dt = new DataTable();
            con.Close();
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = connString;
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select customer_name from table_client", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbCustomer.Items.Add(dr["customer_name"].ToString());
            }
            con.Close();
            return dt;
        }

        public DataTable populateItemCombo()
        {
            DataTable dt = new DataTable();
            con.Close();
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = connString;
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from table_sktitem", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            DataRow topItem = dt.NewRow();
            topItem[0] = 0;
            topItem[1] = "-select-";
            dt.Rows.InsertAt(topItem, 0);
            con.Close();
            return dt;
        }

        // get user details
        public DataTable getClients(String customer_name)
        {
            DataTable dt = new DataTable();
            con.Close();
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = connString;
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from table_client WHERE customer_name='" + customer_name + "'", con);

            cmd.ExecuteNonQuery();
            SqlDataReader dr;

            dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //     add1= (string)dr["cus_address_1"].ToString();
            //     add2 = (string)dr["cus_address_2"].ToString();
            //     add3 = (string)dr["cus_address_3"].ToString();
            //     suburb = (string)dr["cus_suburb"].ToString();
            //     state = (string)dr["cus_state"].ToString();
            //     postalcode = (string)dr["cus_postal_code"].ToString();
            //}
            dt.Load(dr);

            con.Close();
            return dt;
        }


        public DataTable populateSalesDGV()
        {
            DataTable dt = new DataTable();
            con.Close();
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = connString;
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from table_sales_info", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt;
        }

    }
}
