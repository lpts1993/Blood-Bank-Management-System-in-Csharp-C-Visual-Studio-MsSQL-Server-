using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompleto
{
    class funcion
    {
       

        protected SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=LAPTOP-8UITBRBH;Initial Catalog=datablood;Integrated Security=True";
            return conn;
        }
        public DataSet getdata(String query) 
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }

        public void setdate(String query) 
        {

            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection=conn;
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Se conecto con satisfaccion","Exitoso",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }



    }
}
