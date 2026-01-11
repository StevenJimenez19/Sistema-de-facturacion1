using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_facturacion
{
    public static class Sesion
    {
        public static string Usuario;
        public static string Rol;
    }
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
        }

        
        private void Salir_Click(object sender, EventArgs e)
        {
            Entrada frm = new Entrada();
            frm.Show();
            this.Close();
        }


        private void Facturacion_Click(object sender, EventArgs e)
        {
            Facturacion frm = new Facturacion();
            frm.Show();
        }

        private void Menu_principal_Load(object sender, EventArgs e)
        {


            {
                MessageBox.Show("DEBUG MENU\nRol: [" + Sesion.Rol + "]");

                string rol = Sesion.Rol?.Trim();

                if (rol == "Admin")
                {
                    MessageBox.Show("Bienvenido Administrador");
                }
                else if (rol == "Cajero")
                {
                    Usuariobutton.Enabled = false;
                    Clientebutton.Enabled = false;
                    Articulobutton.Enabled = false;
                    Ventas.Enabled = false;

                    MessageBox.Show("Bienvenido Cajero");
                }
                else
                {
                    MessageBox.Show("ROL NO RECONOCIDO");
                }


            }
  
        }

        private void radioButton1_Click_1(object sender, EventArgs e)
        {
            Articulo frm = new Articulo();
            frm.Show();
        }

        private void radioButton2_Click_1(object sender, EventArgs e)
        {
            Cliente frm = new Cliente();
            frm.Show();
        }

        private void radioButton3_Click_1(object sender, EventArgs e)
        {
            Usuario frm = new Usuario();
            frm.Show();
        }
       
    }
}

