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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();



        }
   //conexion con la base de datos
   SqlConnection conex =new SqlConnection("Data Source=LAPTOP-8UITBRBH;Initial Catalog=login;Integrated Security=True");



        //cerrar
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //minimizar
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //boton ingresar
        private void button1_Click(object sender, EventArgs e)
        {
            String usuario = textBox1.Text;
            String clave = textBox2.Text;

            if (usuario == "" && clave == "")
            {

                MessageBox.Show("Le falta usuario o Contraseña. Por favor llene los campos faltantes", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else if (usuario == "")
            {
                MessageBox.Show("Le falta usuario o Contraseña. Por favor llene los campos faltantes", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else if (clave == "") 
            {
                MessageBox.Show("Le falta usuario o Contraseña. Por favor llene los campos faltantes", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                conex.Open();
                SqlCommand cmd = new SqlCommand("SELECT [Usuario],[Contra] FROM [dbo].[Usuarios] where [Usuario]= @usuario AND [Contra]=@contrana", conex);

                cmd.Parameters.AddWithValue("@usuario", textBox1.Text);
                cmd.Parameters.AddWithValue("@contrana", textBox2.Text);

                SqlDataReader lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    conex.Close();
                    Dashboard pl = new Dashboard();
                    pl.Show();
                }
                MessageBox.Show("Bienvenido al sistema", "Gracias...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
            }
         

        }

        //boton registrar
        private void button2_Click(object sender, EventArgs e)
        {


        }

        //LABEL ACCESO PARA REGISTRAR
        private void label10_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label12.Enabled = false;
            label10.Enabled = false;

        }

        
      

       
        //CUANDO ESTE TEMPORIZADOR EMPIEZA MOSTRAREMOS SOLO LA PARTE DE REGISTRO
        private void timer1_Tick_1(object sender, EventArgs e)
        {            
            if (panel2.Location.X > -480)
            {
                panel2.Location = new Point(panel2.Location.X - 10, panel2.Location.Y);
            }
            else
            { 
            timer1.Stop();
                label10.Enabled = true;
                label12.Enabled = true;    

            }

        }


       //CUANDO ESTE TEMPORIZADOR EMPIEZA MOSTRAREMOS SOLO LA PARTE DE INGRESAR
       private void timer2_Tick(object sender, EventArgs e)
        {
            if (panel2.Location.X < 0)
            {
                panel2.Location = new Point(panel2.Location.X + 10, panel2.Location.Y);
            }
            else
            {
                timer2.Stop();
                label10.Enabled = true;
                label12.Enabled = true;

            }

        }
        //LABEL ACCESO PARA INGRESAR
       
        private void label12_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
            label10.Enabled = true;
            label12.Enabled = true;
        }

        //boton registrar usuario
        private void button2_Click_1(object sender, EventArgs e)
        {
            //conexion a la base de datos
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-8UITBRBH;Initial Catalog=login;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            if (textBox7.Text == "" && textBox5.Text == "")
            {
                MessageBox.Show("Por favor confirme Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
           
            else if (textBox7.Text == " ") 
            {
                MessageBox.Show("Por favor confirme Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                textBox5.Text = "";
            }
            else if (textBox5.Text == " ")
            {
                MessageBox.Show("Por favor confirme Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
                textBox7.Text = "";
             
            }
            else if (textBox7.Text == textBox5.Text)
            {
                cmd.CommandText = "INSERT INTO [dbo].[Usuarios] VALUES ('" + textBox4.Text + "','" + textBox3.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                MessageBox.Show("Guardado", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox4.Text = "";
                textBox3.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox5.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor confirme Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked = true)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel1.Text == "Mostrar")
            {
                linkLabel1.Text = "Esconder";
                textBox2.PasswordChar = '\0';
            }
            else
            {
                linkLabel1.Text = "Mostrar";
                textBox2.PasswordChar = '*';
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }
    }
}
 