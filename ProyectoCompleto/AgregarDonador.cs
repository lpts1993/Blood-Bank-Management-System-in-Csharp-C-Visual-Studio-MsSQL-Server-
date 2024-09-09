using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCompleto
{
    public partial class AgregarDonador : Form
    {
        funcion fn = new funcion();
        public AgregarDonador()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard ds  = new Dashboard();
            ds.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton guardar

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && dateTimePicker1.Text != "" && textBox4.Text != "" && comboBox1.Text != "" && textBox5.Text != "" && comboBox2.Text != "" && textBox6.Text != "" && richTextBox1.Text != "")
            {
                String dname = textBox1.Text;
                String fname = textBox2.Text;
                String mname = textBox3.Text;
                String dob = dateTimePicker1.Text;
                Int64 mobile = Int64.Parse(textBox4.Text);
                String geneder = comboBox1.Text;
                String email = textBox5.Text;
                String bgroup = comboBox2.Text;
                String city = textBox6.Text;
                String address = richTextBox1.Text;

                String query = "INSERT INTO [dbo].[NewDonor] VALUES ('" + dname + "','" + fname + "','" + mname + "','" + dob + "'," + mobile + ",'" + geneder + "','" + email + "','" + bgroup + "','" + city + "','" + address + "')";   
                fn.setdate(query);
            }
            else
            { 
            
               MessageBox.Show("Llenar todos los datos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

        private void AgregarDonador_Load(object sender, EventArgs e)
        {
             
            String query = "select max(did) from [dbo].[NewDonor] ";

            DataSet ds = fn.getdata(query);
            int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            label13.Text = (count+1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.ResetText();
            textBox4.Clear();
            comboBox1.ResetText();
            textBox5.Clear();
            comboBox2.ResetText();
            textBox6.Clear();
            richTextBox1.Clear();

        }
    }
}
