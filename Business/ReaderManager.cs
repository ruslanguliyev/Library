using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ReaderManager
    {
        AplicationDbContext _context = new();

        public void AddReader(Reader reader)
        {
            _context.Readers.Add(reader);
            _context.SaveChanges();
        }
        public void UpdateReader(Reader reader)
        {
            _context.Readers.Update(reader);
            _context.SaveChanges();
        }
        public void DeleteReader(Reader reader)
        {
            reader.IsDeleted = true;
            _context.Readers.Remove(reader);
            _context.SaveChanges();
        }
        public IQueryable<Reader> GetReaders()
        {
            return _context.Readers;
        }
        public Reader GetReaderByEmail(string email)
        {
            return _context.Readers.FirstOrDefault(x => x.Email == email);
        }
        public Reader GetReaderById(int Id)
        {
            return _context.Readers.FirstOrDefault(x => x.ID == Id);
        }

    }
}
