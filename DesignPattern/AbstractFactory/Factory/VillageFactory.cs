using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Products;

namespace AbstractFactory.Factory
{
    abstract class VillageFactory
    {

        public void DrawVillage()
        {
            CreateTree().DrawTree();
            CreateHouse().DrawHouse();
        }
        public abstract House CreateHouse();

        public abstract Tree CreateTree();
    }
}
