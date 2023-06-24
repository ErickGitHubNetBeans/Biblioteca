namespace Biblioteca
{
    partial class FrmRegistroLibro
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
            label1 = new Label();
            btnRegister = new Button();
            txtTitulo = new TextBox();
            label2 = new Label();
            txtAutor = new TextBox();
            label3 = new Label();
            txtAnio = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtEditorial = new TextBox();
            label6 = new Label();
            txtPais = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(62, 94);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 0;
            label1.Text = "Título del libro:";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(146, 366);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(125, 43);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitulo.Location = new Point(197, 88);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(161, 27);
            txtTitulo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(123, 146);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 3;
            label2.Text = "Autor:";
            // 
            // txtAutor
            // 
            txtAutor.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAutor.Location = new Point(197, 140);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(161, 27);
            txtAutor.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 305);
            label3.Name = "label3";
            label3.Size = new Size(145, 21);
            label3.TabIndex = 5;
            label3.Text = "Año de publicación:";
            // 
            // txtAnio
            // 
            txtAnio.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnio.Location = new Point(197, 299);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(161, 27);
            txtAnio.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(109, 18);
            label4.Name = "label4";
            label4.Size = new Size(205, 32);
            label4.TabIndex = 8;
            label4.Text = "Registro de libro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(105, 200);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 9;
            label5.Text = "Editorial:";
            // 
            // txtEditorial
            // 
            txtEditorial.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtEditorial.Location = new Point(197, 194);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(161, 27);
            txtEditorial.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(135, 250);
            label6.Name = "label6";
            label6.Size = new Size(40, 21);
            label6.TabIndex = 11;
            label6.Text = "País:";
            // 
            // txtPais
            // 
            txtPais.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPais.Location = new Point(197, 244);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(161, 27);
            txtPais.TabIndex = 12;
            // 
            // FrmRegistroLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 435);
            Controls.Add(txtPais);
            Controls.Add(label6);
            Controls.Add(txtEditorial);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtAnio);
            Controls.Add(label3);
            Controls.Add(txtAutor);
            Controls.Add(label2);
            Controls.Add(txtTitulo);
            Controls.Add(btnRegister);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRegistroLibro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar libro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegister;
        private TextBox txtTitulo;
        private Label label2;
        private TextBox txtAutor;
        private Label label3;
        private TextBox txtAnio;
        private Label label4;
        private Label label5;
        private TextBox txtEditorial;
        private Label label6;
        private TextBox txtPais;

        // id de Libro
        private int id = 0;

        // Ruta completa del archivo.
        private string fullPath;

        // Árbol binario de busqueda accesible a lo largo de toda la aplicación
        // mientras está en ejecución.
        private ABB abb;
    }
}