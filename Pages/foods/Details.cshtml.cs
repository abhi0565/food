using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using food.Models;

namespace food.Pages_foods
{
    public class DetailsModel : PageModel
    {
        private readonly foodfoodContext _context;

        public DetailsModel(foodfoodContext context)
        {
            _context = context;
        }

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
    }
}
