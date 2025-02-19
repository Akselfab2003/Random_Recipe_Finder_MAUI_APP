﻿using Random_Recipe_Finder_MAUI_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Random_Recipe_Finder_MAUI_APP.Services
{
    class RecipeApiService: IRecipeApiService
    {
        private static readonly string MAIN_URL_ENPOINT = "https://www.themealdb.com/api/json/v1/1/";
        
        private HttpClient client;
        public RecipeApiService()
        {
            Uri uri = new Uri(MAIN_URL_ENPOINT);
           // client = new HttpClient() { BaseAddress = uri};
            client = new HttpClient() {  };

        }

        public async Task<List<Recipe>> SearchRecipeByName(string recipeName)
        {

            string API_ENPOINT = $"search.php?f={recipeName}";

            var url = Path.Combine(MAIN_URL_ENPOINT, API_ENPOINT);



            //HttpResponseMessage response = client.GetAsync(API_ENPOINT);

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {

                RecipeApiResponse recipeApiResponse = await response.Content.ReadFromJsonAsync<RecipeApiResponse>();

                if (recipeApiResponse != null)
                {
                    return recipeApiResponse.Meals;
                }
            }

            return [];
        }

    }
}
