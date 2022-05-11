using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGaraz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("123ABC", "modra");
            Garaz garaz = new Garaz();
            
            auto.Zaparkuj(garaz);
            
            Console.WriteLine(garaz);
            Console.ReadKey();
        }
    }
}