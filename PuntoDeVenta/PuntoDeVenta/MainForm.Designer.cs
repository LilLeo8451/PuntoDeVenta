namespace PuntoDeVenta
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnNuevoVenta;
        private System.Windows.Forms.Button btnConsultarVentas;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnReporteVentas; // Nuevo botón agregado

        private void InitializeComponent()
        {
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.btnNuevoVenta = new System.Windows.Forms.Button();
            this.btnConsultarVentas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnReporteVentas = new System.Windows.Forms.Button(); // Instancia del nuevo botón

            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(12, 150);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(776, 200);
            this.dgvVentas.TabIndex = 0;

            // 
            // btnNuevoVenta
            // 
            this.btnNuevoVenta.Location = new System.Drawing.Point(12, 60);
            this.btnNuevoVenta.Name = "btnNuevoVenta";
            this.btnNuevoVenta.Size = new System.Drawing.Size(150, 30);
            this.btnNuevoVenta.TabIndex = 1;
            this.btnNuevoVenta.Text = "Nueva Venta";
            this.btnNuevoVenta.UseVisualStyleBackColor = true;
            this.btnNuevoVenta.Click += new System.EventHandler(this.BtnNuevoVenta_Click);

            // 
            // btnConsultarVentas
            // 
            this.btnConsultarVentas.Location = new System.Drawing.Point(168, 60);
            this.btnConsultarVentas.Name = "btnConsultarVentas";
            this.btnConsultarVentas.Size = new System.Drawing.Size(150, 30);
            this.btnConsultarVentas.TabIndex = 2;
            this.btnConsultarVentas.Text = "Consultar Ventas";
            this.btnConsultarVentas.UseVisualStyleBackColor = true;
            this.btnConsultarVentas.Click += new System.EventHandler(this.BtnConsultarVentas_Click);

            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(324, 60);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(150, 30);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.BtnProductos_Click);

            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(480, 60);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(150, 30);
            this.btnEmpleados.TabIndex = 4;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);

            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(320, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(160, 26);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Punto de Venta";

            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(640, 60);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(150, 30);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);

            // 
            // btnReporteVentas
            // 
            this.btnReporteVentas.Location = new System.Drawing.Point(12, 110);
            this.btnReporteVentas.Name = "btnReporteVentas";
            this.btnReporteVentas.Size = new System.Drawing.Size(150, 30);
            this.btnReporteVentas.TabIndex = 7;
            this.btnReporteVentas.Text = "Reporte de Ventas";
            this.btnReporteVentas.UseVisualStyleBackColor = true;
            this.btnReporteVentas.Click += new System.EventHandler(this.BtnReporteVentas_Click);

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.btnNuevoVenta);
            this.Controls.Add(this.btnConsultarVentas);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnReporteVentas); // Agregar el nuevo botón al formulario
            this.Name = "MainForm";
            this.Text = "Pantalla Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
