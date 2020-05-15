using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Cavalry cav = new Cavalry {number=1000, power=50 };
            cav.calcPower();

            Console.WriteLine("Bu ordunun birlik türü: "+ cav.type+ " asker sayisi: "+ cav.number+" Toplam Gücü: "+cav.allpow);

            var clonecav = cav.Clone(); //klonlama işlemi
            clonecav.number = 500;
            clonecav.calcPower();
            Console.WriteLine("Bu ordunun birlik türü: " + clonecav.type + " asker sayisi: " + clonecav.number + " Toplam Gücü: " + clonecav.allpow);


            Infantry inf = new Infantry { number = 1000, power = 25 };
            inf.calcPower();
            Console.WriteLine("Bu ordunun birlik türü: " + inf.type + " asker sayisi: " + inf.number + " Toplam Gücü: " + inf.allpow);


            var cloneinf = inf.Clone(); //klonlama işlemi.
            cloneinf.number = 2000;
            cloneinf.calcPower();
            Console.WriteLine("Bu ordunun birlik türü: " + cloneinf.type + " asker sayisi: " + cloneinf.number + " Toplam Gücü: " + cloneinf.allpow);

        }
    }
}
