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
    public partial class DeleteDonador : Form
    {

        funcion fn = new funcion();

        String query;
        public DeleteDonador()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard ds= new Dashboard();
            ds.Show();
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

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox7.Text != "")
            {
                query = "select * from [dbo].[NewDonor] where did=" + textBox7.Text + "";
                DataSet ds = fn.getdata(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    textBox1.Text = ds.Tables[0].Rows[0][1].ToString();
                    textBox2.Text = ds.Tables[0].Rows[0][2].ToString();
                    textBox3.Text = ds.Tables[0].Rows[0][3].ToString();
                    dateTimePicker1.Text = ds.Tables[0].Rows[0][4].ToString();
                    textBox4.Text = ds.Tables[0].Rows[0][5].ToString();
                    comboBox1.Text = ds.Tables[0].Rows[0][6].ToString();
                    textBox5.Text = ds.Tables[0].Rows[0][7].ToString();
                    comboBox2.Text = ds.Tables[0].Rows[0][8].ToString();
                    textBox6.Text = ds.Tables[0].Rows[0][9].ToString();
                    richTextBox1.Text = ds.Tables[0].Rows[0][10].ToString();
                }
                else 
                {
                    MessageBox.Show("ID Invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox7.Clear();
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK) 
            {
                query = "DELETE FROM [dbo].[NewDonor] WHERE did = " + textBox7.Text + "";
                fn.setdate(query);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "") 
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
}
