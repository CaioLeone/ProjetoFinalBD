using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Models;

namespace ProjetoFinal.Data
{
    public class ProjetoFinalContext : DbContext
    {
        public ProjetoFinalContext (DbContextOptions<ProjetoFinalContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Loja> Loja { get; set; }
        public DbSet<Comprador> Comprador { get; set; }
    }
}
