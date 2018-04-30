using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WorkWithEntityFramework
{
    public partial class Form1 : Form
    {
        List<Author> authors;
        List<Book> books;
        List<Publisher> publishers;
        public Form1()
        {
            InitializeComponent();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Author author = new Author
            {
                FirstName = txtFirstName.Text.ToString(),
                LastName = txtLastName.Text.ToString()
            };
            MyLibConnection.AddAuthor(author);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           List<Author> authors= MyLibConnection.GetAllAuthors();
           dataGridView1.DataSource = authors;
            
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Book book = new Book()
            {
                IdAuthor = Convert.ToInt32(txtAuthorId.Text),
                IdPublisher = Convert.ToInt32(txtIdPublisher.Text),
                Title = txtTitle.Text,
                Pages = Convert.ToInt32(txtPages.Text),
                Price = Convert.ToInt32(txtPrice.Text)

            };
            MyLibConnection.AddBook(book);

        }

        private void btnGetBooks_Click(object sender, EventArgs e)
        {
            books = MyLibConnection.GetAllBooks();
            dataGridView2.DataSource = this.books;
        }

        private void btnGetPublishers_Click(object sender, EventArgs e)
        {
            publishers = MyLibConnection.GetAllPublishers();
            dataGridView3.DataSource = this.publishers;
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            Publisher publisher = new Publisher()
            {
                PublisherName = txtPublisherName.Text,
                Address = txtPublisherAddress.Text
            };
            MyLibConnection.AddPublisher(publisher);

        }
    }
}
