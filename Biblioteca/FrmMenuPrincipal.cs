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
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistroLibro frmRegistroLibro = new FrmRegistroLibro();
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
    }
}
