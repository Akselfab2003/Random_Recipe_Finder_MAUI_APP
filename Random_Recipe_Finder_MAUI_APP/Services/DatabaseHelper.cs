using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using Random_Recipe_Finder_MAUI_APP.Models;
using System.IO;

namespace Random_Recipe_Finder_MAUI_APP.Services
{
    public class DatabaseHelper
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseHelper()
        {
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "recipes.db");
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Recipe>().Wait();
        }

        public Task<int> SaveRecipeAsync(Recipe recipe)
        {
            return _database.InsertAsync(recipe);
        }

        public async Task<List<Recipe>> GetRecipesAsync()
        {
            var res = await _database.Table<Recipe>().ToListAsync();
            foreach(var item in res)
            {
                item.AddIngredientAndMeasurement();
            }

            return res;
        }

        public Task<int> DeleteRecipeAsync(Recipe recipe)
        {
            return _database.DeleteAsync(recipe);
        }
    }
}
