using Microsoft.EntityFrameworkCore;

namespace MyFirstEFCoreApp
{
    public static class Commands
    {
        public static void ListAll()
        {
            using (var db = new AppDbContext())
            {
                foreach (var book in db.Books.AsNoTracking()
                    .Include(book => book.Author))

                {
                    var webUrl = book.Author.WebUrl == null ? "-no web URL given" : book.Author.WebUrl;

                    Console.WriteLine($"{book.Title} by {book.Author.Name}");
                    Console.WriteLine($"Published on {book.PublishedOn:dd-MMM-yyyy}. {webUrl}");
                }
            }
        }
    }
}
