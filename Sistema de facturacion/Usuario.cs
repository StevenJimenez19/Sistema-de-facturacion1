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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nombreusu_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tabulacion 
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{Tab}");
            }
        }

        private void Claveusu_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tabulacion 
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{Tab}");
            }
        }

        private void Confirmarclaveusu_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tabulacion 
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{Tab}");
            }
        }

        private void Celularusu_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tabulacion 
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{Tab}");
            }
        }

        private void Correousu_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tabulacion 
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{Tab}");
            }
        }

        private void Nuevousu_Click(object sender, EventArgs e)
        {
            //limpiar los textbox combobox
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
                if (ctrl is ComboBox)
                {
                    ctrl.Text = "";
                }
                this.Nombreusu.Focus();

                //incrementar
                Conexion.Conectar();
                SqlDataAdapter sda = new SqlDataAdapter("Select isnull (max(Cast(Cod_usu as int)),0)+1 from Usuario", Conexion.Conectar());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Codigousu.Text = dt.Rows[0][0].ToString();
            }
        }
        //Actualizar data gridview
        public DataTable actualizarusuario()
        {


            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "Select * FROM Usuario order by Cod_usu desc";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }
        private void Usuario_Load(object sender, EventArgs e)
        {
            acusu.DataSource = actualizarusuario();

            //incrementar
            Conexion.Conectar();
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull (max(Cast(Cod_usu as int)),0)+1 from Usuario", Conexion.Conectar());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Codigousu.Text = dt.Rows[0][0].ToString();

            //Contar el numero de filas y colocarlo en el total
            int Total = int.Parse(acusu.RowCount.ToString());
            totalusu.Text = Convert.ToString(Total - 1);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Guardar
            Conexion.Conectar();
            string insertar = "INSERT INTO Usuario(Cod_usu,Nom_usu,Cla_usu,Concla_usu,Cel_usu,Cor_usu)VALUES(@Cod_usu,@Nom_usu,@Cla_usu,@Concla_usu,@Cel_usu,@Cor_usu)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@Cod_usu", Codigousu.Text);
            cmd1.Parameters.AddWithValue("@Nom_usu", Nombreusu.Text);
            cmd1.Parameters.AddWithValue("@Cla_usu", Claveusu.Text);
            cmd1.Parameters.AddWithValue("@Concla_usu", Confirmarclaveusu.Text);
            cmd1.Parameters.AddWithValue("@Cel_usu", Celularusu.Text);
            cmd1.Parameters.AddWithValue("@Cor_usu", Correousu.Text);

            cmd1.ExecuteNonQuery();
            acusu.DataSource = actualizarusuario();

            MessageBox.Show("Datos agregados con exito");

            //Contar el numero de filas y colocarlo en el total
            int Total = int.Parse(acusu.RowCount.ToString());
            totalusu.Text = Convert.ToString(Total - 1);
        }

        private void Codigousu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                Conexion.Conectar();
                string cadsol = "select*from Usuario  where Cod_usu=" + Codigousu.Text + "";

                SqlCommand comando = new SqlCommand(cadsol, Conexion.Conectar());

                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    Nombreusu.Text = leer["Nom_usu"].ToString();
                    Claveusu.Text = leer["Cla_usu"].ToString();
                    Confirmarclaveusu.Text = leer["Concla_usu"].ToString();
                    Celularusu.Text = leer["Cel_usu"].ToString();
                    Correousu.Text = leer["Cor_usu"].ToString();
                    Guardarusu.Enabled = false;
                }

                else
                {
                    Guardarusu.Enabled = false;
                    MessageBox.Show("Registro no encontrado");

                    //limpiar los textbox y combobox y richtbox
                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl is TextBox)
                        {
                            ctrl.Text = "";
                        }
                        if (ctrl is ComboBox)
                        {
                            ctrl.Text = "";
                        }
                    }
                }

                e.Handled = true;
                SendKeys.Send("{Tab}");



            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Busqueda incremental
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consultarA = "Select * from  Usuario where Nom_usu like ('" + Busquedausu.Text + "%')";
            SqlCommand cmd4 = new SqlCommand(consultarA, Conexion.Conectar());
            cmd4.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd4);
            da.Fill(dt);
            acusu.DataSource = dt;
        }

        private void Modificarusu_Click(object sender, EventArgs e)
        {
            
                Conexion.Conectar();
                string cadena = "update Usuario set Nom_usu =' " + Nombreusu.Text + " ',Cla_usu='" + Claveusu.Text + "', Concla_usu='" + Confirmarclaveusu.Text + "', Cel_usu='" + Celularusu.Text + "', Cor_usu='" + Correousu.Text + "' Where Cod_usu =" + Codigousu.Text + "";
                SqlCommand comando = new SqlCommand(cadena, Conexion.Conectar());
                comando.ExecuteNonQuery();
                acusu.DataSource = actualizarusuario();

                MessageBox.Show("Los datos fueron actualizados con exito");

            //Contar el numero de filas y colocarlo en el total
            int Total = int.Parse(acusu.RowCount.ToString());
            totalusu.Text = Convert.ToString(Total - 1);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eliminara el registro?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Conexion.Conectar();
                string eliminar = "Delete from Usuario where Cod_usu = @Cod_usu";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
                cmd3.Parameters.AddWithValue("@Cod_usu", Codigousu.Text);
                cmd3.ExecuteNonQuery();
                acusu.DataSource = actualizarusuario();
            }
            //Contar el numero de filas y colocarlo en el total
            int Total = int.Parse(acusu.RowCount.ToString());
            totalusu.Text = Convert.ToString(Total - 1);

        }

        private void Imprimirusuario_Click(object sender, EventArgs e)
        {
            RU RPU = new RU();
            RPU.Show();
        }
    }
}
