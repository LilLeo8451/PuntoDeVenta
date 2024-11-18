using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Evento para el botón "Nueva Venta"
 
        private void BtnNuevoVenta_Click(object sender, EventArgs e)
        {
            // Aquí se abrirá el formulario de proceso de venta (ProcesoDeVentaForm)
            ProcesoDeVentaForm procesoDeVentaForm = new ProcesoDeVentaForm();
            procesoDeVentaForm.Show();
        }


        // Evento para el botón "Consultar Ventas"
        private void BtnConsultarVentas_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de consulta de ventas
            ConsultarVentasForm consultarVentasForm = new ConsultarVentasForm();
            consultarVentasForm.Show();
        }


        // Evento para el botón "Productos"
        private void BtnProductos_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de gestión de productos
            ProductosForm productosForm = new ProductosForm();
            productosForm.Show();
        }

        // Evento para el botón "Empleados"
        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de gestión de empleados
            EmpleadosForm empleadosForm = new EmpleadosForm();
            empleadosForm.Show();
        }

        // Evento para el botón "Cerrar Sesión"
        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Aquí se puede cerrar la aplicación o redirigir al login
            Application.Exit();
        }
        private void BtnReporteVentas_Click(object sender, EventArgs e)
        {
            ReporteDeVentasForm reporteForm = new ReporteDeVentasForm();
            reporteForm.Show();
        }
    }
}
