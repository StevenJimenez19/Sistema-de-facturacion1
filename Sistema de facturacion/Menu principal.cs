using System;
using System.Windows.Forms;

namespace Sistema_de_facturacion
{
    public partial class Menu_principal : Form
    {
        // Instancias únicas para cada formulario
        private Articulo articuloForm;
        private Cliente clienteForm;
        private Usuario usuarioForm;
        private Crud crudForm;
        private CxC cxcForm;
        private Reporte_de_ventas_diarias ReporteForm;
        public Menu_principal()
        {
            InitializeComponent();
        }

        private void Menu_principal_Load(object sender, EventArgs e)
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

        // ----------------------------
        // Abrir formulario Articulo
        // ----------------------------
        private void radioButton1_Click_1(object sender, EventArgs e)
        {
            if (articuloForm == null || articuloForm.IsDisposed)
            {
                articuloForm = new Articulo();
                articuloForm.Show();
            }
            else
            {
                articuloForm.BringToFront();
            }
        }

        // ----------------------------
        // Abrir formulario Cliente
        // ----------------------------
        private void radioButton2_Click_1(object sender, EventArgs e)
        {
            if (clienteForm == null || clienteForm.IsDisposed)
            {
                clienteForm = new Cliente();
                clienteForm.Show();
            }
            else
            {
                clienteForm.BringToFront();
            }
        }

        // ----------------------------
        // Abrir formulario Usuario
        // ----------------------------
        private void radioButton3_Click_1(object sender, EventArgs e)
        {
            if (usuarioForm == null || usuarioForm.IsDisposed)
            {
                usuarioForm = new Usuario();
                usuarioForm.Show();
            }
            else
            {
                usuarioForm.BringToFront();
            }
        }

        // ----------------------------
        // Abrir formulario Crud (Stock Bajo)
        // ----------------------------
        private void Stocik_Click(object sender, EventArgs e)
        {
            if (crudForm == null || crudForm.IsDisposed)
            {
                crudForm = new Crud();
                crudForm.Show();
            }
            else
            {
                crudForm.BringToFront();
            }
        }

        private void CXCobrar_Click(object sender, EventArgs e)
        {
            if (cxcForm == null || cxcForm.IsDisposed)
            {
                cxcForm = new CxC();
                cxcForm.Show();
            }
            else
            {
                cxcForm.BringToFront();
            }
        }

        private void Reporteventas_Click(object sender, EventArgs e)
        {
            if (ReporteForm == null || ReporteForm.IsDisposed)
            {
                ReporteForm = new Reporte_de_ventas_diarias();
                ReporteForm.Show();
            }
            else
            {
                ReporteForm.BringToFront();
            }
        }
    }

    // ----------------------------
    // Clase Sesion (global)
    // ----------------------------
    public static class Sesion
    {
        public static string Usuario;
        public static string Rol;
    }
}