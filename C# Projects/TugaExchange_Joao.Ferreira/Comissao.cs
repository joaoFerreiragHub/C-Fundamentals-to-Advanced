using System;

namespace TugaExchange
{
    public class comissao
    {
        public decimal valor { get; set; }
        public int Id { get; set; }
        public int userID { get; set; }
        public decimal quantidades { get; set; }
        public decimal valorCoin { get; set; }
        public string tipoComissao { get; set; }

        public DateTime utcDate = DateTime.UtcNow;
        public DateTime data { get { return utcDate; } set { utcDate = DateTime.UtcNow; } }

        public void printcomissoes()
        {
          Console.WriteLine(" ID:{0} | User ID: {1} | Comissão: {2} | Quandtidade:{3} | Valor Total: {4:0.0000} | Preço da Moeda: {5:0.000} | Data:{6} "
              , Id ,userID ,tipoComissao ,quantidades ,valor ,valorCoin ,data );
        }
       
    }
}
