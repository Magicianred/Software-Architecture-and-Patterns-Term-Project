using Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.ConcreteImplementor
{
    class ColorBlue:ColorPicker
    {
        public override void ColorPick(string carbrand)
        {
            Console.WriteLine("Mavi renkte şu aracı kullanıyorsunuz: "+carbrand);
        }
    }
}
