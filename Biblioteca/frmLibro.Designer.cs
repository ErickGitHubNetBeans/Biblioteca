namespace Biblioteca
{
    partial class frmLibro
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
            btnLeer.Location = new Point(149, 424);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(102, 39);
            btnLeer.TabIndex = 1;
            btnLeer.Text = "Leer";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(302, 424);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(105, 39);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtLibros
            // 
            txtLibros.Location = new Point(149, 54);
            txtLibros.Multiline = true;
            txtLibros.Name = "txtLibros";
            txtLibros.Size = new Size(408, 339);
            txtLibros.TabIndex = 3;
            // 
            // btnRegBook
            // 
            btnRegBook.Location = new Point(444, 424);
            btnRegBook.Name = "btnRegBook";
            btnRegBook.Size = new Size(113, 52);
            btnRegBook.TabIndex = 8;
            btnRegBook.Text = "Registrar en un libro";
            btnRegBook.UseVisualStyleBackColor = true;
            btnRegBook.Click += btnRegBook_Click;
            // 
            // frmLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 496);
            Controls.Add(btnRegBook);
            Controls.Add(txtLibros);
            Controls.Add(btnGuardar);
            Controls.Add(btnLeer);
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