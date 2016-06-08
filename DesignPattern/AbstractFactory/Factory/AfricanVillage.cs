using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Products;

namespace AbstractFactory.Factory
{
    class AfricanVillage : VillageFactory
    {
        public override House CreateHouse()
        {
            return new AfricanHouse();
        }

        public override Tree CreateTree()
        {
            return new AfricanTree();
        }
    }
}
