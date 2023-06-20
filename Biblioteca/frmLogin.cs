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
            if(txtUsuario.Text.Equals("Admin")|| 
                txtContrasenia.Text.Equals("12345"))
            {
                /*frmUsuario frmUsuario=new frmUsuario();
                frmUsuario.Show();
                this.Hide();*/
                frmLibro frmLibro=new frmLibro();
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