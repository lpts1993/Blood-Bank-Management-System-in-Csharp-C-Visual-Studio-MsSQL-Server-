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
    public partial class StckDecre : Form
    {

        funcion fn = new funcion();
        String query;

        public StckDecre()
        {
            InitializeComponent();
        }

        private void StckDecre_Load(object sender, EventArgs e)
        {
            query = "select  [bloodgroup],[quality] from [dbo].[Stock]";
            DataSet ds = fn.getdata(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard ds = new Dashboard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            query = "update [dbo].[Stock] SET [quality] = [quality] " + comboBox1.Text + " WHERE [bloodgroup]= '" + comboBox2.Text + "'";
           fn.getdata(query);
            StckDecre_Load(this, null);
    }
}
}