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
    public partial class StokIncremento : Form
    {
        funcion fn =new funcion();
        String query;
        public StokIncremento()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard ds= new Dashboard();
            ds.Show();
        }

        private void StokIncremento_Load(object sender, EventArgs e)
        {
            query = "select [bloodgroup],[quality] FROM [dbo].[Stock]";
           DataSet ds = fn.getdata(query);
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            query = "update [dbo].[Stock] SET [quality] = [quality] + " + comboBox1.Text + "WHERE [bloodgroup]= '" +comboBox2.Text +"'";  
        fn.getdata(query);
            StokIncremento_Load(this,null);

        }
    }
}
