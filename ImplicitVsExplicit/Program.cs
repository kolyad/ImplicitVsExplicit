using System;

namespace ImplicitVsExplicit
{
    class Program
    {
        static void Main(string[] args)
        {

            // Call implicit realization of Write method
            var writer1 = new Writer();
            writer1.Write();

            // Call explicit realization of Write method
            IWriterInterface writer2 = new Writer();
            writer2.Write();

            // Call explicit realization of Write method
            var writer3 = (IWriterInterface)writer1;
            writer3.Write();

            Console.ReadKey();
        }
    }
}
