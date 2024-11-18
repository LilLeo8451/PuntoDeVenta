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
    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            string nombreCompleto = txtNombreCompleto.Text;
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            string rol = cmbRol.SelectedItem.ToString();

            if (RegistrarUsuario(nombreCompleto, usuario, contraseña, rol))
            {
                MessageBox.Show("Registro exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cierra el formulario de registro
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool RegistrarUsuario(string nombreCompleto, string usuario, string contraseña, string rol)
        {
            string query = "INSERT INTO usuarios (username, password, nombre_completo, rol) " +
                           "VALUES (@username, MD5(@password), @nombre_completo, @rol)";

            using (MySqlConnection connection = DbConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", usuario);
                    command.Parameters.AddWithValue("@password", contraseña);  // MD5 para encriptar la contraseña
                    command.Parameters.AddWithValue("@nombre_completo", nombreCompleto);
                    command.Parameters.AddWithValue("@rol", rol);

                    int resultado = command.ExecuteNonQuery();
                    return resultado > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al registrar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario de registro
        }
    }
}
