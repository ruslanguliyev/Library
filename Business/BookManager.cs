using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BookManager
    {
        AplicationDbContext _context = new();

        public IQueryable<Book> GetAllBook()
        {
            return _context.Books.Include(x => x.Author);
        }
        public IQueryable<Book> SearchBook()
        {
            return _context.Books.Include(x => x.Name);
        }
        public IQueryable<Book> BookNames()
            => _context.Books;
        

        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }
        public void UpdateBook(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
        }
        public void DeleteBook(Book book)
        {
            book.IsDeleted = true;
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
        public Book BookName(string name)
        {
            return _context.Books.FirstOrDefault(x => x.Name == name);
        }
        public Book GetBookById(int id)
        {
            return _context.Books.FirstOrDefault(x => x.ID == id);
        }


        




    }
}
