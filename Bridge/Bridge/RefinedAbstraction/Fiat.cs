using Bridge.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.RefinedAbstraction
{
    public class Fiat : CarPicker
    {
        public override void MakeChoice()
        {
            _colorPicker.ColorPick("Fiat");
        }
    }
}
