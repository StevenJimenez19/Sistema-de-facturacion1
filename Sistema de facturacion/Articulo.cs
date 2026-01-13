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
    public partial class Articulo : Form
    {
        public Articulo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Articulo_Load(object sender, EventArgs e)
        {
            acart.DataSource = actualizararticulos();

            //incrementar
            Conexion.Conectar();
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull (max(Cast(Cod_art as int)),0)+1 from Articulo", Conexion.Conectar());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Codigoart.Text = dt.Rows[0][0].ToString();

            //Contar el numero de filas y colocarlo en el total
            int Total = int.Parse(acart.RowCount.ToString());
            totalart.Text = Convert.ToString(Total - 1);

        }

        private void Descripcionart_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tabulacion 
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{Tab}");
            }
        }

        private void Costoart_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tabulacion 
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{Tab}");
            }
        }

        private void Precioart_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tabulacion 
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{Tab}");
            }
        }

        private void Cantidadart_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tabulacion 
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{Tab}");
            }
        }

        private void Existenciaart_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tabulacion 
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{Tab}");
            }
        }

        private void Cantidadminimaart_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tabulacion 
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{Tab}");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
                this.Descripcionart.Focus();

                //incrementar
                Conexion.Conectar();
                SqlDataAdapter sda = new SqlDataAdapter("Select isnull (max(Cast(Cod_art as int)),0)+1 from Articulo", Conexion.Conectar());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Codigoart.Text = dt.Rows[0][0].ToString();
            }
        }

        //Actualizar data gridview
        public DataTable actualizararticulos()
        {


            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "Select * FROM Articulo order by Cod_art desc";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Guardar
            Conexion.Conectar();
            string insertar = "INSERT INTO Articulo(Cod_art,Des_art,Cos_art,Pre_art,Can_art,Exi_art,Can_min)VALUES(@Cod_art,@Des_art,@Cos_art,@Pre_art,@Can_art,@Exi_art,@Can_min)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@Cod_art", Codigoart.Text);
            cmd1.Parameters.AddWithValue("@Des_art", Descripcionart.Text);
            cmd1.Parameters.AddWithValue("@Cos_art", Costoart.Text);
            cmd1.Parameters.AddWithValue("@Pre_art", Precioart.Text);
            cmd1.Parameters.AddWithValue("@Can_art", Cantidadart.Text);
            cmd1.Parameters.AddWithValue("@Exi_art", Existenciaart.Text);
            cmd1.Parameters.AddWithValue("@Can_min", Cantidadminimaart.Text);
            
            cmd1.ExecuteNonQuery();
           acart.DataSource = actualizararticulos();

            MessageBox.Show("Datos agregados con exito");

            //Contar el numero de filas y colocarlo en el total
            int Total = int.Parse(acart.RowCount.ToString());
            totalart.Text = Convert.ToString(Total - 1);
        }

        private void Codigoart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                Conexion.Conectar();
                string cadsol = "select*from Articulo  where Cod_art=" + Codigoart.Text + "";

                SqlCommand comando = new SqlCommand(cadsol, Conexion.Conectar());

                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    Descripcionart.Text = leer["Des_art"].ToString();
                    Costoart.Text = leer["Cos_art"].ToString();
                    Precioart.Text = leer["Pre_art"].ToString();
                    Existenciaart.Text = leer["Exi_art"].ToString();
                    Cantidadminimaart.Text = leer["Can_min"].ToString();
                    pictureBox1.Enabled = false;    
                }

                else
                {
                    pictureBox1.Enabled = false;
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

        private void Busquedaart_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Busqueda incremental
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consultarA = "Select * from  Articulo where Des_Art like ('" + Busquedaart.Text + "%')";
            SqlCommand cmd4 = new SqlCommand(consultarA, Conexion.Conectar());
            cmd4.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd4);
            da.Fill(dt);
            acart.DataSource = dt;
        }

        private void Modificarart_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string cadena = "update Articulo  set Des_art =' " + Descripcionart.Text + " ',Cos_art='" + Costoart.Text + "', Pre_art='" + Precioart.Text + "', Exi_art='" + Existenciaart.Text + "', Can_min='" + Cantidadminimaart.Text + "' Where Cod_art =" + Codigoart.Text + "";
            SqlCommand comando = new SqlCommand(cadena, Conexion.Conectar());
            comando.ExecuteNonQuery();
            acart.DataSource = actualizararticulos();

            MessageBox.Show("Los datos fueron actualizados con exito");

            //Contar el numero de filas y colocarlo en el total
            int Total = int.Parse(acart.RowCount.ToString());
            totalart.Text = Convert.ToString(Total - 1);
        }

        private void Eliminarart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eliminara el registro?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Conexion.Conectar();
                string eliminar = "Delete from Articulo where Cod_art = @Cod_art";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
                cmd3.Parameters.AddWithValue("@Cod_art", Codigoart.Text);
                cmd3.ExecuteNonQuery();
                acart.DataSource = actualizararticulos();
            }
            //Contar el numero de filas y colocarlo en el total
            int Total = int.Parse(acart.RowCount.ToString());
            totalart.Text = Convert.ToString(Total - 1);


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            RA RPA = new RA();
            RPA.Show();
        }

    }
}
