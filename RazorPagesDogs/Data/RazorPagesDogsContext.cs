using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesDogs.Models;

    public class RazorPagesDogsContext : DbContext
    {
        public RazorPagesDogsContext (DbContextOptions<RazorPagesDogsContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesDogs.Models.Dogs> Dogs { get; set; }
    }
