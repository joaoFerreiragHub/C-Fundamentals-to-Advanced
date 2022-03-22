using System.ComponentModel.DataAnnotations;

namespace TugaExchangeWebApp.Data.Entities
{
    public class Coin
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }

        [Key]
        public int Id { get; set; }

        public string Symbol { get; set; }



    }
}

