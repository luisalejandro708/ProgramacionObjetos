namespace ProgramacionObjetos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnGestionarClientes_Click_1(object sender, EventArgs e)
        {
            // Codigo para agregar el nuevo formulario
            GestionClientes ventanaGestionClientes = new GestionClientes();
            ventanaGestionClientes.ShowDialog();
        }
    }
}