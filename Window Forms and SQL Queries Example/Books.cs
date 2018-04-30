using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BookKeeper;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace BookKeeper
{
    [Table ("Books")]
   public class Book
   {
       public int Id { get; set; }
        
        [Required]
       public string BookName { get; set; }
       public int Pages { get; set; }
       public DateTime DateofPublish { get; set; }
       public bool Trilogy { get; set; }
       public double price { get; set; }
       // [DefaultValue(false)]
       //public string Sold { get; set; }

       public int AuthorId { get; set; }
    public virtual Author author {get;set;}
    public int PublisherId { get; set; }
    public virtual Publisher publisher {get;set;}
    public int GenreId { get; set; }
    public virtual Genre genre { get; set; }

    }
    [Table ("Authors")]
public class Author{
    public int Id { get; set; }
    [Required]
    public string FirstName {get;set;}
    [Required]
public string LastName { get; set; }
    public virtual ICollection<Book> Books{get;set;}
}
    [Table ("Publishers")]
public class Publisher{
    public int Id{get;set;}
    [Required]
    public string PublisherName { get; set; }
    public string Address { get; set; }
    public virtual ICollection<Book> Books{get;set;}
}
    [Table("SoldBooks")]
    public class SoldBook {
        public int Id { get; set; }
        public DateTime DateofSale { get; set; }
        public double Price { get; set; }
        public int BookId { get; set; }
        public virtual Book book { get; set; }
    }

    [Table ("Genre")]
    public class Genre {
        public int Id { get; set; }
        public string GenreName { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }

}
