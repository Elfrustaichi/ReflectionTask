using ReflectionTask.Models.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTask.Service
{
    internal class Service
    {
       public static List<Instrument> instrumentslist= new List<Instrument>();
        public static void GetAllIntruments()
        {
            foreach (Instrument instrument in instrumentslist)
            {
                Console.WriteLine($"Instrument:{instrument.GetType().Name}  Brand:{instrument.Brand}  Price:{instrument.Price}  Model:{instrument.Model}");
            }
        }

      
       

    }
}
