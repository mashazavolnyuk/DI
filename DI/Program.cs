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
            IConnecter r = new Connecter("http://dou.ua/");
            IConnecter m = new MockConnecter("http://dou.ua/");

            Console.Write("Please put key \"r\" for start real check\n else \"m\" for mock->\n");
             var ch1 = (char)Console.Read();
             switch (ch1){
                 case 'r':
                     Console.WriteLine("Result {0}",Access(r));
                     Console.ReadLine();
                     break;
                 case 'm':
                      Console.WriteLine("Result {0}",Access(m));
                      Console.ReadLine();
                     break;
             }

             Console.ReadLine();
        }

        static object Access(IConnecter Ic)
        {        
            var c = Ic.Ping();
            return c;
        } 
        }
    }
   


