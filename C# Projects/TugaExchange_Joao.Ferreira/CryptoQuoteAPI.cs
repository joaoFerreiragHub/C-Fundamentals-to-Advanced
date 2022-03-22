using System;
using System.Collections.Generic;
using System.IO;
using Timer = System.Timers.Timer;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Linq;

namespace TugaExchange
{
    public class CryptoQuoteAPI
    {
        private List<Coin> _moedas;
        private List<Investidor> _users;
        private List<comissao> _comissao;
        private int Seconds;

        public CryptoQuoteAPI()
        {
            _moedas = new List<Coin>();
            _users = new List<Investidor>();
            _comissao = new List<comissao>();
        }

        //Funções do Menu
        public void Introducao()
        {
            Console.Clear();
            Console.Title = "TugaExchange";
            Console.WriteLine("\n\n ** Bem-vindo! ** \n ** TugaExchange **");
        }
        public int TipoUtilizador()
        {
            var utilizador = 0;
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("\n Selecione o tipo de utilizador: \n" +
                        "\n 1) Investidor \n" +
                        "\n 2) Admin");
                    utilizador = int.Parse(Console.ReadLine());
                } while (utilizador < 1 || utilizador > 2);
            }
            catch (Exception letras)
            {
                Console.WriteLine("\n Não introduziu nada ou introdzuiu letras!\n\n Programa vai fechar tente de novo!", letras);
                Console.ReadLine();
                Environment.Exit(0);
            }
            return utilizador;
        }
        public void TipoUtilizadorRepete()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\n Selecione o tipo de utilizador: \n" +
                    "\n 1) Investidor \n" +
                    "\n 2) Admin");
                int utilizador = int.Parse(Console.ReadLine());
                if (utilizador == 1 || utilizador == 2)
                {
                    switch (utilizador)
                    {
                        case 1: FazerLoginRepete(); break;
                        case 2: AdminOpcoesRepete(); break;
                    }
                }
                else
                {
                    Console.WriteLine("Escolha entre uma das opções! (1 ou 2)");
                }
            }
            catch (Exception letras)
            {
                Console.WriteLine("Não pode introdzuir letras!, Programa vai fechar tente de novo!", letras);
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        public int InvestidorOpcoes()
        {
            int operacao = 0;
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine(" Selecione uma opção: \n" +
                            "\n 1) Depositar dinheiro " +
                            "\n 2) Comprar Moeda " +
                            "\n 3) Vender Moeda " +
                            "\n 4) Mostrar Portfolio " +
                            "\n 5) Mostrar Câmbio\n\n " +
                            "\n 6) Voltar ao Menu de Utilizadores\n\n" +
                            "\n 7) Sair");
                    operacao = int.Parse(Console.ReadLine());
                } while (operacao < 1 || operacao > 7);
            }
            catch (Exception letras)
            {
                Console.WriteLine("Não pode introdzuir letras!, Programa vai fechar tente de novo!", letras);
                Console.ReadLine();
                Environment.Exit(0);
            }
            return operacao;
        }
        public void InvestidorOpcoesRepete()
        {
            int opecao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(" Selecione uma opção: \n" +
                        "\n 1) Depositar dinheiro " +
                        "\n 2) Comprar Moeda " +
                        "\n 3) Vender Moeda " +
                        "\n 4) Mostrar Portfolio " +
                        "\n 5) Mostrar Câmbio \n\n" +
                        "\n 6) Voltar ao Menu de Utilizadores\n\n" +
                        "\n 7) Sair");
                opecao = int.Parse(Console.ReadLine());
            } while (opecao < 1 || opecao > 7);
            switch (opecao)
            {
                case 1: DepositoInvestidor(); break;
                case 2: ComprarInvestidor(); break;
                case 3: VenderInvestidor(); break;
                case 4: MostrarPortfolio(); break;
                case 5: MostrarCambio(); break;
                case 6: TipoUtilizadorRepete(); break;
                default: Console.WriteLine("Obrigado!"); break;
            }
        }
        public int AdminOpcoes()
        {
            int operacao = 0;
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("\t ** Administrador **\n\n");
                    Console.WriteLine(" Selecione uma opção: \n" +
                        "\n 1) Adicionar moeda" +
                        "\n 2) Remover moeda" +
                        "\n 3) Ver relatório comissões" +
                        "\n 4) Definir tempo de atualização dos preços" +
                        "\n 5) Mostrar de quanto em quanto tempo são atualizados os preços\n\n" +
                        "\n 6) Voltar ao Menu de Utilizadores\n\n" +
                        "\n 7) Sair");
                    operacao = int.Parse(Console.ReadLine());
                } while (operacao < 1 || operacao > 7);
            }
            catch (Exception letras)
            {
                Console.WriteLine("Não pode introdzuir letras!, Programa vai fechar tente de novo!", letras);
                Console.ReadLine();
                Environment.Exit(0);
            }
            return operacao;
        }
        public void AdminOpcoesRepete()
        {
            int operacao = 0;
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("\t ** Administrador **\n\n");
                    Console.WriteLine(" Selecione uma opção: \n" +
                        "\n 1) Adicionar moeda" +
                        "\n 2) Remover moeda" +
                        "\n 3) Ver relatório comissões" +
                        "\n 4) Definir tempo de atualização dos preços" +
                        "\n 5) Mostrar de quanto em quanto tempo são atualizados os preços\n\n" +
                        "\n 6) Voltar ao Menu de Utilizadores\n\n" +
                        "\n 7) Sair");
                    operacao = int.Parse(Console.ReadLine());
                } while (operacao < 1 || operacao > 7);
                switch (operacao)
                {
                    case 1: AdicionarNovaCoin(); break;
                    case 2: removerMoeda(); break;
                    case 3: RelatorioComissoes(); break;
                    case 4: DefinePriceUpdateInSeconds(Temporizador()); break;
                    case 5: VerTempodeAtualziacao(); break;
                    case 6: TipoUtilizadorRepete(); break;
                    default: Console.WriteLine("Sair"); break;
                }
            }
            catch (Exception letras)
            {
                Console.WriteLine("Não pode introdzuir letras!, Programa vai fechar tente de novo!", letras);
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        public int FazerLogin()
        {
            int opcao = 0;
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("\t ** Investidor **\n\n");
                    Console.WriteLine("\n 1) Fazer login \n" +
                        "\n 2) Registar novo Investidor \n");
                    opcao = int.Parse(Console.ReadLine());
                } while (opcao < 1 || opcao > 2);
            }
            catch (Exception letras)
            {
                Console.WriteLine("Não pode introdzuir letras!, Programa vai fechar tente de novo!", letras);
                Console.ReadLine();
                Environment.Exit(0);
            }
            return opcao;
        }
        public void login()
        {
            try
            {
                Console.WriteLine("Introduza o seu id:");
                int id = int.Parse(Console.ReadLine());

                foreach (var investidor in _users)
                {
                    if (_users.Any(investidor => investidor.ID == id))
                    {
                        Console.Clear();
                        InvestidorOpcoesRepete();
                    }
                    else
                    {
                        Console.WriteLine("\n Utilizador não registado!\n ");
                        Console.ReadLine();
                        TipoUtilizadorRepete();
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Nao pode introduzir letras!\n", e);
                voltaMenuInvestidor();
            }
        }
        public void FazerLoginRepete()
        {
            int opcao = 0;
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("\t ** Investidor **\n\n");
                    Console.WriteLine("\n 1) Fazer login \n" +
                        "\n 2) Registar novo Investidor \n");
                    opcao = int.Parse(Console.ReadLine());
                } while (opcao < 1 || opcao > 2);

                switch (opcao)
                {
                    case 1: login(); break;
                    case 2: NovoInvestidor(); InvestidorOpcoesRepete(); break;
                }
            }
            catch (Exception letras)
            {
                Console.WriteLine("Não pode introdzuir letras!, Programa vai fechar tente de novo!", letras);
                Console.ReadLine();
                Environment.Exit(0);
            }

        }
        public void voltaMenuInvestidor()
        {
            Console.ReadLine();
            Console.WriteLine("\n\n Pressione qualquer tecla para voltar ao Menu anterior");
            Console.ReadKey();
            InvestidorOpcoesRepete();
        }
        public void VoltaMenuAdmin()
        {
            Console.WriteLine("\n\nPressione qualquer tecla para voltar ao Menu anterior");
            Console.ReadKey();
            AdminOpcoesRepete();
        }
        public void GuardarMenuInvestidor()
        {
            Save();
            saveData();
            InvestidorOpcoesRepete();
        }
        public void GuardarMenuAdmin()
        {
            Save();
            saveData();
            AdminOpcoesRepete();
        }

        // Funções relacionadas com Investidor
        public void NovoInvestidor()
        {
            Console.Clear();
            Investidor novoInvestidor = new Investidor();

            Console.WriteLine("\n Introduza o seu nome:");
            string novoNome = Console.ReadLine();
            if (Regex.IsMatch(novoNome, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine("\n Crie o seu id:");
                int NovoId = int.Parse(Console.ReadLine());

                novoInvestidor.Nome = novoNome;
                novoInvestidor.ID = NovoId;
                _users.Add(novoInvestidor);

                Save();
                saveData();
            }
            else
            {
                Console.WriteLine("\n Nome não pode conter numeros!\n");
                Console.WriteLine("\n\n Pressione qualquer tecla para voltar ao Menu anterior");
                Console.ReadKey();
                TipoUtilizadorRepete();
            }
        }
        public void DepositoInvestidor()
        {
            decimal deposito = 0;
            Console.Clear();
            PrintCoins(_moedas);
            try
            {
                Console.WriteLine("\n\n Introduza o seu ID");
                int userId = int.Parse(Console.ReadLine());
                if (_users.Any(investidor => investidor.ID == userId))
                {
                    foreach (var user in _users)
                    {
                        if (user.ID == userId)
                        {
                            do
                            {
                                Console.Clear();
                                PrintCoins(_moedas);
                                Console.WriteLine("                                               ");
                                PrintSaldo(_users);
                                Console.WriteLine("\n\n Introduza a quantia que deseja depositar: ");
                                deposito += decimal.Parse(Console.ReadLine());
                            } while (deposito == 0);
                        }
                        if (user.ID == userId)
                            user.Saldo += deposito;
                    }
                    voltaMenuInvestidor();
                }
                else
                {
                    foreach (var user in _users)
                    {
                        if (user.ID != userId)
                        {
                            Console.Clear();
                            Console.WriteLine(" O Utilizador nao esta registado \n");
                            voltaMenuInvestidor();
                        }
                    }
                }
            }
            catch (FormatException format)
            {
                Console.WriteLine("Não pode introduzir letras \n", format);
                Console.ReadKey();
                InvestidorOpcoesRepete();
            }
        }
        public void ComprarInvestidor()
        {
            GetPrices(_moedas);
            Console.Clear();
            Random rnd = new Random();
            comissao novaComissao = new comissao();
            Coin compraCoin = new Coin();

            try
            {
                Console.WriteLine("\n\n Introduza o seu ID");
                int userId = int.Parse(Console.ReadLine());
                var investor = _users.Find(investidor => investidor.ID == userId);
                investor.PrintSaldo();
                PrintCoins(_moedas);
                try
                {
                    Console.WriteLine("\n Introduza o ID da moeda que prentende comprar");
                    int compraId = int.Parse(Console.ReadLine());

                    foreach (var Coin in _moedas)
                    {
                        if (_moedas.Any(Coin => Coin.Id == compraId))
                        {
                            if (Coin.Id == compraId)
                                compraCoin = Coin;
                        }
                        else
                            throw new Exception("\n Esse ID nao esta na lista \n");
                    }

                    Console.WriteLine("\n Quantas unidades pretende comprar?");
                    decimal quantidade = decimal.Parse(Console.ReadLine());
                    if (quantidade <= 0)
                    {
                        Console.WriteLine("\n Tem de comprar no minimo 1 Coin!\n");
                        voltaMenuInvestidor();
                    }
                    foreach (var Coin in _moedas)
                    {
                        if (Coin.Id == compraId)
                        {
                            compraCoin.Quantidades = quantidade;
                        }
                    }

                    decimal preçoFinal = quantidade * compraCoin.Preco;
                    Console.WriteLine("\n Total a pagar:{0}", preçoFinal);
                    if (investor.Saldo < preçoFinal)
                    {
                        Console.WriteLine("Não tem fundos suficientes tente de novo!\n");
                        voltaMenuInvestidor();
                    }
                    investor.Saldo -= preçoFinal;
                    Investidor.Portfolio.Add(compraCoin);

                    novaComissao.userID = userId;
                    novaComissao.valor = preçoFinal * (decimal)0.01;
                    novaComissao.data = DateTime.Today;
                    novaComissao.tipoComissao = "Compra";
                    novaComissao.valorCoin = compraCoin.Preco;
                    novaComissao.Id = rnd.Next(1, 1000);
                    novaComissao.quantidades = quantidade;
                    _comissao.Add(novaComissao);

                    Console.WriteLine("\n Pressione  qualquer tecla para voltar ao Menu anterior\n");
                    Console.ReadKey();
                    GuardarMenuInvestidor();
                }

                catch (FormatException format)
                {
                    Console.WriteLine("Não pode introduzir letras \n", format);
                    Console.ReadKey();
                    InvestidorOpcoesRepete();
                }

                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.ReadKey();
                    InvestidorOpcoesRepete();
                }
            }
            catch (FormatException formatid)
            {
                Console.WriteLine("Não pode introduzir letras no id \n", formatid);
                Console.ReadKey();
                InvestidorOpcoesRepete();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
                InvestidorOpcoesRepete();
            }
        }
        public void VenderInvestidor()
        {
            GetPrices(_moedas);
            Console.Clear();
            Random rnd = new Random();
            Coin venderCoin = null;
            comissao novaComissao = new comissao();
            try
            {
                Console.WriteLine("\n\n Introduza o seu ID\n");
                int userId = int.Parse(Console.ReadLine());
                var investor = _users.Find(investidor => investidor.ID == userId);

                Console.Clear();
                Console.WriteLine("\n                         ");
                investor.PrintSaldo();
                Console.WriteLine("\n ** O seu Portfolio ** \n");
                Console.WriteLine("                           ");

                investor.PrintPortfolio();

                Console.WriteLine("\n Introduza o ID da moeda que prentende Vender\n");
                int venderId = int.Parse(Console.ReadLine());
                var vmoeda = _moedas.Find(coin => coin.Id == venderId);

                foreach (var Coin in _moedas)
                {
                    if (vmoeda.Id == venderId)
                    {
                        venderCoin = vmoeda;
                    }
                }

                Console.WriteLine("\n Introduza a quantidade que prentende Vender\n");
                decimal quantidade = decimal.Parse(Console.ReadLine());

                if (venderCoin.Quantidades < quantidade)
                {
                    Console.Clear();
                    Console.WriteLine("Não tem assim tantas coins! \n");
                    voltaMenuInvestidor();
                }
                else
                {
                    venderCoin.Quantidades = venderCoin.Quantidades - quantidade;
                    if (venderCoin.Quantidades == 0)
                        Investidor.Portfolio.Remove(venderCoin);
                }

                decimal ganho = quantidade * venderCoin.Preco;
                Console.WriteLine(" Total a receber:{0}", ganho);
                var update = Investidor.Portfolio.FirstOrDefault(coin => coin.Id == venderId);
                update.Quantidades = venderCoin.Quantidades;
                investor.Saldo = investor.Saldo + ganho;

                novaComissao.userID = userId;
                novaComissao.valor = ganho * (decimal)0.01;
                novaComissao.data = DateTime.Today;
                novaComissao.valorCoin = venderCoin.Preco;
                novaComissao.tipoComissao = "Venda";
                novaComissao.quantidades = quantidade;
                novaComissao.Id = rnd.Next(1, 1000);
                _comissao.Add(novaComissao);

                Console.WriteLine("Pressione qualquer tecla para voltar ao Menu anterior");
                Console.ReadKey();

                GuardarMenuInvestidor();
            }
            catch (FormatException formatid)
            {
                Console.WriteLine("Não pode introduzir letras no id \n", formatid);
                Console.ReadKey();
                InvestidorOpcoesRepete();
            }
        }
        public void MostrarPortfolio()
        {
            Console.Clear();
            Console.WriteLine("Introduza o seu id:");
            int id = int.Parse(Console.ReadLine());

            Console.Clear();

            PrintSaldo(_users);
            Console.WriteLine("                             ");
            Console.WriteLine("                             ");
            Console.WriteLine("\t ** O seu Portfolio ** \n\n");
            Console.WriteLine("                             ");

            if (_users.Any(investor => investor.ID == id))
            {
                foreach (var investor in _users)
                {
                    investor.PrintPortfolio();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine(" O Utilizador nao esta registado \n");
                voltaMenuInvestidor();
            }
            Console.WriteLine("                             ");
            Console.WriteLine("\n\nPressione qualquer tecla para voltar ao Menu anterior");
            Console.ReadKey();
            InvestidorOpcoesRepete();
        }
        public void MostrarCambio()
        {
            Console.Clear();
            PrintCoins(_moedas);
            voltaMenuInvestidor();

        }

        // Funções relacionadas com o Admin
        public Coin AdicionarNovaCoin()
        {
            Console.Clear();
            Coin novaMoeda = new Coin();

            Console.WriteLine("                             ");
            Console.WriteLine("\t ** Lista de Moedas **\n");
            PrintCoins(_moedas);
            Console.WriteLine("\n *****************************");
            try
            {
                Console.WriteLine("\n Qual o nome da moeda que pretende adicionar?\n");
                string moedasNovas = Console.ReadLine();
                if (Regex.IsMatch(moedasNovas, @"^[a-zA-Z]+$"))
                {
                    foreach (var moeda in _moedas)
                    {
                        if (moeda.Nome == moedasNovas.ToUpper())
                        {
                            Console.WriteLine("\n Já existe uma Moeda com esse nome!\n");
                            VoltaMenuAdmin();
                        }
                    }
                    Console.WriteLine("\n Qual o ID pretende atribuir a moeda?\n");
                    int novoId = int.Parse(Console.ReadLine());
                    foreach (var moeda in _moedas)
                    {
                        if (_moedas.Any(moeda => moeda.Id == novoId))
                        {
                            Console.WriteLine("Já existe uma moeda com este ID.\n");
                            VoltaMenuAdmin();
                        }
                        else
                        {
                            novaMoeda.Nome = moedasNovas.ToUpper();
                            novaMoeda.Id = novoId;
                            novaMoeda.Preco = 1;//No enunciado diz que todas as moedas tem um valor inicial de 1 euro
                            AddCoin(novaMoeda);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\n Nome não pode conter numeros!\n");
                    VoltaMenuAdmin();
                }
                Console.Clear();
                Console.WriteLine("Não existe nenhuma moeda com esse ID!");
            }
            catch (Exception e)
            {
                Console.WriteLine(" ", e);
                Console.ReadLine();
            }
            Console.WriteLine("\n\nPressione qualquer tecla para voltar ao Menu anterior");
            Console.ReadKey();
            GuardarMenuAdmin();
            return novaMoeda;
        }
        public Coin removerMoeda() //continuar macaco
        {
            Console.Clear();
            Coin removeCoin = new Coin();

            Console.WriteLine("                             ");
            Console.WriteLine("\t ** Lista de Moedas **\n");
            PrintCoins(_moedas);
            Console.WriteLine("\n *****************************\n");

            try
            {
                Console.WriteLine("Introduza o ID da moeda que prentende remover\n");
                int removerCoin = int.Parse(Console.ReadLine());
                foreach (var Coin in _moedas)
                {
                    if (_moedas.Any(moeda => moeda.Id == removerCoin))
                    {
                        if (Coin.Id == removerCoin)
                            removeCoin = Coin;
                    }                   
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Não existe nenhuma moeda com esse ID!");
                        Console.WriteLine("\n\n Pressione qualquer tecla para voltar ao Menu anterior");
                        Console.ReadKey();
                        AdminOpcoesRepete();

                    }
                }
                _moedas.Remove(removeCoin);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n Nao pode introduzir letras!", e);
                Console.ReadLine();
            }
            Console.WriteLine("\n\n Pressione qualquer tecla para voltar ao Menu anterior");
            Console.ReadKey();
            Save();
            saveData();
            AdminOpcoesRepete();
            return removeCoin;

        }
        public void RelatorioComissoes()
        {
            Console.Clear();
            Console.WriteLine("                             ");
            Console.WriteLine("                             ");
            Console.WriteLine("\t ** Relatório de Comissões ** \n\n");
            Console.WriteLine("                             ");

            foreach (var comission in _comissao)
                comission.printcomissoes();

            Console.WriteLine("                             ");
            Console.WriteLine("                             ");

            decimal total = 0;
            foreach (var comission in _comissao)
            {
                total += comission.valor;
                Console.WriteLine("Lucro total: ");
                Console.WriteLine(total + "euros");
            }
            VoltaMenuAdmin();
        }
        public void VerTempodeAtualziacao()
        {
            Console.Clear(); Console.WriteLine("\n\n Esta programado para atualizar a cada " + GetPriceUpdateInSeconds() + " segundos");
            VoltaMenuAdmin();
        }

        //**********************************************************************

        public void AddInvestidores(Investidor novoInvestidor)
        {
            _users.Add(novoInvestidor);
        }
        public void BaseCoin()
        {
            _moedas.AddRange(new List<Coin> {
                        new Coin("TUGA", 1, 0),
                        new Coin("CHOW", 1, 1),
                        new Coin("GALLO", 1, 2),
                        new Coin("DOCE", 1, 3),
            });

        }
        public void PrintCoins(List<Coin> Moedas)
        {
            foreach (var Coin in Moedas)
                Coin.Print();
        }
        public void PrintSaldo(List<Investidor> Users)
        {
            foreach (var investidor in Users)
                investidor.PrintSaldo();
        }
        public void AddCoin(Coin coin)
        {
            _moedas.Add(coin);
        }
        public List<Coin> GetCoin() // Como uso listas o GetCoin e o GetPrices neste caso parecem ser redundantes e acabei por não utilizar este diretamente
        {
            foreach (var Coin in _moedas)
                Console.WriteLine("ID: " + Coin.Id + " | " + " Nome: " + Coin.Nome + "  | " + Coin.Preco + " euros");

            return _moedas;
        }
        public List<Coin> GetPrices(List<Coin> moedas) // get
        {
            return moedas;
        }


        // Alterar os preços das moedas

        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
        public List<Coin> VariarPrecos(List<Coin> moedas)
        {
            decimal randNumber = (decimal)GetRandomNumber(-0.05, 0.05);

            foreach (var coin in moedas)
            {
                coin.Preco += randNumber;
            }
            return moedas;
        }
        public int Temporizador()
        {
            Console.Clear();
            Console.WriteLine("\n De quantos em quantos segundos quer atualizar os preços? (Entre 1 e 60 segundos)");
            int updatePreco = int.Parse(Console.ReadLine());
            Timer x = new Timer(updatePreco * 1000);
            x.AutoReset = true;
            x.Elapsed += new System.Timers.ElapsedEventHandler(myTimer);
            x.Start();

            return updatePreco;
        }
        public void myTimer(object sender, System.Timers.ElapsedEventArgs e)
        {
            VariarPrecos(_moedas);
        }

        // Fazer Set e Get aos Preços

        public void DefinePriceUpdateInSeconds(int updatePreco) //Set
        {
            this.Seconds = updatePreco;
            Save();
            saveData();
            AdminOpcoesRepete();
        }
        public void DefinePriceUpdateInSecondsFromFile(int updatePreco)//set quando lido do ficheiro
        {
            this.Seconds = updatePreco;
        }
        public int GetPriceUpdateInSeconds()//Get
        {
            return Seconds;
        }
        public void AtualizarOspreços(int updatePreco, DateTime datafecho)
        {
            if (updatePreco == 0)
                updatePreco += 5;

            var tempo = DateTime.UtcNow - datafecho;
            var nUpdates = Convert.ToInt32(tempo.TotalSeconds) / updatePreco;

            for (int i = 0; i < nUpdates; i++)
            {
                VariarPrecos(_moedas);
            }
        }
        
        // Escrever e Ler Ficheiros
        public DateTime saveData()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var dataFecho = DateTime.UtcNow;
            string data = @"C:\TugaExchange\data.json";

            string json5 = JsonSerializer.Serialize(dataFecho, options);
            File.WriteAllText(data, json5);
            return dataFecho;
        }
        public void Save()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string fileCoin = @"C:\TugaExchange\coins.json";
            string fileUser = @"C:\TugaExchange\users.json";
            string filePortfolio = @"C:\TugaExchange\portfolio.json";
            string fileComissao = @"C:\TugaExchange\comissao.json";
            string priceUpdate = @"C:\TugaExchange\priceUpdate.json";

            string json = JsonSerializer.Serialize(_moedas, options);
            string json1 = JsonSerializer.Serialize(_users, options);
            string json2 = JsonSerializer.Serialize(_comissao, options);
            string json3 = JsonSerializer.Serialize(Investidor.Portfolio, options);
            string json4 = JsonSerializer.Serialize(GetPriceUpdateInSeconds(), options);

            File.WriteAllText(fileCoin, json);
            File.WriteAllText(fileUser, json1);
            File.WriteAllText(fileComissao, json2);
            File.WriteAllText(filePortfolio, json3);
            File.WriteAllText(priceUpdate, json4);
        }
        public int ReadObject()
        {
            int updatePreco = 0;
            if (File.Exists(@"C:\TugaExchange\coins.json") &&
                File.Exists(@"C:\TugaExchange\users.json") &&
                File.Exists(@"C:\TugaExchange\comissao.json") &&
                File.Exists(@"C:\TugaExchange\portfolio.json") &&
                File.Exists(@"C:\TugaExchange\priceUpdate.json"))
            {
                var json = File.ReadAllText(@"C:\TugaExchange\coins.json");
                var json1 = File.ReadAllText(@"C:\TugaExchange\users.json");
                var json2 = File.ReadAllText(@"C:\TugaExchange\comissao.json");
                var json3 = File.ReadAllText(@"C:\TugaExchange\portfolio.json");
                var json4 = File.ReadAllText(@"C:\TugaExchange\priceUpdate.json");

                _moedas = JsonSerializer.Deserialize<List<Coin>>(json);
                _users = JsonSerializer.Deserialize<List<Investidor>>(json1);
                _comissao = JsonSerializer.Deserialize<List<comissao>>(json2);
                Investidor.Portfolio = JsonSerializer.Deserialize<List<Coin>>(json3);
                updatePreco = JsonSerializer.Deserialize<int>(json4);
                return updatePreco;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n\n Não existem dados guardados. Dados serão guardados durante a utilização da App");
                Console.WriteLine("\n\n Clique em qualquer tecla para continuar!");
                Console.ReadLine();
            }
            return updatePreco;


        }
    }
}
