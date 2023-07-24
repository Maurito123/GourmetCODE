using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuProyecto.Logica;

namespace proyecto.Presentacion
{
    public partial class FormLogin : Form
    {
        private LogicLayer logicLayer;

        public FormLogin()
        {
            InitializeComponent();
            logicLayer = new LogicLayer();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Obtener el nombre de usuario y contraseña ingresados por el usuario.
            string username = txtUsuario.Text;
            string password = txtContrasena.Text;

            // Verificar el inicio de sesión utilizando la capa lógica.
            bool loginSuccessful = logicLayer.VerifyLogin(username, password);

            if (loginSuccessful)
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                // Aquí puedes abrir el formulario principal o realizar otras acciones después del inicio de sesión exitoso.
                this.Hide();

                // Mostrar el formulario del menú (FormMenu).
                Menu formMenu = new Menu();
                formMenu.ShowDialog();

                // Cerrar la aplicación cuando se cierre el formulario del menú.
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Inicio de sesión fallido. Verifica tus credenciales.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
