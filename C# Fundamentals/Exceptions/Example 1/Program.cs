using System;

namespace execcaoAula
{
    class Program
    {
        public static DateTime ConvertToDateTime(int hours, int minutes, int seconds)
        {
            if (hours < 0 || hours > 23)
                throw new Exception("As horas são invalidas. As horas deveram estar compreendidas entre 1 e 24");
            else if (minutes < 0 || minutes > 59)
                throw new Exception("Os minutos são inválidos. Os minutos deveram estar compreendidos entre 1 e 59");
            else if (seconds < 0 || seconds > 59)
                throw new Exception("Os segundos são inválidos. Os segundos deveram estar compreendidos entre 1 e 59");
            try
            {
                return new DateTime(hours, minutes, seconds);
            }
            catch
            {
                throw new Exception("Data inválida");
            }
        }
        public static DateTime ConvertToDate(int dia, int mes, int ano)
        {
            if (dia < 1 || dia > 31)
                throw new Exception("O dia é inválido. O dia deverá estar compreendido entre 1 e 31");
            else if(mes <1 || mes >13)
                throw new Exception("O mês é inválido. O mês deverá estar compreendido entre 1 e 12");
            else if(mes == 2 && dia >29 && DateTime.IsLeapYear(ano) == true)
                throw new Exception("O dia é inválido. Fevereiro nunca tem mais que 29 dias. O dia deverá estar compreendido entre 1 e 29 para anos bissextos");
            else if (mes == 2 && dia > 28 && DateTime.IsLeapYear(ano) == false)
                throw new Exception("O dia é inválido. Este ano não é bissexto. O dia deverá estar compreendido entre 1 e 28 para anos não bissextos");
            else if (ano < 1900)
                throw new Exception("Já ninguém quer bem saber o que se passou antes. Muda o Ano");

            try
            {
                return new DateTime(ano, mes, dia);
            }
            catch
            {
                throw new Exception("Data inválida");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                ConvertToDate(29, 2, 2001);
                var data = DateTime.UtcNow;
                var futureDate = data.AddYears(10);
                data = new DateTime(2022, 1, 26, 10, 10, 12);
                Console.WriteLine(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
