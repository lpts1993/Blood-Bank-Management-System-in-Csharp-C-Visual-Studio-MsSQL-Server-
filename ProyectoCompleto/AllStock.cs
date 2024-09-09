using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCompleto
{
    public partial class AllStock : Form
    {

        String query;
        funcion fn= new funcion();
        public AllStock()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard ds=new Dashboard();
            ds.Show();
        }

        private void AllStock_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM [dbo].[Stock]";
            DataSet ds = fn.getdata(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
