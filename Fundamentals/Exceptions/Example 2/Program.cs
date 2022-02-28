using System;

namespace execcaoAula
{
    class Program
    {
        public  static DateTime ConvertToDateTime(int hours, int minutes, int seconds)
        {
            throw new NotImplementedException();
        }
        static void Main(string[] args)
        {
            try
            {
                ConvertToDateTime(12, 12, 1);
                var data = DateTime.UtcNow;
                var futureDate = data.AddYears(10);
                data = new DateTime(2022, 1, 26, 10, 10, 12);
                Console.WriteLine(data);
            }
            catch (NotImplementedException nie)
            {        
                Console.WriteLine(nie.Message);
            }

         
        }
    }
}
