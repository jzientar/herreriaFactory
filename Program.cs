using System;

namespace Herreria_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ForjadoFactory forjadoFactory = new ConcreteForjadoFactory();

            IForjado verja = forjadoFactory.ForjarMaterial("Verja");
            verja.SoldarMaterial("hierro", 2000);

            IForjado escalera = forjadoFactory.ForjarMaterial("Escalera");
            escalera.SoldarMaterial("Aluminio", 400);

            Console.ReadKey();
        }
    }
}
