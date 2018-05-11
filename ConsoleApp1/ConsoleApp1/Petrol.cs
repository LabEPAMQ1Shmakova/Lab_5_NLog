using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Petrol : OilProducts
    {
        public Petrol(double volume, double weight, string Name) : base(volume, weight, Name) { }

        public override void Dencity()
        {
            Console.WriteLine("Плотность нефтепродукта {0} составляет:{1} кг/м3", Name, weight / volume);
        }
    }
}

