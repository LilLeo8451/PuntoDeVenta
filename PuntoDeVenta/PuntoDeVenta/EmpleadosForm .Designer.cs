namespace PuntoDeVenta
{
    partial class EmpleadosForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Button btnEditarEmpleado;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Button btnActualizarEmpleados;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtCorreoEmpleado;
        private System.Windows.Forms.TextBox txtTelefonoEmpleado;
        private System.Windows.Forms.ComboBox cmbCargoEmpleado;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Label lblCorreoEmpleado;
        private System.Windows.Forms.Label lblTelefonoEmpleado;
        private System.Windows.Forms.Label lblCargoEmpleado;

        // Método para liberar recursos
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvEmpleados = new DataGridView();
            btnAgregarEmpleado = new Button();
            btnEditarEmpleado = new Button();
            btnEliminarEmpleado = new Button();
            btnActualizarEmpleados = new Button();
            txtNombreEmpleado = new TextBox();
            txtCorreoEmpleado = new TextBox();
            txtTelefonoEmpleado = new TextBox();
            cmbCargoEmpleado = new ComboBox();
            lblNombreEmpleado = new Label();
            lblCorreoEmpleado = new Label();
            lblTelefonoEmpleado = new Label();
            lblCargoEmpleado = new Label();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Correo, Telefono, Cargo });
            dgvEmpleados.Location = new Point(12, 250);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.Size = new Size(776, 188);
            dgvEmpleados.TabIndex = 0;
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.Location = new Point(12, 179);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(120, 30);
            btnAgregarEmpleado.TabIndex = 1;
            btnAgregarEmpleado.Text = "Agregar Empleado";
            btnAgregarEmpleado.UseVisualStyleBackColor = true;
            btnAgregarEmpleado.Click += BtnAgregarEmpleado_Click;
            // 
            // btnEditarEmpleado
            // 
            btnEditarEmpleado.Location = new Point(138, 179);
            btnEditarEmpleado.Name = "btnEditarEmpleado";
            btnEditarEmpleado.Size = new Size(120, 30);
            btnEditarEmpleado.TabIndex = 2;
            btnEditarEmpleado.Text = "Editar Empleado";
            btnEditarEmpleado.UseVisualStyleBackColor = true;
            btnEditarEmpleado.Click += BtnEditarEmpleado_Click;
            // 
            // btnEliminarEmpleado
            // 
            btnEliminarEmpleado.Location = new Point(264, 179);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(120, 30);
            btnEliminarEmpleado.TabIndex = 3;
            btnEliminarEmpleado.Text = "Eliminar Empleado";
            btnEliminarEmpleado.UseVisualStyleBackColor = true;
            btnEliminarEmpleado.Click += BtnEliminarEmpleado_Click;
            // 
            // btnActualizarEmpleados
            // 
            btnActualizarEmpleados.Location = new Point(390, 179);
            btnActualizarEmpleados.Name = "btnActualizarEmpleados";
            btnActualizarEmpleados.Size = new Size(120, 30);
            btnActualizarEmpleados.TabIndex = 4;
            btnActualizarEmpleados.Text = "Actualizar Lista";
            btnActualizarEmpleados.UseVisualStyleBackColor = true;
            btnActualizarEmpleados.Click += BtnActualizarEmpleados_Click;
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Location = new Point(95, 12);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(200, 23);
            txtNombreEmpleado.TabIndex = 5;
            // 
            // txtCorreoEmpleado
            // 
            txtCorreoEmpleado.Location = new Point(95, 40);
            txtCorreoEmpleado.Name = "txtCorreoEmpleado";
            txtCorreoEmpleado.Size = new Size(200, 23);
            txtCorreoEmpleado.TabIndex = 6;
            // 
            // txtTelefonoEmpleado
            // 
            txtTelefonoEmpleado.Location = new Point(95, 68);
            txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            txtTelefonoEmpleado.Size = new Size(200, 23);
            txtTelefonoEmpleado.TabIndex = 7;
            // 
            // cmbCargoEmpleado
            // 
            cmbCargoEmpleado.FormattingEnabled = true;
            cmbCargoEmpleado.Items.AddRange(new object[] { "Administrador", "Vendedor", "Cajero" });
            cmbCargoEmpleado.Location = new Point(95, 96);
            cmbCargoEmpleado.Name = "cmbCargoEmpleado";
            cmbCargoEmpleado.Size = new Size(200, 23);
            cmbCargoEmpleado.TabIndex = 8;
            // 
            // lblNombreEmpleado
            // 
            lblNombreEmpleado.AutoSize = true;
            lblNombreEmpleado.Location = new Point(12, 15);
            lblNombreEmpleado.Name = "lblNombreEmpleado";
            lblNombreEmpleado.Size = new Size(54, 15);
            lblNombreEmpleado.TabIndex = 9;
            lblNombreEmpleado.Text = "Nombre:";
            // 
            // lblCorreoEmpleado
            // 
            lblCorreoEmpleado.AutoSize = true;
            lblCorreoEmpleado.Location = new Point(12, 43);
            lblCorreoEmpleado.Name = "lblCorreoEmpleado";
            lblCorreoEmpleado.Size = new Size(46, 15);
            lblCorreoEmpleado.TabIndex = 10;
            lblCorreoEmpleado.Text = "Correo:";
            // 
            // lblTelefonoEmpleado
            // 
            lblTelefonoEmpleado.AutoSize = true;
            lblTelefonoEmpleado.Location = new Point(12, 71);
            lblTelefonoEmpleado.Name = "lblTelefonoEmpleado";
            lblTelefonoEmpleado.Size = new Size(55, 15);
            lblTelefonoEmpleado.TabIndex = 11;
            lblTelefonoEmpleado.Text = "Teléfono:";
            // 
            // lblCargoEmpleado
            // 
            lblCargoEmpleado.AutoSize = true;
            lblCargoEmpleado.Location = new Point(12, 99);
            lblCargoEmpleado.Name = "lblCargoEmpleado";
            lblCargoEmpleado.Size = new Size(42, 15);
            lblCargoEmpleado.TabIndex = 12;
            lblCargoEmpleado.Text = "Cargo:";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // Cargo
            // 
            Cargo.HeaderText = "Cargo";
            Cargo.Name = "Cargo";
            // 
            // EmpleadosForm
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(dgvEmpleados);
            Controls.Add(btnAgregarEmpleado);
            Controls.Add(btnEditarEmpleado);
            Controls.Add(btnEliminarEmpleado);
            Controls.Add(btnActualizarEmpleados);
            Controls.Add(txtNombreEmpleado);
            Controls.Add(txtCorreoEmpleado);
            Controls.Add(txtTelefonoEmpleado);
            Controls.Add(cmbCargoEmpleado);
            Controls.Add(lblNombreEmpleado);
            Controls.Add(lblCorreoEmpleado);
            Controls.Add(lblTelefonoEmpleado);
            Controls.Add(lblCargoEmpleado);
            Name = "EmpleadosForm";
            Text = "Gestión de Empleados";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Cargo;
    }
}

