using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_de_facturacion
{
    public partial class CxC : Form
    {
        public CxC()
        {
            InitializeComponent();
        }

        private void CxC_Load(object sender, EventArgs e)
        {
            CargarCxC();
        }

        private void CargarCxC(string estado = "Pendiente")
        {
            dgvCxC.Rows.Clear();

            using (SqlConnection con = Conexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT Num_fac, Nom_cli, Fec_fac, Tot_fac, Estado FROM Factura WHERE Estado = @estado",
                    con);

                cmd.Parameters.AddWithValue("@estado", estado);

                SqlDataReader dr = cmd.ExecuteReader();

                decimal total = 0;

                while (dr.Read())
                {
                    dgvCxC.Rows.Add(
                        dr["Num_fac"],
                        dr["Nom_cli"],
                        dr["Fec_fac"],
                        dr["Tot_fac"],
                        dr["Estado"]
                    );

                    total += Convert.ToDecimal(dr["Tot_fac"]);
                }

                lblTotalCobrar.Text = "$ " + total.ToString("N2");
                dr.Close();
            }
        }

            private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            dgvCxC.Rows.Clear();

            SqlConnection con = Conexion.Conectar();
            SqlCommand cmd = new SqlCommand(
                "SELECT Num_fac, Nom_cli, Fec_fac, Tot_fac, Estado FROM Factura WHERE Nom_cli LIKE @nom", con);

            cmd.Parameters.AddWithValue("@nom", "%" + txtBuscarCliente.Text + "%");

            SqlDataReader dr = cmd.ExecuteReader();
            decimal total = 0;

            while (dr.Read())
            {
                dgvCxC.Rows.Add(
                    dr["Num_fac"],
                    dr["Nom_cli"],
                    dr["Fec_fac"],
                    dr["Tot_fac"],
                    dr["Estado"]
                );
                total += Convert.ToDecimal(dr["Tot_fac"]);
            }

            lblTotalCobrar.Text = "$ " + total.ToString("N2");
            dr.Close();

        }

        private void cmbFiltroEstado_TextChanged(object sender, EventArgs e)
        {
            dgvCxC.Rows.Clear();

            SqlConnection con = Conexion.Conectar();
            SqlCommand cmd = new SqlCommand(
                "SELECT Num_fac, Nom_cli, Fec_fac, Tot_fac, Estado FROM Factura WHERE Estado = @estado", con);

            cmd.Parameters.AddWithValue("@estado", cmbFiltroEstado.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            decimal total = 0;

            while (dr.Read())
            {
                dgvCxC.Rows.Add(
                    dr["Num_fac"],
                    dr["Nom_cli"],
                    dr["Fec_fac"],
                    dr["Tot_fac"],
                    dr["Estado"]
                );
                total += Convert.ToDecimal(dr["Tot_fac"]);
            }

            lblTotalCobrar.Text = "$ " + total.ToString("N2");
            dr.Close();
        }

        private void btnRegistrarCobro_Click(object sender, EventArgs e)
        {
            if (dgvCxC.SelectedRows.Count == 0)
    {
        MessageBox.Show("Seleccione una factura");
        return;
    }

    int numFactura = Convert.ToInt32(dgvCxC.SelectedRows[0].Cells[0].Value);

    SqlConnection con = Conexion.Conectar();
    SqlCommand cmd = new SqlCommand(
        "UPDATE Factura SET Estado = 'Pagado' WHERE Num_fac = @num", con);

    cmd.Parameters.AddWithValue("@num", numFactura);
    cmd.ExecuteNonQuery();

    MessageBox.Show("Cobro registrado correctamente");
            CargarCxC();
        }
    }


}
