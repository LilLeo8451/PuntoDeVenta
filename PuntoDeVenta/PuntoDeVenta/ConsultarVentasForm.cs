using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class ConsultarVentasForm : Form
    {
        public ConsultarVentasForm()
        {
            InitializeComponent();
            CargarVentas();
        }

        // Método para cargar las últimas ventas
        private void CargarVentas()
        {
            try
            {
                using (var conexion = DbConnection.GetConnection())
                {
                    conexion.Open();

                    // Consulta para obtener las últimas ventas
                    string query = "SELECT v.id, v.fecha, v.total, p.nombre AS Producto " +
                                   "FROM Ventas v " +
                                   "JOIN Productos p ON v.producto_codigo = p.codigo " +
                                   "ORDER BY v.fecha DESC LIMIT 10"; // Muestra las últimas 10 ventas

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                    DataTable ventasTable = new DataTable();
                    adapter.Fill(ventasTable);

                    // Asignamos los datos al DataGridView
                    dgvVentas.DataSource = ventasTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
