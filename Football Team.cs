using System;
namespace DZ8_CSharp
{
    class Footballers
    {
        public string Name { get; set; }
        public int Num { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\n Number: {Num}\n Descriptpon: {Description}\n";
        }
    }

    class FootballTeam
    {
        List<Footballers> footballers = new List<Footballers>
        {
            new Footballers
            {
                Name = "Messi",
                Num = 11,
                Description = "Barcelona"
            },
            new Footballers
            {
                Name = "Ronaldo",
                Num = 7,
                Description = "Real Madrid"
            }
        };

        public IEnumerator<Footballers> GetEnumerator()
        {
            for (int i = 0; i < footballers.Count; i++)
            {
                yield return footballers[i];
            }
        }
    }
}

