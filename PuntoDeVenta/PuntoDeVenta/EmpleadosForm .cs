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
    public partial class EmpleadosForm : Form
    {
        public EmpleadosForm()
        {
            InitializeComponent();
            CargarEmpleados();
        }

        // Método para cargar los empleados en el DataGridView
        private void CargarEmpleados()
        {
            dgvEmpleados.Rows.Clear();

            using (var conexion = DbConnection.GetConnection())
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM Empleados";
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                dgvEmpleados.Rows.Add(
                                    lector["id"].ToString(),
                                    lector["nombre"].ToString(),
                                    lector["correo"].ToString(),
                                    lector["telefono"].ToString(),
                                    lector["cargo"].ToString()
                                );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Método para agregar un empleado
        private void BtnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreEmpleado.Text.Trim();
            string correo = txtCorreoEmpleado.Text.Trim();
            string telefono = txtTelefonoEmpleado.Text.Trim();
            string cargo = cmbCargoEmpleado.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(cargo))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conexion = DbConnection.GetConnection())
            {
                try
                {
                    conexion.Open();
                    string query = "INSERT INTO Empleados (nombre, correo, telefono, cargo) VALUES (@nombre, @correo, @telefono, @cargo)";
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@correo", correo);
                        comando.Parameters.AddWithValue("@telefono", telefono);
                        comando.Parameters.AddWithValue("@cargo", cargo);

                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Empleado agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEmpleados(); // Recargar la lista
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Método para editar un empleado
        private void BtnEditarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un empleado para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filaSeleccionada = dgvEmpleados.SelectedRows[0];
            int idEmpleado = Convert.ToInt32(filaSeleccionada.Cells[0].Value);
            string nombre = txtNombreEmpleado.Text.Trim();
            string correo = txtCorreoEmpleado.Text.Trim();
            string telefono = txtTelefonoEmpleado.Text.Trim();
            string cargo = cmbCargoEmpleado.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(cargo))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conexion = DbConnection.GetConnection())
            {
                try
                {
                    conexion.Open();
                    string query = "UPDATE Empleados SET nombre = @nombre, correo = @correo, telefono = @telefono, cargo = @cargo WHERE id = @id";
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", idEmpleado);
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@correo", correo);
                        comando.Parameters.AddWithValue("@telefono", telefono);
                        comando.Parameters.AddWithValue("@cargo", cargo);

                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Empleado editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEmpleados(); // Recargar la lista
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al editar empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Método para eliminar un empleado
        private void BtnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un empleado para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filaSeleccionada = dgvEmpleados.SelectedRows[0];
            int idEmpleado = Convert.ToInt32(filaSeleccionada.Cells[0].Value);

            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este empleado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                using (var conexion = DbConnection.GetConnection())
                {
                    try
                    {
                        conexion.Open();
                        string query = "DELETE FROM Empleados WHERE id = @id";
                        using (var comando = new MySqlCommand(query, conexion))
                        {
                            comando.Parameters.AddWithValue("@id", idEmpleado);
                            comando.ExecuteNonQuery();
                        }

                        MessageBox.Show("Empleado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarEmpleados(); // Recargar la lista
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Método para actualizar la lista de empleados
        private void BtnActualizarEmpleados_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
        }
    }
}
