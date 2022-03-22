using System.Collections.Generic;
using System;

namespace CarRacing
{
    class Pista
    {
        public int Comprimento { get; private set; }
        public List<Veiculo> Veiculos { get; private set; }

        public Pista(int comprimento, List<Veiculo> veiculos)
        {
            Comprimento = comprimento;
            Veiculos = veiculos;
        }

        public int NumeroVeiculos
        {
            get
            {
                return (Veiculos == null) ? 0 : Veiculos.Count;
            }
        }

        public void Print(bool clear = true)
        {
            if (clear)
                Console.Clear();

            var contorno = "".PadRight(Comprimento, '═');

            Console.WriteLine(contorno);

            foreach (var veiculo in Veiculos)
                veiculo.Print();

            System.Console.WriteLine(contorno);
        }

        public void MaisUmaVolta()
        {
            foreach (var veiculo in Veiculos)
                veiculo.Move();
        }

        public bool HaVencedor()
        {
            foreach (var veiculo in Veiculos)
            {
                if (veiculo.Kms >= Comprimento)
                    return true;
            }

            return false;
        }

        public Veiculo GetVencedor()
        {
            foreach (var veiculo in Veiculos)
            {
                if (veiculo.Kms >= Comprimento)
                    return veiculo;
            }

            return null;
        }

        public List<Veiculo> GetVencedores()
        {
            var vencedores = new List<Veiculo>();

            foreach (var veiculo in Veiculos)
            {
                if (veiculo.Kms >= Comprimento)
                    vencedores.Add(veiculo);
            }

            return vencedores;
        }
    }
}