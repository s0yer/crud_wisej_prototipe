using crud_wisej_prototipe;
using ConsultasLinq.Data;

namespace ConsultasLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------- start -------------");

            using(var contexto = new Luck())
            {
                var query = from numero in contexto.Lucks
                            select numero;

                foreach (var num in query)
                {
                    Console.WriteLine("{0}\t{1}",
                        num.Id, num.numero);
                }
            }

            Console.ReadKey();

            Console.WriteLine("----------- end -------------");

        }
    }
}