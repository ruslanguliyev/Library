using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class AuthorManager
    {
        AplicationDbContext _context = new();

        public void AddAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }
        public IQueryable<Author> GetAuthors()
        {
            return _context.Authors;
            _context.SaveChanges();
        }
        public List<Author> GetAllAuthors()
        {
            var authors = _context.Authors.Where(x => x.IsDeleted == false).ToList();
            return authors;
        }
        public Author GetAuthorByName(string authorname)
        {
            var author = _context.Authors.FirstOrDefault(x => x.FullName == authorname);

            return author;
        }
    }
}
