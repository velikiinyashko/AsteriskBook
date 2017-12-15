using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsteriskBook.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? UsersId { get; set; }
        public User Users { get; set; }

        public List<Record> Records { get; set; }

        public Book()
        {
            Records = new List<Record>();
        }
    }
}
