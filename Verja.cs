using System;

namespace Herreria_Factory
{
    class Verja : IForjado
    {
        public void SoldarMaterial(string metal, int precio)
        {
            Console.WriteLine("VERJA\n=====");
            Console.WriteLine("La verja sera forjada con " + metal + ", con un costo de:" + " Bs. " + precio.ToString());
        }
    }
}