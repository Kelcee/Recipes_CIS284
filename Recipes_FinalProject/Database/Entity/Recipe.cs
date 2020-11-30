using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes_FinalProject.Database.Entity
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        [Display(Name = "Prep Time")]
        public string PrepTime { get; set; }

        [Display(Name = "Cook Time")]
        public string CookTime { get; set; }

        public string Yields { get; set; }
        public string ImagePath { get; set; }
        public string Diet { get; set; }
        
        public List<RecipeInstruction> Instructions { get; set; }
    }
}
