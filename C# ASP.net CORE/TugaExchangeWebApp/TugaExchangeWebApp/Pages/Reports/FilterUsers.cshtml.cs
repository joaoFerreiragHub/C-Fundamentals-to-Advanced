using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TugaExchangeWebApp.Services;

namespace TugaExchangeWebApp.Pages
{
    public class ReportsModel : PageModel
    {
        private readonly CoinsDbService _coinDbService;

        public ReportsModel(CoinsDbService coinDbService)
        {
            _coinDbService = coinDbService;
        }
        public void OnGet()
        {
            //_coinDbService.GetUsersByCoin()
        }
    }
}
