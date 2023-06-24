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
    public partial class FrmRegistroLibro : Form
    {
        public FrmRegistroLibro(string fullPath, ABB abb)
        {
            InitializeComponent();
            this.fullPath = fullPath;
            this.abb = abb;
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
                // Atributos de los libros.
                string titulo, autor, editorial, pais;
                int anio;

                // Campos de texto.
                titulo = this.txtTitulo.Text;
                autor = this.txtAutor.Text;
                editorial = this.txtEditorial.Text;
                pais = this.txtPais.Text;
                anio = int.Parse(this.txtAnio.Text);

                this.id = this.abb.isEmpty() ? this.id++ : 
                    this.abb.getGreaterId() + 1;

                // Instancia de la clase libro.
                Libro l = new Libro(id, titulo, autor, editorial, pais,
                    anio);

                this.abb.add(l);

                using (StreamWriter sw = File.AppendText(this.fullPath))
                {
                    sw.WriteLine(this.createLine(id, titulo, autor,
                        editorial, pais, anio));
                }

                // Mensaje de registro exitoso.
                MessageBoxButtons btnOk = MessageBoxButtons.OK;
                MessageBoxIcon icoInfo = MessageBoxIcon.Information;
                string msg = "Libro almacenado.";
                string titleConfr = "Registro de libros";
                MessageBox.Show(msg, titleConfr, btnOk, icoInfo);

                // Limpieza de cuadros de texto.
                this.resetTxtBox();
            }
        }

        // Crea un linea con los atributos del libro separados por ";".
        private string createLine(int id, string titulo, string autor,
            string editorial, string pais, int anio)
        {
            return id + ";" + titulo + ";" + autor + ";" + editorial + ";"
                + pais + ";" + anio;
        }

        // Valida que los cuadros de texto no esten vacios.
        private bool validateTxtBox()
        {
            TextBox[] textBoxes = new TextBox[5];
            textBoxes[0] = this.txtTitulo;
            textBoxes[1] = this.txtAutor;
            textBoxes[2] = this.txtEditorial;
            textBoxes[3] = this.txtPais;
            textBoxes[4] = this.txtAnio;

            foreach (TextBox tb in textBoxes)
            {
                if (tb.Text.Equals(""))
                {
                    return false;
                }
            }
            return true;
        }

        // Limpia los cuadros de texto despues de un registro exitoso de un
        // libro.
        private void resetTxtBox()
        {
            TextBox[] textBoxes = new TextBox[5];
            textBoxes[0] = this.txtTitulo;
            textBoxes[1] = this.txtAutor;
            textBoxes[2] = this.txtEditorial;
            textBoxes[3] = this.txtPais;
            textBoxes[4] = this.txtAnio;

            foreach (TextBox tb in textBoxes)
            {
                tb.Text = "";
            }
        }
    }
}
