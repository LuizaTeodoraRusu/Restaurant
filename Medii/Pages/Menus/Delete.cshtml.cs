﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Medii.Data;
using Medii.Models;

namespace Medii.Pages.Menus
{
    public class DeleteModel : PageModel
    {
        private readonly Medii.Data.MediiContext _context;

        public DeleteModel(Medii.Data.MediiContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Menu Menu { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Menu == null)
            {
                return NotFound();
            }

            var menu = await _context.Menu.FirstOrDefaultAsync(m => m.MenuId == id);

            if (menu == null)
            {
                return NotFound();
            }
            else 
            {
                Menu = menu;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Menu == null)
            {
                return NotFound();
            }
            var menu = await _context.Menu.FindAsync(id);

            if (menu != null)
            {
                Menu = menu;
                _context.Menu.Remove(Menu);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
