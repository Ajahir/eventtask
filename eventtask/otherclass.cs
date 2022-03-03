using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventtask
{
    public delegate void start();
    class otherclass
    {
        public event start complete;
        public void startprocess()
        {
            Console.WriteLine("starting.........");
           
            complete?.Invoke();
            Console.ReadLine();
        }
    }
}
