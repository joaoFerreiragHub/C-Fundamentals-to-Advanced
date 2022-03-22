using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CorridaDeCarros
{
    public class Pista
    {
        public int Comprimento { get; private set; }
        //public List<Carro> Carros  { get; set; } //tbm da assim,aula 
       /* public int NumeroCarros//saber numero de carros, aula
        {
            get
            {
                return (Carros == null) ? 0 : Carros.Count;
            }
        }*/
        oficina Nova = new oficina();


        public Pista()
        {

        }
        /*public Pista(int comprimento, List<Carro> carros)//construto do sergio, aula
        {
            this.Comprimento = comprimento;
            this.Carros = carros;
        }*/
        public Pista(List<Carro> carros)
        {
           var teste = Nova.GetLista();
            teste = carros;
        }


        public Pista(oficina nova)
        {
            Nova = nova;
        }
          
        public Pista(int comprimento)
        {
            Comprimento = comprimento;
        }

        public void quemGanhou(int comprimento, List<Carro> carros)
        {

            while (true)
            {
              Console.Clear();

               Carro vencedor = null;

               while (vencedor == null)
                {
                    Console.Clear();
                    for (int i = 0; i <= comprimento; i++)
                        Console.Write("_");
                    Console.Write(" ");
                    foreach (var Carro in carros)
                    {

                        Carro.Mover();
                        if (Carro.km >= comprimento)
                            vencedor = Carro;
                        Carro.print();

                    }
                    for (int i = 0; i <= comprimento; i++)
                        Console.Write("_");
                    Thread.Sleep(500);
                }
                Console.WriteLine("\n Prima qq tecla para outra corrida");
                Console.WriteLine($"O vencedor é {vencedor.marca}");
                Console.Read();
            
            }
        }
        public void MaisUmaVolta(List<Carro> carros)
        {
            foreach (var Carro in carros)
                Carro.Mover();
        }
        public void pint(List<Carro> carros,int comprimento, bool clear = true)
        {
            if (clear)
                Console.Clear();

            var contorno = "".PadRight(comprimento, '═');

            Console.WriteLine(contorno);

            foreach (var Carro in carros)
                Carro.print();

            Console.WriteLine(contorno);

        }

        public bool HaVencedor(List<Carro> carros, int comprimento)
        {
            foreach (var Carro in carros)
            {
                if (Carro.km >= comprimento)
                    return true;
            }
            return false;
        }
    }
}
