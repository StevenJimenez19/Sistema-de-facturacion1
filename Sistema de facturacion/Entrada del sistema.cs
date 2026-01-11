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

            try
            {
                using (SqlConnection cn = Conexion.Conectar())
                {
                    SqlCommand cmd = new SqlCommand("ValidarUsuario", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Nom_usu", SqlDbType.VarChar, 30).Value = Usuarioent.Text.Trim();
                    cmd.Parameters.Add("@Cla_usu", SqlDbType.VarChar, 15).Value = Contrasenaent.Text.Trim();

                    cmd.Parameters.Add("@Cod_usu", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Rol", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    int cod = Convert.ToInt32(cmd.Parameters["@Cod_usu"].Value);
                    string rol = cmd.Parameters["@Rol"].Value?.ToString();
                    string msg = cmd.Parameters["@Mensaje"].Value.ToString();

                    MessageBox.Show(
                        "DEBUG LOGIN\nCod: " + cod + "\nRol: [" + rol + "]"
                    );

                    if (cod > 0)
                    {
                        Sesion.Usuario = Usuarioent.Text.Trim();
                        Sesion.Rol = rol?.Trim();

                        Menu_principal frm = new Menu_principal();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(msg);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
