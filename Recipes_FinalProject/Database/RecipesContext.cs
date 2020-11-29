using Microsoft.EntityFrameworkCore;

namespace Recipes_FinalProject.Database
{
    public class RecipesContext : DbContext
    {
        public RecipesContext(DbContextOptions<RecipesContext> options) 
            :base(options)
        { }

        public DbSet<Recipe> Recipes { get; set; }  //Recipes Table

        protected override void OnModelCreating(ModelBuilder modelBuilder) //override model create
        {
            modelBuilder.Entity<Recipe>(); //creating recipes entity

            base.OnModelCreating(modelBuilder);
        }
    }
}
