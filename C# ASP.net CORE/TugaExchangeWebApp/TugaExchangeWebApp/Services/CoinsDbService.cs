using TugaExchangeWebApp.Data.DbContexts;
using TugaExchangeWebApp.Data.Entities;

namespace TugaExchangeWebApp.Services
{
    public class CoinsDbService : ICoinService
    {
        private readonly ExchangeDbContext _coinsDbService;


        public CoinsDbService(ExchangeDbContext coinsDbService)
        {
            _coinsDbService = coinsDbService;
        }

        public void AddCoin(Coin coin)
        {
            _coinsDbService.Coins.Add(coin);
            _coinsDbService.SaveChanges();
        }

        public void AddCoin(string name, decimal price)
        {
            var coin = new Coin
            {
                Name = name.ToUpper(),
                Price = price,
            };

          AddCoin(coin);
        }

        public void AddTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public List<Coin> GetAllCoins()
        {
           return _coinsDbService.Coins.ToList();
        }

        public List<Transaction> GetAllTransactions()
        {
            return _coinsDbService.transactions.ToList();
        }

        List<string> ICoinService.GetUsersByCoin(string Symbol)
        {
            var users = (from user in _coinsDbService.Users
                         join transaction in _coinsDbService.transactions on user.Id equals transaction.Id
                         join coin in _coinsDbService.Coins on transaction.CoinId equals coin.Id
                         select user.Name).ToList();

            return users;
        }
    }
}
