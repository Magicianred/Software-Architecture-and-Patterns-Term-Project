using System;
using Bridge.Abstraction;
using Bridge.RefinedAbstraction;
using Bridge.Implementor;
using Bridge.ConcreteImplementor;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            CarPicker car = new Fiat();
            car._colorPicker = new ColorBlue();
            car.MakeChoice();

            car._colorPicker = new ColorRed();
            car.MakeChoice();

            car = new Ford();
            car._colorPicker = new ColorBlue();
            car.MakeChoice();

            Console.ReadKey();



        }
    }
}
