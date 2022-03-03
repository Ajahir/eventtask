using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventtask
{
    class Program
    {
        static void Main(string[] args)
        {
            otherclass sp = new otherclass();
            sp.complete += Sp_complete;
            sp.startprocess();

            sumdelegate x = new sumdelegate();
            x.Plus += X_Plus;
            x.Process();


            add y = new add();
            y.Addnumbers += Y_Addnumbers;
            y.Add();
        }

        private static void Y_Addnumbers(object sender, EventArgs e)
        {
            Console.WriteLine(" Event is Executed.....");
        }

        private static int X_Plus(int x, int y)
        {
            Console.WriteLine(" x + y = " + (x + y));
            return x + y;
        }

        private static void Sp_complete()
        {
            Console.WriteLine("Welocme to the World ");
           
        }
    }
}
