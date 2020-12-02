using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Recipes_FinalProject.Database.Entity;

namespace Recipes_FinalProject.Models
{
    public class FoodWheelModel
    {
        public IEnumerable<Recipe> Recipes { get; set; }
        public SignUpModel SignUp { get; set; }
    }
}
