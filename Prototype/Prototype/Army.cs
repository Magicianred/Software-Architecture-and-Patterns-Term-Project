using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public abstract class Army
    {
        public int number { get; set; }
        public int power { get; set; }
        public string type { get; set; }
        public int allpow { get; set; }


        public abstract Army Clone();
        public abstract int calcPower();
    }
}
