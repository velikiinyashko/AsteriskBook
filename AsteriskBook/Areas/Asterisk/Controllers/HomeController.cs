using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AsteriskBook.Models;
using AsteriskBook.Areas.Asterisk.Models;
using Microsoft.AspNetCore.Authorization;
using System.Globalization;

namespace AsteriskBook.Areas.Asterisk.Controllers
{

    [Area("Asterisk")]
    public class HomeController : Controller
    {
        private BaseContext _context;

        public HomeController(BaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string sortOrder, int? page, int pageSize = 50)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["SrcSortParm"] = string.IsNullOrEmpty(sortOrder) ? "src_desc" : "";
            ViewData["DstSortParm"] = string.IsNullOrEmpty(sortOrder) ? "dst" : "";
            ViewData["DateSortParm"] = sortOrder == "calldate" ? "calldate_desc" : "calldate";

            var cdrs = from s in _context.cdr select s;

            if (string.IsNullOrEmpty(sortOrder))
            {
                sortOrder = "calldate";
            }

            bool descending = false;
            if (sortOrder.EndsWith("_desc"))
            {
                sortOrder = sortOrder.Substring(0, sortOrder.Length - 5);
                descending = true;
            }

            if (descending)
            {
                cdrs = cdrs.OrderByDescending(e => EF.Property<object>(e, sortOrder));
            }
            else
            {
                cdrs = cdrs.OrderBy(e => EF.Property<object>(e, sortOrder));
            }

            //return View(await cdrs.AsNoTracking().ToListAsync());
            return View(await PaginatedList<Cdr>.CreateAsync(cdrs.AsNoTracking(), page ?? 1, pageSize));
        }

    }
}