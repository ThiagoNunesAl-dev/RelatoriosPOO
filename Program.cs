using System;

namespace AulaPOOPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Relatórios");
            Console.WriteLine("----------");
            Relatorio geral = new Relatorio();
            geral.MostrarRelatorio();
            Console.WriteLine("");
            Mensal mensal = new Mensal();
            mensal.MostrarRelatorio();
            Console.WriteLine("");
            Anual anual = new Anual();
            anual.MostrarRelatorio();
        }
    }
}
