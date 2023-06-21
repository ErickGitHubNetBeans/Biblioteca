namespace Biblioteca
{
    partial class FrmCrearLibro
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
            txtTitle = new TextBox();
            label2 = new Label();
            txtAuthor = new TextBox();
            label3 = new Label();
            txtYear = new TextBox();
            id = 0;
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 45);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 0;
            label1.Text = "Título del libro:";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(138, 208);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(99, 43);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(191, 39);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(161, 27);
            txtTitle.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(117, 101);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 3;
            label2.Text = "Autor:";
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAuthor.Location = new Point(191, 95);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(161, 27);
            txtAuthor.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 153);
            label3.Name = "label3";
            label3.Size = new Size(145, 21);
            label3.TabIndex = 5;
            label3.Text = "Año de publicación:";
            // 
            // txtYear
            // 
            txtYear.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtYear.Location = new Point(191, 147);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(161, 27);
            txtYear.TabIndex = 6;
            // 
            // FrmCrearLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 269);
            Controls.Add(txtYear);
            Controls.Add(label3);
            Controls.Add(txtAuthor);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(btnRegister);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FrmCrearLibro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar libro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegister;
        private TextBox txtTitle;
        private Label label2;
        private TextBox txtAuthor;
        private Label label3;
        private TextBox txtYear;
        private int id;
    }
}