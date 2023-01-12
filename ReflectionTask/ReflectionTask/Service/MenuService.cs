using ReflectionTask.Models.Instruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTask.Service
{
    internal class MenuService
    {
        public void AddMenu() 
        {
            again:
            Console.WriteLine("1.Add Piano");
            Console.WriteLine("2.Add Violin");
            Console.WriteLine("3.Add Guitar");
            Console.WriteLine("4.Add Flute");
            Console.Write("Order---");
            int.TryParse(Console.ReadLine(), out int order);

            switch (order)
            {
                case 1:
                    Console.Write("Add Model:");
                    string modelpiano= Console.ReadLine();   
                    Console.Write("Add Price:");
                    int.TryParse(Console.ReadLine(), out int pricepiano);
                    Console.Write("Add Brand:");
                    string brandpiano= Console.ReadLine();
                    Piano piano=new Piano(modelpiano, pricepiano, brandpiano);
                    Console.Clear();
                    break;
                    case 2:
                    Console.Write("Add Model:");
                    string modelviolin = Console.ReadLine();
                    Console.Write("Add Price:");
                    int.TryParse(Console.ReadLine(), out int priceviolin);
                    Console.Write("Add Brand:");
                    string brandviolin = Console.ReadLine();
                    Violin violin = new Violin(modelviolin, priceviolin, brandviolin);
                    Console.Clear();
                    break;
                    case 3:
                    Console.Write("Add Model:");
                    string modelguitar = Console.ReadLine();
                    Console.Write("Add Price:");
                    int.TryParse(Console.ReadLine(), out int priceguitar);
                    Console.Write("Add Brand:");
                    string brandguitar = Console.ReadLine();
                    Guitar guitar = new Guitar(modelguitar, priceguitar, brandguitar);
                    Console.Clear();
                    break;
                    case 4:
                    Console.Write("Add Model:");
                    string modelflute = Console.ReadLine();
                    Console.Write("Add Price:");
                    int.TryParse(Console.ReadLine(), out int priceflute);
                    Console.Write("Add Brand:");
                    string brandflute = Console.ReadLine();
                    Flute flute = new Flute(modelflute, priceflute, brandflute);
                    Console.Clear();
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine("Wrong order try again.");
                    goto again;


                default:
                    Console.Clear();
                    Console.WriteLine("Wrong order try again.");
                    goto again;
                  
            }
        }
    }
}
