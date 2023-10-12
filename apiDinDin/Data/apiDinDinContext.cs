using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using apiDinDin.Models;

namespace apiDinDin.Data
{
    public class apiDinDinContext : DbContext
    {
        public apiDinDinContext (DbContextOptions<apiDinDinContext> options)
            : base(options)
        {
        }

        public DbSet<apiDinDin.Models.Usuario> Usuario { get; set; } = default!;
    }
}
