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

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Cn = new SqlConnection(@"Data Source =.\MSSQLSERVER01; Initial Catalog = TSQL2012; Integrated Security = True; Connection timeout = 5; Application name = Lab 3");
            SqlCommand Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.CommandText = "Production.ProductInfo";

            Cm.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Default, null));
            Cm.Parameters.AddWithValue("@productid", txtproductID.Text);

            Cm.Parameters.Add(new SqlParameter("@productname", SqlDbType.NVarChar, 40, ParameterDirection.Output, true, 0, 0, "", DataRowVersion.Default, null));
            Cm.Parameters.Add(new SqlParameter("@unitprice", SqlDbType.Money, 8, ParameterDirection.Output, true, 0, 0, "", DataRowVersion.Default, null));

            if (Cn.State != ConnectionState.Open) { Cn.Open(); }
            Cm.ExecuteNonQuery();
            Cn.Close();

            lblProductName.Text = Cm.Parameters["@productname"].Value.ToString();
            lblUnitPrice.Text = Cm.Parameters["@unitprice"].Value.ToString();

            MessageBox.Show(Cm.Parameters["@RETURN_VALUE"].Value.ToString());
        }
    }
}
