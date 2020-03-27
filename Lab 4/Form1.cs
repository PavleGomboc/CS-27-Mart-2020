using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdExecuteReader_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source =.\MSSQLSERVER01; Initial Catalog = TSQL2012; Integrated Security = True; Connection timeout = 5; Application name = Lab 4");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Production.SQLReaderDemo";

            cmd.Parameters.AddWithValue("@categoryid", txtCategoryID.Text);
            conn.Open();
            listBox1.Items.Clear();

            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.HasRows == false) // if empty
            {
                dr.Close();
                conn.Close();
                return;
            }

            this.Text = dr.FieldCount.ToString(); //count of columns is data set
            while (dr.Read())
            {
                listBox1.Items.Add(dr["ProductName"].ToString());
            }

            dr.Close();
            conn.Close();
            
        }
    }
}
