namespace BibliotecaUI.Forms
{
    partial class LibraryForm
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
            titleLabel = new Label();
            bookListGroupBox = new GroupBox();
            allBooksListBox = new ListBox();
            bookDataGroupBox = new GroupBox();
            authorTextBox = new TextBox();
            authorLabel = new Label();
            isbnTextBox = new TextBox();
            isbnLabel = new Label();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            addBookButton = new Button();
            managementGroupBox = new GroupBox();
            borrowBookButton = new Button();
            bookListGroupBox.SuspendLayout();
            bookDataGroupBox.SuspendLayout();
            managementGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(243, 19);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(296, 30);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Administración de Biblioteca";
            // 
            // bookListGroupBox
            // 
            bookListGroupBox.BackColor = SystemColors.ControlLight;
            bookListGroupBox.Controls.Add(allBooksListBox);
            bookListGroupBox.Location = new Point(63, 52);
            bookListGroupBox.Name = "bookListGroupBox";
            bookListGroupBox.Size = new Size(262, 305);
            bookListGroupBox.TabIndex = 1;
            bookListGroupBox.TabStop = false;
            bookListGroupBox.Text = "Listado de Libros";
            // 
            // allBooksListBox
            // 
            allBooksListBox.BackColor = SystemColors.HighlightText;
            allBooksListBox.FormattingEnabled = true;
            allBooksListBox.HorizontalScrollbar = true;
            allBooksListBox.ItemHeight = 21;
            allBooksListBox.Location = new Point(3, 25);
            allBooksListBox.Name = "allBooksListBox";
            allBooksListBox.Size = new Size(253, 277);
            allBooksListBox.TabIndex = 0;
            // 
            // bookDataGroupBox
            // 
            bookDataGroupBox.BackColor = SystemColors.ControlLight;
            bookDataGroupBox.Controls.Add(authorTextBox);
            bookDataGroupBox.Controls.Add(authorLabel);
            bookDataGroupBox.Controls.Add(isbnTextBox);
            bookDataGroupBox.Controls.Add(isbnLabel);
            bookDataGroupBox.Controls.Add(nameTextBox);
            bookDataGroupBox.Controls.Add(nameLabel);
            bookDataGroupBox.Location = new Point(430, 52);
            bookDataGroupBox.Name = "bookDataGroupBox";
            bookDataGroupBox.Size = new Size(272, 245);
            bookDataGroupBox.TabIndex = 1;
            bookDataGroupBox.TabStop = false;
            bookDataGroupBox.Text = "Datos Libros";
            // 
            // authorTextBox
            // 
            authorTextBox.BackColor = SystemColors.ScrollBar;
            authorTextBox.Location = new Point(32, 198);
            authorTextBox.Multiline = true;
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(156, 26);
            authorTextBox.TabIndex = 5;
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new Point(32, 174);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(53, 21);
            authorLabel.TabIndex = 4;
            authorLabel.Text = "Autor";
            // 
            // isbnTextBox
            // 
            isbnTextBox.BackColor = SystemColors.ScrollBar;
            isbnTextBox.Location = new Point(32, 135);
            isbnTextBox.Multiline = true;
            isbnTextBox.Name = "isbnTextBox";
            isbnTextBox.Size = new Size(156, 36);
            isbnTextBox.TabIndex = 3;
            // 
            // isbnLabel
            // 
            isbnLabel.AutoSize = true;
            isbnLabel.Location = new Point(32, 111);
            isbnLabel.Name = "isbnLabel";
            isbnLabel.Size = new Size(47, 21);
            isbnLabel.TabIndex = 2;
            isbnLabel.Text = "ISBN";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = SystemColors.ScrollBar;
            nameTextBox.Location = new Point(32, 64);
            nameTextBox.Multiline = true;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(156, 30);
            nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(32, 40);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(144, 21);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Nombre del Libro";
            // 
            // addBookButton
            // 
            addBookButton.Location = new Point(15, 38);
            addBookButton.Name = "addBookButton";
            addBookButton.Size = new Size(117, 34);
            addBookButton.TabIndex = 7;
            addBookButton.Text = "Agregar";
            addBookButton.UseVisualStyleBackColor = true;
            addBookButton.Click += addBookButton_Click;
            // 
            // managementGroupBox
            // 
            managementGroupBox.BackColor = SystemColors.ControlLight;
            managementGroupBox.Controls.Add(borrowBookButton);
            managementGroupBox.Controls.Add(addBookButton);
            managementGroupBox.Location = new Point(430, 320);
            managementGroupBox.Name = "managementGroupBox";
            managementGroupBox.Size = new Size(272, 91);
            managementGroupBox.TabIndex = 2;
            managementGroupBox.TabStop = false;
            managementGroupBox.Text = "Administración";
            // 
            // borrowBookButton
            // 
            borrowBookButton.Location = new Point(138, 38);
            borrowBookButton.Name = "borrowBookButton";
            borrowBookButton.Size = new Size(96, 34);
            borrowBookButton.TabIndex = 8;
            borrowBookButton.Text = "Prestar";
            borrowBookButton.UseVisualStyleBackColor = true;
            borrowBookButton.Click += deleteButton_Click;
            // 
            // LibraryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(784, 438);
            Controls.Add(managementGroupBox);
            Controls.Add(bookDataGroupBox);
            Controls.Add(bookListGroupBox);
            Controls.Add(titleLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "LibraryForm";
            Text = "LibraryForm";
            bookListGroupBox.ResumeLayout(false);
            bookDataGroupBox.ResumeLayout(false);
            bookDataGroupBox.PerformLayout();
            managementGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private GroupBox bookListGroupBox;
        private GroupBox bookDataGroupBox;
        private ListBox allBooksListBox;
        private Label nameLabel;
        private TextBox nameTextBox;
        private TextBox authorTextBox;
        private Label authorLabel;
        private TextBox isbnTextBox;
        private Label isbnLabel;
        private Button addBookButton;
        private GroupBox managementGroupBox;
        private Button borrowBookButton;
    }
}