using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AsteriskBook.Models;
using Microsoft.EntityFrameworkCore;

namespace AsteriskBook.Areas.Cabinet.Controllers
{
    [Area("Cabinet")]
    public class HomeController : Controller
    {
        private BaseContext _context;

        public HomeController(BaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
           List<Book> book = await _context.Books.ToListAsync();

            return View(book);
        }

        public async Task<IActionResult> Create(Book book)
        {

            if (ModelState.IsValid)
            {

            }
            return RedirectToAction("Index");
        }
    }
}