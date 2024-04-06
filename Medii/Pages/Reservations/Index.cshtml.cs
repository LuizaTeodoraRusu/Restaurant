using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Medii.Data;
using Medii.Models;

namespace Medii.Pages.Reservations
{
    public class IndexModel : PageModel
    {
        private readonly Medii.Data.MediiContext _context;

        public IndexModel(Medii.Data.MediiContext context)
        {
            _context = context;
        }

        public IList<Reservation> Reservation { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Reservation != null)
            {
                Reservation = await _context.Reservation
                .Include(r => r.Location)
                .Include(r => r.Menu).ToListAsync();
            }
        }
    }
}
