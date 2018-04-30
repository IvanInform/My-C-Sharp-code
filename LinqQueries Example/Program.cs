using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace lingqueries
{
    class Product
    {
        
        public string Name { set; get; }
        public int Price { set; get; }
        public string Manufacturer { set; get; }
        public int Count { set; get; }
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", this.Name,
            this.Price, this.Manufacturer, this.Count);
        }
    }
    class product {
        public string Name { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return string.Format("{0}{1}", Name, Price);
        }
    }
    
    class Program    {
        public void CreateXmlDocument()
        {
            XDocument xmldoc = new XDocument(
new XElement("computers",
new XAttribute("Price", "800"),
new XAttribute("Warranty", "2 years"),
new XElement("CPU",
new XAttribute("Name", "Intel Core i7-6700K"),
new XAttribute("GHz", 2.5)
),
new XElement("HDD",
new XAttribute("Name", "Samsung 850 PRO"),
new XAttribute("Size", 1.0)
)
,
new XElement("computer",
new XAttribute("Price", "900"),
new XAttribute("Warranty", "2 years"),
new XElement("CPU",
new XAttribute("Name", "AMD A10-5800K"),
new XAttribute("GHz", 2.5)
),
new XElement("HDD",
new XAttribute("Name", "Transcend ESD400"),
new XAttribute("Size", 1.0)
)
)))
;
            Console.WriteLine(xmldoc);

        }
        string [] coutries;
        public Program(){
       this.coutries = new string[]{ "Albania", "UK", "Lithuania",
"Andorra", "Austria", "Latvia",
"Liechtenstein", "Switzerland", "Ireland",
"Sweden", "Italy", "France", "Liechtenstein",
"Spain", "Turkey", "Germany", "Switzerland",
"Monaco", "Montenegro", "Norway", "Finland",
"Turkey", "UK", "Poland", "Portugal",
"Lithuania", "Luxembourg"
};
        }
        private List<product> GetProducts() {
            return new List<product>{
        new product{Price=100,Name="product1"},
        new product{Price=50, Name="product2"}
        ,new product{Price=40, Name="product3"}
        };
        
        }

        static void AddAuthor(Author author) {
            using (mylibraryEntities db = new mylibraryEntities()) {

                db.Author.Add(author);
                db.SaveChanges();
                Console.WriteLine("New author added: "+ author.LastName);
                     
                       }
        
        }
        static void GetAllAuthors() {

            using (mylibraryEntities db = new mylibraryEntities()) {
                var au = db.Author.ToList();
                foreach (var a in au) {
                    Console.WriteLine(a.FirstName+" "+
                        a.LastName);
                }
            
            }
        }
        static void Main(string[] args)
        {
            #region
            //    linemethod();
        //    List<product> products = new Program().GetProducts();
        //    int maxPrice = products.Max(p => p.Price);
        //    var item = products.First(p => p.Price == maxPrice);
        //    Console.WriteLine(item);
        //    var ProdCount = products.Count(p => p.Price > 50 && p.Price <= 100);
        //    Console.WriteLine(ProdCount);
        //    List<Product> prod = new Program().getcountries();
        //    var result5 = from d in prod
        //                  where d.Price < 500
        //                  orderby d.Price
        //                  select new { d.Name, d.Price };
        //    Console.WriteLine();
        //    Console.WriteLine();
        //    foreach (var d in result5) {
        //        Console.WriteLine(d);
            //    }
            #endregion
            #region
            //DataClasses1DataContext context = new DataClasses1DataContext();
            //var queryResults = from c in context.Books
            //                   where c.PRICE > 100
            //                   select new
            //                   {
            //                       Id = c.Id,
            //                       Name = c.Title,
            //                       Price = c.PRICE

            //                   };
            //foreach (var item in queryResults) { Console.WriteLine( item); }

            //Program d = new Program();
            //d.CreateXmlDocument();
            #endregion

            Author author = new Author { FirstName = "Isaac", LastName = "Azimov" };
            AddAuthor(author);
            GetAllAuthors();
            Console.ReadKey();

        }
        private List<Product> getcountries()
        {

            List<Product> products = new List<Product>();



            for (int i = 0; i < 100; i++)
            {

                Thread.Sleep(5);
                products.Add(new Product
                {
                    Name = "Product" + (++i),
                    Price = (new Random()).Next(0, 1000),
                    Manufacturer =
                    this.coutries[(new Random()).
                    Next(0, this.coutries.Length - 1)],
                    Count = (new Random()).Next(0, 10)
                });
            }
            return products;
        }
        

        private static void linemethod()
        {
            string[] countries = new string[]{"Albania", "UK",
"Lithuania", "Andorra", "Austria",
"Latvia", "Liechtenstein", "Switzerland",
"Ireland", "Sweden","Italy", "France",
"Liechtenstein", "Spain", "Turkey", "Germany",
"Switzerland", "Monaco", "Montenegro",
"Norway", "Finland", "Turkey", "UK", "Poland",
"Portugal", "Lithuania", "Luxembourg"
            
            };
            var result = from c in countries
                         where c.StartsWith("L")
                         select c;
            var result2 = from c in countries where c.Length > 10 select c;
            foreach (var item in result2) { Console.WriteLine(item); }
            foreach (var item in result) {
                Console.WriteLine(item);
            }

            var result3 = (from c in countries
                           where c.StartsWith("L")
                           orderby
                               c.Length descending
                           select c).Distinct();
            foreach (var item in result3) { Console.WriteLine(item); }
            var result4 = countries.OrderBy(c => c.Length).Where(c => c.StartsWith("L"));
        
        }
    }
}
