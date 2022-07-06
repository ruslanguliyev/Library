using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class StaffManager
    {
        AplicationDbContext _context = new();

        public void AddStaff(Staff staff)
        {
            _context.Staffs.Add(staff);
            _context.SaveChanges();
        }

        public IQueryable<Staff> GetStaffs()
        {
            return _context.Staffs;
        }
        public Staff StaffByEmail(string email)
        {
            return _context.Staffs.FirstOrDefault(x=>x.Email == email);
        }
    } 
}
