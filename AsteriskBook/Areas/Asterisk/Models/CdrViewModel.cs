using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsteriskBook.Areas.Asterisk.Models
{
    public class CdrViewModel
    {
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CallTime { get; set; }
        public int Src { get; set; }
        public int Dst { get; set; }
        
    }
}
