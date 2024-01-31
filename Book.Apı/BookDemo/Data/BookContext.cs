using BookDemo.Models;

namespace BookDemo.Data
{
    public static class BookContext
    {
        public static List<Book> Books { get; set; }
        static BookContext()
        {
            Books = new List<Book>()
            {
                new Book() {Id=1,Title="Karagöz ve Hacivat",Price=40  },
                new Book() {Id=2,Title="Beyaz Diş" ,Price=20},
                new Book() {Id=3,Title= "Sefiller",Price=30}
            };
        }
    }
}
