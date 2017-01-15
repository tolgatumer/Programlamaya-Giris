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
            int sayi1, sayi2,sayi3;
            int eb, ek;
            Console.Write("lutfen 1. sayi giriniz:");
            sayi1 = int.Parse(Console.ReadLine());
            Console.Write("lutfen 2. sayiyi giriniz:");
            sayi2 = int.Parse(Console.ReadLine());
            Console.Write("lutfen 3. sayiyi giriniz:");
            sayi3 = int.Parse(Console.ReadLine());

            if (sayi1 > sayi2 && sayi1 > sayi3)
                eb = sayi1;
            else if (sayi2 > sayi1 && sayi2 > sayi3)
                eb = sayi2;
            else
                eb = sayi3;

            if (sayi1 < sayi2 && sayi1 < sayi3)
                ek = sayi1;
            else if (sayi2 < sayi1 && sayi2 < sayi3)
                ek = sayi2;
            else
                ek = sayi3;


            Console.WriteLine("Girdiginiz sayilar icinde en kucuk olan " + ek + "'dir");
            Console.WriteLine("Girdiginiz sayilar icinde en buyuk olan da " + eb + "'dir");
            Console.ReadLine();
