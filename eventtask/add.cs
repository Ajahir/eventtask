using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventtask
{

    class add
    {
        public event EventHandler<EventArgs> Addnumbers;

        public void Add()
        {
            int x;
            x = 300+50;
            Console.WriteLine(" Event Add " + (x));
            Console.Read();
            Addnumbers?.Invoke(this, EventArgs.Empty);
            Console.Read();

        }



    }
}
