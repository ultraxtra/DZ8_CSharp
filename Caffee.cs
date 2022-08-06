using System;
namespace DZ8_CSharp
{
   
        class CafeeWorkeres
        {
            public string Name { get; set; }
            public int age { get; set; }
            public string Description { get; set; }

            public override string ToString()
            {
                return $"Name: {Name}\n Age: {age}\n Descriptpon: {Description}\n";
            }
        }

            class Caffee
            {
                List<CafeeWorkeres> CafeeWorkeres = new List<CafeeWorkeres>
               {
            new CafeeWorkeres
            {
                Name = "Artem",
                age = 18,
                Description = "Cook"
            },
            new CafeeWorkeres
            {
                Name = "Anna",
                age = 30,
                Description = "Waiter"
            }
        };

                public IEnumerator<CafeeWorkeres> GetEnumerator()
                {
                    for (int i = 0; i < CafeeWorkeres.Count; i++)
                    {
                        yield return CafeeWorkeres[i];
                    }
                
            }
        }
    }

