﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetoFoodTracker.Data;
using ProjetoFoodTracker.Data.Entities;

namespace ProjetoFoodTracker.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        public IndexModel()
        {       
       
        }

        public void OnGet()
        {
            
        }
    }
}