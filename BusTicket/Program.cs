using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n,d,f,t,v;
            int a,h,m,s;
            Console.WriteLine("DEPO :");
            n = Console.ReadLine();
            Console.Write(" DD/MM/YYYY :");
            d = Console.ReadLine();
            Console.Write("From:");
            f= Console.ReadLine();
            Console.Write("TO:");
            t = Console.ReadLine();
            Console.Write("h:");
            h = Convert.ToInt32(Console.ReadLine());
            Console.Write("m: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("s: ");
            s = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adults :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vehicle no :");
            v = Console.ReadLine();
            Console.WriteLine("            APSRTC         ");
            Console.WriteLine("**************************************");
            Console.WriteLine("DEPO : :" + n);
            Console.WriteLine(d+"  "+h+":"+m+":"+s);
            Console.WriteLine(f + " - " + t);
            Console.WriteLine("A "+ a +"*"+ 40 +" = "+"Rs."+(a*40));
            Console.WriteLine("Vehicle no :" + v);
            Console.WriteLine("NOT TRANSFREABLE");
            Console.WriteLine("**************************************");
            Console.WriteLine("Thank You  For Visit Us");


        }
    }
}