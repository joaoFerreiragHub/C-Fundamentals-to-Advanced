using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaDeCarros
{
    public class oficina
    {

        private List<Carro> ListaDeCarros = new List<Carro>();
       // public  List<Carro> ListaDeCarros { get; set; }
        public int NumeroCarros
        {
            get
            {
                return (ListaDeCarros == null) ? 0 : ListaDeCarros.Count;              
            }
        }
        public void SetLista(List<Carro> listaDeCarros)
        {
            this.ListaDeCarros = listaDeCarros;
        }

        public List<Carro> GetLista()
        {
            return ListaDeCarros;
        }
        public oficina()
        {

        }
        public oficina(List<Carro> listaDeCarros)
        {
            ListaDeCarros = listaDeCarros;
        }

        public void Listabase()
        {
            ListaDeCarros.AddRange(new List<Carro> {
                     new Carro("Beamer", ConsoleColor.Yellow),
                     new Carro("Cedes", ConsoleColor.Green),
                     new Carro("Fords", ConsoleColor.Red),
                         });
        }

        public List<Carro> GerarCarros()
        {
            Random rnd = new Random();
            var faker = new Bogus.Faker();
            var model = faker.Vehicle.Model();
            var manufacturer = faker.Vehicle.Manufacturer();


            for (int i = 0; i < 10; i++)
            {
                int rng = rnd.Next(1, 15);
                ListaDeCarros.Add(
                                new Carro(faker.Vehicle.Model(), (ConsoleColor)rng));
            }

            return ListaDeCarros;
        }
    }
}
