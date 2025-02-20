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

        public Task<List<Recipe>> GetRecipesAsync()
        {
            return _database.Table<Recipe>().ToListAsync();
        }

        public Task<int> DeleteRecipeAsync(Recipe recipe)
        {
            return _database.DeleteAsync(recipe);
        }
    }
}
