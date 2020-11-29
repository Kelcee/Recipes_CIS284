using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes_FinalProject.Database.Entity
{
    public class RecipeInstruction
    {
        [Key]
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public int Step { get; set; }
        public string StepInstructions { get; set; }
    }
}
