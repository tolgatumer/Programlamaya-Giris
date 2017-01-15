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
            float BitmeSuresi=0;
            int IsciSayisi;
            Console.Write("İsci sayisini giriniz:");
            IsciSayisi = int.Parse(Console.ReadLine());
            int[] IsGucu = new int[IsciSayisi];
            for(int i=0;i<IsciSayisi;i++)  //bir işcinin bütün işi tek başına ne kadar surede yapacağının bilgisi
            {
                Console.Write(i + 1 + ". iscinin isi bitirme suresini giriniz:");
                IsGucu[i] = int.Parse(Console.ReadLine());
            }

            for (int i=0;i<IsciSayisi;i++) //burada işci problemlerinden (1/a +1/b)*x=1(işin tamamı) formülünü uygulayacağız
            {
                BitmeSuresi += (float) 1 / IsGucu[i];
            }

            Console.Write(IsciSayisi + " tane isci bu isi " +(1 / BitmeSuresi) + " gunde yapabilir");
            Console.ReadLine();
        }
        
    }

}
