using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton
    {
        // private static Singleton _singleton = new Singleton(); // initialized static member at class load time
        private static Singleton _singleton; 
        private Singleton()
        {
            // private constructor
        }
        public static Singleton GetSingleton()
        {
            if(_singleton == null)
                _singleton = new Singleton();
            return _singleton;
        }
        public void DoSomething()
        {
            Console.WriteLine("Hello Singleton");
        }
    }
}
