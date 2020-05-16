using Bridge.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.RefinedAbstraction
{
    public class Ford : CarPicker
    {
        public override void MakeChoice()
        {
            _colorPicker.ColorPick("Ford");
        }
    }
}
