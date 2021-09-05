
namespace BookeStore
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.ageRatingLabel = new System.Windows.Forms.Label();
            this.yearReleasedLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.genreBox = new System.Windows.Forms.TextBox();
            this.ageRatingBox = new System.Windows.Forms.TextBox();
            this.yearReleasedBox = new System.Windows.Forms.TextBox();
            this.createBookButton = new System.Windows.Forms.Button();
            this.updateBookButton = new System.Windows.Forms.Button();
            this.nextBookButton = new System.Windows.Forms.Button();
            this.previousBookButton = new System.Windows.Forms.Button();
            this.clearFieldsButton = new System.Windows.Forms.Button();
            this.BookIDNumberBox = new System.Windows.Forms.TextBox();
            this.bookIDNumberLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBookIDNumberBox = new System.Windows.Forms.TextBox();
            this.SearchTitleBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SeachBookButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(17, 90);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(17, 120);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(38, 13);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Author";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(17, 150);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(36, 13);
            this.genreLabel.TabIndex = 2;
            this.genreLabel.Text = "Genre";
            // 
            // ageRatingLabel
            // 
            this.ageRatingLabel.AutoSize = true;
            this.ageRatingLabel.Location = new System.Drawing.Point(17, 179);
            this.ageRatingLabel.Name = "ageRatingLabel";
            this.ageRatingLabel.Size = new System.Drawing.Size(60, 13);
            this.ageRatingLabel.TabIndex = 3;
            this.ageRatingLabel.Text = "Age Rating";
            // 
            // yearReleasedLabel
            // 
            this.yearReleasedLabel.AutoSize = true;
            this.yearReleasedLabel.Location = new System.Drawing.Point(17, 213);
            this.yearReleasedLabel.Name = "yearReleasedLabel";
            this.yearReleasedLabel.Size = new System.Drawing.Size(77, 13);
            this.yearReleasedLabel.TabIndex = 4;
            this.yearReleasedLabel.Text = "Year Released";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(99, 83);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(100, 20);
            this.titleBox.TabIndex = 5;
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(99, 113);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(100, 20);
            this.authorBox.TabIndex = 6;
            // 
            // genreBox
            // 
            this.genreBox.Location = new System.Drawing.Point(99, 142);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(100, 20);
            this.genreBox.TabIndex = 7;
            // 
            // ageRatingBox
            // 
            this.ageRatingBox.Location = new System.Drawing.Point(99, 172);
            this.ageRatingBox.Name = "ageRatingBox";
            this.ageRatingBox.Size = new System.Drawing.Size(100, 20);
            this.ageRatingBox.TabIndex = 8;
            // 
            // yearReleasedBox
            // 
            this.yearReleasedBox.Location = new System.Drawing.Point(99, 206);
            this.yearReleasedBox.Name = "yearReleasedBox";
            this.yearReleasedBox.Size = new System.Drawing.Size(100, 20);
            this.yearReleasedBox.TabIndex = 9;
            // 
            // createBookButton
            // 
            this.createBookButton.Location = new System.Drawing.Point(37, 286);
            this.createBookButton.Name = "createBookButton";
            this.createBookButton.Size = new System.Drawing.Size(162, 33);
            this.createBookButton.TabIndex = 10;
            this.createBookButton.Text = "Create New Book";
            this.createBookButton.UseVisualStyleBackColor = true;
            this.createBookButton.Click += new System.EventHandler(this.createBookButton_Click);
            // 
            // updateBookButton
            // 
            this.updateBookButton.Location = new System.Drawing.Point(37, 325);
            this.updateBookButton.Name = "updateBookButton";
            this.updateBookButton.Size = new System.Drawing.Size(162, 33);
            this.updateBookButton.TabIndex = 11;
            this.updateBookButton.Text = "Update Book";
            this.updateBookButton.UseVisualStyleBackColor = true;
            this.updateBookButton.Click += new System.EventHandler(this.updateBookButton_Click);
            // 
            // nextBookButton
            // 
            this.nextBookButton.Location = new System.Drawing.Point(231, 83);
            this.nextBookButton.Name = "nextBookButton";
            this.nextBookButton.Size = new System.Drawing.Size(85, 80);
            this.nextBookButton.TabIndex = 12;
            this.nextBookButton.Text = "Next Book";
            this.nextBookButton.UseVisualStyleBackColor = true;
            this.nextBookButton.Click += new System.EventHandler(this.nextBookButton_Click);
            // 
            // previousBookButton
            // 
            this.previousBookButton.Location = new System.Drawing.Point(231, 172);
            this.previousBookButton.Name = "previousBookButton";
            this.previousBookButton.Size = new System.Drawing.Size(85, 80);
            this.previousBookButton.TabIndex = 13;
            this.previousBookButton.Text = "Previous Book";
            this.previousBookButton.UseVisualStyleBackColor = true;
            this.previousBookButton.Click += new System.EventHandler(this.previousBookButton_Click);
            // 
            // clearFieldsButton
            // 
            this.clearFieldsButton.Location = new System.Drawing.Point(37, 247);
            this.clearFieldsButton.Name = "clearFieldsButton";
            this.clearFieldsButton.Size = new System.Drawing.Size(162, 33);
            this.clearFieldsButton.TabIndex = 14;
            this.clearFieldsButton.Text = "Clear Fields";
            this.clearFieldsButton.UseVisualStyleBackColor = true;
            this.clearFieldsButton.Click += new System.EventHandler(this.clearFieldsButton_Click);
            // 
            // BookIDNumberBox
            // 
            this.BookIDNumberBox.Location = new System.Drawing.Point(99, 21);
            this.BookIDNumberBox.Name = "BookIDNumberBox";
            this.BookIDNumberBox.Size = new System.Drawing.Size(100, 20);
            this.BookIDNumberBox.TabIndex = 15;
            // 
            // bookIDNumberLabel
            // 
            this.bookIDNumberLabel.AutoSize = true;
            this.bookIDNumberLabel.Location = new System.Drawing.Point(20, 27);
            this.bookIDNumberLabel.Name = "bookIDNumberLabel";
            this.bookIDNumberLabel.Size = new System.Drawing.Size(50, 13);
            this.bookIDNumberLabel.TabIndex = 16;
            this.bookIDNumberLabel.Text = "BookID#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "BookID#";
            // 
            // SearchBookIDNumberBox
            // 
            this.SearchBookIDNumberBox.Location = new System.Drawing.Point(413, 179);
            this.SearchBookIDNumberBox.Name = "SearchBookIDNumberBox";
            this.SearchBookIDNumberBox.Size = new System.Drawing.Size(100, 20);
            this.SearchBookIDNumberBox.TabIndex = 27;
            // 
            // SearchTitleBox
            // 
            this.SearchTitleBox.Location = new System.Drawing.Point(413, 210);
            this.SearchTitleBox.Name = "SearchTitleBox";
            this.SearchTitleBox.Size = new System.Drawing.Size(100, 20);
            this.SearchTitleBox.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Title";
            // 
            // SeachBookButton
            // 
            this.SeachBookButton.Location = new System.Drawing.Point(351, 247);
            this.SeachBookButton.Name = "SeachBookButton";
            this.SeachBookButton.Size = new System.Drawing.Size(162, 33);
            this.SeachBookButton.TabIndex = 29;
            this.SeachBookButton.Text = "Search For Book";
            this.SeachBookButton.UseVisualStyleBackColor = true;
            this.SeachBookButton.Click += new System.EventHandler(this.SeachBookButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 33);
            this.button2.TabIndex = 30;
            this.button2.Text = "Remove Book";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Quantity";
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(99, 51);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(100, 20);
            this.quantityBox.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 433);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SeachBookButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBookIDNumberBox);
            this.Controls.Add(this.SearchTitleBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bookIDNumberLabel);
            this.Controls.Add(this.BookIDNumberBox);
            this.Controls.Add(this.clearFieldsButton);
            this.Controls.Add(this.previousBookButton);
            this.Controls.Add(this.nextBookButton);
            this.Controls.Add(this.updateBookButton);
            this.Controls.Add(this.createBookButton);
            this.Controls.Add(this.yearReleasedBox);
            this.Controls.Add(this.ageRatingBox);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.yearReleasedLabel);
            this.Controls.Add(this.ageRatingLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label ageRatingLabel;
        private System.Windows.Forms.Label yearReleasedLabel;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.TextBox genreBox;
        private System.Windows.Forms.TextBox ageRatingBox;
        private System.Windows.Forms.TextBox yearReleasedBox;
        private System.Windows.Forms.Button createBookButton;
        private System.Windows.Forms.Button updateBookButton;
        private System.Windows.Forms.Button nextBookButton;
        private System.Windows.Forms.Button previousBookButton;
        private System.Windows.Forms.Button clearFieldsButton;
        private System.Windows.Forms.TextBox BookIDNumberBox;
        private System.Windows.Forms.Label bookIDNumberLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchBookIDNumberBox;
        private System.Windows.Forms.TextBox SearchTitleBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SeachBookButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox quantityBox;
    }
}

