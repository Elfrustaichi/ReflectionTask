using ReflectionTask.Models.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ReflectionTask.Service;

namespace ReflectionTask.Models.Instruments
{
    internal class Violin : Instrument
    {
        
       
        protected override void Sound()
        {
            Console.WriteLine("Sound as violin.");
        }

        public Violin(string model,int price,string brand) 
        {
            Model = model;
            Price = price;
            Brand = brand;

            Service.Service.instrumentslist.Add(this);
        }

    }
}
