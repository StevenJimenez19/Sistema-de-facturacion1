using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Sistema_de_facturacion
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nombrecli_KeyPress(object sender, KeyPressEventArgs e)

        {
            //tabulacion 
            if (e.KeyChar ==  (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{Tab}") ;
            }

        }

        private void Apellidocli_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tabulacion 
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{Tab}");
            }
        }

        private void Direccioncli_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tabulacion 
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{Tab}");
            }
        }

        private void Sectorcli_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tabulacion 
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{Tab}");
            }
        }

        private void Provinciacli_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tabulacion 
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{Tab}");
            }
        }

        private void Celularcli_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tabulacion 
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{Tab}");
            }
        }

        private void Correocli_KeyPress(object sender, KeyPressEventArgs e)
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
                this.Nombrecli.Focus();

                //incrementar
                Conexion.Conectar();
                SqlDataAdapter sda = new SqlDataAdapter("Select isnull (max(Cast(Cod_cli as int)),0)+1 from Cliente", Conexion.Conectar());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Codigocli.Text = dt.Rows[0][0].ToString();
            }

        }

        
        private void Cliente_Load(object sender, EventArgs e)
        {
            ac.DataSource = actualizarclientes();

            //incrementar
            Conexion.Conectar();
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull (max(Cast(Cod_cli as int)),0)+1 from Cliente", Conexion.Conectar());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Codigocli.Text = dt.Rows[0][0].ToString();

            //Contar el numero de filas y colocarlo en el total
            int Total = int.Parse(ac.RowCount.ToString());
            total.Text = Convert.ToString(Total - 1);

        }
        //Actualizar data gridview
        public DataTable actualizarclientes()
        {


            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "Select * FROM Cliente order by Cod_cli desc";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;

        }
        private void Botonguardar_Click(object sender, EventArgs e)
        {
            //Guardar
            Conexion.Conectar();
            string insertar = "INSERT INTO Cliente(Cod_cli,Nom_cli,Aper_cli,Dir_cli,Sec_cli,Pro_cli,Con_cli,Cor_cli)VALUES(@Cod_cli,@Nom_cli,@Aper_cli,@Dir_cli,@Sec_cli,@Pro_cli,@Con_cli,@Cor_cli)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@Cod_cli", Codigocli.Text);
            cmd1.Parameters.AddWithValue("@Nom_cli", Nombrecli.Text);
            cmd1.Parameters.AddWithValue("@Aper_cli", Apellidocli.Text);
            cmd1.Parameters.AddWithValue("@Dir_cli", Direccioncli.Text);
            cmd1.Parameters.AddWithValue("@Sec_cli", Sectorcli.Text);
            cmd1.Parameters.AddWithValue("@Pro_cli", Provinciacli.Text);
            cmd1.Parameters.AddWithValue("@Con_cli", Contactocli.Text);
            cmd1.Parameters.AddWithValue("@Cor_cli", Correocli.Text);
            cmd1.ExecuteNonQuery();
            ac.DataSource = actualizarclientes();

            MessageBox.Show("Datos agregados con exito");

            //Contar el numero de filas y colocarlo en el total
            int Total = int.Parse(ac.RowCount.ToString());
            total.Text = Convert.ToString(Total - 1);
        }

        private void Codigocli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                Conexion.Conectar();
                string cadsol = "select*from Cliente  where Cod_cli=" + Codigocli.Text + "";

                SqlCommand comando = new SqlCommand(cadsol, Conexion.Conectar());

                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    Nombrecli.Text = leer["Nom_cli"].ToString(); 
                    Apellidocli.Text = leer["Aper_cli"].ToString();
                    Direccioncli.Text = leer["Dir_cli"].ToString();
                    Sectorcli.Text = leer["Sec_cli"].ToString();
                    Provinciacli.Text = leer["Pro_cli"].ToString();
                    Contactocli.Text = leer["Con_cli"].ToString();
                    Correocli.Text = leer["Cor_cli"].ToString();
                    Botonguardar.Enabled = false;
                }

                else
                {
                    Botonguardar.Enabled = false;
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

        private void Busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Busqueda incremental
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consultarA = "Select * from  Cliente where Nom_cli like ('"+ Busqueda.Text +"%')";
            SqlCommand cmd4 = new SqlCommand(consultarA, Conexion.Conectar());
            cmd4.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd4);
            da.Fill(dt);
            ac.DataSource = dt;
        }

        private void Modificarcli_Click(object sender, EventArgs e)
        {  
            Conexion.Conectar();
            string cadena = "update Cliente set Nom_cli =' " + Nombrecli.Text + " ',aper_cli='" + Apellidocli.Text + "', Sec_cli='" + Sectorcli.Text + "', Pro_cli='" + Provinciacli.Text + "', Con_cli='" + Contactocli.Text + "', Cor_cli='" + Correocli.Text + "' Where Cod_cli =" + Codigocli.Text + " ";
            SqlCommand comando = new SqlCommand(cadena, Conexion.Conectar());
            comando.ExecuteNonQuery();
            ac.DataSource = actualizarclientes();

            MessageBox.Show("Los datos fueron actualizados con exito");

            //Contar el numero de filas y colocarlo en el total
            int Total = int.Parse(ac.RowCount.ToString());
            total.Text = Convert.ToString(Total - 1);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eliminara el registro?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                Conexion.Conectar();
                string eliminar = "Delete from cliente where Cod_cli = @Cod_cli";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
                cmd3.Parameters.AddWithValue("@Cod_cli", Codigocli.Text);
                cmd3.ExecuteNonQuery();
                ac.DataSource = actualizarclientes();
            }
            //Contar el numero de filas y colocarlo en el total
            int Total = int.Parse(ac.RowCount.ToString());
            total.Text = Convert.ToString(Total - 1);
            

        }

        private void Imprimircliente_Click(object sender, EventArgs e)
        {
            RC RPC = new RC();
            RPC.Show();

        }
    }
}
