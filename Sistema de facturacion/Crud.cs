using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_de_facturacion
{
    public partial class Crud : Form
    {
        private string connectionString = @"Server=DESKTOP-PHTCG9K\SQLEXPRESS;Database=Facturacion;Integrated Security=True";
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public Crud()
        {
            InitializeComponent();
        }

        private void Crud_Load_1(object sender, EventArgs e)
        {
            CargarArticuloStockBajo();
        }

        private void CargarArticuloStockBajo()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Cod_art, Des_art, Exi_art, Pre_art FROM Articulo WHERE Exi_art < Can_min";
                    dataAdapter = new SqlDataAdapter(query, conn);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvStockBajo.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar artículos: " + ex.Message);
            }
        }

      

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Genera Cod_art automáticamente
                    int nuevoCodArt = 1;
                    string queryMax = "SELECT ISNULL(MAX(Cod_art), 0) + 1 FROM Articulo";
                    using (SqlCommand cmdMax = new SqlCommand(queryMax, conn))
                    {
                        nuevoCodArt = (int)cmdMax.ExecuteScalar();
                    }

                    string queryInsert = "INSERT INTO Articulo (Cod_art, Des_art, Cos_art, Pre_art, Can_art, Exi_art, Can_min) " +
                                         "VALUES (@Cod_art, @Des_art, @Cos_art, @Pre_art, @Can_art, @Exi_art, @Can_min)";
                    using (SqlCommand cmd = new SqlCommand(queryInsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cod_art", nuevoCodArt);
                        cmd.Parameters.AddWithValue("@Des_art", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@Cos_art", int.Parse(txtCosto.Text.Trim()));
                        cmd.Parameters.AddWithValue("@Pre_art", int.Parse(txtPrecio.Text.Trim()));
                        cmd.Parameters.AddWithValue("@Can_art", int.Parse(txtStock.Text.Trim()));
                        cmd.Parameters.AddWithValue("@Exi_art", int.Parse(txtExistecia.Text.Trim()));
                        cmd.Parameters.AddWithValue("@Can_min", 5); // puedes ajustar este valor

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Artículo agregado correctamente.");
                LimpiarCampos();
                CargarArticuloStockBajo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar artículo: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvStockBajo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un artículo para eliminar.");
                return;
            }

            try
            {
                int cod_art = Convert.ToInt32(dgvStockBajo.SelectedRows[0].Cells["Cod_art"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Articulo WHERE Cod_art = @Cod_art";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cod_art", cod_art);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Artículo eliminado correctamente.");
                CargarArticuloStockBajo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar artículo: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Cod_art, Des_art, Cos_art, Pre_art, Can_art, Exi_art FROM Articulo WHERE Des_art LIKE @Des_art";
                    dataAdapter = new SqlDataAdapter(query, conn);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@Des_art", "%" + txtProductos.Text.Trim() + "%");
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvStockBajo.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar artículos: " + ex.Message);
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            
                CargarArticuloStockBajo();
            
        }

        // -----------------------------
        // Validar que los campos no estén vacíos
        // -----------------------------
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCosto.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text) ||
                string.IsNullOrWhiteSpace(txtExistecia.Text))
            {
                MessageBox.Show("Completa todos los campos antes de guardar.");
                return false;
            }

            // Validar que sean números
            if (!int.TryParse(txtCosto.Text.Trim(), out _) ||
                !int.TryParse(txtPrecio.Text.Trim(), out _) ||
                !int.TryParse(txtStock.Text.Trim(), out _) ||
                !int.TryParse(txtExistecia.Text.Trim(), out _))
            {
                MessageBox.Show("Costo, Precio, Stock y Existencia deben ser números.");
                return false;
            }

            return true;
        }

        // -----------------------------
        // Limpiar TextBox
        // -----------------------------
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCosto.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtExistecia.Clear();
            txtProductos.Clear();
        }
    }
}
    
    

    


