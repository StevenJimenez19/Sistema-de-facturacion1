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
using ClosedXML.Excel;
using System.IO;

namespace Sistema_de_facturacion
{
    public partial class Reporte_de_ventas_diarias : Form
    {
        public Reporte_de_ventas_diarias()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void CargarReporte()
        {
            dgvReportes.Rows.Clear();

            SqlConnection con = Conexion.Conectar();
            SqlCommand cmd = new SqlCommand(
                @"SELECT Fec_fac, Num_fac, Nom_cli, Tot_fac, Estado
                  FROM Factura
                  WHERE Fec_fac BETWEEN @inicio AND @fin", con);

            cmd.Parameters.AddWithValue("@inicio", dtpInicio.Value.Date);
            cmd.Parameters.AddWithValue("@fin", dtpFin.Value.Date);

            SqlDataReader dr = cmd.ExecuteReader();

            decimal total = 0;

            while (dr.Read())
            {
                dgvReportes.Rows.Add(
                    Convert.ToDateTime(dr["Fec_fac"]).ToShortDateString(),
                    dr["Num_fac"],
                    dr["Nom_cli"],
                    dr["Tot_fac"],
                    dr["Estado"]
                );

                total += Convert.ToDecimal(dr["Tot_fac"]);
            }

            lblTotalVentas.Text = "$ " + total.ToString("N2");
            lblGanancia.Text = lblTotalVentas.Text; // simplificado
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvReportes.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel (*.xlsx)|*.xlsx";
            save.FileName = "Reporte_Ventas.xlsx";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (XLWorkbook wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add("Ventas");

                    // Encabezados
                    for (int i = 0; i < dgvReportes.Columns.Count; i++)
                    {
                        ws.Cell(1, i + 1).Value = dgvReportes.Columns[i].HeaderText;
                        ws.Cell(1, i + 1).Style.Font.Bold = true;
                    }

                    // Datos
                    for (int i = 0; i < dgvReportes.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvReportes.Columns.Count; j++)
                        {
                            ws.Cell(i + 2, j + 1).Value =
                                dgvReportes.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    ws.Columns().AdjustToContents();
                    wb.SaveAs(save.FileName);
                }

                MessageBox.Show("Reporte exportado correctamente");
            }
        }
    }

}

