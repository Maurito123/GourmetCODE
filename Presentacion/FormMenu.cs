using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto.Presentacion
{
    public partial class FormMenu : Form
    {
        bool sidebarExpand;
        bool panel11Expand;
        int panel11OriginalWidth;

        public FormMenu()
        {
            InitializeComponent();
            SetFlatStyleToAllButtons(this);

            // Guarda el ancho original del panel11 para usarlo en la animación
            panel11OriginalWidth = panel11.Width;
        }

        private void sidebarTime_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTime.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTime.Stop();
                }
            }

            // Ajusta el tamaño y la posición del panel11 durante la animación
            if (panel11Expand)
            {
                panel11.Width -= 10;
                if (panel11.Width == panel11.MinimumSize.Width)
                {
                    panel11Expand = false;
                }
            }
            else
            {
                panel11.Width += 10;
                if (panel11.Width == panel11OriginalWidth)
                {
                    panel11Expand = true;
                }
            }
            panel11.Location = new Point(sidebar.Width, panel11.Location.Y);
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            sidebarTime.Start();
        }
        private void SetFlatStyleToAllButtons(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is Button button)
                {
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.BackColor = Color.Transparent;
                }
                else if (ctrl.HasChildren)
                {
                    SetFlatStyleToAllButtons(ctrl);
                }
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormAltaCliente formAltaCliente = new FormAltaCliente();

            // Configurar el formulario secundario para que no tenga borde de formulario propio
            formAltaCliente.FormBorderStyle = FormBorderStyle.None;

            // Establecer el formulario secundario como hijo del panel11
            formAltaCliente.TopLevel = false;
            panel11.Controls.Clear(); // Limpia el panel si ya hay controles en él
            panel11.Controls.Add(formAltaCliente);

            // Mostrar el formulario dentro del panel11
            formAltaCliente.Show();
        }
    }
}

