using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products
{
    class AfricanHouse : House
    {
        public override void DrawHouse()
        {
            Console.WriteLine("African House Built");
        }
    }
}
