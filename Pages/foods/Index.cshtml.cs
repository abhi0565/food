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
    public class IndexModel : PageModel
    {
        private readonly foodfoodContext _context;

        public IndexModel(foodfoodContext context)
        {
            _context = context;
        }

        public IList<fooditem> fooditem { get;set; }

        public async Task OnGetAsync()
        {
            fooditem = await _context.fooditem.ToListAsync();
        }
    }
}
