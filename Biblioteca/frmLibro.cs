using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Biblioteca
{
    public partial class frmLibro : Form
    {
        public frmLibro()
        {
            InitializeComponent();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string ruta = @"C:\Users\hristochavez\Documents\libros.txt"; //ruta para importar la base de datos
            string[] libros = File.ReadAllLines(ruta); //lee todas la líneas
            if (txtLibros.Text.Length == 0) //si está vacío, llena el textbox
            {
                foreach (string linea in libros)  //recorrido de libros
                {
                    txtLibros.Text += linea + "\r" + "\n"; 
                    //se añade línea por línea
                }
            }
            else //en caso txtLibros no esté vacío, se realiza la limpieza
            {
                txtLibros.Text = "";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string ruta = @"C:\Users\hristochavez\Documents\libros.txt"; //ruta para exportar a la base de datos
            using (StreamWriter writer = new StreamWriter(ruta)) //permite escribir
                                                                 //en el archivo
            {
                //Escribir en un archivo de texto:
                writer.WriteLine(txtLibros.Text); //escribe lo del multilínea
                writer.Close(); //cierra el archivo
            }
        }
    }
}
