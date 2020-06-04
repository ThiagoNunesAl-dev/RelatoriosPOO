namespace AulaPOOPolimorfismo
{
    using System;
    public class Mensal : Relatorio
    {
        public override void MostrarRelatorio() {
            base.MostrarRelatorio();
            Console.WriteLine("Mostrando relatório mensal.");
        } 
    }
}