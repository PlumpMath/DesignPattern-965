using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Use PROJECT > Singleton Properties (Project Name) > Startup Object dropdown (which main to execute)
namespace Singleton
{
    class MainSingleton
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetSingleton();
            Singleton s2 = Singleton.GetSingleton();
            s1.DoSomething();
            if(s1==s2)
                Console.WriteLine("s1 and s2 point to the same object");
            Console.ReadLine();
        }
    }
}
