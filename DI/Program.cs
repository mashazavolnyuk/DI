using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DI
{
    class Program
    {
        static void Main(string[] args)
        {
            IConnecter c = new Connecter("http://dou.ua/");
            Console.WriteLine("Result {0}",Access(c));
            Console.ReadLine();
                
        }

        static object Access(IConnecter Ic)
        {
            var c = Ic.Ping();
            return c;
        }

    }
   
}

