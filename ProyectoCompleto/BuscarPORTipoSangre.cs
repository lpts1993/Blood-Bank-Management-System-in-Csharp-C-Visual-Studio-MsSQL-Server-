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
    public partial class BuscarPORTipoSangre : Form
    {
        funcion fn= new funcion();
        public BuscarPORTipoSangre()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard ds=new Dashboard();
            ds.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void BuscarPORTipoSangre_Load(object sender, EventArgs e)
        {
            String query = "Select * from [dbo].[NewDonor]";
            DataSet ds = fn.getdata(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                String query = "Select * from [dbo].[NewDonor] where [bloodgroup] like '" + textBox1.Text + "%'";
                DataSet ds = fn.getdata(query);
                dataGridView1.DataSource = ds.Tables[0];

            }
            else
            {
                String query = "Select * from [dbo].[NewDonor]";
                DataSet ds = fn.getdata(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
