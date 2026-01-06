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

namespace Sistema_de_facturacion
{
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
              

            Conexion.Conectar();
            string consulta = "Select * from Usuario where Nom_usu=  '" + Usuarioent.Text + "' and Cla_usu = '" + Contrasenaent.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, Conexion.Conectar());
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            if (lector.HasRows == true)
            {
                MessageBox.Show("Bienvenido al sistema");
                Menu_principal frm = new Menu_principal();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario y/o contrasena incorrecta");
                this.Usuarioent.Text = "";
                this.Contrasenaent.Text = "";
                this.Usuarioent.Focus();

            }
        }

        private void Usuarioent_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tabulacion 
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{Tab}");
            }
        }

        private void Contrasenaent_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tabulacion 
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{Tab}");
            }
        }
    }
}
