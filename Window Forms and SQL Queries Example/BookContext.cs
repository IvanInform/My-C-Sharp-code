using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookKeeper
{
    public class BookContext:DbContext
    {
        public BookContext()
            : base() {
        Database.SetInitializer(new BooksDBInitilizer());
    }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get;set;}
        public DbSet<SoldBook> SoldBooks { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
