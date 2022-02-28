using System;
using System.Collections.Generic;

namespace TugaExchange
{
    class ModuloPrincipal
    {
        public void Menu()
        {
            var myCrypto = new CryptoQuoteAPI();
            var myInvestor = new Investidor(myCrypto);

            myCrypto.BaseCoin();
            myCrypto.AtualizarOspreços(myCrypto.ReadObject(), myCrypto.saveData());
            var second = myCrypto.ReadObject();
            if(second == 0)
            myCrypto.DefinePriceUpdateInSecondsFromFile(10);
            myCrypto.Introducao();
            switch (myCrypto.TipoUtilizador())
            {
                case 1:
                    switch (myCrypto.FazerLogin())
                    {
                        case 1:myCrypto.login(); break;
                        case 2:myCrypto.NovoInvestidor(); break;
                        default:
                            Console.WriteLine("Sair"); break;
                    }Console.Clear();
                    switch (myCrypto.InvestidorOpcoes())
                    {
                        case 1: myCrypto.DepositoInvestidor(); break;
                        case 2: myCrypto.ComprarInvestidor(); break;
                        case 3: myCrypto.VenderInvestidor(); break;
                        case 4: myCrypto.MostrarPortfolio(); break;
                        case 5: myCrypto.MostrarCambio(); break;
                        case 6: myCrypto.TipoUtilizadorRepete(); break;
                        default: Console.WriteLine("Obrigado!"); break;
                    }  break;
                case 2:
                    switch (myCrypto.AdminOpcoes()) {
                        case 1: myCrypto.AdicionarNovaCoin(); break;
                        case 2: myCrypto.removerMoeda(); break;
                        case 3: myCrypto.RelatorioComissoes(); break;
                        case 4: myCrypto.DefinePriceUpdateInSeconds(myCrypto.Temporizador());break;
                        case 5: myCrypto.VerTempodeAtualziacao(); break;
                        case 6: myCrypto.TipoUtilizadorRepete(); break;
                        default: Console.WriteLine("Sair"); break;
                    } break;
                default: myCrypto.TipoUtilizador(); break;
            }
            Console.Read();
        }
    }
}
