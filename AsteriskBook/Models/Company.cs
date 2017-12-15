using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsteriskBook.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PathPhoneBook { get; set; }

        public List<Department> Departments { get; set; }

        public Company()
        {
            Departments = new List<Department>();
        }
    }
}
