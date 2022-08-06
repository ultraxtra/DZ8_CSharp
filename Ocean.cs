using System;
using static System.Console;
using System.Collections.Generic;

namespace DZ8_CSharp
{
    class OceanAnimals
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\n Type: {Type}\n Descriptpon: {Description}\n";
        }
    }

    class Ocean
    {
        List<OceanAnimals> oceans = new List<OceanAnimals>
        {
            new OceanAnimals
            {
                Name = "Crystal Jellyfish",
                Type = "Jellyfish",
                Description = "Coming in at number one is the Crystal jellyfish"
            },
            new OceanAnimals
            {
                Name = "Shark",
                Type = "Tiger shark",
                Description = "The tiger shark is a common large shark found worldwide"
            }
        };

        public IEnumerator<OceanAnimals> GetEnumerator(){
            for(int i = 0; i < oceans.Count; i++)
            {
                yield return oceans[i];
            }
        }
    }
}