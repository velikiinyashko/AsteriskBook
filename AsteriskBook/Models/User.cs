using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsteriskBook.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string MacPhone { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Phone { get; set; }
        public string Path { get; set; }

        public int? BooksId { get; set; }
        public Book Books { get; set; }

        public int? RoleId { get; set; }
        public Role Role { get; set; }
    }
}
