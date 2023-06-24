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
            if ((txtUsuario.Text.Equals("Admin")||txtUsuario.Text.Equals("Erick"))&&
                txtContrasenia.Text.Equals("12345"))
            {
                frmLibro frmLibro = new frmLibro();
                frmLibro.Show();
                this.Hide();
            }
            else
            {
                txtUsuario.Text = "";
                txtContrasenia.Text = "";
            }
        }
    }
}