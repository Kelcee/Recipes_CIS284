using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes_FinalProject.Database.Entity
{
    public class RecipeIngredient
    {
        [Key]
        public int Id { get; set; }
        public string Ingredient { get; set; }

    }
}
