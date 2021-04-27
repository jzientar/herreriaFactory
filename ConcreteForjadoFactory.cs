using System;
using System.Collections.Generic;

namespace Herreria_Factory
{
    class ConcreteForjadoFactory : ForjadoFactory
    {
        public override IForjado ForjarMaterial(string forjado)
        {
            switch (forjado)
            {
                case "Verja":
                    return new Verja();
                case "Escalera":
                    return new Escalera();
                default:
                    throw new Exception(string.Format("Forjado '{0}' No se pudo crear", forjado));
            }
        }
    }
}