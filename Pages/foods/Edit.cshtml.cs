using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using food.Models;

namespace food.Pages_foods
{
    public class EditModel : PageModel
    {
        private readonly foodfoodContext _context;

        public EditModel(foodfoodContext context)
        {
            _context = context;
        }

        [BindProperty]
        public fooditem fooditem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            fooditem = await _context.fooditem.FirstOrDefaultAsync(m => m.ID == id);

            if (fooditem == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(fooditem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!fooditemExists(fooditem.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool fooditemExists(int id)
        {
            return _context.fooditem.Any(e => e.ID == id);
        }
    }
}
