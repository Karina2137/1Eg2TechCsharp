using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartaPracy2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zad.1
            int a = int.Parse(Console.ReadLine());
            if (a/3 == 0) 
            {
                Console.WriteLine("Tak");
             }
            else
            {
                Console.WriteLine("Nie");
             }

            //Zad.2
            int b = int.Parse(Console.ReadLine());
            if (b/17 == 0 && 100<=b && b<1000)
            {
                Console.WriteLine("Tak");
            }
            else
            {
                Console.WriteLine("Nie");
             }

            //Zad.3
            int c = int.Parse(Console.ReadLine());
            if (c>17)
            {

            }
            
            
            Console.ReadKey();
        }
    }
}
