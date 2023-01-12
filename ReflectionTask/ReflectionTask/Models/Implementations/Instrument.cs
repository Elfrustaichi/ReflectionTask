using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTask.Models.Implementations
{
    internal abstract class Instrument
    {
        public string Model { get; set; }
        
        public double Price { get; set; }

        public string Brand { get; set; }

        

        protected abstract void Sound();

    }
}
