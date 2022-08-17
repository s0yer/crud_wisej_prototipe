using crud_wisej_prototipe;
using ConsultasLinq.Data;

namespace ConsultasLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------- start -------------");


            var listluck = new List<Luck>();    
            
            //using (var contexto = lucks)
            //{
                var query = from numero in listluck
                            select numero;

                foreach (var num in query)
                {
                    Console.WriteLine("{0}\t{1}",
                        num.Id, num.numero);
                }
            //}

            Console.ReadKey();

            Console.WriteLine("----------- end -------------");

        }
    }
}