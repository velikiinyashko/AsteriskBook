using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsteriskBook.Models
{
    public class Record
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string Other { get; set; }
        public int Ring { get; set; }
        public string Group { get; set; }

        public int? BookId { get; set; }
        public Book Book { get; set; }
    }
}
