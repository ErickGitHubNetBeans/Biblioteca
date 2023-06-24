namespace Biblioteca
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //usuario Admin, contrasenia 12345
            if (txtUsuario.Text.Equals("admin") &&
                txtContrasenia.Text.Equals("12345"))
            {
                // Ruta de la carpeta.
                string dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // Nombre del archivo.
                string filename = "libros.txt";

                // Ruta completa del archivo.
                string fullPath = dir + "\\" + filename;

                // Nuevo árbol binario de busqueda accesible a lo largo 
                // de toda la aplicación mientras está en ejecución.
                ABB abb = new ABB();

                FrmMenuPrincipal menuPrincipal = 
                    new FrmMenuPrincipal(fullPath, abb);
                this.Hide();
                menuPrincipal.Show();
            }
            else
            {
                txtUsuario.Text = "";
                txtContrasenia.Text = "";
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}