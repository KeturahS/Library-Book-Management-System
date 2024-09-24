namespace LibraryBookManagement
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.CboxStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CboxCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPublishedYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.bookName = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AutamatedInput = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Library_book_report = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Random automated Input\r\n       of 10,000 Books:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(14, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "ISBN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.btnAddBook);
            this.panel1.Controls.Add(this.CboxStatus);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CboxCategory);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPublishedYear);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtAuthor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.bookName);
            this.panel1.Controls.Add(this.txtISBN);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panel1.Location = new System.Drawing.Point(47, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 526);
            this.panel1.TabIndex = 5;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAddBook.Location = new System.Drawing.Point(17, 478);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(121, 30);
            this.btnAddBook.TabIndex = 16;
            this.btnAddBook.Text = "Add book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // CboxStatus
            // 
            this.CboxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxStatus.FormattingEnabled = true;
            this.CboxStatus.Items.AddRange(new object[] {
            "Available",
            "Borrowed"});
            this.CboxStatus.Location = new System.Drawing.Point(17, 420);
            this.CboxStatus.Name = "CboxStatus";
            this.CboxStatus.Size = new System.Drawing.Size(121, 24);
            this.CboxStatus.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(14, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Book Status";
            // 
            // CboxCategory
            // 
            this.CboxCategory.DisplayMember = "Science Fiction";
            this.CboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxCategory.FormattingEnabled = true;
            this.CboxCategory.Items.AddRange(new object[] {
            "Science Fiction",
            "Novel",
            "History",
            "Biography"});
            this.CboxCategory.Location = new System.Drawing.Point(17, 332);
            this.CboxCategory.Name = "CboxCategory";
            this.CboxCategory.Size = new System.Drawing.Size(121, 24);
            this.CboxCategory.TabIndex = 13;
            this.CboxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(14, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Category";
            // 
            // txtPublishedYear
            // 
            this.txtPublishedYear.Location = new System.Drawing.Point(17, 260);
            this.txtPublishedYear.Name = "txtPublishedYear";
            this.txtPublishedYear.Size = new System.Drawing.Size(100, 22);
            this.txtPublishedYear.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(17, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Year published";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(17, 191);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 22);
            this.txtAuthor.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(17, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Author Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(20, 126);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 22);
            this.txtTitle.TabIndex = 7;
            // 
            // bookName
            // 
            this.bookName.AutoSize = true;
            this.bookName.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold);
            this.bookName.Location = new System.Drawing.Point(17, 95);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(89, 16);
            this.bookName.TabIndex = 6;
            this.bookName.Text = "Book Title";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(21, 52);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(106, 22);
            this.txtISBN.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.AutamatedInput);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(396, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 252);
            this.panel2.TabIndex = 6;
            // 
            // AutamatedInput
            // 
            this.AutamatedInput.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold);
            this.AutamatedInput.Location = new System.Drawing.Point(99, 96);
            this.AutamatedInput.Name = "AutamatedInput";
            this.AutamatedInput.Size = new System.Drawing.Size(75, 23);
            this.AutamatedInput.TabIndex = 4;
            this.AutamatedInput.Text = "Click here";
            this.AutamatedInput.UseVisualStyleBackColor = true;
            this.AutamatedInput.Click += new System.EventHandler(this.AutamatedInput_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "Book report sorted by\r\n     publication year";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Library_book_report
            // 
            this.Library_book_report.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold);
            this.Library_book_report.Location = new System.Drawing.Point(63, 82);
            this.Library_book_report.Name = "Library_book_report";
            this.Library_book_report.Size = new System.Drawing.Size(167, 53);
            this.Library_book_report.TabIndex = 4;
            this.Library_book_report.Text = "View library book\r\n report\r\n\r\n";
            this.Library_book_report.UseVisualStyleBackColor = true;
            this.Library_book_report.Click += new System.EventHandler(this.Library_book_report_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightYellow;
            this.panel3.Controls.Add(this.Library_book_report);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(801, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 252);
            this.panel3.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(47, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 30);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Add Book Manually\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LibraryBookManagement.Properties.Resources.library2;
            this.pictureBox1.Location = new System.Drawing.Point(-141, -454);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1706, 969);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Aharoni", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(423, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "Library Book Management";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 665);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Library Book Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label bookName;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPublishedYear;
        private System.Windows.Forms.ComboBox CboxCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CboxStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button AutamatedInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Library_book_report;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

