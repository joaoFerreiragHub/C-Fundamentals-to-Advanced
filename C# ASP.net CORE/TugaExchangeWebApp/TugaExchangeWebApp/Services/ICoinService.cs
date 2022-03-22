using TugaExchangeWebApp.Data.Entities;

namespace TugaExchangeWebApp.Services
{
    public interface ICoinService
    {     
        void AddCoin(Coin coin);
        void AddTransaction(Transaction transaction);
        List<Coin> GetAllCoins();
        List<Transaction> GetAllTransactions();

        List<string> GetUsersByCoin(string Symbol);
    }
}
