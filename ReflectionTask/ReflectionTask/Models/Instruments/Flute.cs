using ReflectionTask.Models.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTask.Models.Instruments
{
    internal class Flute : Instrument
    {
       
        protected override void Sound()
        {
            Console.WriteLine("Sound as Flute.");
        }
        public Flute(string model, int price, string brand)
        {
            Model =model;
            Price = price;
            Brand = brand;

            Service.Service.instrumentslist.Add(this);
        }
    }
}
