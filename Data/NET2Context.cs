using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NET2.Models;

    public class NET2Context : DbContext
    {
        public NET2Context (DbContextOptions<NET2Context> options)
            : base(options)
        {
        }

        public DbSet<NET2.Models.Categoria> Categoria { get; set; }
    }
