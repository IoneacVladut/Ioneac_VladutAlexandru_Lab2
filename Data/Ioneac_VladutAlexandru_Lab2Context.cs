using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ioneac_VladutAlexandru_Lab2.Models;

namespace Ioneac_VladutAlexandru_Lab2.Data
{
    public class Ioneac_VladutAlexandru_Lab2Context : DbContext
    {
        public Ioneac_VladutAlexandru_Lab2Context (DbContextOptions<Ioneac_VladutAlexandru_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ioneac_VladutAlexandru_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Ioneac_VladutAlexandru_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
