namespace AulaPOOPolimorfismo
{
    using System;
    public class Anual : Relatorio
    {
        public override void MostrarRelatorio() {
            base.MostrarRelatorio();
            Console.WriteLine("Mostrando relatório anual.");
        }
    }
}