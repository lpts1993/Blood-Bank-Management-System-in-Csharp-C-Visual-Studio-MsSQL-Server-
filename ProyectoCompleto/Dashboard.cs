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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

           
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void agregarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarDonador AD = new AgregarDonador();
            AD.Show();
            this.Hide();

        }

        private void cargarDetallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDonarDetails udd =    new UpdateDonarDetails();
            udd.Show();
        }

        private void todosLosDetallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllDonatorDetails alldd=new AllDonatorDetails();
            alldd.Show();
        }

        private void ubicaionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarPORDireccion bXdi=new BuscarPORDireccion();
            bXdi.Show();

        }

        private void donarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tipoDeSandreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarPORTipoSangre bXrs=new BuscarPORTipoSangre();
            bXrs.Show();
        }

        private void aumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokIncremento stkIn = new StokIncremento();
            stkIn.Show();
        }

        private void disminusionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StckDecre std = new StckDecre();
            std.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void detallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllStock alls = new AllStock();
            alls.Show();
        }

        private void eliminarDonadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDonador dld=new DeleteDonador();
            dld.Show();
        }
    }
}
