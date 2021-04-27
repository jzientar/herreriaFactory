using System;

namespace Herreria_Factory
{
    class Escalera : IForjado
    {
        public void SoldarMaterial(string metal, int precio)
        {
            Console.WriteLine("Escalera\n=====");
            Console.WriteLine("La escalera sera forjada con " + metal + ", con un costo de:" + " Bs. " + precio.ToString());
        }
    }
}