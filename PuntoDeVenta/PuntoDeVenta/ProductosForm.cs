using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PuntoDeVenta
{
    public partial class ProductosForm : Form
    {
        public ProductosForm()
        {
            InitializeComponent();
            CargarProductos();
        }

        // Método para cargar los productos en el DataGridView
        private void CargarProductos()
        {
            dgvProductos.Rows.Clear();

            using (var conexion = DbConnection.GetConnection())
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM Productos";
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                dgvProductos.Rows.Add(
                                    lector["codigo"].ToString(),
                                    lector["nombre"].ToString(),
                                    Convert.ToDecimal(lector["precio"]).ToString("C"),
                                    lector["stock"].ToString()
                                );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Método para agregar un producto
        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            string nombre = txtNombreProducto.Text.Trim();
            decimal precio =numPrecio.Value;
            int stock = (int)numStock.Value;

            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Código y nombre son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conexion = DbConnection.GetConnection())
            {
                try
                {
                    conexion.Open();
                    string query = "INSERT INTO Productos (codigo, nombre, precio, stock) VALUES (@codigo, @nombre, @precio, @stock)";
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@codigo", codigo);
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@precio", precio);
                        comando.Parameters.AddWithValue("@stock", stock);

                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos(); // Recargar la lista
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Método para editar un producto
        private void BtnEditarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un producto para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener los datos del producto seleccionado
            var filaSeleccionada = dgvProductos.SelectedRows[0];
            string codigo = filaSeleccionada.Cells[0].Value.ToString();
            string nombre = txtNombreProducto.Text.Trim();
            decimal precio = numPrecio.Value;
            int stock = (int)numStock.Value;

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Debe ingresar un nombre para el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conexion = DbConnection.GetConnection())
            {
                try
                {
                    conexion.Open();
                    string query = "UPDATE Productos SET nombre = @nombre, precio = @precio, stock = @stock WHERE codigo = @codigo";
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@codigo", codigo);
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@precio", precio);
                        comando.Parameters.AddWithValue("@stock", stock);

                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Producto editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos(); // Recargar la lista
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al editar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Método para eliminar un producto
        private void BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filaSeleccionada = dgvProductos.SelectedRows[0];
            string codigo = filaSeleccionada.Cells[0].Value.ToString();

            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                using (var conexion = DbConnection.GetConnection())
                {
                    try
                    {
                        conexion.Open();
                        string query = "DELETE FROM Productos WHERE codigo = @codigo";
                        using (var comando = new MySqlCommand(query, conexion))
                        {
                            comando.Parameters.AddWithValue("@codigo", codigo);
                            comando.ExecuteNonQuery();
                        }

                        MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarProductos(); // Recargar la lista
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Método para actualizar la lista de productos
        private void BtnActualizarLista_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }
    }
}
