using MesRecettes.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MesRecettes.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IngredientRecette>()
               .HasKey(t => new { t.RecetteId, t.IngredientId });

            modelBuilder.Entity<Ingredient>()
                .HasKey(t => new { t.Id });
                
            modelBuilder.Entity<Recette>()
                .HasKey(t => new { t.Id });

            modelBuilder.Entity<TypeAliment>()
                .HasKey(t => new { t.Id });

            modelBuilder.Entity<OrigineAliment>()
                .HasKey(t => new { t.Id });

            modelBuilder.Entity<UniteDeMesure>()
                .HasKey(t => new { t.Id});
                
        }

    }
}
