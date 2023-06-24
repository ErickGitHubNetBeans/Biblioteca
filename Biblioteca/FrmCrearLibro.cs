using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FrmCrearLibro : Form
    {
        public FrmCrearLibro()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {   
            if (!this.validateTxtBox())
            {
                MessageBoxButtons btnOk = MessageBoxButtons.OK;
                MessageBoxIcon icoWarn = MessageBoxIcon.Warning;
                string msg = "Aún hay campos por llenar.";
                string title = "Validar campos";
                MessageBox.Show(msg, title, btnOk, icoWarn);
            }
            else
            {
                ABB abb = new ABB(); //se instancia árbol

                // Atributos de los libros.
                string title, author;
                int anio;

                // Identificador de libro autoincrementable.
                id = id + 1;

                // Ruta de la carpeta.
                string dir = Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments); //Mis documentos

                // Nombre del archivo.
                string filename = "libros.txt";

                title = this.txtTitle.Text;
                author = this.txtAuthor.Text;
                anio=int.Parse(this.txtYear.Text);

                // Instancia de la clase libro.
                Libro libro = new Libro(id, title, author,anio);

                // Agregar el libro al ABB.
                abb.insertar(libro);

                // Ruta completa del archivo libro.txt.
                string path = dir + "\\" + filename;

                // Escribe una cadena por linea
                using (StreamWriter sw = File.AppendText(path))
                    //Agrega a la BD sin sobreescribirla
                { 
                    //exportar datos y agrega datos
                    sw.WriteLine(createLine(id, title, author,anio));
                }

                // Mensaje de registro exitoso.
                MessageBoxButtons btnOk = MessageBoxButtons.OK;
                MessageBoxIcon icoInfo = MessageBoxIcon.Information;
                string msg = "Libro almacenado.";
                string titleConfr = "Registro de libros";
                MessageBox.Show(msg, titleConfr, btnOk, icoInfo);

                // Limpieza de cuadros de texto.
                resetTxtBox();
            }
        }

        private string createLine(int id, string title, string author,int anio)
        {
            return id + ";" + title + ";" + author + ";" +anio;
        }

        private bool validateTxtBox()
        {
            TextBox[] textBoxes = new TextBox[3];
            textBoxes[0] = this.txtTitle;
            textBoxes[1] = this.txtAuthor;
            textBoxes[2] = this.txtYear;

            foreach (TextBox tb in textBoxes)
            {
                if (tb.Text.Equals(""))
                {
                    return false;
                }
            }
            return true;
        }

        private void resetTxtBox()
        {
            TextBox[] textBoxes = new TextBox[3];
            textBoxes[0] = this.txtTitle;
            textBoxes[1] = this.txtAuthor;
            textBoxes[2] = this.txtYear;

            foreach (TextBox tb in textBoxes)
            {
                tb.Text = "";
            }
        }
    }
}
