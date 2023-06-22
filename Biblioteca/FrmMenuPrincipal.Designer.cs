namespace Biblioteca
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLeer = new Button();
            btnGuardar = new Button();
            txtLibros = new TextBox();
            btnRegBook = new Button();
            SuspendLayout();
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(178, 322);
            btnLeer.Margin = new Padding(3, 2, 3, 2);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(82, 22);
            btnLeer.TabIndex = 1;
            btnLeer.Text = "Leer";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(305, 322);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtLibros
            // 
            txtLibros.Location = new Point(178, 40);
            txtLibros.Margin = new Padding(3, 2, 3, 2);
            txtLibros.Multiline = true;
            txtLibros.Name = "txtLibros";
            txtLibros.Size = new Size(338, 262);
            txtLibros.TabIndex = 3;
            // 
            // btnRegBook
            // 
            btnRegBook.Location = new Point(432, 322);
            btnRegBook.Name = "btnRegBook";
            btnRegBook.Size = new Size(94, 39);
            btnRegBook.TabIndex = 4;
            btnRegBook.Text = "Registrar un libro";
            btnRegBook.UseVisualStyleBackColor = true;
            btnRegBook.Click += btnRegBook_Click;
            // 
            // frmLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 386);
            Controls.Add(btnRegBook);
            Controls.Add(txtLibros);
            Controls.Add(btnGuardar);
            Controls.Add(btnLeer);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLibro";
            Text = "frmLibro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLeer;
        private Button btnGuardar;
        private TextBox txtLibros;
        private Button btnRegBook;
    }
}