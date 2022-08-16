namespace ConsultasLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------- start -------------");

            var query = from n in numeros
                        select n;

            foreach(var num in query)
            {
                Console.WriteLine("{0}\t{1}", 
                    num.Id, num.numero);
            }
            Console.ReadKey();

            Console.WriteLine("----------- end -------------");

        }
    }
}