using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace libraryProjectEntity
{
    public partial class Form1 : Form
    {
        string findauthor;
        List<Book> listofBooks = new List<Book>();
        public Form1()
        {
            InitializeComponent();
            btnFind.Enabled = false;

        }
        #region 
        //private void fillTables() {
        //    using (LibraryEntities db = new LibraryEntities())
        //    {
                
        //        //Author a1 = new Author() { FirstName = "Sasha", LastName = "Petrov" };
        //        //Author a2 = new Author() { FirstName = "Masha", LastName = "Petrova" };
        //        //Author a3 = new Author() { FirstName = "Egor", LastName = "Pushkin" };
        //        //Author a4 = new Author() { FirstName = "Grisha", LastName = "Mushin" };
        //        //db.Authors.AddRange(new Author[] { a1, a2, a3, a4 });
        //        //db.SaveChanges();
        //        Book book1 = new Book() { Title = "Book1", Pages = 100, IdAuthor = 1, Publisher = new Publisher() {Address="Street1, Zaporozhye", PublisherName="Publisher1" },
        //            Price = 300 };
        //        Book book2 = new Book()
        //        {
        //            Title = "Book2",
        //            Pages = 100,
        //            IdAuthor = 2,
        //            Publisher = new Publisher() { Address = "Street2, Kyiv", PublisherName = "Publisher1" },
        //            Price = 300
        //        };
        //        Book book3 = new Book()
        //        {
        //            Title = "Book1",
        //            Pages = 500,
        //            IdAuthor = 3,
        //            Publisher = new Publisher() { Address = "Street2, Kharkiv", PublisherName = "Publisher1" },
        //            Price = 300
        //        };
        //        Book book4 = new Book()
        //        {
        //            Title = "Book1",
        //            Pages = 700,
        //            IdAuthor = 1,
        //            Publisher = new Publisher() { Address = "Street1, Zaporozhye", PublisherName = "Publisher1" },
        //            Price = 300
        //        };
        //        db.Books.AddRange(new Book[] { book1, book2, book3, book4 });
        //        db.SaveChanges();

        //    }

        //}
        #endregion
        private void btnFind_Click(object sender, EventArgs e)
        {
            findauthor = tbFind.Text;
            using (LibraryEntities context = new LibraryEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                var author = (from b in context.Authors
                              where (b.LastName.StartsWith(findauthor))
                              select b).ToList();
                foreach (var item in author)
                {
                    context.Entry(item).Collection(a => a.Books).Load();
                    listofBooks.AddRange(item.Books);
                }
                dataGridView1.DataSource = listofBooks;


            }
        }

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            if (tbFind.Text.Length > 3) {

                btnFind.Enabled = true;
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            fillTables();
        }
    }
}
