using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TugaExchangeWebApp.Data.Entities;
using TugaExchangeWebApp.Services;

namespace TugaExchangeWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICoinService _coinService;

        public IndexModel(ICoinService coinService)
        {
            _coinService = coinService;
        }

        public List<Coin> Coins { get; set; }
        public void OnGet()
        {
            Coins = _coinService.GetAllCoins();
        }
    }
}