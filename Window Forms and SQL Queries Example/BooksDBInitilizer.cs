using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookKeeper
{
    public class BooksDBInitilizer : DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            IList<Genre> defaultGenre = new List<Genre>();
            defaultGenre.Add(new Genre() { GenreName = "Science Fiction" });
            defaultGenre.Add(new Genre() { GenreName = "Detective" });
            defaultGenre.Add(new Genre() { GenreName = "Fantasy" });
            defaultGenre.Add(new Genre() { GenreName = "Fantastic" });
            defaultGenre.Add(new Genre() { GenreName = "Drama" });
            defaultGenre.Add(new Genre() { GenreName = "Thriller" });
            defaultGenre.Add(new Genre() { GenreName = "History" });
            defaultGenre.Add(new Genre() { GenreName = "Education" });
            context.Genres.AddRange(defaultGenre);
            
            
            base.Seed(context);
        }
    }
}
