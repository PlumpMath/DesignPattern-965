using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products
{
    class AfricanTree : Tree
    {
        public override void DrawTree()
        {
            Console.WriteLine("African Tree Built");
        }
    }
}
