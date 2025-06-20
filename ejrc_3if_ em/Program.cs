using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejrc_3if__em
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota;
            Console.WriteLine("ingresew nota");
            nota = Convert.ToInt32(Console.ReadLine());
            if (nota >= 16)
            {
                Console.WriteLine("exelente");
            }
            else if (nota==14|| nota == 15)
            {
                Console.WriteLine("muy bueno");
            }
            else if (nota <= 13 && nota >=11)
            {
                Console.WriteLine("buno");
            }
            else
            {
                Console.WriteLine("insuficiente");
            }
        }
    }
}
