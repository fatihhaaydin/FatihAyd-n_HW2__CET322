namespace FatihAydın_HW2__CET322.Models
{
    public class FakeDb
    {
        public static List<Book> Db { get; set; } = new List<Book>();
        static FakeDb()
        {
            Db.Add(
                new Book
                {
                    ID = 1,
                    Title = "CW",
                    Description = "ajsdhkjhsda",
                    Author = "Mehmet",
                    PageSize = 100,
                    Price = 100,
                    PublishDate = DateTime.Now

                }
            );
            Db.Add(
                new Book
                {
                    ID = 2,
                    Title = "CC",
                    Description = "müthiş",
                    Author = "Kağan",
                    PageSize = 150,
                    Price = 200,
                    PublishDate = DateTime.Now

                }
            );
        }
        public List<Book> GetAllBooks()
        {
            return Db;
        }
        public Book? GetBookById(int id)
        {
            //foreach(Book book in Db)
            //{
            //    if (book.ID == id) return book;
            //}
            return Db.FirstOrDefault(b => b.ID == id);
            //return Db.Where(b=>b.ID==id).FirstOrDefault(); bu da bir opsiyon

        }
        public bool DeleteBook(int id)
        {
            var book = GetBookById(id);
            if (book == null) return false;
            Db.Remove(book);
            return true;

        }
        public Book CreateBook(Book newBook)
        {
            newBook.ID = Db.Count + 1;
            Db.Add(newBook);
            return newBook;

        }

    }
}
