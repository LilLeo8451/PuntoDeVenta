namespace PuntoDeVenta
{
    partial class ConsultarVentasForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvVentas;

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
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();

            // dgvVentas
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(12, 12);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(760, 400);
            this.dgvVentas.TabIndex = 0;

            // ConsultarVentasForm
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.dgvVentas);
            this.Name = "ConsultarVentasForm";
            this.Text = "Consultar Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
