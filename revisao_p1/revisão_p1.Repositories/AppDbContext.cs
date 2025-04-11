using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using revisao_p1.Domain;

namespace revisão_p1.Repositories
{
    public class AppDbContext : DbContext
    {
        private readonly DbContext _context;
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<AlunoDomain> Alunos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlunoDomain>(entity =>
            {
                entity.HasKey(u => u.id);
            });
        }
    }
}
