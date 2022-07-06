namespace Entities
{
    public class BookToReader : BaseEntity
    {
        public int ReaderID { get; set; }
        public Reader Reader { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
        public DateTime RentDate { get; set; }
        public int Limit { get; set; }
    }
}
