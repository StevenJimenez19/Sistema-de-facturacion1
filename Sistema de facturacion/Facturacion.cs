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
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            Articulofac.Enabled = false;
            Descripcionfac.Enabled = false;
            Preciofac.Enabled = false;
            Cantidadfac.Enabled = false;
            Subtotalfac.Enabled = false;
            Guardarfac.Enabled = false;
            Imprimifac.Enabled = false;

        }


        public DataTable eliminar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "Delete TemDetalleFactura";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }

        private void Nuevofac_Click(object sender, EventArgs e)
        {
            Articulofac.Enabled = true;
            Descripcionfac.Enabled = true;
            Preciofac.Enabled = true;
            Cantidadfac.Enabled = true;
            

            //Limpiar los textos combobox y richtbox
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
                this.PDESC.Text = "0";
                this.PITBIS.Text = "0";
                Descuento.Text = "0";
                ITBIS.Text = "0";

                //-Incrementar el codigo en orden ascendente 
                Conexion.Conectar();
                SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(num_fac as int)),0)+1 from Factura", Conexion.Conectar());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Numerofac.Text = dt.Rows[0][0].ToString();

            }//...
            Tipofac.Text = "Efectivo";
            Clientefac.Text = "1";
            Nombrefac.Text = "Generico";
            Articulofac.Focus();
            Fechafac.Enabled = true;


            Guardarfac.Enabled = true;

         

            DGfactura.DataSource = eliminar_grid();

        }
        




        private void Fh_Tick(object sender, EventArgs e)
        {
            Horafac.Text = DateTime.Now.ToString("hh:mm:ss");
            Fechafac.Text = DateTime.Now.ToShortDateString();
        }

        private void Buscarclifac_Click(object sender, EventArgs e)
        {
            Cliente frm = new Cliente();
            frm.Show();
        }

        private void Buscarartfac_Click(object sender, EventArgs e)
        {
            Articulo frm = new Articulo();
            frm.Show();
        }

        private void Clientefac_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Buscar un codigo de cliente y mostrar su contenido

            if (e.KeyChar == (char)(Keys.Enter))
            {
                Conexion.Conectar();
                string cadsol = "select*from Cliente  where Cod_cli=" + Clientefac.Text + "";
                SqlCommand comando = new SqlCommand(cadsol, Conexion.Conectar());

                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    Nombrefac.Text = leer["Nom_cli"].ToString();

                }
                else
                {

                    Nombrefac.Text = ("No encontrado");


                }
                e.Handled = true;
                SendKeys.Send("{Tab}");
            }
        }

        private void Articulofac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                Conexion.Conectar();
                string cadsol = "select*from Articulo  where Cod_art=" + Articulofac.Text + "";
                SqlCommand comando = new SqlCommand(cadsol, Conexion.Conectar());

                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    Descripcionfac.Text = leer["Des_art"].ToString();
                    Preciofac.Text = leer["Pre_art"].ToString();

                }
                else
                {

                    Descripcionfac.Text = ("No encontrado");


                }
                e.Handled = true;
                SendKeys.Send("{Tab}");
            }
        }
        public DataTable llenar_gridDF()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "Select * from TemDetalleFactura order by Cod_art desc";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }
        private void Cantidadfac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                {
                    decimal subtotal, pre, can;

                    pre = Convert.ToDecimal(Preciofac.Text);
                    can = Convert.ToDecimal(Cantidadfac.Text);

                    subtotal = (pre * can);
                    Subtotalfac.Text = subtotal.ToString();

                   
                    this.Nombrefac.Focus();

                    //Guardar en la tabla temporal detalledefactura
                    {
                        Conexion.Conectar();
                        string insertar = "Insert INTO TemDetalleFactura(Num_fac,Cod_art,Des_art,Pre_art,Can_art,Sub_tot)Values(@Num_fac,@Cod_art,@Des_art,@Pre_art,@Can_art,@Sub_tot)";
                        SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());

                        cmd1.Parameters.AddWithValue("@num_fac", Numerofac.Text);
                        cmd1.Parameters.AddWithValue("@Cod_art", Articulofac.Text);
                        cmd1.Parameters.AddWithValue("@Des_art", Descripcionfac.Text);
                        cmd1.Parameters.AddWithValue("@Pre_art", Preciofac.Text);
                        cmd1.Parameters.AddWithValue("@Can_art", Cantidadfac.Text);
                        cmd1.Parameters.AddWithValue("@Sub_tot", Subtotalfac.Text);
                        cmd1.ExecuteNonQuery();

                        DGfactura.DataSource = llenar_gridDF();

                    }

                    {
                        // Guardar en la tabla detallefactura
                        Conexion.Conectar();
                        string insertar = "Insert INTO DetalleFactura(Num_fac, Cod_art,Des_art,Pre_art,Can_art,Sub_tot)Values(@Num_fac,@Cod_art,@Des_art,@Pre_art,@Can_art,@Sub_tot)";
                        SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());

                        cmd1.Parameters.AddWithValue("@num_fac", Numerofac.Text);
                        cmd1.Parameters.AddWithValue("@Cod_art", Articulofac.Text);
                        cmd1.Parameters.AddWithValue("@Des_art", Descripcionfac.Text);
                        cmd1.Parameters.AddWithValue("@Pre_art", Preciofac.Text);
                        cmd1.Parameters.AddWithValue("@Can_art", Cantidadfac.Text);
                        cmd1.Parameters.AddWithValue("@Sub_tot", Subtotalfac.Text);
                        cmd1.ExecuteNonQuery();

                    }

                    //Disminuir la existencia

                    {
                        //Disminuir el inventario

                        Conexion.Conectar();
                        string cadena = "update Articulo set Exi_art=Exi_art-" + Cantidadfac.Text + " where Cod_art='" + Articulofac.Text + "'";
                        SqlCommand comando1 = new SqlCommand(cadena, Conexion.Conectar());
                        comando1.ExecuteNonQuery();
                    }

                    {
                        //sumar la columna subtotal

                        double stf = 0;
                        foreach (DataGridViewRow row in DGfactura.Rows)
                            stf += Convert.ToDouble(row.Cells["Sub_tot"].Value);
                        Subtotalfin.Text = Convert.ToString(stf);


                    }

                    {
                        //Sumar la columna total a pagar

                        double tap = 0;
                        foreach (DataGridViewRow row in DGfactura.Rows)
                            tap += Convert.ToDouble(row.Cells["Sub_tot"].Value);
                        Totalapagar.Text = Convert.ToString(tap);
                    }

                    //Limpiar los textos
                    Articulofac.Text = "";
                    Descripcionfac.Text = "";
                    Cantidadfac.Text = "";
                    Preciofac.Text = "";
                    Subtotalfac.Text = "";


                    e.Handled = true;
                    SendKeys.Send("{TAB}");

                    
                   

                }

            }
        }

        private void Guardarfac_Click(object sender, EventArgs e)
        {
            if (Subtotalfin.Text == string.Empty)
            {
                MessageBox.Show("No hay factura para procesar");
                this.Articulofac.Focus();

            }

            else
            {
                //Guardar

                Conexion.Conectar();
                string insertar = "INSERT INTO Factura(Num_fac,Hor_fac,Fec_fac,Cod_Cli,Tip_fac,Nom_cli,Sub_Tot_fac,Des_fac,Itb_fac,Tot_fac,PDF_fac,Pit_fac) Values(@Num_fac,@Hor_fac,@Fec_fac,@Cod_Cli,@Tip_fac,@Nom_cli,@Sub_Tot_fac,@Des_fac,@Itb_fac,@Tot_fac,@PDF_fac,@Pit_fac)";
                SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
                cmd1.Parameters.AddWithValue("@Num_fac", Numerofac.Text);
                cmd1.Parameters.AddWithValue("@Hor_fac", Horafac.Text);
                cmd1.Parameters.AddWithValue("@Fec_fac", Fechafac.Text);
                cmd1.Parameters.AddWithValue("@Cod_cli", Clientefac.Text);
                cmd1.Parameters.AddWithValue("@Tip_fac", Tipofac.Text);
                cmd1.Parameters.AddWithValue("@Nom_cli", Nombrefac.Text);
                cmd1.Parameters.AddWithValue("@Sub_Tot_fac", Subtotalfin.Text);
                cmd1.Parameters.AddWithValue("@Des_fac", Descripcionfac.Text);
                cmd1.Parameters.AddWithValue("@Itb_fac", ITBIS.Text);
                cmd1.Parameters.AddWithValue("@Tot_fac", Totalapagar.Text);
                cmd1.Parameters.AddWithValue("@Pdf_fac", PDESC.Text);
                cmd1.Parameters.AddWithValue("@Pit_fac", PITBIS.Text);

                cmd1.ExecuteNonQuery();
                MessageBox.Show("Registro agregado");


                // caja cj = new caja();
                // cj.Numerofac.Text = this.Numerofac.Text;
                // cj.Totpag.Text = this.Totalapagar.Text;
                // cj.TF.Text = this.Tipofac.Text;
                // cj.show();
                Guardarfac.Enabled = false;


            }


        }

        private void PDESC_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Programacion del descuento
            if (e.KeyChar == (char)(Keys.Enter))
            {
                decimal pddesc = 0;
                decimal dalf = 0;
                decimal stf = 0;
                decimal tf = 0;
                decimal itb = 0;

                stf = Convert.ToDecimal(Subtotalfin.Text);
                pddesc = Convert.ToDecimal(PDESC.Text);
                itb = Convert.ToDecimal(PITBIS.Text );
                dalf = stf * (pddesc / 100);
                Descuento.Text = dalf.ToString();
                tf = (stf - dalf) + itb;
                Totalapagar.Text = tf.ToString();
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void PITBIS_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Calcular el % del itbis
            if (e.KeyChar == (char)(Keys.Enter))
            {
                decimal pitb = 0;
                decimal iaf = 0;
                decimal daaf = 0;
                decimal stf = 0;
                decimal tif = 0;
                decimal tf = 0;
                decimal stnf = 0;

                daaf = Convert.ToDecimal(PDESC.Text);
                stf = Convert.ToDecimal(Subtotalfin.Text);
                pitb = Convert.ToDecimal(PITBIS.Text);
                iaf = stf - daaf;
                tif = iaf * (pitb / 100);
                ITBIS.Text = tif.ToString();
                stnf = stf - daaf;
                tf = stnf + tif;
                Totalapagar.Text = tf.ToString();

                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

        }

        private void Imprimifac_Click(object sender, EventArgs e)
        {
            F3P rn = new F3P();
            rn.Numero.Text = this.Numerofac.Text;
            rn.ShowDialog();
        }
    }

}
