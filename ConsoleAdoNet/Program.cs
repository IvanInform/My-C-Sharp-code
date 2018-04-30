using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ado_net_application
{
    public struct info {
        public double price;
        public int pages;
    }
    class Program
    {
        public info BookInfo;
        private string connectionString = ConfigurationManager.ConnectionStrings["LocalDb"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        public Program()
        {
            con = null;
            cmd = null;
        }
        public int getBooksNumber() {
            int numberBooks = 0;
            using (con = new SqlConnection(connectionString)) {
                string commandString = @"Select count (id) from Books";
                cmd = new SqlCommand(commandString, con);
                try
                {
                con.Open();
                numberBooks = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            
            }
            return numberBooks;
        
        }
        public info getPagesPrices() {
            BookInfo.pages = 0;
            BookInfo.price = 0.0;
            using (con = new SqlConnection(connectionString))
            {
                string commandString = @"Select * from Books";
                cmd = new SqlCommand(commandString, con);
               
                try
                {
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read()) { 
                        Console.Write("Book Title: {0}", rdr["Title"].ToString());
                       
                        int pages=Convert.ToInt32(rdr["PAGES"].ToString());
                      
                        BookInfo.pages += pages;
                        double price=Convert.ToDouble(rdr["PRICE"].ToString());
                    BookInfo.price += price;
                     Console.WriteLine("Price: {0}, Pages: {1}",pages,price  );
                    }
                    
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }
            return BookInfo;
        
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            int totalBooks=program.getBooksNumber();
            Console.WriteLine("Number of books: {0}", totalBooks);
            
            info bookinfo = program.getPagesPrices();
            Console.WriteLine("Total Price: {0}, Total Pages: {1}", bookinfo.price, bookinfo.pages);
            Console.ReadKey();
        }
    }
}
