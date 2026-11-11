using System.Globalization;

namespace PraticandoConceitos.Exercicio006
{
    internal class Exercicio06
    {
        public static void Executar()
        {
            Console.WriteLine("Data Atual");
            DateTime data = DateTime.Now;
            DateOnly DataOnly =  DateOnly.FromDateTime(DateTime.Now);
            TimeOnly hora = TimeOnly.FromDateTime(DateTime.Now);
            string texto = DataOnly.ToString("D", new CultureInfo("pt-BR"));
            Console.WriteLine(data);
            Console.WriteLine(DataOnly);
            Console.WriteLine(texto);
           
            




        }
    }
}
