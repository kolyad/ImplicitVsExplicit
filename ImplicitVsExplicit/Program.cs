using System;

namespace ImplicitVsExplicit
{
    class Program
    {
        static void Main(string[] args)
        {

            var writer1 = new Writer();
            IWriterInterface writer2 = new Writer();

            writer1.Write();
            writer2.Write();

            Console.ReadKey();
        }
    }
}
