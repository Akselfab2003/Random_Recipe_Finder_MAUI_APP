using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Recipe_Finder_MAUI_APP.Models
{
    public class Recipe
    {
        [PrimaryKey]
        public int IdMeal { get; set; }
        public string StrMeal { get; set; }
        public string StrDrinkAlternate { get; set; }
        public string StrCategory { get; set; }
        public string StrArea { get; set; }
        public string StrInstructions { get; set; }
        public string StrMealThumb { get; set; }
        public string StrTags { get; set; }
        public string StrYoutube { get; set; }
        public string StrIngredient1 { get; set; }
        public string StrIngredient2 { get; set; }
        public string StrIngredient3 { get; set; }
        public string StrIngredient4 { get; set; }
        public string StrIngredient5 { get; set; }
        public string StrIngredient6 { get; set; }
        public string StrIngredient7 { get; set; }
        public string StrIngredient8 { get; set; }
        public string StrIngredient9 { get; set; }
        public string StrIngredient10 { get; set; }
        public string StrIngredient11 { get; set; }
        public string StrIngredient12 { get; set; }
        public string StrIngredient13 { get; set; }
        public string StrIngredient14 { get; set; }
        public string StrIngredient15 { get; set; }
        public string StrIngredient16 { get; set; }
        public string StrIngredient17 { get; set; }
        public string StrIngredient18 { get; set; }
        public string StrIngredient19 { get; set; }
        public string StrIngredient20 { get; set; }
        public string StrMeasure1 { get; set; }
        public string StrMeasure2 { get; set; }
        public string StrMeasure3 { get; set; }
        public string StrMeasure4 { get; set; }
        public string StrMeasure5 { get; set; }
        public string StrMeasure6 { get; set; }
        public string StrMeasure7 { get; set; }
        public string StrMeasure8 { get; set; }
        public string StrMeasure9 { get; set; }
        public string StrMeasure10 { get; set; }
        public string StrMeasure11 { get; set; }
        public string StrMeasure12 { get; set; }
        public string StrMeasure13 { get; set; }
        public string StrMeasure14 { get; set; }
        public string StrMeasure15 { get; set; }
        public string StrMeasure16 { get; set; }
        public string StrMeasure17 { get; set; }
        public string StrMeasure18 { get; set; }
        public string StrMeasure19 { get; set; }
        public string StrMeasure20 { get; set; }
        public string StrSource { get; set; }
        public string StrImageSource { get; set; }
        public string StrCreativeCommonsConfirmed { get; set; }
        public string DateModified { get; set; }

        [Ignore]
        public List<string> Ingredients
        public List<string> Ingredients { get; set; }
        public List<string> Measurements { get; set; }
        public void AddIngredientAndMeasurement()
        {
            List<string> ingredients = new List<string> { StrIngredient1, StrIngredient2, StrIngredient3, StrIngredient4, StrIngredient5, StrIngredient6, StrIngredient7, StrIngredient8, StrIngredient9, StrIngredient10, StrIngredient11, StrIngredient12, StrIngredient13, StrIngredient14, StrIngredient15, StrIngredient16, StrIngredient17, StrIngredient18, StrIngredient19, StrIngredient20 };
            Ingredients = ingredients.Where(x => !string.IsNullOrEmpty(x)).ToList();
            List<string> measurements = new List<string> { StrMeasure1, StrMeasure2, StrMeasure3, StrMeasure4, StrMeasure5, StrMeasure6, StrMeasure7, StrMeasure8, StrMeasure9, StrMeasure10, StrMeasure11, StrMeasure12, StrMeasure13, StrMeasure14, StrMeasure15, StrMeasure16, StrMeasure17, StrMeasure18, StrMeasure19, StrMeasure20 };
            Measurements = measurements.Where(x => !string.IsNullOrEmpty(x)).ToList();
        }
    }
}
