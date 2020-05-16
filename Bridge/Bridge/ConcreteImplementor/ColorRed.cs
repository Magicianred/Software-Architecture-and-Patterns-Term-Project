using System;
using System.Collections.Generic;
using System.Text;
using Bridge;
using Bridge.Implementor;

namespace Bridge.ConcreteImplementor
{
    class ColorRed : ColorPicker
    {
        public override void ColorPick(string carbrand)
        {
            Console.WriteLine("Kırmızı renkte şu arabayı kullanıyorsunuz: "+carbrand);
        }
    }
}
