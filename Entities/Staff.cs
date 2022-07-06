namespace Entities
{
    public class Staff : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public string  Password { get; set; }
        public bool IsDeleted { get; set; }
    }
}
