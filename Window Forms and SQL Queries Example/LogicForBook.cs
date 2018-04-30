using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BookKeeper;

namespace BookKeeper
{
   public class LogicForBook    {
       public List<Book> GetAllBooks() {
           using (BookContext db = new BookContext()) {

               var au = db.Books.OrderBy((x) => x.BookName).ToList();
               return au;
                      }
       }
       public void AddAuthor(Author fname){
        using (BookContext db=new BookContext())
        {
        var author=db.Authors.Where((x)=>x.FirstName==fname.FirstName&&x.LastName==fname.LastName).FirstOrDefault();
            if (author==null){
            db.Authors.Add(fname);
                db.SaveChanges();
            
            }
        
        }       
       }
  
       public void AddPublisher(Publisher fname){
        using (BookContext db=new BookContext())
        {
        var publisher=db.Publishers.Where((x)=>x.PublisherName==fname.PublisherName).FirstOrDefault();
            if (publisher==null){
            db.Publishers.Add(fname);
                db.SaveChanges();
            
            }
        
        } 
       
       }
           public void AddBook(Book fname){
           using (BookContext db=new BookContext())
        {
       
            db.Books.Add(fname);
                db.SaveChanges();
            
                   
        } 
     }
          public void DeleteBook(int id) {
               using (BookContext db = new BookContext()) {

                   var au = db.Books.Find(id);
                   db.Books.Remove(au);
                   db.SaveChanges();
               
               }
                     
           }
          public void ModifyBook(Book fname)
          {
               using (BookContext db = new BookContext()) {
                   db.Entry(fname).State = EntityState.Modified;
                   db.SaveChanges();
                              
               }
           
           }

          public List<Book> FindBookByAuthor(string AuthorName)
          {
               using (BookContext db = new BookContext()) {
                   var books = db.Books.Include("Author").ToList<Book>();
                   var needBook = books.Where((x) => x.author.LastName.StartsWith(AuthorName)).ToList();
                   if (needBook != null)
                   {
                       return needBook;

                   }
                   else {

                       return new List<Book>(){new Book{
                       
                           Id = 100,
                           BookName = "Not Known",
                           author = new Author() { FirstName = "Unknown", LastName = "Unknown" },
                           DateofPublish = new DateTime(2000, 1, 1),
                           genre = new Genre() { GenreName = "unknown" },
                           Pages = 0,
                           publisher = new Publisher() { PublisherName = "unknown", Address = "unknown" },
                           Trilogy = false}
                       };
                   }
               }
           
           }
          public List<Book> FindBookByTitle(string title)
          {
               using (BookContext db = new BookContext()) {
                   var au = db.Books.Where((x) => x.BookName.StartsWith(title)).ToList();
                   if (au != null)
                   {
                       return au;

                   }
                   else
                   {

                       return new List<Book>(){new Book()
                       {
                           Id = 100,
                           BookName = "Not Known",
                           author = new Author() { FirstName = "Unknown", LastName = "Unknown" },
                           DateofPublish = new DateTime(2000, 1, 1),
                           genre = new Genre() { GenreName = "unknown" },
                           Pages = 0,
                           publisher = new Publisher() { PublisherName = "unknown", Address = "unknown" },
                           Trilogy = false
                       }};
                   }

               }
           }
          public bool AddtoSale(int bookid, double bookprice) {
              bool soldalready = false;
             using (BookContext db = new BookContext()) {
                 Book au = db.Books.Find(bookid);
                 var bk = db.SoldBooks.Where((x) => x.BookId == au.Id).FirstOrDefault();
                 if (bk == null)
                 {

                     db.SoldBooks.Add(new SoldBook() { BookId = bookid, DateofSale = DateTime.Now, Price = bookprice });

                     db.SaveChanges();
                 }
                 else {
                     soldalready = true;
                 }
            }
             return soldalready;
        }
          public List<SoldBook> ShowAllSold() {
              using (BookContext db = new BookContext()) {
                  var au = db.SoldBooks.ToList();
                  return au;
              
              
              }
          
          }
          public List<Book> FindBookByGenre(string genrename)
          {
               using (BookContext db = new BookContext())
               {
                   var books = db.Books.Include("Genre").ToList<Book>();
                   var needBook = books.Where((x) => x.genre.GenreName.StartsWith(genrename)).ToList();
                   if (needBook != null)
                   {
                       return needBook;

                   }
                   else
                   {
                       return new List<Book>(){new Book
                       {
                           Id = 100,
                           BookName = "Not Known",
                           author = new Author() { FirstName = "Unknown", LastName = "Unknown" },
                           DateofPublish = new DateTime(2000, 1, 1),
                           genre = new Genre() { GenreName = "unknown" },
                           Pages = 0,
                           publisher = new Publisher() { PublisherName = "unknown", Address = "unknown" },
                           Trilogy = false
                       }};
                   }
               }
           
           }
          public List<Book> NewBooksByYear(DateTime date)
          {
               using (BookContext db = new BookContext())
               {
                   var au = db.Books.Where((x) => x.DateofPublish.Year > date.Year).ToList();
                   return au;
               }

           }
          public List<Book> NewBooksByMonth(DateTime date)
           {
               using (BookContext db = new BookContext())
               {
                   var au = db.Books.Where((x) => (((x.DateofPublish.Year - date.Year) * 12) + x.DateofPublish.Month - date.Month)>0).ToList();
                   return au;
               }

           }
          public List<Book> NewBooksByDate(DateTime date)
           {
               DateTime dt = date;
              
               using (BookContext db = new BookContext())
               {
                   var au = db.Books.Where((x) => DbFunctions.TruncateTime(x.DateofPublish).Value > dt).ToList();
                   return au;
               }

           }
          public List<Book> BlockBusters()
          {
              List<Book> blockbust=new List<Book>();
               using (BookContext db = new BookContext()) {
                   
                   var au = db.SoldBooks.Include("book").ToList();
                   var mostused = au.GroupBy(q => q.book.BookName).OrderByDescending(gp => gp.Count())
                       .Take(1)
                       .Select(g => g.Key).ToList();
                   foreach(var item in mostused){
                       var finalresult = db.Books.Where((x) => x.BookName.StartsWith(item)).FirstOrDefault();
                       blockbust.Add(finalresult);
                   }
                   return blockbust;
               
               }
           
           }

       
       }

 }

