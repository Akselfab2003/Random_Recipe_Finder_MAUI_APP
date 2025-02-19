using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Recipe_Finder_MAUI_APP.Models
{
    public class Recipe
    {
        public int IdMeal { get; set; }
        public string StrMeal { get; set; }
        public string StrDrinkAlternate { get; set; }
        public string StrCategory { get; set; }
        public string StrArea { get; set; }
        public string StrInstructions { get; set; }
        public string StrMealThumb { get; set; }
        public string StrTags { get; set; }
        public string StrYoutube { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>(new string[20]);
        public List<string> Measures { get; set; } = new List<string>(new string[20]);
        public string StrSource { get; set; }
        public string StrImageSource { get; set; }
        public string StrCreativeCommonsConfirmed { get; set; }
        public string DateModified { get; set; }
    }
}
