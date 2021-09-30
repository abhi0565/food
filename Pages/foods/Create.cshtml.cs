using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using food.Models;

namespace food.Pages_foods
{
    public class CreateModel : PageModel
    {
        private readonly foodfoodContext _context;

        public CreateModel(foodfoodContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public fooditem fooditem { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.fooditem.Add(fooditem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
