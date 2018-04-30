using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MoreLinq;
using System.Data.Entity;
using System.Xml.Linq;
using System.Xml;




namespace ConsoleApplication1
{
   
    class Program
    {
       
        static void Main(string[] args)
        {
            //Random rand = new Random();
#region
            //XmlDocument doc = new XmlDocument();
            //XmlElement docname = doc.CreateElement("Books");
            //doc.AppendChild(docname);
            //try
            //{

            //    for (int i = 0; i < 10000; i++)
            //    {
            //        XmlElement book = doc.CreateElement("Book");
            //        XmlElement title = doc.CreateElement("Title");
            //        title.InnerText = string.Format("Book number {0}", rand.Next(1, 100));
            //        XmlElement pages = doc.CreateElement("Pages");
            //        pages.InnerText = string.Format("{0}", rand.Next(100, 1000));
            //        XmlElement price = doc.CreateElement("Price");
            //        price.InnerText = string.Format("{0}", rand.Next(300, 700));
            //        XmlElement idAuthor = doc.CreateElement("idAuthor");
            //        idAuthor.InnerText = string.Format("{0}", rand.Next(1, 3));
            //        XmlElement idPublisher = doc.CreateElement("idPublisher");
            //        idPublisher.InnerText = string.Format("{0}", rand.Next(1, 2));
            //        book.AppendChild(title);
            //        book.AppendChild(pages);
            //        book.AppendChild(price);
            //        book.AppendChild(idAuthor);
            //        book.AppendChild(idPublisher);
            //        docname.AppendChild(book);
            //    }
            //    doc.Save("books.xml");

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //} 
#endregion 
            #region 

            //XDocument xmldoc = XDocument.Load("books.xml");
            //var result = from c in xmldoc.Descendants(XName.Get("Book"))
            //             select new Book
            //             {
            //                 Title = c.Element("Title").Value.ToString(),
            //                 Price = Convert.ToDouble(c.Element("Price").Value),
            //                 AuthorId1 = Convert.ToInt32(c.Element("idAuthor").Value),
            //                 IdAuthor = Convert.ToInt32(c.Element("idAuthor").Value),
            //                 PublisherId = Convert.ToInt32(c.Element("idPublisher").Value),
            //                 IdPublisher = Convert.ToInt32(c.Element("idPublisher").Value),
            //                 Pages = Convert.ToInt32(c.Element("Pages").Value)
            //             };

            //var result1 = xmldoc.Descendants(XName.Get("Book")).Select(p => new Book
            //{
            //    Title = p.Element("Title").Value,
            //    Price = Convert.ToDouble(p.Element("Price").Value.ToString()),
            //    AuthorId1 = Convert.ToInt32(p.Element("idAuthor").Value.ToString()),
            //    IdPublisher = Convert.ToInt32(p.Element("idPublisher").Value.ToString()),
            //    Pages = Convert.ToInt32(p.Element("Pages").Value.ToString())
            //});
            //var xmlresult = from c in xmldoc.Descendants(XName.Get("Book"))
            //                select c.Element("Title").Value.ToString();

            //try
            //{
            //    foreach (Book item in result)
            //    {
            //        AddBook(item);

            //    }
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}



            //using (Model1Container db = new Model1Container())
            //{

            //    AddAuthor(new Author() { FirstName = "Peter", LastName = "Grishin" });
            //    AddAuthor(new Author() { FirstName = "Sasha", LastName = "Pupkin" });
            //    AddAuthor(new Author() { FirstName = "Grisha", LastName = "Saveliev" });
            //    AddPublisher(new Publisher() { PublisherName = "Publisher 1", PublisherAddress = "Zaporozhye, street 5" });
            //    AddPublisher(new Publisher() { PublisherName = "Publisher 1", PublisherAddress = "Zaporozhye, street 225" });
            //    db.SaveChanges();


            //}
            #endregion
            long start = DateTime.Now.Ticks;
            
            using (Model1Container db = new Model1Container()) {
                var au = db.Books.OrderBy((x) => x.Title).ToList();
                           
            
            }
            long end = DateTime.Now.Ticks;
            long tick = end - start;
            long milliseconds = tick / TimeSpan.TicksPerMillisecond;
            Console.WriteLine("Time passed for retrieving with lazy loading: "+ milliseconds);
            start = DateTime.Now.Ticks;
            using (Model1Container db = new Model1Container())
            {
                var books = db.Books.Include("Author").ToList<Book>();


            }
             end = DateTime.Now.Ticks;
             tick = end - start;
             milliseconds = tick / TimeSpan.TicksPerMillisecond;
            Console.WriteLine("Time passed for retrieving with lazy loading: " + milliseconds);
            Console.ReadKey();

        }

        static void AddBook(Book book) { 
        using (Model1Container db =new Model1Container()){
        Book a=db.Books.Where((x)=>x.Title==book.Title).FirstOrDefault();
            if (a==null){
            db.Books.Add(book);
                db.SaveChanges();
                Console.WriteLine("New Book Added: "+book.Title+" "+book.Pages);
            
            }
        
        }
        }
        #region
        static void AddAuthor(Author author) {
            using (Model1Container db = new Model1Container()) {
                Author a = db.AuthorSet.Where((x) => x.FirstName == author.FirstName && x.LastName == author.LastName).FirstOrDefault();

                if (a == null) {
                    db.AuthorSet.Add(author);
                    db.SaveChanges();
                    Console.WriteLine("New Author added: "+author.LastName);
                }
            
            
            
            }
        
        }
        static void AddPublisher(Publisher publisher) {

            using (Model1Container db = new Model1Container()) {
                Publisher a = db.Publishers.Where((x) => (x.PublisherName == publisher.PublisherName) &&( x.PublisherAddress == publisher.PublisherAddress)).FirstOrDefault();
                if (a == null) {
                    db.Publishers.Add(publisher);
                    db.SaveChanges();
                    Console.WriteLine("new Publisher: "+publisher.PublisherName);
                }
            
            }
        }
        static void GetAllAuthors() {
            using (Model1Container db = new Model1Container()) {
                var au = db.AuthorSet.ToList();
                foreach (var a in au) {
                    Console.WriteLine(a.FirstName+" "+a.LastName);
                }
            
            
            }
        
        
        }
        #endregion
        class Product {
            public string Name { get; set; }
            public int Price { get; set; }
        }
        //static void myTransaction() {
        //    using (LibraryEntities context = new LibraryEntities()) {

        //        using (DbContextTransaction dbtran = context.Database.BeginTransaction()) {

        //            try
        //            {
        //                Authors author = new Authors { FirstName = "Stanislav", LastName = "Lem" };
        //                context.Authors.Add(author);
        //                context.Authors.Remove(author);
        //                context.SaveChanges();
        //                dbtran.Commit();

        //            }
        //            catch (Exception ex)
        //            {

        //                Console.WriteLine(ex.Message);
        //                dbtran.Rollback();
        //            }
                
        //        }
        //    }
        
        //}
        //static void addauthor(Authors author) { 
        //  using (LibraryEntities context = new LibraryEntities())
        //    {
        //        context.Database.Log = Console.Write;
        //        Authors a = context.Authors.Where((x) => x.FirstName == author.FirstName &&
        //            x.LastName == author.LastName).FirstOrDefault();
        //        if (a == null) {

        //            context.Authors.Add(author);
        //            context.SaveChanges();
        //            Console.WriteLine("New author added: "+author.LastName);
        //        }

        //    }
        //}
                }
        }



