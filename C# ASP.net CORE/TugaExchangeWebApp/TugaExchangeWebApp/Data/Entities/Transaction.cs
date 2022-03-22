namespace TugaExchangeWebApp.Data.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Quantity { get; set; }

        //FK
        public decimal Price { get; set; }
        public int CoinId { get; set; }
        public Coin Coin { get; set; }  
        public decimal Comission { get; set; }


        public int UserID { get; set; }
        public User User { get; set; }
    }
}
