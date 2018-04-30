using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookKeeper;
using System.Data.Entity;

namespace BookKeeper
{
    public partial class Form1 : Form
    {
        LogicForBook logic = new LogicForBook();
        List<Book> ListOfBooks;
        List<compressedBook> compressedbooks;
        List<compressedBook> secondGridList;
        List<Book> allBooks;
        string password = "111";
        string login = "masha";
        public Form1()
        {
            InitializeComponent();
            ListOfBooks = new List<Book>();
            compressedbooks = null;
            secondGridList = null;
            btnFindNextBook.Enabled = false;
            allBooks = null;
            foreach (var page in tbControlBooks.TabPages) {
                Control item = (Control)page;
                if (item.Text == "Login") { continue; }
                item.Enabled = false;
            
            }     
            
          }

        private void btnAddBook_Click(object sender, EventArgs e)
        {

            DateTime date = new DateTime();
            int pagenumber = 0;
            double bprice = 0.0;
            int authorid = 0;
            int publisherid = 0;
            int genreid = 0;
            bool trilogy = false;
            try
            {
                date = Convert.ToDateTime(txtBookDate.Text);
                pagenumber = Convert.ToInt32(txtBookPages.Text);
                bprice = Convert.ToDouble(txtBookPrice.Text);
                authorid = Convert.ToInt32(txtAuthorId.Text);
                publisherid = Convert.ToInt32(txtPublisherId.Text);
                genreid = Convert.ToInt32(txtGenreId.Text);
                trilogy = Convert.ToBoolean(comboTrilogy.SelectedItem.ToString());


                Book book = new Book()
                {
                    BookName = txtBookTitle.Text,
                    Pages = pagenumber,
                    DateofPublish = date,
                    GenreId = genreid,
                    AuthorId = authorid,
                    PublisherId = publisherid,
                    price=bprice

                };
                logic.AddBook(book);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            logic.AddAuthor(new Author() { LastName = txtLastName.Text, FirstName = txtFirstName.Text });
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            logic.AddPublisher(new Publisher() { PublisherName = txtPublisherName.Text, Address = txtPublisherAddress.Text });

        }

        private void btnGetAllBooks_Click(object sender, EventArgs e)
        {
           
           
                compressedbooks = ConverttoBook(logic.GetAllBooks());

                dataGridView1.DataSource = compressedbooks;

            
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            int bookid = 0;
            try
            {
                bookid = Convert.ToInt32(txtBookId.Text);
                logic.DeleteBook(bookid);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnModifyBook_Click(object sender, EventArgs e)
        {
            Book mybook = null;
            int bookId = 0;
            string title = "";
            DateTime date = new DateTime();
            int mypage = 0;
            double myprice = 0;
            int authorid = 0;
            int publisherid = 0;
            int genreid = 0;
            bool tril = false;

            try
            {
                bookId = Convert.ToInt32(txtBookId.Text);
                title = txtBookTitle.Text;
                date = Convert.ToDateTime(txtBookDate.Text);
                mypage = Convert.ToInt32(txtBookPages.Text);
                myprice = Convert.ToDouble(txtBookPrice.Text);
                authorid = Convert.ToInt32(txtAuthorId.Text);
                publisherid = Convert.ToInt32(txtPublisherId.Text);
                genreid = Convert.ToInt32(txtGenreId.Text);
                tril = Convert.ToBoolean(comboTrilogy.SelectedItem.ToString());
                mybook = new Book()
                {
                    Trilogy = tril,
                    GenreId = genreid,
                    PublisherId = publisherid,
                    AuthorId = authorid,
                    price = myprice,
                    Pages = mypage,
                    DateofPublish = date,
                    BookName = title,
                    Id = bookId
                };
                logic.ModifyBook(mybook);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnfindBook_Click(object sender, EventArgs e)
        {
            btnFindNextBook.Enabled = false;
            Book mybook = null;
           if (!string.IsNullOrEmpty(txtBookTitle.Text))
            {

                allBooks=logic.FindBookByTitle(txtBookTitle.Text);
                if (allBooks.Count>1){ btnFindNextBook.Enabled=true;}
                mybook = allBooks.ElementAt(0);
                if (string.Compare(mybook.BookName, "Not Known") == 0)
                {
                    MessageBox.Show("Book is not found");

                }
                else
                {
                    txtBookId.Text = mybook.Id.ToString();
                    txtBookTitle.Text = mybook.BookName.ToString();

                    txtBookDate.Text = mybook.DateofPublish.ToShortDateString();
                    txtBookPages.Text = mybook.Pages.ToString();
                    txtBookPrice.Text = mybook.price.ToString();
                    txtAuthorId.Text = mybook.AuthorId.ToString();
                    txtPublisherId.Text = mybook.PublisherId.ToString();
                    txtGenreId.Text = mybook.GenreId.ToString();
                    comboTrilogy.SelectedItem = mybook.Trilogy.ToString();

                }
            }
        }

        private void btnGetBookByAuthor_Click(object sender, EventArgs e)
        {
            string authorname = txtEnterAuthor.Text;
            
            dataGridView1.DataSource = ConverttoBook(logic.FindBookByAuthor(authorname));

        }

        private void btnGetBookByTitle_Click(object sender, EventArgs e)
        {
            string booktitle = txtGetBookTitle.Text;
            List<Book> returnedbooks = logic.FindBookByTitle(booktitle);
            compressedbooks = this.ConverttoBook(returnedbooks);
            dataGridView1.DataSource = compressedbooks;
        }

        private void btnGetBookByGenre_Click(object sender, EventArgs e)
        {
            string genretitle = txtEnterGenre.Text;
            dataGridView1.DataSource = ConverttoBook(logic.FindBookByGenre(genretitle));
        }
        private List<compressedBook> ConverttoBook(List<Book> books) {
            List<compressedBook> mylist = new List<compressedBook>();
            foreach (var item in books) {
                mylist.Add(new compressedBook()
                {
                    Id = item.Id,
                    BookName = item.BookName,
                    AuthorId = item.AuthorId,
                    DateofPublish = item.DateofPublish,
                    GenreId = item.GenreId,
                    price = item.price,
                    PublisherId = item.PublisherId,
                    Trilogy = item.Trilogy
                });
            
            }
            return mylist;
        
        }
        private compressedBook ConvertOneBook(Book item) {
            compressedBook book = new compressedBook()
            {
                Id = item.Id,
                BookName = item.BookName,
                AuthorId = item.AuthorId,
                DateofPublish = item.DateofPublish,
                GenreId = item.GenreId,
                price = item.price,
                PublisherId = item.PublisherId,
                Trilogy = item.Trilogy
            };
            return book;
        
        }
        class compressedBook
        {
            public int Id { get; set; }
            public string BookName { get; set; }
            public DateTime DateofPublish { get; set; }
            public bool Trilogy { get; set; }
            public double price { get; set; }

            public int AuthorId { get; set; }
            public int PublisherId { get; set; }
            public int GenreId { get; set; }

        }

        private void btnAfterYear_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime();
            try
            {
                date1 = Convert.ToDateTime(txtEnterDate.Text);
List<Book> listbooks =logic.NewBooksByYear(date1);
            secondGridList=ConverttoBook(listbooks);
            dataGridView2.DataSource=secondGridList;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnAfterMonth_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime();
            try
            {
                date1 = Convert.ToDateTime(txtEnterDate.Text);
                List<Book> listbooks = logic.NewBooksByMonth(date1);
                secondGridList = ConverttoBook(listbooks);
                dataGridView2.DataSource = secondGridList;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
           
        }

        private void btnAfterDate_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime();
            try
            {
                date1 = Convert.ToDateTime(txtEnterDate.Text);
                List<Book> listbooks = logic.NewBooksByDate(date1);
                secondGridList = ConverttoBook(listbooks);
                dataGridView2.DataSource = secondGridList;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
         }

        private void btnMostSoldList_Click(object sender, EventArgs e)
        {
            secondGridList = ConverttoBook(logic.BlockBusters());

            dataGridView2.DataSource = secondGridList;
        }

        private void btnSellBook_Click(object sender, EventArgs e)
        {
            
        }

        private void btnShowAllSold_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = returnShortSold(logic.ShowAllSold());
        }
        private List<shortForSold> returnShortSold(List<SoldBook> books) {
            List<shortForSold> soldshort = new List<shortForSold>();
            foreach (var item in books) {
                soldshort.Add(new shortForSold()
                {
                    Id=item.Id,
                    DateofSale=item.DateofSale,
                     BookId=item.BookId,
                      Price=item.Price

                });
            
            }
            return soldshort;
        
        }
        class shortForSold {
            public int Id { get; set; }
            public DateTime DateofSale { get; set; }
            public double Price { get; set; }
            public int BookId { get; set; }
           
        }

        private void btnSellBook_Click_1(object sender, EventArgs e)
        {
            bool result=false;
            if ((!string.IsNullOrEmpty(txtBookId.Text) && !string.IsNullOrEmpty(txtBookPrice.Text)))
            {
                result=logic.AddtoSale(Convert.ToInt32(txtBookId.Text), Convert.ToDouble(txtBookPrice.Text));
                if (result == true) { MessageBox.Show("Book sold Already!"); }
            }
            else
            {
                MessageBox.Show("No book selected!");

            }
        }

        private void btnFindNextBook_Click(object sender, EventArgs e)
        {
            Book mybook = null;
            if (allBooks.Count > 2)
            {
                allBooks.RemoveAt(0);
                mybook = allBooks.ElementAt(0);

                txtBookId.Text = mybook.Id.ToString();
                txtBookTitle.Text = mybook.BookName.ToString();

                txtBookDate.Text = mybook.DateofPublish.ToShortDateString();
                txtBookPages.Text = mybook.Pages.ToString();
                txtBookPrice.Text = mybook.price.ToString();
                txtAuthorId.Text = mybook.AuthorId.ToString();
                txtPublisherId.Text = mybook.PublisherId.ToString();
                txtGenreId.Text = mybook.GenreId.ToString();
                comboTrilogy.SelectedItem = mybook.Trilogy.ToString();


            }
            else {
                MessageBox.Show("No other books of same title");
                btnFindNextBook.Enabled = false;
            }
            
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*
              string password = "111";
        string login = "masha";*/
            if (txtLoginName.Text == login && txtLoginPass.Text == password)
            {

                foreach (var page in tbControlBooks.TabPages)
                {
                    Control item = (Control)page;
                    if (item.Text == "Login") { continue; }
                    item.Enabled = true;

                }

            }
            else {
                MessageBox.Show("Wrong Password or Login. No Authentication!");
            }
        }

    }
}
