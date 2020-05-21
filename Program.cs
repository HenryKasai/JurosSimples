using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Insira o capital investido.");
            string stringcapital = Console.ReadLine();
            decimal capital = Convert.ToDecimal(stringcapital);

            Console.WriteLine("Insira a taxa em juros (%).");
            string stringtaxa = Console.ReadLine();
            decimal taxa1 = Convert.ToDecimal(stringtaxa);
            decimal x = 100;
            decimal taxa = taxa1 / x;

            Console.WriteLine("Insira o tempo em meses");
            string stringtempo = Console.ReadLine(); 
            decimal tempo = Convert.ToDecimal(stringtempo);

            decimal juros = capital * taxa * tempo;
            decimal montante = capital + juros;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Juros(R$) {juros}");
            Console.WriteLine($"Montate(R$ {montante}");
            Console.ForegroundColor = ConsoleColor.Gray;








        }
    }
}
