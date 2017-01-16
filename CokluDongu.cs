using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {

        static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if (i % 15 == 0)
                    Console.Write(i + " ");
                
            }
            Console.WriteLine();
            for(int i=1;i<=30;i++)
            {
                if (i % 5 == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
            for(int i=100;i>=50;i--)
            {
                if (i % 10 == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();

            for(int i=2;i<65;i=i*2)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
                
        }
        
    }

}
