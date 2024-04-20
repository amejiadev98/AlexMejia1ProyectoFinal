using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projectweb1.Models;

namespace Projectweb1.Data
{
    public class EmpleadoDBContext : DbContext
    {
        public EmpleadoDBContext (DbContextOptions<EmpleadoDBContext> options)
            : base(options)
        {
        }

        public DbSet<Projectweb1.Models.Empleado> Empleado { get; set; } = default!;
    }
}
