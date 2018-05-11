using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class OilProducts
    {
        public double volume, weight;
        public string Name;

        public OilProducts(double volume, double weight, string Name)
        {
            this.volume = volume;
            this.weight = weight;
            this.Name = Name;
        }

        public virtual void Dencity()
        {
            Console.WriteLine("Плотность нефтепродукта {0} составляет:{1} кг/м3", Name, weight / volume);
        }
    }
}