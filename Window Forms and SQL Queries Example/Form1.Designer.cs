namespace BookKeeper
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
            this.tbControlBooks = new System.Windows.Forms.TabControl();
            this.tbLogin = new System.Windows.Forms.TabPage();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginPass = new System.Windows.Forms.TextBox();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.tbAddBook = new System.Windows.Forms.TabPage();
            this.btnfindBook = new System.Windows.Forms.Button();
            this.btnModifyBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.lblBookId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboTrilogy = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGenreId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPublisherId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAuthorId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookPages = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.tbAddAuthor = new System.Windows.Forms.TabPage();
            this.txtAuthorAuthorId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAddPublisher = new System.Windows.Forms.TabPage();
            this.btnAddPublisher = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPublisherAddress = new System.Windows.Forms.TextBox();
            this.txtPublisherName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPublisherPublisherId = new System.Windows.Forms.TextBox();
            this.tbListBooks = new System.Windows.Forms.TabPage();
            this.txtEnterGenre = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnGetBookByGenre = new System.Windows.Forms.Button();
            this.txtGetBookTitle = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnGetBookByTitle = new System.Windows.Forms.Button();
            this.txtEnterAuthor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGetBookByAuthor = new System.Windows.Forms.Button();
            this.btnGetAllBooks = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabBookSelection = new System.Windows.Forms.TabPage();
            this.btnMostSoldList = new System.Windows.Forms.Button();
            this.btnAfterDate = new System.Windows.Forms.Button();
            this.btnAfterMonth = new System.Windows.Forms.Button();
            this.btnAfterYear = new System.Windows.Forms.Button();
            this.txtEnterDate = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnSellBook = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.tabSoldBooks = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnShowAllSold = new System.Windows.Forms.Button();
            this.btnFindNextBook = new System.Windows.Forms.Button();
            this.tbControlBooks.SuspendLayout();
            this.tbLogin.SuspendLayout();
            this.tbAddBook.SuspendLayout();
            this.tbAddAuthor.SuspendLayout();
            this.tbAddPublisher.SuspendLayout();
            this.tbListBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabBookSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabSoldBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControlBooks
            // 
            this.tbControlBooks.Controls.Add(this.tbLogin);
            this.tbControlBooks.Controls.Add(this.tbAddBook);
            this.tbControlBooks.Controls.Add(this.tbAddAuthor);
            this.tbControlBooks.Controls.Add(this.tbAddPublisher);
            this.tbControlBooks.Controls.Add(this.tbListBooks);
            this.tbControlBooks.Controls.Add(this.tabBookSelection);
            this.tbControlBooks.Controls.Add(this.tabSoldBooks);
            this.tbControlBooks.Location = new System.Drawing.Point(31, 55);
            this.tbControlBooks.Name = "tbControlBooks";
            this.tbControlBooks.SelectedIndex = 0;
            this.tbControlBooks.Size = new System.Drawing.Size(1043, 557);
            this.tbControlBooks.TabIndex = 0;
            // 
            // tbLogin
            // 
            this.tbLogin.Controls.Add(this.btnLogin);
            this.tbLogin.Controls.Add(this.txtLoginPass);
            this.tbLogin.Controls.Add(this.txtLoginName);
            this.tbLogin.Location = new System.Drawing.Point(4, 22);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(1035, 531);
            this.tbLogin.TabIndex = 4;
            this.tbLogin.Text = "Login";
            this.tbLogin.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(333, 255);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(324, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLoginPass
            // 
            this.txtLoginPass.Location = new System.Drawing.Point(333, 210);
            this.txtLoginPass.Name = "txtLoginPass";
            this.txtLoginPass.Size = new System.Drawing.Size(324, 20);
            this.txtLoginPass.TabIndex = 1;
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(333, 161);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(324, 20);
            this.txtLoginName.TabIndex = 0;
            // 
            // tbAddBook
            // 
            this.tbAddBook.Controls.Add(this.btnFindNextBook);
            this.tbAddBook.Controls.Add(this.label18);
            this.tbAddBook.Controls.Add(this.btnSellBook);
            this.tbAddBook.Controls.Add(this.btnfindBook);
            this.tbAddBook.Controls.Add(this.btnModifyBook);
            this.tbAddBook.Controls.Add(this.btnDeleteBook);
            this.tbAddBook.Controls.Add(this.btnAddBook);
            this.tbAddBook.Controls.Add(this.txtBookId);
            this.tbAddBook.Controls.Add(this.lblBookId);
            this.tbAddBook.Controls.Add(this.label8);
            this.tbAddBook.Controls.Add(this.comboTrilogy);
            this.tbAddBook.Controls.Add(this.label7);
            this.tbAddBook.Controls.Add(this.txtGenreId);
            this.tbAddBook.Controls.Add(this.label6);
            this.tbAddBook.Controls.Add(this.txtPublisherId);
            this.tbAddBook.Controls.Add(this.label5);
            this.tbAddBook.Controls.Add(this.txtAuthorId);
            this.tbAddBook.Controls.Add(this.label4);
            this.tbAddBook.Controls.Add(this.txtBookPrice);
            this.tbAddBook.Controls.Add(this.label3);
            this.tbAddBook.Controls.Add(this.txtBookPages);
            this.tbAddBook.Controls.Add(this.label2);
            this.tbAddBook.Controls.Add(this.txtBookDate);
            this.tbAddBook.Controls.Add(this.label1);
            this.tbAddBook.Controls.Add(this.txtBookTitle);
            this.tbAddBook.Location = new System.Drawing.Point(4, 22);
            this.tbAddBook.Name = "tbAddBook";
            this.tbAddBook.Padding = new System.Windows.Forms.Padding(3);
            this.tbAddBook.Size = new System.Drawing.Size(1035, 531);
            this.tbAddBook.TabIndex = 0;
            this.tbAddBook.Text = "Add Books";
            this.tbAddBook.UseVisualStyleBackColor = true;
            // 
            // btnfindBook
            // 
            this.btnfindBook.Location = new System.Drawing.Point(583, 190);
            this.btnfindBook.Name = "btnfindBook";
            this.btnfindBook.Size = new System.Drawing.Size(275, 23);
            this.btnfindBook.TabIndex = 21;
            this.btnfindBook.Text = "Find Book";
            this.btnfindBook.UseVisualStyleBackColor = true;
            this.btnfindBook.Click += new System.EventHandler(this.btnfindBook_Click);
            // 
            // btnModifyBook
            // 
            this.btnModifyBook.Location = new System.Drawing.Point(583, 132);
            this.btnModifyBook.Name = "btnModifyBook";
            this.btnModifyBook.Size = new System.Drawing.Size(275, 23);
            this.btnModifyBook.TabIndex = 20;
            this.btnModifyBook.Text = "Modify Book";
            this.btnModifyBook.UseVisualStyleBackColor = true;
            this.btnModifyBook.Click += new System.EventHandler(this.btnModifyBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(583, 79);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(275, 23);
            this.btnDeleteBook.TabIndex = 19;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(583, 31);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(275, 23);
            this.btnAddBook.TabIndex = 18;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(140, 31);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(345, 20);
            this.txtBookId.TabIndex = 17;
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Location = new System.Drawing.Point(32, 38);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(44, 13);
            this.lblBookId.TabIndex = 16;
            this.lblBookId.Text = "Book Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Trilogy (True/False)";
            // 
            // comboTrilogy
            // 
            this.comboTrilogy.FormattingEnabled = true;
            this.comboTrilogy.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboTrilogy.Location = new System.Drawing.Point(144, 384);
            this.comboTrilogy.Name = "comboTrilogy";
            this.comboTrilogy.Size = new System.Drawing.Size(121, 21);
            this.comboTrilogy.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Genre Id";
            // 
            // txtGenreId
            // 
            this.txtGenreId.Location = new System.Drawing.Point(140, 324);
            this.txtGenreId.Name = "txtGenreId";
            this.txtGenreId.Size = new System.Drawing.Size(345, 20);
            this.txtGenreId.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Publisher Id";
            // 
            // txtPublisherId
            // 
            this.txtPublisherId.Location = new System.Drawing.Point(140, 289);
            this.txtPublisherId.Name = "txtPublisherId";
            this.txtPublisherId.Size = new System.Drawing.Size(345, 20);
            this.txtPublisherId.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Author Id";
            // 
            // txtAuthorId
            // 
            this.txtAuthorId.Location = new System.Drawing.Point(140, 249);
            this.txtAuthorId.Name = "txtAuthorId";
            this.txtAuthorId.Size = new System.Drawing.Size(345, 20);
            this.txtAuthorId.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Book Price";
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(140, 208);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(345, 20);
            this.txtBookPrice.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of Pages";
            // 
            // txtBookPages
            // 
            this.txtBookPages.Location = new System.Drawing.Point(140, 156);
            this.txtBookPages.Name = "txtBookPages";
            this.txtBookPages.Size = new System.Drawing.Size(345, 20);
            this.txtBookPages.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date Of Publish";
            // 
            // txtBookDate
            // 
            this.txtBookDate.Location = new System.Drawing.Point(140, 109);
            this.txtBookDate.Name = "txtBookDate";
            this.txtBookDate.Size = new System.Drawing.Size(345, 20);
            this.txtBookDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Title";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(140, 72);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(345, 20);
            this.txtBookTitle.TabIndex = 0;
            // 
            // tbAddAuthor
            // 
            this.tbAddAuthor.Controls.Add(this.txtAuthorAuthorId);
            this.tbAddAuthor.Controls.Add(this.label9);
            this.tbAddAuthor.Controls.Add(this.btnAddAuthor);
            this.tbAddAuthor.Controls.Add(this.txtLastName);
            this.tbAddAuthor.Controls.Add(this.txtFirstName);
            this.tbAddAuthor.Controls.Add(this.label11);
            this.tbAddAuthor.Controls.Add(this.label10);
            this.tbAddAuthor.Location = new System.Drawing.Point(4, 22);
            this.tbAddAuthor.Name = "tbAddAuthor";
            this.tbAddAuthor.Padding = new System.Windows.Forms.Padding(3);
            this.tbAddAuthor.Size = new System.Drawing.Size(1035, 531);
            this.tbAddAuthor.TabIndex = 1;
            this.tbAddAuthor.Text = "Add Author";
            this.tbAddAuthor.UseVisualStyleBackColor = true;
            // 
            // txtAuthorAuthorId
            // 
            this.txtAuthorAuthorId.Location = new System.Drawing.Point(198, 60);
            this.txtAuthorAuthorId.Name = "txtAuthorAuthorId";
            this.txtAuthorAuthorId.Size = new System.Drawing.Size(338, 20);
            this.txtAuthorAuthorId.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Author Id";
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(198, 210);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(338, 23);
            this.btnAddAuthor.TabIndex = 6;
            this.btnAddAuthor.Text = "Add Author";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(198, 149);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(338, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(198, 103);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(338, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(79, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Last Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "FirstName";
            // 
            // tbAddPublisher
            // 
            this.tbAddPublisher.Controls.Add(this.btnAddPublisher);
            this.tbAddPublisher.Controls.Add(this.label14);
            this.tbAddPublisher.Controls.Add(this.txtPublisherAddress);
            this.tbAddPublisher.Controls.Add(this.txtPublisherName);
            this.tbAddPublisher.Controls.Add(this.textBox1);
            this.tbAddPublisher.Controls.Add(this.label12);
            this.tbAddPublisher.Controls.Add(this.txtPublisherPublisherId);
            this.tbAddPublisher.Location = new System.Drawing.Point(4, 22);
            this.tbAddPublisher.Name = "tbAddPublisher";
            this.tbAddPublisher.Size = new System.Drawing.Size(1035, 531);
            this.tbAddPublisher.TabIndex = 2;
            this.tbAddPublisher.Text = "Add Publisher";
            this.tbAddPublisher.UseVisualStyleBackColor = true;
            // 
            // btnAddPublisher
            // 
            this.btnAddPublisher.Location = new System.Drawing.Point(178, 227);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(350, 23);
            this.btnAddPublisher.TabIndex = 6;
            this.btnAddPublisher.Text = "Add Publisher";
            this.btnAddPublisher.UseVisualStyleBackColor = true;
            this.btnAddPublisher.Click += new System.EventHandler(this.btnAddPublisher_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(46, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Publisher Address";
            // 
            // txtPublisherAddress
            // 
            this.txtPublisherAddress.Location = new System.Drawing.Point(178, 178);
            this.txtPublisherAddress.Name = "txtPublisherAddress";
            this.txtPublisherAddress.Size = new System.Drawing.Size(350, 20);
            this.txtPublisherAddress.TabIndex = 4;
            // 
            // txtPublisherName
            // 
            this.txtPublisherName.AutoSize = true;
            this.txtPublisherName.Location = new System.Drawing.Point(46, 139);
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.Size = new System.Drawing.Size(81, 13);
            this.txtPublisherName.TabIndex = 3;
            this.txtPublisherName.Text = "Publisher Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Publisher Id";
            // 
            // txtPublisherPublisherId
            // 
            this.txtPublisherPublisherId.Location = new System.Drawing.Point(178, 89);
            this.txtPublisherPublisherId.Name = "txtPublisherPublisherId";
            this.txtPublisherPublisherId.Size = new System.Drawing.Size(350, 20);
            this.txtPublisherPublisherId.TabIndex = 0;
            // 
            // tbListBooks
            // 
            this.tbListBooks.Controls.Add(this.txtEnterGenre);
            this.tbListBooks.Controls.Add(this.label16);
            this.tbListBooks.Controls.Add(this.btnGetBookByGenre);
            this.tbListBooks.Controls.Add(this.txtGetBookTitle);
            this.tbListBooks.Controls.Add(this.label15);
            this.tbListBooks.Controls.Add(this.btnGetBookByTitle);
            this.tbListBooks.Controls.Add(this.txtEnterAuthor);
            this.tbListBooks.Controls.Add(this.label13);
            this.tbListBooks.Controls.Add(this.btnGetBookByAuthor);
            this.tbListBooks.Controls.Add(this.btnGetAllBooks);
            this.tbListBooks.Controls.Add(this.dataGridView1);
            this.tbListBooks.Location = new System.Drawing.Point(4, 22);
            this.tbListBooks.Name = "tbListBooks";
            this.tbListBooks.Size = new System.Drawing.Size(1035, 531);
            this.tbListBooks.TabIndex = 3;
            this.tbListBooks.Text = "List Books";
            this.tbListBooks.UseVisualStyleBackColor = true;
            // 
            // txtEnterGenre
            // 
            this.txtEnterGenre.Location = new System.Drawing.Point(708, 335);
            this.txtEnterGenre.Name = "txtEnterGenre";
            this.txtEnterGenre.Size = new System.Drawing.Size(219, 20);
            this.txtEnterGenre.TabIndex = 10;
            this.txtEnterGenre.Text = "Enter Genre";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(708, 302);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Genre Name";
            // 
            // btnGetBookByGenre
            // 
            this.btnGetBookByGenre.Location = new System.Drawing.Point(708, 368);
            this.btnGetBookByGenre.Name = "btnGetBookByGenre";
            this.btnGetBookByGenre.Size = new System.Drawing.Size(219, 23);
            this.btnGetBookByGenre.TabIndex = 8;
            this.btnGetBookByGenre.Text = "Get Book By Genre";
            this.btnGetBookByGenre.UseVisualStyleBackColor = true;
            this.btnGetBookByGenre.Click += new System.EventHandler(this.btnGetBookByGenre_Click);
            // 
            // txtGetBookTitle
            // 
            this.txtGetBookTitle.Location = new System.Drawing.Point(708, 219);
            this.txtGetBookTitle.Name = "txtGetBookTitle";
            this.txtGetBookTitle.Size = new System.Drawing.Size(219, 20);
            this.txtGetBookTitle.TabIndex = 7;
            this.txtGetBookTitle.Text = "Enter Book Title";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(708, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Book Title";
            // 
            // btnGetBookByTitle
            // 
            this.btnGetBookByTitle.Location = new System.Drawing.Point(708, 252);
            this.btnGetBookByTitle.Name = "btnGetBookByTitle";
            this.btnGetBookByTitle.Size = new System.Drawing.Size(219, 23);
            this.btnGetBookByTitle.TabIndex = 5;
            this.btnGetBookByTitle.Text = "Get Book By Title";
            this.btnGetBookByTitle.UseVisualStyleBackColor = true;
            this.btnGetBookByTitle.Click += new System.EventHandler(this.btnGetBookByTitle_Click);
            // 
            // txtEnterAuthor
            // 
            this.txtEnterAuthor.Location = new System.Drawing.Point(711, 102);
            this.txtEnterAuthor.Name = "txtEnterAuthor";
            this.txtEnterAuthor.Size = new System.Drawing.Size(219, 20);
            this.txtEnterAuthor.TabIndex = 4;
            this.txtEnterAuthor.Text = "Enter Author";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(711, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Author Name";
            // 
            // btnGetBookByAuthor
            // 
            this.btnGetBookByAuthor.Location = new System.Drawing.Point(711, 135);
            this.btnGetBookByAuthor.Name = "btnGetBookByAuthor";
            this.btnGetBookByAuthor.Size = new System.Drawing.Size(219, 23);
            this.btnGetBookByAuthor.TabIndex = 2;
            this.btnGetBookByAuthor.Text = "Get Book By Author";
            this.btnGetBookByAuthor.UseVisualStyleBackColor = true;
            this.btnGetBookByAuthor.Click += new System.EventHandler(this.btnGetBookByAuthor_Click);
            // 
            // btnGetAllBooks
            // 
            this.btnGetAllBooks.Location = new System.Drawing.Point(711, 26);
            this.btnGetAllBooks.Name = "btnGetAllBooks";
            this.btnGetAllBooks.Size = new System.Drawing.Size(219, 23);
            this.btnGetAllBooks.TabIndex = 1;
            this.btnGetAllBooks.Text = "Get All Books";
            this.btnGetAllBooks.UseVisualStyleBackColor = true;
            this.btnGetAllBooks.Click += new System.EventHandler(this.btnGetAllBooks_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(626, 378);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabBookSelection
            // 
            this.tabBookSelection.Controls.Add(this.btnMostSoldList);
            this.tabBookSelection.Controls.Add(this.btnAfterDate);
            this.tabBookSelection.Controls.Add(this.btnAfterMonth);
            this.tabBookSelection.Controls.Add(this.btnAfterYear);
            this.tabBookSelection.Controls.Add(this.txtEnterDate);
            this.tabBookSelection.Controls.Add(this.label17);
            this.tabBookSelection.Controls.Add(this.dataGridView2);
            this.tabBookSelection.Location = new System.Drawing.Point(4, 22);
            this.tabBookSelection.Name = "tabBookSelection";
            this.tabBookSelection.Size = new System.Drawing.Size(1035, 531);
            this.tabBookSelection.TabIndex = 5;
            this.tabBookSelection.Text = "Book Selection";
            this.tabBookSelection.UseVisualStyleBackColor = true;
            // 
            // btnMostSoldList
            // 
            this.btnMostSoldList.Location = new System.Drawing.Point(712, 258);
            this.btnMostSoldList.Name = "btnMostSoldList";
            this.btnMostSoldList.Size = new System.Drawing.Size(227, 23);
            this.btnMostSoldList.TabIndex = 6;
            this.btnMostSoldList.Text = "Find Most Sold";
            this.btnMostSoldList.UseVisualStyleBackColor = true;
            this.btnMostSoldList.Click += new System.EventHandler(this.btnMostSoldList_Click);
            // 
            // btnAfterDate
            // 
            this.btnAfterDate.Location = new System.Drawing.Point(712, 206);
            this.btnAfterDate.Name = "btnAfterDate";
            this.btnAfterDate.Size = new System.Drawing.Size(227, 23);
            this.btnAfterDate.TabIndex = 5;
            this.btnAfterDate.Text = "After Date Day";
            this.btnAfterDate.UseVisualStyleBackColor = true;
            this.btnAfterDate.Click += new System.EventHandler(this.btnAfterDate_Click);
            // 
            // btnAfterMonth
            // 
            this.btnAfterMonth.Location = new System.Drawing.Point(712, 155);
            this.btnAfterMonth.Name = "btnAfterMonth";
            this.btnAfterMonth.Size = new System.Drawing.Size(227, 23);
            this.btnAfterMonth.TabIndex = 4;
            this.btnAfterMonth.Text = "Find After Date Month";
            this.btnAfterMonth.UseVisualStyleBackColor = true;
            this.btnAfterMonth.Click += new System.EventHandler(this.btnAfterMonth_Click);
            // 
            // btnAfterYear
            // 
            this.btnAfterYear.Location = new System.Drawing.Point(712, 106);
            this.btnAfterYear.Name = "btnAfterYear";
            this.btnAfterYear.Size = new System.Drawing.Size(227, 23);
            this.btnAfterYear.TabIndex = 3;
            this.btnAfterYear.Text = "Find After Date Year";
            this.btnAfterYear.UseVisualStyleBackColor = true;
            this.btnAfterYear.Click += new System.EventHandler(this.btnAfterYear_Click);
            // 
            // txtEnterDate
            // 
            this.txtEnterDate.Location = new System.Drawing.Point(712, 60);
            this.txtEnterDate.Name = "txtEnterDate";
            this.txtEnterDate.Size = new System.Drawing.Size(227, 20);
            this.txtEnterDate.TabIndex = 2;
            this.txtEnterDate.Text = "Enter Date...";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(709, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Enter Date";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(648, 397);
            this.dataGridView2.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnSellBook
            // 
            this.btnSellBook.Location = new System.Drawing.Point(639, 407);
            this.btnSellBook.Name = "btnSellBook";
            this.btnSellBook.Size = new System.Drawing.Size(219, 23);
            this.btnSellBook.TabIndex = 22;
            this.btnSellBook.Text = "Sell Book";
            this.btnSellBook.UseVisualStyleBackColor = true;
            this.btnSellBook.Click += new System.EventHandler(this.btnSellBook_Click_1);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(377, 410);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(216, 20);
            this.label18.TabIndex = 23;
            this.label18.Text = "First Select Book, Then Sell it";
            // 
            // tabSoldBooks
            // 
            this.tabSoldBooks.Controls.Add(this.btnShowAllSold);
            this.tabSoldBooks.Controls.Add(this.dataGridView3);
            this.tabSoldBooks.Location = new System.Drawing.Point(4, 22);
            this.tabSoldBooks.Name = "tabSoldBooks";
            this.tabSoldBooks.Size = new System.Drawing.Size(1035, 531);
            this.tabSoldBooks.TabIndex = 6;
            this.tabSoldBooks.Text = "Sold Books";
            this.tabSoldBooks.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(47, 37);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(580, 446);
            this.dataGridView3.TabIndex = 0;
            // 
            // btnShowAllSold
            // 
            this.btnShowAllSold.Location = new System.Drawing.Point(694, 68);
            this.btnShowAllSold.Name = "btnShowAllSold";
            this.btnShowAllSold.Size = new System.Drawing.Size(268, 23);
            this.btnShowAllSold.TabIndex = 1;
            this.btnShowAllSold.Text = "Show All Sold Books";
            this.btnShowAllSold.UseVisualStyleBackColor = true;
            this.btnShowAllSold.Click += new System.EventHandler(this.btnShowAllSold_Click);
            // 
            // btnFindNextBook
            // 
            this.btnFindNextBook.Location = new System.Drawing.Point(583, 233);
            this.btnFindNextBook.Name = "btnFindNextBook";
            this.btnFindNextBook.Size = new System.Drawing.Size(275, 23);
            this.btnFindNextBook.TabIndex = 24;
            this.btnFindNextBook.Text = "Find Next";
            this.btnFindNextBook.UseVisualStyleBackColor = true;
            this.btnFindNextBook.Click += new System.EventHandler(this.btnFindNextBook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 652);
            this.Controls.Add(this.tbControlBooks);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "Form1";
            this.Text = "Book Shop";
            this.tbControlBooks.ResumeLayout(false);
            this.tbLogin.ResumeLayout(false);
            this.tbLogin.PerformLayout();
            this.tbAddBook.ResumeLayout(false);
            this.tbAddBook.PerformLayout();
            this.tbAddAuthor.ResumeLayout(false);
            this.tbAddAuthor.PerformLayout();
            this.tbAddPublisher.ResumeLayout(false);
            this.tbAddPublisher.PerformLayout();
            this.tbListBooks.ResumeLayout(false);
            this.tbListBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabBookSelection.ResumeLayout(false);
            this.tabBookSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabSoldBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlBooks;
        private System.Windows.Forms.TabPage tbLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLoginPass;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.TabPage tbAddBook;
        private System.Windows.Forms.TabPage tbAddAuthor;
        private System.Windows.Forms.TabPage tbAddPublisher;
        private System.Windows.Forms.TabPage tbListBooks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAuthorId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookPages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboTrilogy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGenreId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPublisherId;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAuthorAuthorId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label lblBookId;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnModifyBook;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPublisherPublisherId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPublisherAddress;
        private System.Windows.Forms.Label txtPublisherName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddPublisher;
        private System.Windows.Forms.Button btnGetAllBooks;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetBookByAuthor;
        private System.Windows.Forms.TextBox txtEnterAuthor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGetBookTitle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnGetBookByTitle;
        private System.Windows.Forms.TextBox txtEnterGenre;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnGetBookByGenre;
        private System.Windows.Forms.TabPage tabBookSelection;
        private System.Windows.Forms.TextBox txtEnterDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnAfterDate;
        private System.Windows.Forms.Button btnAfterMonth;
        private System.Windows.Forms.Button btnAfterYear;
        private System.Windows.Forms.Button btnMostSoldList;
        private System.Windows.Forms.Button btnfindBook;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSellBook;
        private System.Windows.Forms.TabPage tabSoldBooks;
        private System.Windows.Forms.Button btnShowAllSold;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnFindNextBook;
    }
}

