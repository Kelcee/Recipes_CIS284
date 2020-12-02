using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes_FinalProject.Models
{
    public class SearchModel
    {
        [Required]
        [StringLength(10, MinimumLength = 4)]
        public string DietSearch { get; set; }

    }
}
