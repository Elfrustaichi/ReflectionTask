using ReflectionTask.Models.Implementations;
using ReflectionTask.Service;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTask.Models.Instruments
{
    internal class Piano : Instrument
    {
        
        protected override void Sound()
        {
            Console.WriteLine("Sound as Piano.");
        }
        public Piano(string model, int price, string brand)
        {
            Model = model;
            Price = price;
            Brand = brand;

           Service.Service.instrumentslist.Add(this);


        }
    }
}
