using System;


namespace TugaExchange
{
    public class Coin
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Id { get; set; }
        public decimal Quantidades { get; set; }
        public Coin()
        {

        }
        public Coin(string nome, decimal preco, int id)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Id = id;
        }
        public void Print()
        {
            //Console.WriteLine($"{Id} : {Nome} : {Preco}euro");
            Console.WriteLine("ID : {0} \t Nome : {1} \t Preço : {2:0.0000}", Id,Nome,Preco);
        }
    }
}
