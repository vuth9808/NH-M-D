﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FSK.Reponsitories.Entities;
using FSK.Services;

namespace FSK.WebApp.Pages.Product.KoiFishProduct
{
    public class CreateModel : PageModel
    {
        private readonly IBaseServices _context;

        public CreateModel(IBaseServices context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public KoiFish KoiFish { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.koiFishServices.AddKoiFish(KoiFish);

            return RedirectToPage("./Index");
        }
    }
}
