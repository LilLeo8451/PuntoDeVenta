using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PuntoDeVenta
{
    public partial class ProcesoDeVentaForm : Form
    {
        private List<Producto> productosEnVenta = new List<Producto>();
        private decimal subtotal = 0;
        private decimal impuestos = 0;
        private decimal total = 0;

        public ProcesoDeVentaForm()
        {
            InitializeComponent();
            InicializarDataGridView();
        }

        private void InicializarDataGridView()
        {
            dgvProductos.Columns.Add("Codigo", "Código");
            dgvProductos.Columns.Add("Nombre", "Nombre");
            dgvProductos.Columns.Add("Cantidad", "Cantidad");
            dgvProductos.Columns.Add("Precio", "Precio Unitario");
            dgvProductos.Columns.Add("Subtotal", "Subtotal");

            dgvProductos.Columns["Codigo"].Width = 100;
            dgvProductos.Columns["Nombre"].Width = 200;
            dgvProductos.Columns["Cantidad"].Width = 100;
            dgvProductos.Columns["Precio"].Width = 100;
            dgvProductos.Columns["Subtotal"].Width = 100;
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            // Simular búsqueda de producto por código o nombre
            string criterio = txtBuscarProducto.Text.Trim();
            Producto producto = BuscarProducto(criterio);

            if (producto == null)
            {
                MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Agregar producto a la lista de venta
            productosEnVenta.Add(producto);

            // Actualizar el DataGridView
            dgvProductos.Rows.Add(producto.Codigo, producto.Nombre, producto.Cantidad,
                                  producto.Precio.ToString("C"), producto.Subtotal.ToString("C"));

            // Actualizar totales
            ActualizarTotales();
            txtBuscarProducto.Clear();
        }

        private Producto BuscarProducto(string criterio)
        {
            Producto productoEncontrado = null;

            using (var conexion = DbConnection.GetConnection())
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM Productos WHERE codigo = @criterio OR nombre LIKE @criterioNombre LIMIT 1";
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@criterio", criterio);
                        comando.Parameters.AddWithValue("@criterioNombre", $"%{criterio}%");

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                int stockDisponible = Convert.ToInt32(lector["stock"]);

                                // Verificamos si hay suficiente stock
                                if (stockDisponible > 0)
                                {
                                    productoEncontrado = new Producto
                                    {
                                        Codigo = lector["codigo"].ToString(),
                                        Nombre = lector["nombre"].ToString(),
                                        Precio = Convert.ToDecimal(lector["precio"]),
                                        Cantidad = 1 // Inicialmente agregamos 1 unidad
                                    };
                                }
                                else
                                {
                                    MessageBox.Show("No hay suficiente stock de este producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return productoEncontrado;
        }



        private void ActualizarTotales()
        {
            subtotal = 0;
            foreach (var producto in productosEnVenta)
            {
                subtotal += producto.Subtotal;
            }

            impuestos = subtotal * 0.16m; // Suponiendo 16% de IVA
            total = subtotal + impuestos;

            lblSubtotal.Text = $"Subtotal: {subtotal:C}";
            lblImpuestos.Text = $"Impuestos: {impuestos:C}";
            lblTotal.Text = $"Total: {total:C}";
        }
        private void FinalizarVenta()
        {
            if (productosEnVenta.Count == 0)
            {
                MessageBox.Show("No hay productos en la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Suponiendo que solo vendemos un producto por venta
            Producto producto = productosEnVenta[0]; // El primer producto en la lista

            using (var conexion = DbConnection.GetConnection())
            {
                try
                {
                    conexion.Open();
                    MySqlTransaction transaccion = conexion.BeginTransaction();

                    // Insertar la venta en la tabla Ventas con el código del producto
                    string queryVenta = "INSERT INTO Ventas (fecha, total, producto_codigo) VALUES (@fecha, @total, @producto_codigo)";
                    using (var comandoVenta = new MySqlCommand(queryVenta, conexion, transaccion))
                    {
                        comandoVenta.Parameters.AddWithValue("@fecha", DateTime.Now);  // Fecha actual
                        comandoVenta.Parameters.AddWithValue("@total", total);          // Total de la venta
                        comandoVenta.Parameters.AddWithValue("@producto_codigo", producto.Codigo);  // Código del producto
                        comandoVenta.ExecuteNonQuery();
                    }

                    // Actualizar el stock del producto en la tabla Productos
                    string queryActualizarStock = "UPDATE Productos SET stock = stock - @cantidad WHERE codigo = @codigo_producto";
                    using (var comandoStock = new MySqlCommand(queryActualizarStock, conexion, transaccion))
                    {
                        comandoStock.Parameters.AddWithValue("@cantidad", producto.Cantidad);
                        comandoStock.Parameters.AddWithValue("@codigo_producto", producto.Codigo);  // Código del producto
                        comandoStock.ExecuteNonQuery();
                    }

                    // Commit de la transacción
                    transaccion.Commit();

                    // Limpiar los datos de la venta actual
                    productosEnVenta.Clear();
                    dgvProductos.Rows.Clear();  // Si usas un DataGridView para mostrar los productos
                    ActualizarTotales();

                    MessageBox.Show("Venta finalizada y stock actualizado.", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Si algo sale mal, revertir los cambios
                    MessageBox.Show($"Error al finalizar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void BtnFinalizarVenta_Click(object sender, EventArgs e)
        {
            if (productosEnVenta.Count == 0)
            {
                MessageBox.Show("No hay productos en la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificación del total
            if (total <= 0)
            {
                MessageBox.Show("El total de la venta no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                FinalizarVenta();  // Llamamos al método para insertar la venta

                // Limpiar los datos de la venta actual
                productosEnVenta.Clear();
                dgvProductos.Rows.Clear();  // Si usas un DataGridView para mostrar los productos
                ActualizarTotales();        // Actualizamos los totales a 0

                MessageBox.Show("Venta finalizada y registrada en la base de datos.", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al finalizar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void BtnCancelarVenta_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("¿Seguro que desea cancelar la venta?", "Confirmación",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                productosEnVenta.Clear();
                dgvProductos.Rows.Clear();
                ActualizarTotales();
            }
        }
    }

    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public decimal Subtotal
        {
            get { return Precio * Cantidad; }
        }
    }
}