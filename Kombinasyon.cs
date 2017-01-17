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
            int sayi1, sayi2;
            int kombinasyon;
            Console.Write("kombinasyonu alinacak sayiyi giriniz:");
            sayi1 = int.Parse(Console.ReadLine());
            Console.Write("kacli kombinasyon alinacak lutfen giriniz:");
            sayi2 = int.Parse(Console.ReadLine());
            kombinasyon = faktoriyel(sayi1) / (faktoriyel(sayi1 - sayi2) * faktoriyel(sayi2));
            Console.Write(sayi1 + "'in " + sayi2 + "'li kombinasyonu:" + kombinasyon);
            Console.ReadKey();
                
        }
        static int faktoriyel(int x)
        {
            if (x == 1 || x == 0)
                return 1;
            else
                return x * faktoriyel(x - 1);
        }
        
    }

}
