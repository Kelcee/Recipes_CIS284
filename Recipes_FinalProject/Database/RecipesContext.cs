//Kelcee Chorba & Christine Jordan 
//CIS 284: Week 10 Team Project
//11.29.2020
using Microsoft.EntityFrameworkCore;
using Recipes_FinalProject.Database.Entity;

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
            //.HasData for seeding starting data

            base.OnModelCreating(modelBuilder);
        }
    }
}
