using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; //dodato
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //dodato

namespace SQLCommand
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\MSSQLSERVER01;Initial Catalog=TSQL2012;Integrated Security=True;Connection timeout = 5;Application name = RAF");
        //!!!PAZNJA KOD Connection Stringa!!!
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecuteScalar_Click(object sender, EventArgs e) //Slanje celog upita na SQL Server
        {
            string SqlQuery = "SELECT SUM(OD.unitprice*OD.qty) AS Promet " +
                               "FROM Sales.Orders AS O " +
                               "INNER JOIN Sales.OrderDetails AS OD " +
                               "ON O.orderid = OD.orderid WHERE O.custid = " + txtCustomerID.Text;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = SqlQuery;
            if (conn.State != ConnectionState.Open) conn.Open();
            object result = cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open) conn.Close();
            MessageBox.Show("Promet: " + result.ToString());
        }

        private void button1_Click(object sender, EventArgs e) //Pozivanje Stored Procedure kojoj prosledjujemo broj iz txtbox-a
        {
            string SQLQuery = "EXEC Sales.PrometZaKupca " + txtCustomerID.Text;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = SQLQuery;
            if (conn.State != ConnectionState.Open) conn.Open();
            object result = cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open) conn.Close();
            MessageBox.Show("Promet: " + result.ToString());
        }

        private void btnExecuteNonScalar_Click(object sender, EventArgs e)
        {
            string SQLQuery = String.Format("INSERT INTO Sales.Shippers (companyname, phone) VALUES" +
                "(N'{0}',N'{1}')",txtCompanyName.Text,txtPhone.Text); //N'' za unicode
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = SQLQuery;
            if (conn.State != ConnectionState.Open) conn.Open();
            int RecordsAffected = cmd.ExecuteNonQuery();
            if (conn.State == ConnectionState.Open) conn.Close();
            MessageBox.Show("Uspesno dodato " + RecordsAffected.ToString() + " redova.");

        }

        private void btnNonScalarStoredProcedure_Click(object sender, EventArgs e)
        {
            string SQLQuery = String.Format("EXEC Sales.ShippersInsert N'{0}',N'{1}';",
                txtCompanyName.Text,txtPhone.Text);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = SQLQuery;
            if (conn.State != ConnectionState.Open) conn.Open();
            int RecordsAffected = cmd.ExecuteNonQuery();
            if (conn.State == ConnectionState.Open) conn.Close();
            MessageBox.Show("Uspesno dodato " + RecordsAffected.ToString() + " redova.");
        }
    }
}
