using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PuntoDeVenta
{
    public partial class ReporteDeVentasForm : Form
    {
        public ReporteDeVentasForm()
        {
            InitializeComponent();
        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFin = dtpFechaFin.Value.Date;

            using (var connection = DbConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT id AS 'ID Venta', fecha AS 'Fecha', total AS 'Total'
                        FROM Ventas
                        WHERE fecha BETWEEN @fechaInicio AND @fechaFin
                        ORDER BY fecha ASC";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@fechaFin", fechaFin);

                        DataTable dataTable = new DataTable();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        adapter.Fill(dataTable);

                        dgvReporteVentas.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
