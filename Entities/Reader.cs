namespace Entities
{
    public class Reader : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public bool IsDeleted { get; set; }

    }
}
