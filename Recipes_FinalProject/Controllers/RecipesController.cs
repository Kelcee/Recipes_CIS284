//Christine Jordan and Kelcee Chorba 12.2.2020 W10 Term Project
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
        public async Task<IActionResult> Index(string dietSearch)
        {
            var recipes = databaseContext.Recipes.AsQueryable();
            if (!string.IsNullOrWhiteSpace(dietSearch))
            {
                recipes = recipes.Where(recipe => recipe.Diet.Contains(dietSearch,StringComparison.CurrentCultureIgnoreCase));//ignore case sensitivity in search
            }
            return View(await recipes.ToArrayAsync());
        }

        [HttpGet]
        public async Task<IActionResult> FoodWheel()
        {
            var recipes = await databaseContext.Recipes.ToArrayAsync(); //Getting all recipes from database
            var model = new FoodWheelModel { Recipes = recipes };

            return View(model); //Sending model to foodwheel view
        }

        [HttpPost]
        public async Task<IActionResult> FoodWheel(FoodWheelModel model)
        {
            var recipes = await databaseContext.Recipes.ToArrayAsync(); //Getting all recipes from database
            model.Recipes = recipes;
            return View(model);
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