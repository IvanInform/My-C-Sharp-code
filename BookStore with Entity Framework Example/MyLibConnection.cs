using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithEntityFramework
{
    public class MyLibConnection
    {
      
        public static void AddAuthor(Author author)
        {
            using (mylibraryEntities db = new mylibraryEntities())
            {
                Author a = db.Author.Where((x) =>
                x.FirstName == author.FirstName
                ).FirstOrDefault();
                if (a == null)
                db.Author.Add(author);
                db.SaveChanges();
               
            }
        }
        public static void AddBook() { 
        
        
        }
       public  static void AddPublisher(Publisher publisher)
{
            using (mylibraryEntities db = new mylibraryEntities ())
        {
                Publisher a = db.Publisher.Where((x) =>
                x.PublisherName == publisher.
                PublisherName).FirstOrDefault();
                if (a == null)
            {
            db.Publisher.Add(publisher);
                db.SaveChanges();

                }
            }
    }
       public static void AddBook(Book book) {
           using (mylibraryEntities db = new mylibraryEntities()) {
               Book a = db.Book.Where((x) =>
                   x.Title == book.Title).FirstOrDefault();
               if (a == null) {
                   db.Book.Add(book);
                   db.SaveChanges();
               }
           
           }
       
       }
        public static List<Author> GetAllAuthors()
        {
            List<Author> authors = new List<Author>();
            using (mylibraryEntities db = new mylibraryEntities())
            {
                authors = db.Author.ToList();
                
            }
            return authors;
        }
        public static List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();
            using (mylibraryEntities db = new mylibraryEntities())
            {
                books = db.Book.ToList();

            }
            return books;
        }
        public static List<Publisher> GetAllPublishers()
        {
            List<Publisher> publishes = new List<Publisher>();
            using (mylibraryEntities db = new mylibraryEntities())
            {
                publishes = db.Publisher.ToList();

            }
            return publishes;
        }
    }
}
