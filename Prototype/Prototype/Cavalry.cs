using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Cavalry:Army
    {
        
        public Cavalry() //constructor
        {
            this.type = "Atlı Birlik";
        }
        
        public override Army Clone()
        {
            return MemberwiseClone() as Cavalry;
        }
        public override int calcPower() //toplam gücü hesaplama
        {
            this.allpow = power * number;
            return allpow;
        }
    }
}
