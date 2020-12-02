using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Recipes_FinalProject.Database;
using Recipes_FinalProject.Database.Entity;
using Recipes_FinalProject.Models;

//Christine Jordan and Kelcee Chorba 12.1.2020 
namespace Recipes_FinalProject.Controllers
{
    public class RecipesController : Controller
    {
        private readonly RecipesContext databaseContext;

        public RecipesController(RecipesContext context)
        {
            databaseContext = context;
        }


        // GET: Recipes
        public async Task<IActionResult> Index(SearchModel model)
        {
            var recipes = databaseContext.Recipes.AsQueryable();
            if (!string.IsNullOrWhiteSpace(model.DietSearch))
            {
                recipes = recipes.Where(recipe => recipe.Diet.Contains(model.DietSearch));
            }
            return View(await recipes.ToArrayAsync());
        }

        public async Task<IActionResult> FoodWheel()
        {
            var recipes = await databaseContext.Recipes.ToArrayAsync(); //Getting all recipes from database
            return View(recipes); //Sending model to foodwheel view
        }


        // GET: Recipes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipe = await databaseContext.Recipes
                //Include data from ingredients table
                .Include(r => r.Ingredients)
                .Include(r => r.Instructions)//Include data from ReceipeInstruction table
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recipe == null)
            {
                return NotFound();
            }

            return View(recipe);
        }

        private bool RecipeExists(int id)
        {
            return databaseContext.Recipes.Any(e => e.Id == id);
        }
    }
}