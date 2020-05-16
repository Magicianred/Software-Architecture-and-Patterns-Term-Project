using System;
using System.Collections.Generic;
using System.Text;
using Bridge.Implementor;

namespace Bridge.Abstraction
{
    public abstract class CarPicker
    {
        public ColorPicker _colorPicker;
        public abstract void MakeChoice();
    }
}
