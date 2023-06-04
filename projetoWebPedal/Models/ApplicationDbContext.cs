using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoWebPedal.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Proponente> Proponente { get; set; }
        public DbSet<Roteiro> Roteiros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<RoteiroUsuario> RoteiroUsuarios { get; set; }
    }
}
