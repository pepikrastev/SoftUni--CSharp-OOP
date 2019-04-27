using System;
using AnimalCentre.Core;
using AnimalCentre.Core.Contracts;
using AnimalCentre.Models.Animals;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();

           //Animal cat = new Lion("s", 12, 12, 12);

           //cat.IsChipped = true;

           //cat.Owner = "Cveti";


           //Console.WriteLine(cat.IsChipped);
           //Console.WriteLine(cat.Owner);
           //Console.WriteLine(cat);
        }
    }
}
