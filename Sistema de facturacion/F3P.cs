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
using CrystalDecisions.CrystalReports.Engine;


namespace Sistema_de_facturacion
{
    public partial class F3P : Form
    {
        public F3P()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string consulta = "Select *from ventas where num_fac=@parametro";
            SqlCommand comando = new SqlCommand(consulta, Conexion.Conectar());
            comando.Parameters.AddWithValue("@parametro", Numero.Text);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            ReportDocument reporte = CRV3P.ReportSource as ReportDocument;
            reporte.SetDataSource(dt);
            CRV3P.Refresh();


        }
    }
}
