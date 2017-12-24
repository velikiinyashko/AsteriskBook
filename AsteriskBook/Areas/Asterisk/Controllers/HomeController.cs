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

        //[Authorize]
        public async Task<IActionResult> Index(int? Id, DateTime? Date, int? Src, int? Dst, int PageSize=25, int page=1)
        {

            IQueryable<Cdr> source = _context.cdr;

            if (Date != null)
            {
                DateTime Day = Convert.ToDateTime(Date.Value.ToString("yyyy-MM-dd"));
                var NextDay = Date.Value.AddDays(1);
                var requery = source.Where(d => d.calldate >= Date.Value && d.calldate < NextDay);

                return View(IvxAsync(requery,page,PageSize));
            }
            
            if(Date == null)
            {
                return View(IvxAsync(source, page, PageSize));
            }

            return View();
        }

        public async Task<IndexViewModel> IvxAsync(IQueryable<Cdr> queryable, int PageSize, int Page)
        {
            var Count = await queryable.CountAsync();
            var Items = await queryable.Skip((Page - 1) * PageSize).Take(PageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(Count, Page, PageSize);
            IndexViewModel indexViewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Cdrs = Items
            };

            return indexViewModel;
        }

    }
}