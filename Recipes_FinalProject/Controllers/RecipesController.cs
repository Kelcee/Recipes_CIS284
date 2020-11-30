using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Recipes_FinalProject.Database;
using Recipes_FinalProject.Database.Entity;

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
            var recipes =  databaseContext.Recipes.AsQueryable();
            if (!string.IsNullOrWhiteSpace(dietSearch))
            {
                recipes = recipes.Where(recipe => recipe.Diet.Contains(dietSearch));
            }
            return View(await recipes.ToArrayAsync());
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
                .Include(recipe => recipe.Ingredients)
                .Include(recipe => recipe.Instructions)//Include data from ReceipeInstruction table
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
