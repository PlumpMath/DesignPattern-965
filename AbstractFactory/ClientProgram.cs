using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory;

namespace AbstractFactory
{
    class ClientProgram
    {
        static void Main(string[] args)
        {
            VillageFactory asianVillage = new AsianVillage();
            asianVillage.DrawVillage();

            VillageFactory africanVillage = new AfricanVillage();
            africanVillage.DrawVillage();

            Console.ReadLine();
        }
    }
}
