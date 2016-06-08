using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products
{
    class AsianHouse : House
    {
        public override void DrawHouse()
        {
            Console.WriteLine("Asian House Built");
        }
    }
}
