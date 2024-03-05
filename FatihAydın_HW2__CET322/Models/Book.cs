namespace FatihAydın_HW2__CET322.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public int PageSize { get; set; }
        public Decimal Price { get; set; }

    }
}
