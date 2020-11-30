using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Recipes_FinalProject.Database.Entity;

namespace Recipes_FinalProject.Database
{

    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RecipesContext(serviceProvider.GetRequiredService<DbContextOptions<RecipesContext>>()))
            {
                if (context.Recipes.Any()) { return; }

                context.Recipes.AddRange(new[] {
                        new Recipe
                        {
                            Title = "Peanut Butter Jelly Sandwich",
                            Description = "A yummy sandwich.",
                            PrepTime = "5 minutes",
                            CookTime = "5 minutes",
                            Yields = "Sandwich for 1",
                            ImagePath = "./images/PBJ.jpg",
                            Diet = "Vegan, Vegetarian",
                            Instructions = new List<RecipeInstruction>
                            {
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 1,
                                    StepInstructions = "Get peanut butter and jelly."

                                },
                                new RecipeInstruction
                                {
                                    RecipeId = 1,
                                    Step = 2,
                                    StepInstructions = "Make sandwich."
                                }
                            }
                        }
                });


                _ = context.SaveChanges();

            }
        }
    }
}
