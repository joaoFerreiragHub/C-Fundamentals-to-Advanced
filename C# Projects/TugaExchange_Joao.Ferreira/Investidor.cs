using System;
using System.Collections.Generic;


namespace TugaExchange
{
    public class Investidor
    {
        private CryptoQuoteAPI _investor;
        public Investidor(CryptoQuoteAPI investor)
        {
            _investor = investor;
        }
        public string Nome { get; set; }
        public int ID { get; set; }
        public decimal Saldo { get; set; }
        public static List<Coin> Portfolio = new List<Coin>();
        public Investidor()
        {
        }
        public void PrintSaldo()
        {
            Console.WriteLine("Saldo: {0}", Saldo);
        }
        public void PrintPortfolio()
        {          
            foreach (var coin in Portfolio)
                Console.WriteLine("ID: " + coin.Id + " | " + "Nome: " + coin.Nome + " | " + " Quantidade: " + coin.Quantidades + " | " + "Preço:" + coin.Preco);

        }
    }
}
