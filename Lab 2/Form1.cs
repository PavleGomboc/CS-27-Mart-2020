using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int RetVal = 0; //Save Return value from stored Proc (SQL.txt)
            SqlConnection conn = new SqlConnection(@"Data Source =.\MSSQLSERVER01; Initial Catalog = TSQL2012; Integrated Security = True; Connection timeout = 5; Application name = Lab 2");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Production.ProductsInsert";
            // params
            cmd.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int,
                4, ParameterDirection.ReturnValue, true, 0, 0,"", DataRowVersion.Default, null)); // define ret value
            SqlParameter PCompName = new SqlParameter("@productname", SqlDbType.NVarChar, 40,
                ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Default, txtProductName.Text);
            cmd.Parameters.Add(PCompName);

            cmd.Parameters.AddWithValue("@supplierid", txtSupplierID.Text);
            cmd.Parameters.AddWithValue("@categoryid", txtCategoryID.Text);
            cmd.Parameters.AddWithValue("@unitprice", txtUnitPrice.Text);
            cmd.Parameters.AddWithValue("@discontinued", cboxDisscontinued.Checked);

            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                RetVal = (int)cmd.Parameters["@RETURN_VALUE"].Value;
                MessageBox.Show("Return value: " + RetVal.ToString());
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmdInsertDLL_Click(object sender, EventArgs e)
        {
            clsMiddleLayer.Products kol = new clsMiddleLayer.Products();
            int RetVal = kol.ProductsInsert(txtProductName.Text, Int32.Parse(txtSupplierID.Text),
                Convert.ToInt32(txtCategoryID.Text), Convert.ToDecimal(txtUnitPrice.Text), cboxDisscontinued.Checked);
            MessageBox.Show(RetVal.ToString());
        }
    }
}
