using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsteriskBook.Models;
using AsteriskBook.Areas.Asterisk.Models;

namespace AsteriskBook.Areas.Asterisk.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Cdr> Cdrs { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
