    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Book:BaseEntity
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public int AuthorID { get; set; }
        public Author Author { get; set; }
        public bool IsDeleted { get; set; }
    }
}
