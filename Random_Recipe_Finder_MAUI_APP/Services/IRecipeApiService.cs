using Random_Recipe_Finder_MAUI_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Recipe_Finder_MAUI_APP.Services
{
    public interface IRecipeApiService
    {
        public Task<List<Recipe>> SearchRecipeByName(string recipeName);
        public Task<Recipe?> GetRandomRecipe();
    }
}
