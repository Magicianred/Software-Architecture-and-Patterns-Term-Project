using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Infantry : Army
    {
        public Infantry() //constructor
        {
            this.type = "Piyade";
        }

        public override Army Clone()
        {
            return MemberwiseClone() as Infantry;
        }
        public override int calcPower() //hesaplama
        {
            this.allpow = power * number;
            return allpow;

        }
    }
}
