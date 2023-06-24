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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal(string fullPath, ABB abb)
        {
            InitializeComponent();
            this.fullPath = fullPath;
            this.abb = abb;
            this.loadABB();
        }

        private void btnRegBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistroLibro frmRegistroLibro =
                new FrmRegistroLibro(this.fullPath, this.abb);
            frmRegistroLibro.ShowDialog();
            frmRegistroLibro = null;
            this.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBusquedaLibro frmBusquedaLibro = new FrmBusquedaLibro();
            frmBusquedaLibro.ShowDialog();
            frmBusquedaLibro = null;
            this.Show();
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loadABB()
        {
            if (File.Exists(this.fullPath))
            {
                using (StreamReader sr = new StreamReader(this.fullPath))
                {
                    string line;

                    // Si la linea no es nula, se lee la siguiente linea
                    // y se asigna el la cadena a line.
                    while ((line = sr.ReadLine()) is not null)
                    {
                        // Dado que el árbol solo acepta enteros, tenemos que
                        // convertir el valor de cada linea a entero.
                        abb.add(this.createLibro(line));
                    }
                }
            }
        }

        private Libro createLibro(string line)
        {
            string atributo;
            string[] atributos = new string[6];

            for (int i = 0; i < atributos.Length; i++)
            {
                if (line.IndexOf(";") != -1)
                {
                    atributo = line.Substring(0, line.IndexOf(";"));
                    line = line.Substring(line.IndexOf(";") + 1);
                }
                else
                {
                    atributo = line.Substring(0);
                }
                atributos[i] = atributo;
            }

            

            return new Libro(int.Parse(atributos[0]),atributos[1], 
                atributos[2], atributos[3], atributos[4], 
                int.Parse(atributos[5]));
        }
    }
}
