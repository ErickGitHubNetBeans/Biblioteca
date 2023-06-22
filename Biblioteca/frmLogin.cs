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
                FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal();
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