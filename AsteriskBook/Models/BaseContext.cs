using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AsteriskBook.Models
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions context) : base(context)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Cdr> cdr { get; set; }
    }
}
