using System;

namespace ChallengeTernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string temperatureMessage = string.Empty;

            Console.WriteLine("What's the temperature?");
            string str = Console.ReadLine();
            int temperature = int.Parse(str);

            bool validInteger = int.TryParse(str, out temperature);

            if(validInteger)
            {
                temperatureMessage = temperature <= 15 ? "it is too cold here":
                (temperature >= 16 && temperature <= 28) ? "it is ok":
                temperature > 28 ? "it is hot in here" : "";
                Console.WriteLine(temperatureMessage);
            }
            else
            {
                Console.WriteLine("Not a valid Temperature");
            }
             
        }
    }
}
 