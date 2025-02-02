﻿using Microsoft.AspNetCore.Mvc;
using ProjetoFoodTracker.Data.Entities;

namespace ProjetoFoodTracker.Services.FoodServices
{
    public interface IFoodService
    {
        Task<List<Food>> GetAllFoodsAsync();
        Task<List<FoodAction>> GetAllFoodActionsAsync();
        Task<List<Category>> GetAllCategoriesAsync();
        Task<List<Actions>> GetAllActionsAsync();
        public List<Actions> GetAllActions();
        Task<List<Favorites>> GetAllFavoritesAsync();
        Task<List<Blacklist>> GetAllBlacklistAsync();
        Task<List<TrackSuccess>> GetAllSuccessesAsync();
        void AddToFavorites(int ID, string userId);
        void AddToBlacklist(int ID, string userId);
        void RemoveFromFavorites(int ID, string userId);
        void RemoveFromBlacklist(int ID, string userId);
    }
}
