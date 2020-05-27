﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AgendaAspNet.Models;

namespace AgendaAspNet.Pages.Contatos
{
    public class DetailsModel : PageModel
    {
        private readonly AgendaAspNet.Models.ApplicationDbContext _context;

        public DetailsModel(AgendaAspNet.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public Contato Contato { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contato = await _context.Contatos.FirstOrDefaultAsync(m => m.Id == id);

            if (Contato == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
