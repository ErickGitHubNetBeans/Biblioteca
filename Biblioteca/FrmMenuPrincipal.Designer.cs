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
            btnRegBook = new Button();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // btnRegBook
            // 
            btnRegBook.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegBook.Location = new Point(33, 40);
            btnRegBook.Name = "btnRegBook";
            btnRegBook.Size = new Size(149, 46);
            btnRegBook.TabIndex = 4;
            btnRegBook.Text = "Registrar un libro";
            btnRegBook.UseVisualStyleBackColor = true;
            btnRegBook.Click += btnRegBook_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(215, 40);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(149, 46);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Buscar un libro";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 122);
            Controls.Add(btnSearch);
            Controls.Add(btnRegBook);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú principal";
            FormClosing += FrmMenuPrincipal_FormClosing;
            ResumeLayout(false);
        }

        #endregion
        private Button btnRegBook;
        private Button btnSearch;
    }
}