using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventtask
{
    public delegate int Sum(int x, int y);
    class sumdelegate
    {
        public event Sum Plus;
        public void Process()
        {
            Console.WriteLine("  Strating  Process......");
            Console.ReadLine();
            Plus.Invoke(20, 30);
            Console.Read();

        }

      




    }
}
