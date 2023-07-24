namespace proyecto.Presentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAltas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAlta formAlta = new FormAlta();
            formAlta.ShowDialog();
            this.Show();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBaja formBaja = new FormBaja();
            formBaja.ShowDialog();
            this.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
