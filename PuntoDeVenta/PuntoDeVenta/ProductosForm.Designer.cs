namespace PuntoDeVenta
{
    partial class ProductosForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnEditarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnActualizarLista;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.TextBox txtCodigo;  // Agregado: TextBox para el Código
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblDescripcionProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblStockProducto;
        private System.Windows.Forms.Label lblCodigoProducto; // Agregado: Label para el Código

        private void InitializeComponent()
        {
            dgvProductos = new DataGridView();
            btnAgregarProducto = new Button();
            btnEditarProducto = new Button();
            btnEliminarProducto = new Button();
            btnActualizarLista = new Button();
            txtNombreProducto = new TextBox();
            txtDescripcionProducto = new TextBox();
            numPrecio = new NumericUpDown();
            numStock = new NumericUpDown();
            txtCodigo = new TextBox();
            lblNombreProducto = new Label();
            lblDescripcionProducto = new Label();
            lblPrecioProducto = new Label();
            lblStockProducto = new Label();
            lblCodigoProducto = new Label();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Precio, Stock });
            dgvProductos.Location = new Point(12, 190);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(776, 150);
            dgvProductos.TabIndex = 0;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(12, 154);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(120, 30);
            btnAgregarProducto.TabIndex = 1;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += BtnAgregarProducto_Click;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Location = new Point(138, 154);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(120, 30);
            btnEditarProducto.TabIndex = 2;
            btnEditarProducto.Text = "Editar Producto";
            btnEditarProducto.UseVisualStyleBackColor = true;
            btnEditarProducto.Click += BtnEditarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(264, 154);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(120, 30);
            btnEliminarProducto.TabIndex = 3;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += BtnEliminarProducto_Click;
            // 
            // btnActualizarLista
            // 
            btnActualizarLista.Location = new Point(390, 154);
            btnActualizarLista.Name = "btnActualizarLista";
            btnActualizarLista.Size = new Size(120, 30);
            btnActualizarLista.TabIndex = 4;
            btnActualizarLista.Text = "Actualizar Lista";
            btnActualizarLista.UseVisualStyleBackColor = true;
            btnActualizarLista.Click += BtnActualizarLista_Click;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(95, 12);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(200, 23);
            txtNombreProducto.TabIndex = 5;
            // 
            // txtDescripcionProducto
            // 
            txtDescripcionProducto.Location = new Point(95, 40);
            txtDescripcionProducto.Name = "txtDescripcionProducto";
            txtDescripcionProducto.Size = new Size(200, 23);
            txtDescripcionProducto.TabIndex = 6;
            // 
            // numPrecio
            // 
            numPrecio.DecimalPlaces = 2;
            numPrecio.Location = new Point(95, 68);
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(120, 23);
            numPrecio.TabIndex = 7;
            // 
            // numStock
            // 
            numStock.Location = new Point(95, 96);
            numStock.Name = "numStock";
            numStock.Size = new Size(120, 23);
            numStock.TabIndex = 8;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(95, 124);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(200, 23);
            txtCodigo.TabIndex = 9;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Location = new Point(12, 15);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(54, 15);
            lblNombreProducto.TabIndex = 10;
            lblNombreProducto.Text = "Nombre:";
            // 
            // lblDescripcionProducto
            // 
            lblDescripcionProducto.AutoSize = true;
            lblDescripcionProducto.Location = new Point(12, 43);
            lblDescripcionProducto.Name = "lblDescripcionProducto";
            lblDescripcionProducto.Size = new Size(72, 15);
            lblDescripcionProducto.TabIndex = 11;
            lblDescripcionProducto.Text = "Descripción:";
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.AutoSize = true;
            lblPrecioProducto.Location = new Point(12, 71);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(43, 15);
            lblPrecioProducto.TabIndex = 12;
            lblPrecioProducto.Text = "Precio:";
            // 
            // lblStockProducto
            // 
            lblStockProducto.AutoSize = true;
            lblStockProducto.Location = new Point(12, 99);
            lblStockProducto.Name = "lblStockProducto";
            lblStockProducto.Size = new Size(39, 15);
            lblStockProducto.TabIndex = 13;
            lblStockProducto.Text = "Stock:";
            // 
            // lblCodigoProducto
            // 
            lblCodigoProducto.AutoSize = true;
            lblCodigoProducto.Location = new Point(12, 127);
            lblCodigoProducto.Name = "lblCodigoProducto";
            lblCodigoProducto.Size = new Size(49, 15);
            lblCodigoProducto.TabIndex = 14;
            lblCodigoProducto.Text = "Código:";
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            // 
            // ProductosForm
            // 
            ClientSize = new Size(800, 352);
            Controls.Add(dgvProductos);
            Controls.Add(btnAgregarProducto);
            Controls.Add(btnEditarProducto);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnActualizarLista);
            Controls.Add(txtNombreProducto);
            Controls.Add(txtDescripcionProducto);
            Controls.Add(numPrecio);
            Controls.Add(numStock);
            Controls.Add(txtCodigo);
            Controls.Add(lblNombreProducto);
            Controls.Add(lblDescripcionProducto);
            Controls.Add(lblPrecioProducto);
            Controls.Add(lblStockProducto);
            Controls.Add(lblCodigoProducto);
            Name = "ProductosForm";
            Text = "Gestión de Productos";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
    }
}
