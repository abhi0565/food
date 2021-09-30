using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using food.Models;

    public class foodfoodContext : DbContext
    {
        public foodfoodContext (DbContextOptions<foodfoodContext> options)
            : base(options)
        {
        }

        public DbSet<food.Models.fooditem> fooditem { get; set; }
    }
