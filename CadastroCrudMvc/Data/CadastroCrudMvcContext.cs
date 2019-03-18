using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CadastroCrudMvc.Models
{
    public class CadastroCrudMvcContext : DbContext
    {
        public CadastroCrudMvcContext (DbContextOptions<CadastroCrudMvcContext> options)
            : base(options)
        {
        }

        public DbSet<CadastroCrudMvc.Models.Department> Department { get; set; }
    }
}
