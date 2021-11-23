using System;

namespace Laboratorio10
{
   public class Program
    {
        static void Main(string[] args)
        {
            TermometroLimite term = new TermometroLimite(35); 
            Console.WriteLine(term.ToString());

            term.LimiteSuperiorEvent += new TermometroLimite.MeuDelegate(TrataLimiteSuperior);
            Console.Write("Temperatura: ");
            Console.WriteLine(term.ToString());

        }
        private static void TrataLimiteSuperior(string msg)
        {
            Console.WriteLine(msg);
        }

    }
}
