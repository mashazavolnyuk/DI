using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DI
{
    class MockConnecter:IConnecter
    {
        private string url;
        public MockConnecter(string Url)
        {
            this.url = Url;         
        }

        public bool Ping()
        {
            Thread.Sleep(3000);
            return false;
        }

    }
}
