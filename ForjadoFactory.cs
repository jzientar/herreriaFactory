using System;

namespace Herreria_Factory
{
    public abstract class ForjadoFactory
    {
        public abstract IForjado ForjarMaterial(string forjado);
    }
}