using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ioneac_VladutAlexandru_Lab2.Data;
using Ioneac_VladutAlexandru_Lab2.Models;

namespace Ioneac_VladutAlexandru_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Ioneac_VladutAlexandru_Lab2.Data.Ioneac_VladutAlexandru_Lab2Context _context;

        public IndexModel(Ioneac_VladutAlexandru_Lab2.Data.Ioneac_VladutAlexandru_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.Publisher)
                .ToListAsync();
        }
    }
}
