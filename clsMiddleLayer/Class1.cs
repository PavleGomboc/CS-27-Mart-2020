using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace clsMiddleLayer
{
    public class Products
    {
        public int ProductsInsert(string productname, int supplierid, int categoryid, decimal unitprice, bool discontinued)
        {
            int RetVal = 0; //Save Return value from stored Proc (SQL.txt)
            SqlConnection conn = new SqlConnection(@"Data Source =.\MSSQLSERVER01; Initial Catalog = TSQL2012; Integrated Security = True; Connection timeout = 5; Application name = Lab 2");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Production.ProductsInsert";
            // params
            cmd.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int,
                4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Default, null)); // define ret value
            SqlParameter PCompName = new SqlParameter("@productname", SqlDbType.NVarChar, 40,
                ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Default, productname);
            cmd.Parameters.Add(PCompName);

            cmd.Parameters.AddWithValue("@supplierid", supplierid);
            cmd.Parameters.AddWithValue("@categoryid", categoryid);
            cmd.Parameters.AddWithValue("@unitprice", unitprice);
            cmd.Parameters.AddWithValue("@discontinued", discontinued);

            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                RetVal = (int)cmd.Parameters["@RETURN_VALUE"].Value;
                return RetVal;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
