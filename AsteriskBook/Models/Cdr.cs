using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsteriskBook.Models
{
    public class Cdr
    {
        [Key]
        public DateTime	calldate { get; set; }
	    public string src { get; set; }
        public string dst { get; set; }
	    public string dcontext { get; set; }
	    public string clid { get; set; }
	    public string channel { get; set; }
	    public string dstchannel { get; set; }
	    public string lastapp { get; set; }
	    public string lastdata { get; set; }
	    public DateTime start { get; set; }
	    public DateTime answer { get; set; }
	    public DateTime end { get; set; }
	    public int duration { get; set; }
        public int billsec { get; set; }
	    public string disposition { get; set; }
	    public int amaflags { get; set; }
	    public string accountcode { get; set; }
	    public string userfield { get; set; }
	    public string uniqueid { get; set; }
    }
}
