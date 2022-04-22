using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiGetTodosHumanos;

namespace ApiGetTodosHumanos.Data
{
    public class ApiGetTodosHumanosContext : DbContext
    {
        public ApiGetTodosHumanosContext (DbContextOptions<ApiGetTodosHumanosContext> options)
            : base(options)
        {
        }

        public DbSet<ApiGetTodosHumanos.Humano> Humano { get; set; }
    }
}
